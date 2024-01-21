using Overlay.src;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Overlay {
    public partial class mainWindow : Form {

        WindowProperties properties = new( );

        public mainWindow( ) {
            InitializeComponent( );
        }

        private void WindowInitialize( object sender, EventArgs e ) {


        }

        private void MenuOpenTick( object sender, EventArgs e ) {

            if ( ( Imports.GetAsyncKeyState( Keys.Insert ) & 1 ) > 0 )
                properties.open = !properties.open;

            if ( properties.open && properties.currentFade < 1.0 )
                Opacity = Misc.Lerp( 0f, 1f, properties.currentFade += 0.1 );
            else if ( !properties.open && properties.currentFade > 0.0 )
                Opacity = Misc.Lerp( 0f, 1f, properties.currentFade -= 0.1 );

            Visible = Opacity > 0.0 ? true : false;
        }

        // win 11 already does rounding :)
        private void RoundedCorners( ) =>
            Region = Region.FromHrgn( Imports.CreateRoundRectRgn( 0, 0, Width, Height, 20, 20 ) );

        private void OnLaunchOverlay( object sender, EventArgs e ) {

            try {

                if ( properties.runningWindow != null )
                    properties.runningWindow.Close();

                properties.runningWindow = null!;
                string userTextFormated = userInput.Text;
                if ( userInput.Text.Contains( ".exe" ) )
                    userTextFormated = userInput.Text.Remove( userInput.Text.Length - 4 );

                bool name = radioID.Checked ? false : true;
                if ( userTextFormated.Trim( ).Length == 0 )
                    throw new Exception( $"Wrong process {( name ? "name" : "id" )}" );

                if ( !int.TryParse( userTextFormated, out var processID ) && !name )
                    throw new Exception( $"Invalid process ID" );

                Process? process = null!;
                if ( name )
                    Misc.GetProcess( userTextFormated, out process );
                else
                    Misc.GetProcess( processID, out process );

                if ( process == null )
                    throw new Exception( $"Couldn't find the process" );

                properties.runningWindow = new( process.MainWindowHandle );
                properties.runningWindow.Show( );
            }
            catch ( Exception ex ) {

                MessageBox.Show( $"{ex.Message}" );
            }

        }
    }
}
