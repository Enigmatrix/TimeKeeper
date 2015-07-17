using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TimeKeeper.Views
{
    /// <summary>
    ///     Interaction logic for MainView.xaml
    ///     This class is magic. Interacting with Win32 apis is a pain ..
    ///     Credit to https://gist.github.com/JoshClose/1367657, most of
    ///     the code here is copied onto here
    ///     There are other ways to achive this of course (using manual addition
    ///     to width or height / changing top and left when mouse drag is detected on rectangles)
    ///     but those dont take advantage of the built in system calculations(windows calculates
    ///     the coordinates and length based on user mouse movement and such) so this is preferable
    ///     which is why we are communicating with the Win32 api using P/Invoke
    /// </summary>
    public partial class MainView
    {
        private const int WM_SYSCOMMAND = 0x112;
        private HwndSource hwndSource;

        public MainView()
        {
            InitializeComponent();
        }

        //Call the this function from user32.dll using P/Invoke. Magic
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private void MainWindowSourceInitialized(object sender, EventArgs e)
        {
            hwndSource = PresentationSource.FromVisual((Visual) sender) as HwndSource;
        }

        private void ResizeWindow(ResizeDirection direction)
        {
            SendMessage(hwndSource.Handle, WM_SYSCOMMAND, (IntPtr) direction, IntPtr.Zero);
        }

        protected void ResetCursor(object sender, MouseEventArgs e)
        {
            if (Mouse.LeftButton != MouseButtonState.Pressed)
            {
                Cursor = Cursors.Arrow;
            }
        }

        protected void Resize(object sender, MouseButtonEventArgs e)
        {
            var clickedShape = sender as Shape;

            switch (clickedShape.Name)
            {
                case "ResizeN":
                    Cursor = Cursors.SizeNS;
                    ResizeWindow(ResizeDirection.Top);
                    break;
                case "ResizeE":
                    Cursor = Cursors.SizeWE;
                    ResizeWindow(ResizeDirection.Right);
                    break;
                case "ResizeS":
                    Cursor = Cursors.SizeNS;
                    ResizeWindow(ResizeDirection.Bottom);
                    break;
                case "ResizeW":
                    Cursor = Cursors.SizeWE;
                    ResizeWindow(ResizeDirection.Left);
                    break;
                case "ResizeNW":
                    Cursor = Cursors.SizeNWSE;
                    ResizeWindow(ResizeDirection.TopLeft);
                    break;
                case "ResizeNE":
                    Cursor = Cursors.SizeNESW;
                    ResizeWindow(ResizeDirection.TopRight);
                    break;
                case "ResizeSE":
                    Cursor = Cursors.SizeNWSE;
                    ResizeWindow(ResizeDirection.BottomRight);
                    break;
                case "ResizeSW":
                    Cursor = Cursors.SizeNESW;
                    ResizeWindow(ResizeDirection.BottomLeft);
                    break;
                default:
                    break;
            }
        }

        protected void DisplayResizeCursor(object sender, MouseEventArgs e)
        {
            var clickedShape = sender as Shape;

            switch (clickedShape.Name)
            {
                case "ResizeN":
                case "ResizeS":
                    Cursor = Cursors.SizeNS;
                    break;
                case "ResizeE":
                case "ResizeW":
                    Cursor = Cursors.SizeWE;
                    break;
                case "ResizeNW":
                case "ResizeSE":
                    Cursor = Cursors.SizeNWSE;
                    break;
                case "ResizeNE":
                case "ResizeSW":
                    Cursor = Cursors.SizeNESW;
                    break;
                default:
                    break;
            }
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        //System-defined constants I guess
        private enum ResizeDirection
        {
            Left = 61441,
            Right = 61442,
            Top = 61443,
            TopLeft = 61444,
            TopRight = 61445,
            Bottom = 61446,
            BottomLeft = 61447,
            BottomRight = 61448
        }
    }
}