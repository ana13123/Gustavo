using Model.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IArticleService
    {
        IList<Article> Read();
        Article Read(int id);

        Article Create (Article entity);

        void Update(Article entity, int id);

        void Delete(int id);
    }
}
