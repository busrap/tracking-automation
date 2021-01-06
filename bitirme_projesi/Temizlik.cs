using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitirme_projesi
{
    class Temizlik
    {
        public void Temizle(Control.ControlCollection temiz)
        {
            foreach (Control item in temiz)
            {
                if (item is TextBox)
                {
                    item.Text = " ";
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
                else if (item is PictureBox)
                {
                    ((PictureBox)item).Image = null;
                }

            }
        }
       
    }
}
