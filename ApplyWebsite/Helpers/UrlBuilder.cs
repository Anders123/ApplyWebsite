using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ApplyWebsite.Helpers
{
    public static class UrlBuilder
    {
        /// <summary>
        /// Register with name and email.
        /// </summary>
        /// <param name="baseUrl">Base URL for request.</param>
        /// <param name="name">Full name.</param>
        /// <param name="email">Email</param>
        /// <returns>Uri</returns>
        public static Uri SignInUri(string baseUrl, string name, string email)
        {
            return new Uri($"{baseUrl}Person/SignIn?name={WebUtility.UrlEncode(name)}&email={WebUtility.UrlEncode(email)}", UriKind.Absolute);
        }

        /// <summary>
        /// Add post to briefcase.
        ///  </summary>
        /// <param name="baseUrl">Base URL for request.</param>
        /// <param name="briefcaseId">Set to "0" on first request to create briefcase.</param>
        /// <param name="personId">Person id.</param>
        /// <param name="postId">Post id to apply for.</param>
        /// <returns>Uri</returns>
        public static Uri BriefcaseAddPostUri(string baseUrl, int briefcaseId, int personId, int postId)
        {
            return new Uri($"{baseUrl}Briefcase/{briefcaseId}/AddPost?briefcaseTypeId=1&personId={personId}&postId={postId}", UriKind.Absolute);
        }

        /// <summary>
        /// Create the URL for an interview.
        /// </summary>
        /// <param name="baseUrl">Base URL for request.</param>
        /// <param name="briefcaseId">Briefcase id.</param>
        /// <param name="interviewInstanceId">If not set the interview will be created.</param>
        /// <returns></returns>
        public static Uri InterviewCreateUri(string baseUrl, int briefcaseId, int? interviewInstanceId)
        {
            if (interviewInstanceId == null)
            {
                return new Uri($"{baseUrl}Interview/Create?briefcaseId={briefcaseId}", UriKind.Absolute);
            }
            else
            {
                return new Uri($"{baseUrl}Interview?briefcaseId={briefcaseId}&interviewInstanceId={interviewInstanceId}", UriKind.Absolute);
            }
        }
    }
}
