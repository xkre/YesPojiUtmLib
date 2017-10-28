using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Diagnostics;
using YesPojiUtmLib.Models;
using YesPojiUtmLib.Exceptions;
using static YesPojiUtmLib.Constants;

namespace YesPojiUtmLib.Services
{
    public class YesSessionService : IYesSessionService
    {
        public async Task<YesSessionData> GetSessionDataAsync()
            => ParseSession(await GetRawSessionDataAsync());

        public async Task<string> GetRawSessionDataAsync()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(SESSION_URL);
                var rawHtml = await result.Content.ReadAsStringAsync();

                return rawHtml;
            }
        }

        public YesSessionData ParseSession(string rawHtml)
        {
            //TODO::Change the way the data is read.
            var htmlByLine = rawHtml.Split('\n');

            string sentS = htmlByLine[17];
            string recvS = htmlByLine[18];
            string timeS = htmlByLine[19];

            var sentString = Regex.Match(sentS, @":([^)]*) kB").Groups[1].Value;
            var recvString = Regex.Match(recvS, @":([^)]*) kB").Groups[1].Value;
            var timeString = Regex.Match(timeS, @":([^)]*)</tt").Groups[1].Value;

            try
            {
                var session = new YesSessionData()
                {
                    Sent = double.Parse(sentString),
                    Received = double.Parse(recvString),
                    Time = TimeSpan.Parse(timeString)
                };
                return session;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
