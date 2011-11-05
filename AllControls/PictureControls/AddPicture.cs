using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Data;
using Data.VO;
using System.Web.UI;

namespace PictureControls
{
    public class NewPicture : WebControl
    {
        Button btnSave;
        TextBox titleBox;
        TextBox descBox;
        FileUpload fileUpload;


        /// <summary>
        /// La clé de tag à écrire
        /// </summary>
        protected override HtmlTextWriterTag TagKey
        {
            get
            {
                return HtmlTextWriterTag.Div;
            }
        }


        protected override void CreateChildControls()
        {
            base.CreateChildControls();
            Panel pnlBox = new Panel();
            pnlBox.CssClass = "images_uploaded clear";
            btnSave = new Button()
            {
                Text = "Save",
            };
            btnSave.Click += btnClick;
            titleBox = new TextBox();
            descBox = new TextBox()
            {
                TextMode = TextBoxMode.MultiLine,
                Rows = 4
            };
            fileUpload = new FileUpload();
            pnlBox.Controls.Add(titleBox);
            pnlBox.Controls.Add(descBox);
            pnlBox.Controls.Add(fileUpload);
            pnlBox.Controls.Add(btnSave);
            Controls.Add(pnlBox);
        }

        protected void btnClick(object sender, EventArgs e)
        {
            int picSize = fileUpload.PostedFile.ContentLength;
            string picType = fileUpload.PostedFile.ContentType;
            byte[] picData = new byte[picSize];
            fileUpload.PostedFile.InputStream.Read(picData, 0, picSize);
            VOImage img = new VOImage();
            img.Data = picData;
            img.Description = descBox.Text;
            img.Title = titleBox.Text;
            ImageData.CreateImage(img);
        }
    }
}