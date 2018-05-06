﻿using System;
using System.IO;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Helpers;

namespace Stolarus2.Controllers
{
    public class ImagesController : Controller
    {
        public ActionResult Image(string id, int? width, int? height, bool crop = true, bool center = true)
        {
            IImagesRepository repository = DependencyResolver.Current.GetService<IImagesRepository>();

            var imageEntity = repository.GetById(new Guid(id));

            byte[] binary;
            if (width == null && height == null)
            {
                binary = imageEntity.Binary;
            }
            else
            {
                string key = "File_" + id + "_width_" + width + "_height_" + height + "_crop_" + crop + "_center_" + center;

                binary = this.HttpContext.Cache[key] as byte[];
                if (binary == null)
                {
                    binary = crop ? 
                        ImageHelper.GetImageCroped(imageEntity.Binary, width.Value, height.Value, center) : 
                        ImageHelper.GetImageResized(imageEntity.Binary, width.Value, height.Value);
                    this.HttpContext.Cache.Insert(key, binary);
                }
            }

            return File(new MemoryStream(binary), ImageHelper.GetContentType(Path.GetExtension(imageEntity.Name)), imageEntity.Name);
        }
    }
}