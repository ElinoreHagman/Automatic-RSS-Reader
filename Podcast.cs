using System;
using System.Collections.Generic;

namespace Project_RSS
{
    class Podcast
    {
        public string Url { get; set; }
        public string Interval { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int TotalEpisodes { get; set; }
        public List<Episode> EpisodeList { get; set; }

        public Podcast(string aUrl, string aCategory, string aInterval, string aName, int aTotalEpisodes, List<Episode> aEpisodeList)
        {
            Url = aUrl;
            Interval = aInterval;
            Category = aCategory;
            Name = aName;
            TotalEpisodes = aTotalEpisodes;
            EpisodeList = aEpisodeList;
        }

        public Podcast()
        {

        }
    }

}
