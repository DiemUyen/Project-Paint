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
using System.ComponentModel;

namespace Paint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow, INotifyPropertyChanged
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
        double originalWidth, originalHeight;
        List<CustomColor> _colors = new List<CustomColor>();
        ScaleTransform scaleTransform = new ScaleTransform();
        int zoomOutTimes, zoomInTimes;
        List<IShape> _redoShapes = new List<IShape>();

        public event PropertyChangedEventHandler PropertyChanged;

        public string TitleName { get; set; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Load all graphic objects from external DLL files
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

            // Create orginal data
            TitleName = "Untitled";
            ShapeList.ItemsSource = _shapeButtons;
            _selectedShapeName = _prototypes.First().Value.Name;
            _preview = _prototypes[_selectedShapeName].Clone();
            DataContext = this;
            zoomInTimes = 0;
            zoomOutTimes = 0;

            // Create canvas
            originalWidth = ActualWidth;
            originalHeight = ActualHeight;

            canvas.Width = originalWidth;
            canvas.Height = originalHeight;
            border.Width = canvas.Width;
            border.Height = canvas.Height;

            canvas.LayoutTransform = scaleTransform;
            border.LayoutTransform = scaleTransform;

            // Create color list
            _colors.Add(new CustomColor() { ColorName = "Black", HexColor = new SolidColorBrush(Colors.Black) });
            _colors.Add(new CustomColor() { ColorName = "Gray", HexColor = new SolidColorBrush(Colors.Gray) });
            _colors.Add(new CustomColor() { ColorName = "Dark Red", HexColor = new SolidColorBrush(Colors.DarkRed) });
            _colors.Add(new CustomColor() { ColorName = "Red", HexColor = new SolidColorBrush(Colors.Red) });
            _colors.Add(new CustomColor() { ColorName = "Orange", HexColor = new SolidColorBrush(Colors.Orange) });
            _colors.Add(new CustomColor() { ColorName = "Yellow", HexColor = new SolidColorBrush(Colors.Yellow) });
            _colors.Add(new CustomColor() { ColorName = "Green", HexColor = new SolidColorBrush(Colors.Green) });
            _colors.Add(new CustomColor() { ColorName = "Turquoise", HexColor = new SolidColorBrush(Colors.Turquoise) });
            _colors.Add(new CustomColor() { ColorName = "Indigo", HexColor = new SolidColorBrush(Colors.Indigo) });
            _colors.Add(new CustomColor() { ColorName = "Purple", HexColor = new SolidColorBrush(Colors.Purple) });
            _colors.Add(new CustomColor() { ColorName = "White", HexColor = new SolidColorBrush(Colors.White) });
            _colors.Add(new CustomColor() { ColorName = "Light Gray", HexColor = new SolidColorBrush(Colors.LightGray) });
            _colors.Add(new CustomColor() { ColorName = "Brown", HexColor = new SolidColorBrush(Colors.Brown) });
            _colors.Add(new CustomColor() { ColorName = "Light Pink", HexColor = new SolidColorBrush(Colors.LightPink) });
            _colors.Add(new CustomColor() { ColorName = "Gold", HexColor = new SolidColorBrush(Colors.Gold) });
            _colors.Add(new CustomColor() { ColorName = "Light Yellow", HexColor = new SolidColorBrush(Colors.LightYellow) });
            _colors.Add(new CustomColor() { ColorName = "Lime", HexColor = new SolidColorBrush(Colors.Lime) });
            _colors.Add(new CustomColor() { ColorName = "Medium Turquoise", HexColor = new SolidColorBrush(Colors.MediumTurquoise) });
            _colors.Add(new CustomColor() { ColorName = "Light Slate Gray", HexColor = new SolidColorBrush(Colors.LightSlateGray) });
            _colors.Add(new CustomColor() { ColorName = "Lavender", HexColor = new SolidColorBrush(Colors.Lavender) });

            ColorList.ItemsSource = _colors;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point position = e.GetPosition(canvas);
            if (position.X > border.Width || position.Y > border.Height)
            {
                return;
            }

            isSaved = false;
            isDrawing = true;
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
            if (isDrawing)
            {
                isDrawing = false;
                BtnUndo.IsEnabled = true;
                BtnRedo.IsEnabled = false;
                _redoShapes.Clear();

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
                ClearCanvas();
            }
            else
            {
                var result = MessageBox.Show("Do you want to save changes to " + TitleName + "?", "Paint", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        bool saveResult = SaveCanvasToImage();
                        if (saveResult)
                        {
                            MessageBox.Show("Save successfully.");
                            ClearCanvas();
                        }
                        else
                            MessageBox.Show("Save failed.");
                        break;
                    case MessageBoxResult.No:
                        ClearCanvas();
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
                // Set the original size of canvas
                SetOriginalCanvasToSave();

                // Render canvas to bitmap
                int canvasWidth = (int)canvas.ActualWidth;
                int canvasHeight = (int)canvas.ActualHeight;
                RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap(canvasWidth, canvasHeight, 96d, 96d, PixelFormats.Pbgra32);
                canvas.Measure(new Size(canvasWidth, canvasHeight));
                canvas.Arrange(new Rect(new Size(canvasWidth, canvasHeight)));
                renderTargetBitmap.Render(canvas);
                ReturnZoomCanvas();
                
                // Transfer bitmap to png 
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(renderTargetBitmap));

                // Choose path to save image
                string imageFilename = "";
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Image files|*.png";
                if (dialog.ShowDialog() == true)
                    imageFilename = dialog.FileName;
                else
                    throw new Exception();

                // Save image
                isSaved = true;
                using (FileStream stream = new FileStream(imageFilename, FileMode.Create))
                {
                    encoder.Save(stream);
                }

                // Update title
                UpdateTitle(imageFilename);

                return true;
            }
            catch (Exception e)
            {
                isSaved = false;
                return false;
            }
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All image files|*.png;*jpeg;*jpg;*bmp|PNG|*png|JPEG|*jpg;*jpeg|BMP|*.bmp";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == true)
            {
                string imageFilename = dialog.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(imageFilename, UriKind.RelativeOrAbsolute);
                bitmap.EndInit();

                ImageBrush imageBrush = new ImageBrush();
                imageBrush.ImageSource = bitmap;
                canvas.Width = bitmap.Width;
                canvas.Height = bitmap.Height;
                border.Width = bitmap.Width;
                border.Height = bitmap.Height;
                canvas.Background = imageBrush;
                UpdateTitle(imageFilename);
            }
        }

        private void UpdateTitle(string imageFilename)
        {
            int lastBackflashPosition = imageFilename.LastIndexOf("\\");
            string name = imageFilename.Substring(lastBackflashPosition + 1);
            int lastDotPosition = name.LastIndexOf(".");
            TitleName = name.Substring(0, lastDotPosition);
        }

        private void BtnColorPicker_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog colorPicker = new System.Windows.Forms.ColorDialog();
            if (colorPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var color = colorPicker.Color;
                BtnBrushColor.Background = new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B));
            }
        }

        private void BtnColor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnZoomIn_Click(object sender, RoutedEventArgs e)
        {
            if (zoomInTimes < 3)
            {
                scaleTransform.ScaleX *= 2;
                scaleTransform.ScaleY *= 2;
                zoomInTimes++;
                zoomOutTimes--;
            }
        }

        private void BtnZoomOut_Click(object sender, RoutedEventArgs e)
        {
            if (zoomOutTimes < 3)
            {
                scaleTransform.ScaleX /= 2;
                scaleTransform.ScaleY /= 2;
                zoomOutTimes++;
                zoomInTimes--;
            }
        }

        private void ClearCanvas()
        {
            // Clear all objects in canvas
            canvas.Children.Clear();
            _shapes.Clear();
            TitleName = "Untitled";

            // Clear background
            canvas.Background = new SolidColorBrush(Colors.White);

            // Set the original canvas and border
            canvas.Width = originalWidth;
            canvas.Height = originalHeight;
            border.Width = canvas.Width;
            border.Height = canvas.Height;
        }

        private void BtnUndo_Click(object sender, RoutedEventArgs e)
        {
            BtnRedo.IsEnabled = true;

            int countObjects = canvas.Children.Count;
            _redoShapes.Add(_shapes.Last());
            canvas.Children.RemoveAt(countObjects - 1);
            _shapes.RemoveAt(countObjects - 1);

            if (canvas.Children.Count == 0)
                BtnUndo.IsEnabled = false;
        }

        private void BtnRedo_Click(object sender, RoutedEventArgs e)
        {
            BtnUndo.IsEnabled = true;

            canvas.Children.Add(_redoShapes.Last().Draw());
            _shapes.Add(_redoShapes.Last());
            _redoShapes.RemoveAt(_redoShapes.Count - 1);

            if (_redoShapes.Count == 0)
                BtnRedo.IsEnabled = false;
        }

        private void SetOriginalCanvasToSave()
        {
            int zoom = zoomInTimes;
            while (zoom != 0)
            {
                if (zoom > 0)
                {
                    scaleTransform.ScaleX /= 2;
                    scaleTransform.ScaleY /= 2;
                    zoom--;
                }
                else
                {
                    scaleTransform.ScaleX *= 2;
                    scaleTransform.ScaleY *= 2;
                    zoom++;
                }
            }
        }

        private void ReturnZoomCanvas()
        {
            int zoom = zoomInTimes;
            while (zoom != 0)
            {
                if (zoom > 0)
                {
                    scaleTransform.ScaleX *= 2;
                    scaleTransform.ScaleY *= 2;
                    zoom--;
                }
                else
                {
                    scaleTransform.ScaleX /= 2;
                    scaleTransform.ScaleY /= 2;
                    zoom++;
                }
            }
        }
    }
}
