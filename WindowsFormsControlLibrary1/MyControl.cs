using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{

  [Designer(typeof(MyControlDesigner))]
  [ToolboxItem(true)]
  public class MyControl : Control
  {

    protected override void OnPaint(PaintEventArgs e)
    {
      e.Graphics.FillRectangle(SystemBrushes.Info, new Rectangle(0, 0, Width, Height));
      e.Graphics.DrawString("MyControl", Font, SystemBrushes.InfoText, new PointF(0, 0));
    }
  }
}
