using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Domain
{
    public class ArticleType
    {
        public ArticleType()
        {
            ArticleNavigations = new List<Article>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Article> ArticleNavigations { get; set; }
    }
}
