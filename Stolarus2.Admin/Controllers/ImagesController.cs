using System;
using System.IO;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Helpers;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class ImagesController : ApplicationController<Image, Guid>
    {
        private IImagesRepository repository;

        public ImagesController(IImagesRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        [Route("Image/{id}")]
        public ActionResult Image(string id)
        {
            var imageEntity = repository.GetById(new Guid(id));

            string key = "File_" + id;

            byte[] binary = this.HttpContext.Cache[key] as byte[];
            if (binary == null)
            {
                binary = ImageHelper.GetImageCroped(imageEntity.Binary, 100, 100, true);
                this.HttpContext.Cache.Insert(key, binary);
            }

            return File(new MemoryStream(binary), ImageHelper.GetContentType(Path.GetExtension(imageEntity.Name)), imageEntity.Name);
        }
    }
}
