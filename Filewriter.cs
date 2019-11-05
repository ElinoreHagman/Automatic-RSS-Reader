using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Project_RSS
{
    class Filewriter : IGetPodcastList
    {
        private readonly string podcastFile = @"podcastList.json";
        public List<Podcast> podcastList = new List<Podcast>();
        protected string savedCategories = @"savedCategories.txt";
        public List<string> categories = new List<string>();

        public void SavePodcastToFile()
        {
            string JSONresult = JsonConvert.SerializeObject(podcastList);
            using (var sw = new StreamWriter(podcastFile, false))
            {
                sw.WriteLine(JSONresult.ToString());
                sw.Close();
            }
        }

        public List<Podcast> GetSavedPodcasts()
        {
            if (File.Exists(podcastFile))
            {
                using (StreamReader reader = new StreamReader(podcastFile))
                {
                    string JSONresult = reader.ReadToEnd();
                    podcastList = JsonConvert.DeserializeObject<List<Podcast>>(JSONresult);
                }
            }
            return podcastList;
        }
    }
}
