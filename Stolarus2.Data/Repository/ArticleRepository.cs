using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Data.Repository
{
    public class ArticleRepository: RepositoryBase<Article, int>, IArticleRepository
    {
        public ArticleRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}