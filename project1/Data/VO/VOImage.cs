using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.VO
{
    public class VOImage
    {
        /// <summary>
        /// Image Title
        /// </summary>
        public string Title;

        /// <summary>
        /// Image description
        /// </summary>
        public string Description;

        /// <summary>
        /// Image link
        /// </summary>
        public string Link;

        /// <summary>
        /// Image data
        /// </summary>
        public byte[] Data;
    }
}