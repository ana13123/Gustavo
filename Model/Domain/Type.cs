using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Domain
{
    public class Type
    {
        public Type()
        {
            ArticleNavigations = new List<Article>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Article> ArticleNavigations { get; set; }
    }
}
