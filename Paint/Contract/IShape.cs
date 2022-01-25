using System;
using System.Windows;
using System.Windows.Media;

namespace Contract
{
    public interface IShape
    {
        string Name { get; }
        string Icon { get; }
        Brush ColorBorder { get; set; }
        double WidthBorder { get; set; }
        DoubleCollection StyleBorder { get; set; }

        void HandleStart(double x, double y);
        void HandleEnd(double x, double y);

        UIElement Draw();
        IShape Clone(Brush color, double width, DoubleCollection style);
    }
}
