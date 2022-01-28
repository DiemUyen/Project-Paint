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

        public Point2D Start { get; set; }
        
        public Point2D End { get; set; }

        public IShape Clone(Brush color, double width, DoubleCollection style)
        {
            return new Line2D() { ColorBorder = color, WidthBorder = width, StyleBorder = style };
        }

        public UIElement Draw()
        {
            Line line = new Line()
            {
                X1 = Start.X,
                Y1 = Start.Y,
                X2 = End.X,
                Y2 = End.Y,
                Stroke = ColorBorder,
                StrokeThickness = WidthBorder,
                StrokeDashArray = StyleBorder,
                Fill = new SolidColorBrush(Colors.Transparent)
            };

            return line;
        }

        public void HandleEnd(double x, double y)
        {
            End = new Point2D() { X = x, Y = y };
        }

        public void HandleStart(double x, double y)
        {
            Start = new Point2D() { X = x, Y = y };
        }
    }
}
