namespace Overlay {
    partial class mainWindow {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            components = new System.ComponentModel.Container( );
            openTimer = new System.Windows.Forms.Timer( components );
            userInput = new TextBox( );
            radioName = new RadioButton( );
            radioID = new RadioButton( );
            overlayButton = new Button( );
            vScroll = new VScrollBar( );
            controlBox = new GroupBox( );
            button1 = new Button( );
            comboBox1 = new ComboBox( );
            controlBox.SuspendLayout( );
            SuspendLayout( );
            // 
            // openTimer
            // 
            openTimer.Enabled = true;
            openTimer.Interval = 1;
            openTimer.Tick +=  MenuOpenTick ;
            // 
            // userInput
            // 
            userInput.BackColor = Color.FromArgb(     25,     25,     25 );
            userInput.BorderStyle = BorderStyle.FixedSingle;
            userInput.ForeColor = Color.FromArgb(     212,     212,     212 );
            userInput.Location = new Point( 12, 12 );
            userInput.Name = "userInput";
            userInput.Size = new Size( 257, 22 );
            userInput.TabIndex = 0;
            userInput.Text = "notepad.exe";
            userInput.TextAlign = HorizontalAlignment.Center;
            // 
            // radioName
            // 
            radioName.AutoSize = true;
            radioName.Checked = true;
            radioName.Location = new Point( 275, 16 );
            radioName.Name = "radioName";
            radioName.Size = new Size( 109, 18 );
            radioName.TabIndex = 1;
            radioName.TabStop = true;
            radioName.Text = "Process name";
            radioName.UseVisualStyleBackColor = true;
            // 
            // radioID
            // 
            radioID.AutoSize = true;
            radioID.Location = new Point( 275, 45 );
            radioID.Name = "radioID";
            radioID.Size = new Size( 95, 18 );
            radioID.TabIndex = 2;
            radioID.TabStop = true;
            radioID.Text = "Process ID";
            radioID.UseVisualStyleBackColor = true;
            // 
            // overlayButton
            // 
            overlayButton.BackColor = Color.FromArgb(     25,     25,     25 );
            overlayButton.FlatStyle = FlatStyle.Flat;
            overlayButton.Location = new Point( 12, 40 );
            overlayButton.Name = "overlayButton";
            overlayButton.Size = new Size( 257, 23 );
            overlayButton.TabIndex = 3;
            overlayButton.Text = "Attach overlay";
            overlayButton.UseVisualStyleBackColor = false;
            overlayButton.Click +=  OnLaunchOverlay ;
            // 
            // vScroll
            // 
            vScroll.Location = new Point( 341, 8 );
            vScroll.Name = "vScroll";
            vScroll.Size = new Size( 17, 303 );
            vScroll.TabIndex = 4;
            // 
            // controlBox
            // 
            controlBox.Controls.Add( vScroll );
            controlBox.ForeColor = Color.FromArgb(     212,     212,     212 );
            controlBox.Location = new Point( 12, 98 );
            controlBox.Name = "controlBox";
            controlBox.Size = new Size( 358, 313 );
            controlBox.TabIndex = 5;
            controlBox.TabStop = false;
            controlBox.Text = "Controls";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(     25,     25,     25 );
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point( 12, 69 );
            button1.Name = "button1";
            button1.Size = new Size( 125, 23 );
            button1.TabIndex = 6;
            button1.Text = "Add control";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(     25,     25,     25 );
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = Color.FromArgb(     212,     212,     212 );
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange( new object[ ] { "Label", "PictureBox", "TextBox", "Button", "CheckBox", "Panel", "GroupBox" } );
            comboBox1.Location = new Point( 148, 70 );
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size( 121, 22 );
            comboBox1.TabIndex = 7;
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF( 7F, 14F );
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(     25,     25,     25 );
            ClientSize = new Size( 408, 420 );
            Controls.Add( comboBox1 );
            Controls.Add( button1 );
            Controls.Add( controlBox );
            Controls.Add( overlayButton );
            Controls.Add( radioID );
            Controls.Add( radioName );
            Controls.Add( userInput );
            DoubleBuffered = true;
            Font = new Font( "Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point,   0 );
            ForeColor = Color.FromArgb(     212,     212,     212 );
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "mainWindow";
            ShowIcon = false;
            Text = "Main";
            Load +=  WindowInitialize ;
            controlBox.ResumeLayout( false );
            ResumeLayout( false );
            PerformLayout( );
        }

        #endregion

        private System.Windows.Forms.Timer openTimer;
        private TextBox userInput;
        private RadioButton radioName;
        private RadioButton radioID;
        private Button overlayButton;
        private VScrollBar vScroll;
        private GroupBox controlBox;
        private Button button1;
        private ComboBox comboBox1;
    }
}
