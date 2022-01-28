using Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Line2D
{
    public class Line2DToStringConverter : IShapeToStringConverter
    {
        public string Name => "Line";

        public string ConvertToData(IShape shape)
        {
            var line = (Line2D)shape;
            StringBuilder builder = new StringBuilder();

            // Line ((Start), (End)) (ColorBorder, WidthBorder, StyleBorder)
            builder.Append("Line ((")
                .Append(line.Start.X)
                .Append(", ")
                .Append(line.Start.Y)
                .Append("), (")
                .Append(line.End.X)
                .Append(", ")
                .Append(line.End.Y)
                .Append(")) (")
                .Append(line.ColorBorder.ToString())
                .Append(", ")
                .Append(line.WidthBorder.ToString())
                .Append(", ")
                .Append(line.StyleBorder.ToString())
                .Append(")");

            return builder.ToString();
        }

        public IShape ConvertToUI(string buffer)
        {
            int firstSpace = buffer.IndexOf(" ");

            // Start), (End)) (ColorBorder, WidthBorder, StyleBorder
            string elements = buffer.Substring(firstSpace + 3, buffer.Length - firstSpace - 4);
            string[] tokens = elements.Split(")) (");

            // LeftTop), (RightBottom
            string[] positions = tokens[0].Split("), (");
            string[] positionStart = positions[0].Split(", ");
            string[] positionEnd = positions[1].Split(", ");

            // ColorBorder, WidthBorder, StyleBorder
            string[] border = tokens[1].Split(", ");

            IShape result = new Line2D()
            {
                Start = new Point2D() { X = double.Parse(positionStart[0]), Y = double.Parse(positionStart[1]) },
                End = new Point2D() { X = double.Parse(positionEnd[0]), Y = double.Parse(positionEnd[1]) },
                ColorBorder = new SolidColorBrush((Color)ColorConverter.ConvertFromString(border[0])),
                WidthBorder = double.Parse(border[1]),
                StyleBorder = DoubleCollection.Parse(border[2])
            };

            return result;
        }
    }
}
