using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Data.Repository
{
    public class ArticleCategoriesRepository: RepositoryBase<ArticleCategory, int>, IArticleCategoriesRepository
    {
        public ArticleCategoriesRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}