using Contract;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Rectangle2D
{
    public class Rectangle2D : IShape
    {
        public string Name => "Rectangle";

        public string Icon => "/Icons/rectangle.png";

        public Brush ColorBorder { get; set; }

        public double WidthBorder { get; set; }

        public DoubleCollection StyleBorder { get; set; }

        public Point2D LeftTop { get; set; }

        public Point2D RightBottom { get; set; }

        public IShape Clone(Brush color, double width, DoubleCollection style)
        {
            return new Rectangle2D() { ColorBorder = color, WidthBorder = width, StyleBorder = style };
        }

        public UIElement Draw()
        {
            Rectangle rectangle = new Rectangle()
            {
                Width = Math.Abs(RightBottom.X - LeftTop.X),
                Height = Math.Abs(RightBottom.Y - LeftTop.Y),
                Stroke = ColorBorder,
                StrokeThickness = WidthBorder,
                StrokeDashArray = StyleBorder,
                Fill = new SolidColorBrush(Colors.Transparent)
            };

            if (LeftTop.X > RightBottom.X && LeftTop.Y < RightBottom.Y)
            {
                Canvas.SetLeft(rectangle, RightBottom.X);
                Canvas.SetTop(rectangle, LeftTop.Y);
            }
            else if (LeftTop.X > RightBottom.X && LeftTop.Y > RightBottom.Y)
            {
                Canvas.SetLeft(rectangle, RightBottom.X);
                Canvas.SetTop(rectangle, RightBottom.Y);
            }
            else if (LeftTop.X < RightBottom.X && LeftTop.Y > RightBottom.Y)
            {
                Canvas.SetLeft(rectangle, LeftTop.X);
                Canvas.SetTop(rectangle, RightBottom.Y);
            }
            else
            {
                Canvas.SetLeft(rectangle, LeftTop.X);
                Canvas.SetTop(rectangle, LeftTop.Y);
            }

            return rectangle;
        }

        public void HandleEnd(double x, double y)
        {
            RightBottom = new Point2D() { X = x, Y = y };
        }

        public void HandleStart(double x, double y)
        {
            LeftTop = new Point2D() { X = x, Y = y };
        }
    }
}
