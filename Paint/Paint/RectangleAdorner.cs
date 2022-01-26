using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Paint
{
    public class RectangleAdorner : Adorner
    {
        public Rect rectangleBound { get; set; }
        public RectangleAdorner(UIElement element, Rect rect) : base(element) 
        {
            rectangleBound = rect;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            Rect elementRect = rectangleBound;

            Pen renderPen = new Pen(new SolidColorBrush(Colors.Gray), 1);

            drawingContext.DrawRectangle(null, renderPen, elementRect);
            
        }
    }
}
