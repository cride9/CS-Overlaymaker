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
using static Overlay.CONTROLS;
using static Overlay.src.ControlProperties;

namespace Overlay.src {
    public partial class overlayWindow : Form {
        public overlayWindow( IntPtr handle ) {
            InitializeComponent( );
            windowHandle = handle;
        }

        public static List<KeyValuePair<CONTROLS, object>> controls = new( );
        private IntPtr windowHandle = IntPtr.Zero;
        private KeyValuePair<CONTROLS, object> currentDraw;
        private Font font = null;

        private void InitializeOverlay( object sender, EventArgs e ) {
            Imports.SetWindowLong( Handle, -20, Imports.GetWindowLong( Handle, -20 ) | 0x80000 | 0x20 );
            font = new Font( "Consolas", 20 );
        }

        private void UpdatePosition( object sender, EventArgs e ) {

            if ( Imports.GetWindowRect( windowHandle, out Imports.RECT windowRect ) ) {

                Location = new Point( windowRect.Left, windowRect.Top );
                Size = new Size( windowRect.Right - windowRect.Left, windowRect.Bottom - windowRect.Top );
            }

            //foreach ( var control in controls ) {

            //    currentDraw = control;
            //    Refresh( );
            //}
        }

        private void OnPaintCallback( object sender, PaintEventArgs e ) {

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;


            foreach ( var it in controls ) {
                if ( it.Value != null ) {
                    switch ( it.Key ) {
                        case CONTROLS.TEXT:
                            var control = ( ( ControlText )it.Value );
                            control.UpdateBounds( Width, Height );
                            e.Graphics.DrawString( control.text, font, Brushes.Black, control.x, control.y );
                            break;
                    }
                }
            }
        }
    }
}
