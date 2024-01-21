using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Overlay.src {
    public partial class overlayWindow : Form {
        public overlayWindow( IntPtr handle ) {
            InitializeComponent( );
            windowHandle = handle;
        }

        private IntPtr windowHandle = IntPtr.Zero;
        private void InitializeOverlay( object sender, EventArgs e ) {
            Imports.SetWindowLong( Handle, -20, Imports.GetWindowLong( Handle, -20 ) | 0x80000 | 0x20 );
        }

        private void UpdatePosition( object sender, EventArgs e ) {

            if ( Imports.GetWindowRect( windowHandle, out Imports.RECT windowRect ) ) {

                Location = new Point( windowRect.Left, windowRect.Top );
                Size = new Size( windowRect.Right - windowRect.Left, windowRect.Bottom - windowRect.Top );
            }
        }

        private void OnPaintCallback( object sender, PaintEventArgs e ) {

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            string text = "No Antialiasing";
            Font font = new Font( "Consolas", 20 );
            Brush brush = Brushes.Black;

            e.Graphics.DrawString( text, font, brush, 50, 100 );
        }
    }
}
