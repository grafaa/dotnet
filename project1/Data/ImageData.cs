using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.VO;
using Data.VOMapper;
using DBConnection;
using System.Data.Entity;

namespace Data
{
    public static class ImageData
    {
        /// <summary>
        /// Get VOImage from the image ID
        /// </summary>
        /// <param name="imageId">Image ID to get</param>
        /// <returns>Object VOImage</returns>
        public static VOImage GetImage(Guid imageId)
        {
            Image img = Image.GetImageInstance(imageId);
            return VOMapperImage.ImageInstanceFromData(img);
        }

        /// <summary>
        /// Create new image record 
        /// </summary>
        /// <param name="newImage">Object with all image properties</param>
        public static void CreateImage(VOImage newImage)
        {
            try
            {
                Image img = Image.CreateImage(new Guid(), newImage.Title, newImage.Description, newImage.Link, newImage.Data);
                img.Add();
            }
            catch (Exception ex)
            {
            }
        }
    }
}