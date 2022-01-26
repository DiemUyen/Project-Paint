using Contract;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Line2D
{
    public class Line2D : IShape
    {
        public string Name => "Line";

        public string Icon => "/Icons/line.png";

        public Brush ColorBorder { get; set; }

        public double WidthBorder { get; set; }

        public DoubleCollection StyleBorder { get; set; }

        public Point2D _start { get; set; }
        
        public Point2D _end { get; set; }

        public IShape Clone(Brush color, double width, DoubleCollection style)
        {
            return new Line2D() { ColorBorder = color, WidthBorder = width, StyleBorder = style };
        }

        public UIElement Draw()
        {
            Line line = new Line()
            {
                X1 = _start.X,
                Y1 = _start.Y,
                X2 = _end.X,
                Y2 = _end.Y,
                Stroke = ColorBorder,
                StrokeThickness = WidthBorder,
                StrokeDashArray = StyleBorder,
                Fill = new SolidColorBrush(Colors.Transparent)
            };

            return line;
        }

        public void HandleEnd(double x, double y)
        {
            _end = new Point2D() { X = x, Y = y };
        }

        public void HandleStart(double x, double y)
        {
            _start = new Point2D() { X = x, Y = y };
        }
    }
}
