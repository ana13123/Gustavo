using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Domain
{
    public class Article
    {
        public Article()
        {
            TypeNavigation = new Type();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public int TypeId { get; set; }
        public Type TypeNavigation { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
