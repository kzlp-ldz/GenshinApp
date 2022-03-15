using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;

namespace GenshinApp.DB
{
    public class DataManager
    {
        private static WebResponse Resp(string url)
        {
            try
            {
                var request = WebRequest.Create(Case.baseUrl + url);
                request.Credentials = CredentialCache.DefaultCredentials;
                return request.GetResponse();
            }
            catch (WebException e)
            {
                return e.Response;
            }
        }
        public static List<Characters> GetCharacters(string url)
        {
            using (Stream dataStream = Resp(url).GetResponseStream())
            {
                var reader = new StreamReader(dataStream);
                var responseFromServer = JsonSerializer.Deserialize<List<Characters>>(reader.ReadToEnd());
                return responseFromServer;
            }
        }
        public static Characters CharacterInfo(string url)
        {
            using (Stream dataStream = Resp(url).GetResponseStream())
            {
                var reader = new StreamReader(dataStream);
                var responseFromServer = JsonSerializer.Deserialize<Characters>(reader.ReadToEnd());
                return responseFromServer;
            }
        }

        public static Artifacts ArtifactsInfo(string url)
        {
            using (Stream dataStream = Resp(url).GetResponseStream())
            {
                var reader = new StreamReader(dataStream);
                var responseFromServer = JsonSerializer.Deserialize<Artifacts>(reader.ReadToEnd());
                return responseFromServer;
            }
        }

        public static List<Artifacts> GetArtifacts(string url)
        {
            using (Stream dataStream = Resp(url).GetResponseStream())
            {
                var reader = new StreamReader(dataStream);
                var responseFromServer = JsonSerializer.Deserialize<List<Artifacts>>(reader.ReadToEnd());
                return responseFromServer;
            }
        }
    }
}
