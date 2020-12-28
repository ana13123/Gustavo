using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Domain
{
    public class Article
    {
        public Article()
        {
        }

        public int Id { get; set; }
        [Display(Name = "Titulo")]
        public string Title { get; set; }
        [Display(Name = "Cuerpo")]
        public string Body { get; set; }
        public int ArticleTypeId { get; set; }
        public ArticleType ArticleTypeNavigation { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
