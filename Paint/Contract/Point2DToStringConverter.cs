using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Contract
{
    class Point2DToStringConverter : IShapeToStringConverter
    {
        public string Name => "Point";

        public string ConvertToData(IShape shape)
        {
            var point = (Point2D)shape;
            StringBuilder builder = new StringBuilder();

            // Point (X, Y) (ColorBorder, WidthBorder, StyleBorder)
            builder.Append(Name);
            builder.Append(" (");
            builder.Append(point.X);
            builder.Append(", ");
            builder.Append(point.Y);
            builder.Append(") (");
            builder.Append(point.ColorBorder.ToString());
            builder.Append(", ");
            builder.Append(point.WidthBorder.ToString());
            builder.Append(", ");
            builder.Append(point.StyleBorder.ToString());
            builder.Append(")");

            return builder.ToString();
        }

        public IShape ConvertToUI(string buffer)
        {
            int firstSpace = buffer.IndexOf(" ");

            // X, Y) (ColorBorder, WidthBorder, StyleBorder
            string elements = buffer.Substring(firstSpace + 2, buffer.Length - firstSpace - 3);
            string[] tokens = elements.Split(") (");

            // X, Y
            string[] position = tokens[0].Split(", ");

            // ColorBorder, WidthBorder, StyleBorder
            string[] border = tokens[1].Split(", ");

            IShape result = new Point2D()
            {
                X = Double.Parse(position[0]),
                Y = Double.Parse(position[1]),
                ColorBorder = new SolidColorBrush((Color)ColorConverter.ConvertFromString(border[0])),
                WidthBorder = Double.Parse(border[1]),
                StyleBorder = DoubleCollection.Parse(border[2])
            };

            return result;
        }
    }
}
