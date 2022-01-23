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

        public Point2D _leftTop { get; set; }

        public Point2D _rightBottom { get; set; }

        public IShape Clone()
        {
            return new Rectangle2D();
        }

        public UIElement Draw()
        {
            Rectangle rectangle = new Rectangle()
            {
                Width = Math.Abs(_rightBottom.X - _leftTop.X),
                Height = Math.Abs(_rightBottom.Y - _leftTop.Y),
                Stroke = new SolidColorBrush(Colors.Red),
                StrokeThickness = 1
            };

            if (_leftTop.X > _rightBottom.X && _leftTop.Y < _rightBottom.Y)
            {
                Canvas.SetLeft(rectangle, _rightBottom.X);
                Canvas.SetTop(rectangle, _leftTop.Y);
            }
            else if (_leftTop.X > _rightBottom.X && _leftTop.Y > _rightBottom.Y)
            {
                Canvas.SetLeft(rectangle, _rightBottom.X);
                Canvas.SetTop(rectangle, _rightBottom.Y);
            }
            else if (_leftTop.X < _rightBottom.X && _leftTop.Y > _rightBottom.Y)
            {
                Canvas.SetLeft(rectangle, _leftTop.X);
                Canvas.SetTop(rectangle, _rightBottom.Y);
            }
            else
            {
                Canvas.SetLeft(rectangle, _leftTop.X);
                Canvas.SetTop(rectangle, _leftTop.Y);
            }

            return rectangle;
        }

        public void HandleEnd(double x, double y)
        {
            _rightBottom = new Point2D() { X = x, Y = y };
        }

        public void HandleStart(double x, double y)
        {
            _leftTop = new Point2D() { X = x, Y = y };
        }
    }
}
