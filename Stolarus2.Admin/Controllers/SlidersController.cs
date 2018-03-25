using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;
using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace Stolarus2.Admin.Controllers
{
    public class SlidersController : ApplicationController<Slider, int>
    {
        private ISlidersRepository repository;

        public SlidersController(ISlidersRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase file)
        {
            try
            {
                var memStream = new MemoryStream();
                file.InputStream.CopyTo(memStream);

                byte[] fileData = memStream.ToArray();

                //save file to database using fictitious repository
                //var repo = new FictitiousRepository();
                //repo.SaveFile(file.FileName, fileData);
            }
            catch (Exception exception)
            {
                return Json(new
                {
                    success = false,
                    response = exception.Message
                });
            }

            return Json(new
            {
                success = true,
                response = "File uploaded."
            });
        }
    }
}
