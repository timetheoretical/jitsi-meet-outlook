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
        private RequestCache<string> PhoneNumbersCache = new RequestCache<string>();

        public JitsiApiService() { }

        public async Task<string> getPIN(string roomName)
        {
            try
            {
                return await PINCache.GetOrCreate(roomName, async () =>
                {
                    HttpResponseMessage response = await client.GetAsync($"{Properties.Settings.Default.conferenceMapperEndpoint}?conference={roomName}@conference.{JitsiUrl.getDomain()}");
                    response.EnsureSuccessStatusCode();
                    var responsestring = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<ConferenceMapperResponse>(responsestring, serializerOptions).IdString;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occured within JitsiOutlook: " + ex.Message);
                return "ERROR";
            }
        }

        public async Task<string> getPhoneNumbers(string roomName)
        {
            try
            {
                return await PhoneNumbersCache.GetOrCreate(roomName, async () =>
                    {
                        HttpResponseMessage response = await client.GetAsync($"{Properties.Settings.Default.phoneNumberListEndpoint}?conference={roomName}@conference.{JitsiUrl.getDomain()}");
                        response.EnsureSuccessStatusCode();
                        var responsestring = await response.Content.ReadAsStringAsync();
                        PhoneNumberListResponse phoneNumbers = JsonSerializer.Deserialize<PhoneNumberListResponse>(responsestring, serializerOptions);

                        return phoneNumbers.NumbersEnabled ? "  " + string.Join("\n  ", phoneNumbers.Numbers.AsEnumerable().Select(x => string.Format("{0}: {1}", x.Key, string.Join(",", x.Value))).ToList()) : string.Empty;
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occured within JitsiOutlook: " + ex.Message);
                return "ERROR";
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
                MessageBox.Show("An Error occured within JitsiOutlook: " + ex.Message);
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
