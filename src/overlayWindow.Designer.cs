namespace Overlay.src {
    partial class overlayWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            components = new System.ComponentModel.Container( );
            positionTimer = new System.Windows.Forms.Timer( components );
            SuspendLayout( );
            // 
            // positionTimer
            // 
            positionTimer.Enabled = true;
            positionTimer.Interval = 1;
            positionTimer.Tick +=  UpdatePosition ;
            // 
            // overlayWindow
            // 
            AutoScaleDimensions = new SizeF( 18F, 39F );
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size( 587, 244 );
            Font = new Font( "Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point,   0 );
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding( 7 );
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "overlayWindow";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "overlayWindow";
            TopMost = true;
            TransparencyKey = Color.Lime;
            Load +=  InitializeOverlay ;
            Paint +=  OnPaintCallback ;
            ResumeLayout( false );
        }

        #endregion

        private System.Windows.Forms.Timer positionTimer;
    }
}