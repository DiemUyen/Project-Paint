using Contract;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Ellipse2D
{
    public class Ellipse2D : IShape
    {
        public string Name => "Ellipse";

        public string Icon => "/Icons/ellipse.png";

        public Brush ColorBorder { get; set; }

        public double WidthBorder { get; set; }

        public DoubleCollection StyleBorder { get; set; }

        public Point2D LeftTop { get; set; }

        public Point2D RightBottom { get; set; }

        public IShape Clone(Brush color, double width, DoubleCollection style)
        {
            return new Ellipse2D() { ColorBorder = color, WidthBorder = width, StyleBorder = style };
        }

        public UIElement Draw()
        {
            Ellipse ellipse = new Ellipse()
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
                Canvas.SetLeft(ellipse, RightBottom.X);
                Canvas.SetTop(ellipse, LeftTop.Y);
            }
            else if (LeftTop.X > RightBottom.X && LeftTop.Y > RightBottom.Y)
            {
                Canvas.SetLeft(ellipse, RightBottom.X);
                Canvas.SetTop(ellipse, RightBottom.Y);
            }
            else if (LeftTop.X < RightBottom.X && LeftTop.Y > RightBottom.Y)
            {
                Canvas.SetLeft(ellipse, LeftTop.X);
                Canvas.SetTop(ellipse, RightBottom.Y);
            }
            else
            {
                Canvas.SetLeft(ellipse, LeftTop.X);
                Canvas.SetTop(ellipse, LeftTop.Y);
            }

            return ellipse;
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
