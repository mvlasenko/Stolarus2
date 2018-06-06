using System;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class TranslationsController : ApplicationController<Translation, int>
    {
        private ITranslationsRepository repository;

        public TranslationsController(ITranslationsRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public virtual JsonResult GetEntityList(string table, string field)
        {
            //todo
            string res = "";

            Table t = (Table)Enum.Parse(typeof(Table), table);
            Field f = (Field)Enum.Parse(typeof(Field), field);

            if (t == Table.Articles && f == Field.Name)
            {
                res = "";
            }

            

            return Json(res, JsonRequestBehavior.AllowGet);

        }
    }
}
