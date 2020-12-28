using Model.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IArticleTypeService
    {
        IList<ArticleType> Read();

        ArticleType Read(int id);
    }
}
