using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Sinsoft.Alejo
{
    public class PronounsApi
    {
        protected const string apiUrl = "https://api.pronouns.alejo.io/v1";

        protected string DoApiCall(string url, int httpTimeout = 5)
        {
            using (HttpClient _client = new HttpClient())
            {
                _client.Timeout = TimeSpan.FromSeconds(httpTimeout);

                string _result = "";

                try
                {
                    _result = _client.GetStringAsync(url).Result;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    _client.Dispose();
                }

                return _result;
            }
        }

        public Status GetApiHealth()
        {
            string url = $"{apiUrl}/health";
            string apiResult = DoApiCall(url);
            HealthCheck healthCheck = JsonConvert.DeserializeObject<HealthCheck>(apiResult);
            return healthCheck.Status;
        }

        public PronounEx GetUserPronouns(string userName)
        {
            string url = $"{apiUrl}/users/{userName.ToLower()}";
            string apiResult = DoApiCall(url);
            if (apiResult == "not_found") { throw new UserNotFoundException(userName); }
            PronounUser pronounUser = JsonConvert.DeserializeObject<PronounUser>(apiResult);

            PronounEx _return;
            
            if (pronounUser.AltPronounId != null)
            {
                _return = PronounEx.GetPronounExByPronounId(pronounUser.AltPronounId);
            }
            else
            {
                _return = PronounEx.GetPronounExByPronounId(pronounUser.PronounId);
            }

            return _return;
        }
    }
}