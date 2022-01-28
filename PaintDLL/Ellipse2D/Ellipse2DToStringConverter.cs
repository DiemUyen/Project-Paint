using Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Ellipse2D
{
    public class Ellipse2DToStringConverter : IShapeToStringConverter
    {
        public string Name => "Ellipse";

        public string ConvertToData(IShape shape)
        {
            var ellipse = (Ellipse2D)shape;
            StringBuilder builder = new StringBuilder();

            // Ellipse ((LeftTop), (RightBottom)) (ColorBorder, WidthBorder, StyleBorder)
            builder.Append("Ellipse ((")
                .Append(ellipse.LeftTop.X)
                .Append(", ")
                .Append(ellipse.LeftTop.Y)
                .Append("), (")
                .Append(ellipse.RightBottom.X)
                .Append(", ")
                .Append(ellipse.RightBottom.Y)
                .Append(")) (")
                .Append(ellipse.ColorBorder.ToString())
                .Append(", ")
                .Append(ellipse.WidthBorder.ToString())
                .Append(", ")
                .Append(ellipse.StyleBorder.ToString())
                .Append(")");

            return builder.ToString();
        }

        public IShape ConvertToUI(string buffer)
        {
            int firstSpace = buffer.IndexOf(" ");

            // LeftTop), (RightBottom)) (ColorBorder, WidthBorder, StyleBorder
            string elements = buffer.Substring(firstSpace + 3, buffer.Length - firstSpace - 4);
            string[] tokens = elements.Split(")) (");

            // LeftTop), (RightBottom
            string[] positions = tokens[0].Split("), (");
            string[] positionLeftTop = positions[0].Split(", ");
            string[] positionRightBottom = positions[1].Split(", ");

            // ColorBorder, WidthBorder, StyleBorder
            string[] border = tokens[1].Split(", ");

            IShape result = new Ellipse2D()
            {
                LeftTop = new Point2D() { X = double.Parse(positionLeftTop[0]), Y = double.Parse(positionLeftTop[1]) },
                RightBottom = new Point2D() { X = double.Parse(positionRightBottom[0]), Y = double.Parse(positionRightBottom[1]) },
                ColorBorder = new SolidColorBrush((Color)ColorConverter.ConvertFromString(border[0])),
                WidthBorder = double.Parse(border[1]),
                StyleBorder = DoubleCollection.Parse(border[2])
            };

            return result;
        }
    }
}
