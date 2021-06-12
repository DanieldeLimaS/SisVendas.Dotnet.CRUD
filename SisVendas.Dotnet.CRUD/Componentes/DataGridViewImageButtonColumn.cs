using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Componentes
{
    public partial class DataGridViewImageButtonColumn: DataGridViewButtonColumn
    {
        public DataGridViewImageButtonColumn() : base()
        {
            base.CellTemplate=new DataGridViewImageButtonCell();
        }

        public override object Clone()
        {
            var col = (DataGridViewImageButtonColumn)base.Clone();
            col.Image=Image;
            return col;
        }

        [DefaultValue(null)]
        [Category("Appearance")]
        [Description("DataGridViewImageButtonColumn_ImageDescr")]
        public Image Image { get; set; }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if(value!=null&&!(value.GetType().IsAssignableFrom(typeof(DataGridViewImageButtonCell))))
                {
                    throw new InvalidCastException("Must be a DataGridViewImageButtonCell");
                }
                base.CellTemplate=value;
            }
        }
    }
}
