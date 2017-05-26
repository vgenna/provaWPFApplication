using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication1
{

    class Class1
    {
        private String str;

        public Class1(string newstr)
        {
            str = newstr;
        }

        public void printStr() {
            MessageBox.Show(str);
        }

    }
}
