using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.VO;
using DBConnection;
using System.Data.Entity;

namespace Data.VOMapper
{
    public static class VOMapperImage
    {
        public static VOImage ImageInstanceFromData(Image imgItem)
        {
            VOImage img = new VOImage();
            img.Title = imgItem.Title;
            img.Description = imgItem.Description;
            img.Link = imgItem.Link;
            img.Data = imgItem.Data;
            return img;
        }
    }
}