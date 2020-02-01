namespace WordpadKiller
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPanel = new System.Windows.Forms.Panel();
            this.appName = new Guna.UI.WinForms.GunaLabel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorPicker = new Guna.UI.WinForms.GunaButton();
            this.fontStyleLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.allignRight = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loadButton = new Guna.UI.WinForms.GunaButton();
            this.saveButton = new Guna.UI.WinForms.GunaButton();
            this.loadBox = new Guna.UI.WinForms.GunaTextBox();
            this.saveBox = new Guna.UI.WinForms.GunaTextBox();
            this.allignCenter = new Guna.UI.WinForms.GunaButton();
            this.allignLeft = new Guna.UI.WinForms.GunaButton();
            this.fontSizeBox = new Guna.UI.WinForms.GunaComboBox();
            this.fontBox = new Guna.UI.WinForms.GunaComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.italic = new Guna.UI.WinForms.GunaImageCheckBox();
            this.underline = new Guna.UI.WinForms.GunaImageCheckBox();
            this.bold = new Guna.UI.WinForms.GunaImageCheckBox();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.topPanel.Controls.Add(this.appName);
            this.topPanel.Controls.Add(this.gunaTransfarantPictureBox1);
            this.topPanel.Controls.Add(this.gunaControlBox1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1150, 30);
            this.topPanel.TabIndex = 0;
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Elektra Text Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(32, 6);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(112, 18);
            this.appName.TabIndex = 3;
            this.appName.Text = "Notepad Killer";
            this.appName.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1105, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 30);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.topPanel;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.italic);
            this.panel1.Controls.Add(this.underline);
            this.panel1.Controls.Add(this.bold);
            this.panel1.Controls.Add(this.colorPicker);
            this.panel1.Controls.Add(this.fontStyleLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.allignRight);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loadButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.loadBox);
            this.panel1.Controls.Add(this.saveBox);
            this.panel1.Controls.Add(this.allignCenter);
            this.panel1.Controls.Add(this.allignLeft);
            this.panel1.Controls.Add(this.fontSizeBox);
            this.panel1.Controls.Add(this.fontBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 100);
            this.panel1.TabIndex = 1;
            // 
            // colorPicker
            // 
            this.colorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPicker.Animated = true;
            this.colorPicker.AnimationHoverSpeed = 0.07F;
            this.colorPicker.AnimationSpeed = 0.03F;
            this.colorPicker.BackColor = System.Drawing.Color.Transparent;
            this.colorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.colorPicker.BaseColor = System.Drawing.Color.White;
            this.colorPicker.BorderColor = System.Drawing.Color.Black;
            this.colorPicker.DialogResult = System.Windows.Forms.DialogResult.None;
            this.colorPicker.FocusedColor = System.Drawing.Color.Empty;
            this.colorPicker.Font = new System.Drawing.Font("Elektra Text Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPicker.ForeColor = System.Drawing.Color.Black;
            this.colorPicker.Image = null;
            this.colorPicker.ImageSize = new System.Drawing.Size(20, 20);
            this.colorPicker.Location = new System.Drawing.Point(533, 50);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(112)))), ((int)(((byte)(96)))));
            this.colorPicker.OnHoverBorderColor = System.Drawing.Color.Black;
            this.colorPicker.OnHoverForeColor = System.Drawing.Color.White;
            this.colorPicker.OnHoverImage = null;
            this.colorPicker.OnPressedColor = System.Drawing.Color.Black;
            this.colorPicker.Radius = 5;
            this.colorPicker.Size = new System.Drawing.Size(243, 26);
            this.colorPicker.TabIndex = 8;
            this.colorPicker.Text = "Select Color";
            this.colorPicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colorPicker.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.colorPicker.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // fontStyleLabel
            // 
            this.fontStyleLabel.AutoSize = true;
            this.fontStyleLabel.Font = new System.Drawing.Font("Elektra Text Pro", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontStyleLabel.Location = new System.Drawing.Point(287, 17);
            this.fontStyleLabel.Name = "fontStyleLabel";
            this.fontStyleLabel.Size = new System.Drawing.Size(106, 22);
            this.fontStyleLabel.TabIndex = 6;
            this.fontStyleLabel.Text = "Font styles";
            this.fontStyleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elektra Text Pro", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Size";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allignRight
            // 
            this.allignRight.Animated = true;
            this.allignRight.AnimationHoverSpeed = 0.07F;
            this.allignRight.AnimationSpeed = 0.03F;
            this.allignRight.BackColor = System.Drawing.Color.Transparent;
            this.allignRight.BaseColor = System.Drawing.Color.White;
            this.allignRight.BorderColor = System.Drawing.Color.Black;
            this.allignRight.DialogResult = System.Windows.Forms.DialogResult.None;
            this.allignRight.FocusedColor = System.Drawing.Color.Empty;
            this.allignRight.Font = new System.Drawing.Font("Elektra Text Pro", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allignRight.ForeColor = System.Drawing.Color.Black;
            this.allignRight.Image = null;
            this.allignRight.ImageSize = new System.Drawing.Size(20, 20);
            this.allignRight.Location = new System.Drawing.Point(479, 50);
            this.allignRight.Name = "allignRight";
            this.allignRight.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(112)))), ((int)(((byte)(96)))));
            this.allignRight.OnHoverBorderColor = System.Drawing.Color.Black;
            this.allignRight.OnHoverForeColor = System.Drawing.Color.White;
            this.allignRight.OnHoverImage = null;
            this.allignRight.OnPressedColor = System.Drawing.Color.Black;
            this.allignRight.Radius = 5;
            this.allignRight.Size = new System.Drawing.Size(26, 26);
            this.allignRight.TabIndex = 2;
            this.allignRight.Tag = "R";
            this.allignRight.Text = "R";
            this.allignRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.allignRight.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.allignRight.Click += new System.EventHandler(this.allignRight_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elektra Text Pro", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Font";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elektra Text Pro", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Allignment";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Elektra Text Pro", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(623, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Color";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadButton
            // 
            this.loadButton.Animated = true;
            this.loadButton.AnimationHoverSpeed = 0.07F;
            this.loadButton.AnimationSpeed = 0.03F;
            this.loadButton.BackColor = System.Drawing.Color.Transparent;
            this.loadButton.BaseColor = System.Drawing.Color.White;
            this.loadButton.BorderColor = System.Drawing.Color.Black;
            this.loadButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loadButton.FocusedColor = System.Drawing.Color.Empty;
            this.loadButton.Font = new System.Drawing.Font("Elektra Text Pro", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.ForeColor = System.Drawing.Color.Black;
            this.loadButton.Image = null;
            this.loadButton.ImageSize = new System.Drawing.Size(20, 20);
            this.loadButton.Location = new System.Drawing.Point(1070, 18);
            this.loadButton.Name = "loadButton";
            this.loadButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(112)))), ((int)(((byte)(96)))));
            this.loadButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loadButton.OnHoverForeColor = System.Drawing.Color.White;
            this.loadButton.OnHoverImage = null;
            this.loadButton.OnPressedColor = System.Drawing.Color.Black;
            this.loadButton.Radius = 5;
            this.loadButton.Size = new System.Drawing.Size(68, 26);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loadButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Animated = true;
            this.saveButton.AnimationHoverSpeed = 0.07F;
            this.saveButton.AnimationSpeed = 0.03F;
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.BaseColor = System.Drawing.Color.White;
            this.saveButton.BorderColor = System.Drawing.Color.Black;
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveButton.FocusedColor = System.Drawing.Color.Empty;
            this.saveButton.Font = new System.Drawing.Font("Elektra Text Pro", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Image = null;
            this.saveButton.ImageSize = new System.Drawing.Size(20, 20);
            this.saveButton.Location = new System.Drawing.Point(1070, 50);
            this.saveButton.Name = "saveButton";
            this.saveButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(112)))), ((int)(((byte)(96)))));
            this.saveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.saveButton.OnHoverForeColor = System.Drawing.Color.White;
            this.saveButton.OnHoverImage = null;
            this.saveButton.OnPressedColor = System.Drawing.Color.Black;
            this.saveButton.Radius = 5;
            this.saveButton.Size = new System.Drawing.Size(68, 26);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadBox
            // 
            this.loadBox.BackColor = System.Drawing.Color.Transparent;
            this.loadBox.BaseColor = System.Drawing.Color.White;
            this.loadBox.BorderColor = System.Drawing.Color.Silver;
            this.loadBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loadBox.Enabled = false;
            this.loadBox.FocusedBaseColor = System.Drawing.Color.White;
            this.loadBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.loadBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.loadBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loadBox.ForeColor = System.Drawing.Color.Gray;
            this.loadBox.Location = new System.Drawing.Point(806, 18);
            this.loadBox.Name = "loadBox";
            this.loadBox.PasswordChar = '\0';
            this.loadBox.Radius = 5;
            this.loadBox.ReadOnly = true;
            this.loadBox.Size = new System.Drawing.Size(258, 26);
            this.loadBox.TabIndex = 4;
            this.loadBox.Text = "Press Load button and select file";
            // 
            // saveBox
            // 
            this.saveBox.BackColor = System.Drawing.Color.Transparent;
            this.saveBox.BaseColor = System.Drawing.Color.White;
            this.saveBox.BorderColor = System.Drawing.Color.Silver;
            this.saveBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.saveBox.Enabled = false;
            this.saveBox.FocusedBaseColor = System.Drawing.Color.White;
            this.saveBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.saveBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.saveBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveBox.ForeColor = System.Drawing.Color.Gray;
            this.saveBox.Location = new System.Drawing.Point(806, 50);
            this.saveBox.Name = "saveBox";
            this.saveBox.PasswordChar = '\0';
            this.saveBox.Radius = 5;
            this.saveBox.Size = new System.Drawing.Size(258, 26);
            this.saveBox.TabIndex = 4;
            this.saveBox.Text = "Press Save button to save text file";
            this.saveBox.Click += new System.EventHandler(this.saveBox_Click);
            // 
            // allignCenter
            // 
            this.allignCenter.Animated = true;
            this.allignCenter.AnimationHoverSpeed = 0.07F;
            this.allignCenter.AnimationSpeed = 0.03F;
            this.allignCenter.BackColor = System.Drawing.Color.Transparent;
            this.allignCenter.BaseColor = System.Drawing.Color.White;
            this.allignCenter.BorderColor = System.Drawing.Color.Black;
            this.allignCenter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.allignCenter.FocusedColor = System.Drawing.Color.Empty;
            this.allignCenter.Font = new System.Drawing.Font("Elektra Text Pro", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allignCenter.ForeColor = System.Drawing.Color.Black;
            this.allignCenter.Image = null;
            this.allignCenter.ImageSize = new System.Drawing.Size(20, 20);
            this.allignCenter.Location = new System.Drawing.Point(447, 51);
            this.allignCenter.Name = "allignCenter";
            this.allignCenter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(112)))), ((int)(((byte)(96)))));
            this.allignCenter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.allignCenter.OnHoverForeColor = System.Drawing.Color.White;
            this.allignCenter.OnHoverImage = null;
            this.allignCenter.OnPressedColor = System.Drawing.Color.Black;
            this.allignCenter.Radius = 5;
            this.allignCenter.Size = new System.Drawing.Size(26, 26);
            this.allignCenter.TabIndex = 2;
            this.allignCenter.Tag = "C";
            this.allignCenter.Text = "C";
            this.allignCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.allignCenter.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.allignCenter.Click += new System.EventHandler(this.allignCenter_Click);
            // 
            // allignLeft
            // 
            this.allignLeft.Animated = true;
            this.allignLeft.AnimationHoverSpeed = 0.07F;
            this.allignLeft.AnimationSpeed = 0.03F;
            this.allignLeft.BackColor = System.Drawing.Color.Transparent;
            this.allignLeft.BaseColor = System.Drawing.Color.White;
            this.allignLeft.BorderColor = System.Drawing.Color.Black;
            this.allignLeft.DialogResult = System.Windows.Forms.DialogResult.None;
            this.allignLeft.FocusedColor = System.Drawing.Color.Empty;
            this.allignLeft.Font = new System.Drawing.Font("Elektra Text Pro", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allignLeft.ForeColor = System.Drawing.Color.Black;
            this.allignLeft.Image = null;
            this.allignLeft.ImageSize = new System.Drawing.Size(20, 20);
            this.allignLeft.Location = new System.Drawing.Point(415, 51);
            this.allignLeft.Name = "allignLeft";
            this.allignLeft.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(112)))), ((int)(((byte)(96)))));
            this.allignLeft.OnHoverBorderColor = System.Drawing.Color.Black;
            this.allignLeft.OnHoverForeColor = System.Drawing.Color.White;
            this.allignLeft.OnHoverImage = null;
            this.allignLeft.OnPressedColor = System.Drawing.Color.Black;
            this.allignLeft.Radius = 5;
            this.allignLeft.Size = new System.Drawing.Size(26, 26);
            this.allignLeft.TabIndex = 2;
            this.allignLeft.Tag = "L";
            this.allignLeft.Text = "L";
            this.allignLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.allignLeft.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.allignLeft.Click += new System.EventHandler(this.allignLeft_Click);
            // 
            // fontSizeBox
            // 
            this.fontSizeBox.BackColor = System.Drawing.Color.Transparent;
            this.fontSizeBox.BaseColor = System.Drawing.Color.White;
            this.fontSizeBox.BorderColor = System.Drawing.Color.Silver;
            this.fontSizeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fontSizeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontSizeBox.FocusedColor = System.Drawing.Color.Empty;
            this.fontSizeBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fontSizeBox.ForeColor = System.Drawing.Color.Black;
            this.fontSizeBox.FormattingEnabled = true;
            this.fontSizeBox.Location = new System.Drawing.Point(209, 50);
            this.fontSizeBox.Name = "fontSizeBox";
            this.fontSizeBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.fontSizeBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.fontSizeBox.Radius = 5;
            this.fontSizeBox.Size = new System.Drawing.Size(65, 26);
            this.fontSizeBox.TabIndex = 1;
            this.fontSizeBox.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.fontSizeBox.SelectedIndexChanged += new System.EventHandler(this.fontSizeBox_SelectedIndexChanged);
            // 
            // fontBox
            // 
            this.fontBox.BackColor = System.Drawing.Color.Transparent;
            this.fontBox.BaseColor = System.Drawing.Color.White;
            this.fontBox.BorderColor = System.Drawing.Color.Silver;
            this.fontBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fontBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontBox.FocusedColor = System.Drawing.Color.Empty;
            this.fontBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fontBox.ForeColor = System.Drawing.Color.Black;
            this.fontBox.FormattingEnabled = true;
            this.fontBox.Location = new System.Drawing.Point(12, 50);
            this.fontBox.Name = "fontBox";
            this.fontBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.fontBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.fontBox.Radius = 5;
            this.fontBox.Size = new System.Drawing.Size(191, 26);
            this.fontBox.TabIndex = 0;
            this.fontBox.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.fontBox.SelectedIndexChanged += new System.EventHandler(this.fontBox_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1150, 570);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // colorDialog1
            // 
            this.colorDialog1.HelpRequest += new System.EventHandler(this.Form1_Load);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontBox_DropDown);
            // 
            // italic
            // 
            this.italic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.italic.ImageCheckedOff = global::WordpadKiller.Properties.Resources.italic;
            this.italic.ImageCheckedOn = global::WordpadKiller.Properties.Resources.italic_white;
            this.italic.ImageSize = new System.Drawing.Size(20, 20);
            this.italic.Location = new System.Drawing.Point(361, 50);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(26, 26);
            this.italic.TabIndex = 10;
            this.italic.CheckedChanged += new System.EventHandler(this.fontStyle_CheckedChanged);
            // 
            // underline
            // 
            this.underline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.underline.ImageCheckedOff = global::WordpadKiller.Properties.Resources.boldtest;
            this.underline.ImageCheckedOn = global::WordpadKiller.Properties.Resources.boldtest_white;
            this.underline.ImageSize = new System.Drawing.Size(20, 20);
            this.underline.Location = new System.Drawing.Point(329, 50);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(26, 26);
            this.underline.TabIndex = 10;
            this.underline.CheckedChanged += new System.EventHandler(this.fontStyle_CheckedChanged);
            // 
            // bold
            // 
            this.bold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bold.ImageCheckedOff = global::WordpadKiller.Properties.Resources.bold;
            this.bold.ImageCheckedOn = global::WordpadKiller.Properties.Resources.bold_white;
            this.bold.ImageSize = new System.Drawing.Size(20, 20);
            this.bold.Location = new System.Drawing.Point(297, 50);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(26, 26);
            this.bold.TabIndex = 10;
            this.bold.CheckedChanged += new System.EventHandler(this.fontStyle_CheckedChanged);
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Image = global::WordpadKiller.Properties.Resources.Ico;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaTransfarantPictureBox1.TabIndex = 1;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton loadButton;
        private Guna.UI.WinForms.GunaButton saveButton;
        private Guna.UI.WinForms.GunaTextBox loadBox;
        private Guna.UI.WinForms.GunaTextBox saveBox;
        private Guna.UI.WinForms.GunaButton allignRight;
        private Guna.UI.WinForms.GunaButton allignCenter;
        private Guna.UI.WinForms.GunaButton allignLeft;
        private Guna.UI.WinForms.GunaComboBox fontSizeBox;
        private Guna.UI.WinForms.GunaComboBox fontBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Guna.UI.WinForms.GunaButton colorPicker;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private Guna.UI.WinForms.GunaLabel appName;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fontStyleLabel;
        private Guna.UI.WinForms.GunaImageCheckBox bold;
        private Guna.UI.WinForms.GunaImageCheckBox underline;
        private Guna.UI.WinForms.GunaImageCheckBox italic;
    }
}

