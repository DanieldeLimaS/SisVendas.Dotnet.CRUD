using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Infraestrutura
{
    public class TextBoxCustomValues
    {
        public void PermiteDecimal(object sender, KeyPressEventArgs e, char cSymbol)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)&&e.KeyChar!=cSymbol)
            {
                e.Handled=true;
            }

            if(e.KeyChar==cSymbol&&(sender as TextBox).Text.IndexOf(cSymbol)>-1)
            {
                e.Handled=true;
            }
        }
    }
}
