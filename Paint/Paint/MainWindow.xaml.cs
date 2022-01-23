using Contract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Fluent;
using Microsoft.Win32;

namespace Paint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Dictionary<string, IShape> _prototypes = new Dictionary<string, IShape>();
        bool isDrawing = false;
        List<IShape> _shapeButtons = new List<IShape>();
        List<IShape> _shapes = new List<IShape>();
        IShape _preview;
        string _selectedShapeName;
        string projectPath = "";
        bool isSaved = true;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            projectPath = AppDomain.CurrentDomain.BaseDirectory;
            string exeFolderPath = projectPath + "\\DLL";
            var dllFiles = new DirectoryInfo(exeFolderPath).GetFiles("*.dll");

            foreach (var dll in dllFiles)
            {
                var assembly = Assembly.LoadFile(dll.FullName);
                var types = assembly.GetTypes();
                
                foreach (var type in types)
                {
                    if (type.IsClass && typeof(IShape).IsAssignableFrom(type))
                    {
                        var shape = Activator.CreateInstance(type) as IShape;
                        _prototypes.Add(shape.Name, shape);
                        _shapeButtons.Add(shape);
                    }
                }
            }

            ShapeList.ItemsSource = _shapeButtons;
            _selectedShapeName = _prototypes.First().Value.Name;
            _preview = _prototypes[_selectedShapeName].Clone();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isSaved = false;
            isDrawing = true;
            Point position = e.GetPosition(canvas);
            _preview.HandleStart(position.X, position.Y);
        }

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Point position = e.GetPosition(canvas);
                _preview.HandleEnd(position.X, position.Y);

                // Delete previous drawn shapes
                canvas.Children.Clear();

                // Draw shapes again
                foreach (var shape in _shapes)
                {
                    canvas.Children.Add(shape.Draw());
                }

                // Draw preview shape
                canvas.Children.Add(_preview.Draw());
            }
        }

        private void Border_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isDrawing = false;
            // Add preview shape into list drawn shapes
            Point position = e.GetPosition(canvas);
            _preview.HandleEnd(position.X, position.Y);
            _shapes.Add(_preview);

            // Create the next shape
            _preview = _prototypes[_selectedShapeName].Clone();

            // Delete previous drawn shapes
            canvas.Children.Clear();

            // Draw shapes again
            foreach (var shape in _shapes)
            {
                canvas.Children.Add(shape.Draw());
            }
        }

        private void BtnPaste_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnCut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCopy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnShape_Click(object sender, RoutedEventArgs e)
        {
            _selectedShapeName = (sender as Fluent.Button).Tag as string;
            _preview = _prototypes[_selectedShapeName].Clone();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            bool result = SaveCanvasToImage();
            if (result)
                MessageBox.Show("Save successfully.");
            else
                MessageBox.Show("Save failed.");
        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            if (isSaved)
            {
                canvas.Children.Clear();
                _shapes.Clear();
            }
            else
            {
                var result = MessageBox.Show("Do you want to save changes to ?", "Paint", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        bool saveResult = SaveCanvasToImage();
                        if (saveResult)
                            MessageBox.Show("Save successfully.");
                        else
                            MessageBox.Show("Save failed.");
                        break;
                    case MessageBoxResult.No:
                        canvas.Children.Clear();
                        _shapes.Clear();
                        break;
                    case MessageBoxResult.Cancel:
                        break;
                }
            }
        }

        private bool SaveCanvasToImage()
        {
            try
            {
                // Render canvas to bitmap
                int canvasWidth = (int)canvas.ActualWidth;
                int canvasHeight = (int)canvas.ActualHeight;
                RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap(canvasWidth, canvasHeight, 100d, 100d, PixelFormats.Pbgra32);
                canvas.Measure(new Size(canvasWidth, canvasHeight));
                canvas.Arrange(new Rect(new Size(canvasWidth, canvasHeight)));
                renderTargetBitmap.Render(canvas);

                // Transfer bitmap to png 
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(renderTargetBitmap));

                // Choose path to save image
                string imageFilename = "";
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Image files|*.png";
                if (dialog.ShowDialog() == true)
                    imageFilename = dialog.FileName;

                // Save image
                isSaved = true;
                using (FileStream stream = new FileStream(imageFilename, FileMode.Create))
                {
                    encoder.Save(stream);
                }

                return true;
            }
            catch (Exception e)
            {
                isSaved = false;
                return false;
            }
        }
    }
}
