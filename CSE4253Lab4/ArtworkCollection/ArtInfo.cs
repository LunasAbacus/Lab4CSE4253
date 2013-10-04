using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtworkCollection
{
    [Serializable]
    public class ArtInfo
    {
        public string Title {get; set;}
        public string author {get; set;}
        public string category {get; set;}
        public string website {get; set;}
        public int year {get; set;}
        
        public ArtInfo()
        {
            Title = "Enter title...";
            author = "Enter author...";
            category = "Enter category...";
            website = "Enter website...";
            year = 2013;
        }

        public override string  ToString()
        {
 	        return Title;
        }
    }
}
