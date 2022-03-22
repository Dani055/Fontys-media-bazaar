using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.logic
{
    public static class VisualHelper
    {
        public static void ShowError(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInfo(string text)
        {
            MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowConfirmation(string text)
        {
           return MessageBox.Show(text, caption:"Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);          
        }

        public static string GetDateStringForMySQL(DateTime date)
        {
            return $"{date.Year}-{date.Month}-{date.Day}";
        }

        public static void PicButtonHoverEffect(PictureBox pb)
        {
            int currentSize = pb.Size.Width;
            int newSize = currentSize == 64 ? 60 : 64; //If current size is 64, switch it to 60 and other way around.
            pb.Size = new System.Drawing.Size(newSize, newSize);
            Relocate(pb); //To center image
        }
        private static void Relocate(PictureBox sender)
        {
            int x = sender.Location.X;
            int y = sender.Location.Y;
            sender.Location = sender.Size.Width == 64 ? new System.Drawing.Point(x - 2, y - 2) : new System.Drawing.Point(x + 2, y + 2);
        }
    }
}
