using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStyling
{
    public class BlueRenderer : ToolStripProfessionalRenderer
    {
        //public BlueRenderer() : base(new MyColors()) { }
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            //e.Item.BackColor = Color.MidnightBlue;
            //e.Item.MouseHoverColor = Color.MidnightBlue;
            Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
            Color c = Color.FromArgb(19, 33, 60);
            using (SolidBrush brush = new SolidBrush(c))
                e.Graphics.FillRectangle(brush, rc);
        }
        //private class MyColors : ProfessionalColorTable
        //{
        //    public override Color MenuItemSelected
        //    {
        //        get { return Color.Yellow; }
        //    }
        //    public override Color MenuItemSelectedGradientBegin
        //    {
        //        get { return Color.Orange; }
        //    }
        //    public override Color MenuItemSelectedGradientEnd
        //    {
        //        get { return Color.Yellow; }
        //    }
        //}
    }

}
