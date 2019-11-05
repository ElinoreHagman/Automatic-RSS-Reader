using System;
using System.Collections.Generic;

namespace Project_RSS
{
    interface IGetPodcastList
    {
        List<Podcast> GetSavedPodcasts();
    }
}
