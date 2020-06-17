using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyOff
{
    class FormTools
    {
        public static bool HasEmptyFields(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox box && box.Text.Trim().Length == 0)
                {
                    if (box.Name != "addressBox" && box.Name != "addressNumberBox")
                        return true;
                }
            }
            return false;
        }

        public static string To256Hash(string password)
        {
            var crypt = new SHA256Managed();
            var hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
