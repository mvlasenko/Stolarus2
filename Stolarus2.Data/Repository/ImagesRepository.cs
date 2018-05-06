using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;
using System;

namespace Stolarus2.Data.Repository
{
    public class ImagesRepository: RepositoryBase<Image, Guid>, IImagesRepository
    {
        public ImagesRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}