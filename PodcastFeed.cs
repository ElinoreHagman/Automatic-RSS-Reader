using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project_RSS
{
    class PodcastFeed : Feed, IGetPodcastList, IRepository
    {
        public List<Podcast> GetSavedPodcasts()
        {
            var podcastList = fw.GetSavedPodcasts();
            return podcastList;
        }

        public string GetPodcastUrl(int podcastIndex)
        {
            Podcast podcast = fw.podcastList[podcastIndex];
            string url = podcast.Url;
            return url;
        }

        public string GetPodcastCategory(int podcastIndex)
        {
            Podcast podcast = fw.podcastList[podcastIndex];
            string category = podcast.Category;
            return category;
        }

        public string GetInterval(int podcastIndex)
        {
            Podcast podcast = fw.podcastList[podcastIndex];
            string interval = podcast.Interval;
            return interval;
        }

        public async Task<Podcast> AddNewPodcast(string url, string category, string interval)
        {
            Podcast podcast = new Podcast();
            await Task.Run(() =>
            {
                int totalEpisodes = info.GetTotalEpisodes(url);
                string urlName = info.GetUrlName(url);
                var episodeList = info.GetEpisodes(url);

                podcast = new Podcast(url, category, interval, urlName, totalEpisodes, episodeList.Result);
                fw.podcastList.Add(podcast);
                fw.SavePodcastToFile();
                return podcast;

            });
            return podcast;
        }

        public async Task<Podcast> AddNewPodcast(string url, string interval)
        {
            Podcast podcast = new Podcast();
            await Task.Run(() =>
            {
                int totalEpisodes = info.GetTotalEpisodes(url);
                string urlName = info.GetUrlName(url);
                var episodeList = info.GetEpisodes(url);

                podcast = new Podcast(url, "None", interval, urlName, totalEpisodes, episodeList.Result);
                fw.podcastList.Add(podcast);
                fw.SavePodcastToFile();
            });
            return podcast;
        }

        public override void Delete(int podcastindex)
        {
            fw.podcastList.RemoveAt(podcastindex);
            fw.SavePodcastToFile();
        }

        public void UpdatePodcast(int podcastIndex, string category, string interval)
        {
            Podcast podcast = fw.podcastList[podcastIndex];
            podcast.Category = category;
            podcast.Interval = interval;
            fw.SavePodcastToFile();
        }

        public async void UpdatePodcast(string url)
        {
            List<Episode> newEpisodeList = await info.GetEpisodes(url);

            foreach (var pod in fw.podcastList)
            {
                if (pod.Url.Equals(url))
                {
                    pod.EpisodeList = newEpisodeList;
                    pod.TotalEpisodes = info.GetTotalEpisodes(url);
                }
            }
            fw.SavePodcastToFile();
        }

        public List<Episode> GetEpisodeList(int podcastIndex)
        {
            List<Episode> episodeList;
            Podcast podcast = fw.podcastList[podcastIndex];
            episodeList = podcast.EpisodeList;

            return episodeList;
        }
    }
}
