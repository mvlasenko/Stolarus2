using System;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models.Filters;

namespace Stolarus2.Admin.ModelBinding
{
    public abstract class FilterModelBinderBase<T, TKey> : DefaultModelBinder where T : IEntity<TKey>
    {
        protected override object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType)
        {
            return new Filter<T, TKey>();
        }
    }
}