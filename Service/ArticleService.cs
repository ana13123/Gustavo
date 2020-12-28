using Microsoft.EntityFrameworkCore;
using Model;
using Model.Domain;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class ArticleService : IArticleService
    {

        private readonly ProfileDbContext _Context;
        public ArticleService(ProfileDbContext context)
        {
            _Context = context;
        }
        public Article Create(Article entity)
        {
            var create = _Context.Articles.Add(entity);
            _Context.SaveChanges();
            return create.Entity;
        }

        public void Delete(int id)
        {
            Article article = Read(id);
            _Context.Entry(article).State = EntityState.Deleted;
            _Context.SaveChanges();
        }

        public IList<Article> Read()
        {
            var article = _Context.Articles
                .Include(e => e.ArticleTypeNavigation)
                .ToList();
            return article;
        }

        public Article Read(int id)
        {
            var article = _Context.Articles.Find(id);
            return article;
        }

        public void Update(Article entity, int id)
        {
            if(entity.Id != id)
            {
                return;
            }
            _Context.Articles.Update(entity);
            _Context.SaveChanges();
        }
    }
}
