using Stolarus2.Data.Models;
using System;

namespace Stolarus2.Data.Contracts
{
    public interface IImagesRepository : IRepository<Image, Guid>
    {
    }
}