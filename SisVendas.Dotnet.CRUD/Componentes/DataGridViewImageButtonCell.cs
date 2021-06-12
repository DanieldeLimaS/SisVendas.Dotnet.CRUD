using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Componentes
{
    class DataGridViewImageButtonCell: DataGridViewButtonCell
    {
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
          DataGridViewElementStates elementState, object value,
          object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
          DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value,
             formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            var col = (DataGridViewImageButtonColumn)OwningColumn;
            if(col.Image!=null)
                graphics.DrawImage(col.Image, CenterInRectangle(col.Image.Size, cellBounds));
        }

        public static Point CenterInRectangle(Size Inner, Rectangle Outer)
        {
            return new Point()
            {
                X=Outer.X+((Outer.Width-Inner.Width)/2),
                Y=Outer.Y+((Outer.Height-Inner.Height)/2)
            };
        }
    }
}
