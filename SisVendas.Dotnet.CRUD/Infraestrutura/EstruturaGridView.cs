using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Componentes;

namespace UI.Infraestrutura
{
    public class EstruturaGridView
    {
        public  void criaHeadersGrid(DataGridView dgv, string HeaderText, string Name, bool readOnly, int mininumWidth,int width=0)
        {
            
            DataGridViewTextBoxColumn grid = new DataGridViewTextBoxColumn();
            grid.DataPropertyName=Name;
            grid.HeaderText=HeaderText;
            grid.Name=Name;
            grid.ReadOnly=readOnly;
            grid.MinimumWidth=mininumWidth;
            if(width!=0)
                grid.Width=width;
                dgv.Columns.Add(grid);

        }
        public void criaHeadersGridImagemButton(DataGridView dgv, string HeaderText, string Name,Bitmap endImg)
        {
            DataGridViewImageButtonColumn grid =new DataGridViewImageButtonColumn() { Image=new Bitmap(endImg) };
            grid.DataPropertyName=Name;
            grid.HeaderText=HeaderText;
            grid.Name=Name;
            grid.ReadOnly=true;
            grid.Width=50;

            dgv.Columns.Add(grid);

        }
    }
}
