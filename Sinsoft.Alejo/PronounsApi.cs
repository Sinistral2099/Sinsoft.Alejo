using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Sinsoft.Alejo
{
    public class PronounsApi
    {
        protected const string apiUrl = "https://pronouns.alejo.io/api";

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

        public PronounEx GetUserPronouns(string userName)
        {
            string url = $"{apiUrl}/users/{userName.ToLower()}";
            string apiResult = DoApiCall(url);
            if (apiResult == "[]" || apiResult == "fail") { throw new UserNotFoundException(userName); }

            JArray users = JArray.Parse(apiResult);
            
            return PronounEx.GetPronounExByPronounId(users[0]["pronoun_id"].ToString());
        }
    }
}