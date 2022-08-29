using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1
{
    public class NewsFeed
    {
        private List<FeedEntry> feedEntries;

        public NewsFeed()
        {
            feedEntries = new List<FeedEntry>();
        }
        public void PrintNewsFeed()
        {
            foreach (FeedEntry entry in feedEntries)
            {
                Console.WriteLine(entry.ToString());
            }
        }

        public void PrintSearchResults(string query)
        {
            foreach (FeedEntry entry in feedEntries)
            {
                if (entry.ToString().Contains(query))
                {
                    Console.WriteLine(entry.ToString());
                }
            }
        }

        public void AddFeedEntry(FeedEntry entry) 
        {
            feedEntries.Add(entry);
        }

    }
}
