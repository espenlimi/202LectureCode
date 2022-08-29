using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1
{
    public class FeedEntry
    {
        private string _timeStamp;
        public string Author { set; get; }
        public string Text { set; get; }
        public string TimeStamp
        {
            get { return _timeStamp; }
            set { if (!String.IsNullOrWhiteSpace(value)) 
                {
                    _timeStamp = value;
                } }
        }
        public override string ToString()
        {
            return "Author: " + Author + ", Text: " + Text;
        }

    }
}
