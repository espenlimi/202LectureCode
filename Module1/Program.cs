// See https://aka.ms/new-console-template for more information

using Modul1;

public class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var newsFeed = new NewsFeed();
        var feedEntry1 = new FeedEntry();
        feedEntry1.Text = "hei og hå";
        feedEntry1.Author = "Esp1";

        var feedEntry2 = new FeedEntry 
        {
         Author = "Esp2",
         Text = "My Text"
        };
        newsFeed.AddFeedEntry(feedEntry1);
        newsFeed.AddFeedEntry(feedEntry2);

        newsFeed.PrintNewsFeed();
    }
}

