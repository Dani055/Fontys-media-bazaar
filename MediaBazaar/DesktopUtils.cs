using MBazaarClassLibrary.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    public static class DesktopUtils
    {

        public static Employee loggedEmployee { get; set; }

        public static Bitmap ByteArrayToImage(byte[] raw)
        {
            Bitmap result;
            using (MemoryStream ms = new MemoryStream(raw))
            {
                result = new Bitmap(ms);
            }
            return result;
        }

        /// <summary>
        /// If product have picture it will be displayed, "no-picure" picture otherwise.
        /// </summary>
        /// <param name="product">Product</param>
        /// <param name="pbx">Picturebox to update</param>
        public static void SetImage(Product product, PictureBox pbx)
        {          
            Bitmap image;
            if (product.Picture is not null)
            {
                image = ByteArrayToImage(product.Picture);
            }
            else
            {
                image = Properties.Resources.no_picture;
            }
            pbx.Image = image;
        }
    }
}
