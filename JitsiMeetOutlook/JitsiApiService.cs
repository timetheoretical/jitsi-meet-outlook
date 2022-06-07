using System;
using Outlook = Microsoft.Office.Interop.Outlook;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Security.Cryptography;
using System.Text;
using System.Numerics;
using System.Net.Http;
using System.Text.Json;
using System.Collections.Generic;
using JitsiMeetOutlook.Entities;
using System.Threading.Tasks;
using System.Linq;
using System.Net;
using System.Text.Json.Serialization;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace JitsiMeetOutlook
{
    public class JitsiApiService
    {
        readonly HttpClient client = new HttpClient();

        private readonly JsonSerializerOptions serializerOptions = new JsonSerializerOptions
        {
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
        };

        private RequestCache<string> PINCache = new RequestCache<string>();
        private RequestCache<PhoneNumberListResponse> PhoneNumbersCache = new RequestCache<PhoneNumberListResponse>();

        public JitsiApiService() {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public async Task<string> getPIN(string roomName)
        {
            string conferenceMapperRequestUrl = $"{Properties.Settings.Default.conferenceMapperEndpoint}?conference={roomName}@conference.{JitsiUrl.getDomain()}";

            try
            {
                return await PINCache.GetOrCreate(roomName, async () =>
                {
                    HttpResponseMessage response = await client.GetAsync(conferenceMapperRequestUrl);
                    response.EnsureSuccessStatusCode();
                    var responsestring = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<ConferenceMapperResponse>(responsestring, serializerOptions).IdString;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occured within JitsiOutlook: " + ex.Message + ex.InnerException?.Message + ex.InnerException?.InnerException?.Message + " for " + conferenceMapperRequestUrl);
                return "ERROR";
            }
        }

        public async Task<PhoneNumberListResponse> getPhoneNumbers(string roomName)
        {
            string phoneNumberListRequestUrl = $"{Properties.Settings.Default.phoneNumberListEndpoint}?conference={roomName}@conference.{JitsiUrl.getDomain()}";
            try
            {
                return await PhoneNumbersCache.GetOrCreate(roomName, async () =>
                    {
                        HttpResponseMessage response = await client.GetAsync(phoneNumberListRequestUrl);
                        response.EnsureSuccessStatusCode();
                        var responsestring = await response.Content.ReadAsStringAsync();
                        PhoneNumberListResponse phoneNumbers = JsonSerializer.Deserialize<PhoneNumberListResponse>(responsestring, serializerOptions);

                        return phoneNumbers;
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occured within JitsiOutlook: " + ex.Message + ex.InnerException?.Message + ex.InnerException?.InnerException?.Message + " for " + phoneNumberListRequestUrl);
                return new PhoneNumberListResponse { Numbers = new Dictionary<string, List<string>>() };
            }

        }


        public async void ScheduleConference(ConferenceSchedulerMessage scheduledConference)
        {
            try
            {
                if (Properties.Settings.Default.conferenceSchedulerEndpoint != String.Empty)
                {
                    string json = JsonSerializer.Serialize(scheduledConference, serializerOptions);
                    using (var request = new HttpRequestMessage(HttpMethod.Post, Properties.Settings.Default.conferenceSchedulerEndpoint))
                    {
                        var content = new StringContent(json, Encoding.UTF8, "application/json");
                        request.Content = content;
                        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", GetJWT());
                        var response = await client.SendAsync(request);
                        response.EnsureSuccessStatusCode();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occured within JitsiOutlook: " + ex.Message + ex.InnerException?.Message + ex.InnerException?.InnerException?.Message + " for " + Properties.Settings.Default.conferenceSchedulerEndpoint);
            }
        }

        private string GetJWT()
        {
            var secret = Encoding.Unicode.GetBytes(Properties.Settings.Default.conferenceSchedulerEndpointSecret);
            var now = DateTime.UtcNow;
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("sub", "customer") }),
                Issuer = "Who issued the token",
                Claims = new Dictionary<string, object>
                {
                    ["room"] = "*",
                },
                IssuedAt = now,
                NotBefore = now,
                Expires = now + TimeSpan.FromDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secret), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
