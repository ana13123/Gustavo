using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Domain
{
    public class Article
    {
        public int Id { get; set; }
        [Display(Name = "Titulo")]
        public string Title { get; set; }
        [Display(Name = "Cuerpo")]
        public string Body { get; set; }
        [Display(Name = "Tipo de articulo")]
        public int ArticleTypeId { get; set; }
        public ArticleType ArticleTypeNavigation { get; set; }
        [Display(Name = "Fecha de creación")]
        public DateTime CreatedAt { get; set; }
    }
}
