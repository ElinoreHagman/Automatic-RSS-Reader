using System;

namespace Project_RSS
{
    abstract class Feed
    {
        protected readonly Category category = new Category();
        protected readonly Urlinfo info = new Urlinfo();
        protected Filewriter fw = new Filewriter();

        public virtual void Delete(string aCategory)
        {
        }

        public virtual void Delete(int podcastindex)
        {
        }
    }
}
