using Model;
using Model.Domain;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class ArticleTypeService : IArticleTypeService
    {
        private readonly ProfileDbContext _Context;
        public ArticleTypeService(ProfileDbContext context)
        {
            _Context = context;
        }

        public IList<ArticleType> Read()
        {
            var articleTypes = _Context.ArticleTypes.ToList();
            return articleTypes;
        }

        public ArticleType Read(int id)
        {
            var articleType = _Context.ArticleTypes.Find(id);

            return articleType;
        }
    }
}
