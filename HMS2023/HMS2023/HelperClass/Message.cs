using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS2023.HelperClass
{
   public  static class My_Message
    {
        public static void success(string Name)
        {
            MessageBox.Show(Name+"Record Save Successfully","success message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
    }
}
