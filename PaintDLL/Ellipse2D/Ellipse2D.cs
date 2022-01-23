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

        public Point2D _leftTop { get; set; }

        public Point2D _rightBottom { get; set; }

        public IShape Clone()
        {
            return new Ellipse2D();
        }

        public UIElement Draw()
        {
            Ellipse ellipse = new Ellipse()
            {
                Width = Math.Abs(_rightBottom.X - _leftTop.X),
                Height = Math.Abs(_rightBottom.Y - _leftTop.Y),
                StrokeThickness = 1,
                Stroke = new SolidColorBrush(Colors.Black)
            };

            if (_leftTop.X > _rightBottom.X && _leftTop.Y < _rightBottom.Y)
            {
                Canvas.SetLeft(ellipse, _rightBottom.X);
                Canvas.SetTop(ellipse, _leftTop.Y);
            }
            else if (_leftTop.X > _rightBottom.X && _leftTop.Y > _rightBottom.Y)
            {
                Canvas.SetLeft(ellipse, _rightBottom.X);
                Canvas.SetTop(ellipse, _rightBottom.Y);
            }
            else if (_leftTop.X < _rightBottom.X && _leftTop.Y > _rightBottom.Y)
            {
                Canvas.SetLeft(ellipse, _leftTop.X);
                Canvas.SetTop(ellipse, _rightBottom.Y);
            }
            else
            {
                Canvas.SetLeft(ellipse, _leftTop.X);
                Canvas.SetTop(ellipse, _leftTop.Y);
            }

            return ellipse;
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
