using System;


namespace JitsiMeetOutlook.Entities
{
    public class ConferenceSchedulerMessage
    {
        /// <summary>
        /// The name of the conference.
        /// </summary>
        public string ConferenceName { get; set; }

        /// <summary>
        /// The start date and time of the conference.
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// The end date and time of the conference.
        /// </summary>
        public DateTime End{ get; set; }

        /// <summary>
        /// Recurrance pattern as described in RFC.
        /// <see href="https://datatracker.ietf.org/doc/html/rfc5545"/>
        /// </summary>
        public string Recurrance{ get; set; }
    }
}
