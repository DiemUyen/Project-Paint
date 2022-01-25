using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Paint
{
    public class BrushTool
    {
        public Brush brushColor { get; set; }
        
        public double brushWidth { get; set; }

        public DoubleCollection brushStyle { get; set; }
    }
}
