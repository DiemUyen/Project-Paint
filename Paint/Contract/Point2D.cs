﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Contract
{
    public class Point2D : IShape
    {
        public string Name => "Point";

        public string Icon => "";

        public double X { get; set; }
        
        public double Y { get; set; }

        public IShape Clone()
        {
            return new Point2D();
        }

        public UIElement Draw()
        {
            Line point = new Line()
            {
                X1 = X,
                Y1 = Y,
                X2 = X,
                Y2 = Y,
                StrokeThickness = 1,
                Stroke = new SolidColorBrush(Colors.Black)
            };

            return point;
        }

        public void HandleEnd(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void HandleStart(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
