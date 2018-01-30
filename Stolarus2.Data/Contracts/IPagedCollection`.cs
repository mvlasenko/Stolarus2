using System.Collections.Generic;

namespace Stolarus2.Data.Contracts
{
    public interface IPagedCollection<T> : IPagedCollection, IEnumerable<T>
    {
    }
}
