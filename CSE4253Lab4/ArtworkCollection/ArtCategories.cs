using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtworkCollection
{
    public class ArtCategories
    {
        IList<string> categories;

        public ArtCategories()
        {
            categories = new List<string>();
        }

        public void Add(string category)
        {
            if (!categories.Contains(category))
            {
                categories.Add(category);
            }
        }

        public IList<string> getCategories()
        {
            return categories;
        }
    }
}
