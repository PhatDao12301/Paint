namespace MyPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDrawLine = new System.Windows.Forms.Button();
            this.btDrawRectangle = new System.Windows.Forms.Button();
            this.btDrawCircle = new System.Windows.Forms.Button();
            this.btDrawSquare = new System.Windows.Forms.Button();
            this.btDrawEllipse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btThickness1 = new System.Windows.Forms.Button();
            this.btThickness5 = new System.Windows.Forms.Button();
            this.btThickness7 = new System.Windows.Forms.Button();
            this.btThickness3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorPickEdit1 = new DevExpress.XtraEditors.ColorPickEdit();
            this.btDrawPencil = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(955, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDrawPencil);
            this.panel1.Controls.Add(this.btDrawLine);
            this.panel1.Controls.Add(this.btDrawRectangle);
            this.panel1.Controls.Add(this.btDrawCircle);
            this.panel1.Controls.Add(this.btDrawSquare);
            this.panel1.Controls.Add(this.btDrawEllipse);
            this.panel1.Location = new System.Drawing.Point(5, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 99);
            this.panel1.TabIndex = 2;
            // 
            // btDrawLine
            // 
            this.btDrawLine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDrawLine.BackgroundImage = global::MyPaint.Properties.Resources._4c9o5Xyoi;
            this.btDrawLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDrawLine.Location = new System.Drawing.Point(64, 5);
            this.btDrawLine.Name = "btDrawLine";
            this.btDrawLine.Size = new System.Drawing.Size(51, 42);
            this.btDrawLine.TabIndex = 4;
            this.btDrawLine.UseVisualStyleBackColor = false;
            // 
            // btDrawRectangle
            // 
            this.btDrawRectangle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDrawRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDrawRectangle.BackgroundImage")));
            this.btDrawRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDrawRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btDrawRectangle.Image")));
            this.btDrawRectangle.Location = new System.Drawing.Point(7, 53);
            this.btDrawRectangle.Name = "btDrawRectangle";
            this.btDrawRectangle.Size = new System.Drawing.Size(51, 42);
            this.btDrawRectangle.TabIndex = 0;
            this.btDrawRectangle.UseVisualStyleBackColor = false;
            // 
            // btDrawCircle
            // 
            this.btDrawCircle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDrawCircle.BackgroundImage = global::MyPaint.Properties.Resources.square;
            this.btDrawCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDrawCircle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btDrawCircle.Location = new System.Drawing.Point(178, 54);
            this.btDrawCircle.Name = "btDrawCircle";
            this.btDrawCircle.Size = new System.Drawing.Size(51, 42);
            this.btDrawCircle.TabIndex = 3;
            this.btDrawCircle.UseVisualStyleBackColor = false;
            // 
            // btDrawSquare
            // 
            this.btDrawSquare.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDrawSquare.BackgroundImage = global::MyPaint.Properties.Resources._4c9o5Xyoi;
            this.btDrawSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDrawSquare.Location = new System.Drawing.Point(64, 53);
            this.btDrawSquare.Name = "btDrawSquare";
            this.btDrawSquare.Size = new System.Drawing.Size(51, 42);
            this.btDrawSquare.TabIndex = 1;
            this.btDrawSquare.UseVisualStyleBackColor = false;
            // 
            // btDrawEllipse
            // 
            this.btDrawEllipse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDrawEllipse.BackgroundImage = global::MyPaint.Properties.Resources.e81136ff89d964e1b8e8e4f7ff63d4cf_ellipse_by_vexels;
            this.btDrawEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDrawEllipse.Location = new System.Drawing.Point(121, 53);
            this.btDrawEllipse.Name = "btDrawEllipse";
            this.btDrawEllipse.Size = new System.Drawing.Size(51, 42);
            this.btDrawEllipse.TabIndex = 2;
            this.btDrawEllipse.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.vScrollBar1);
            this.panel2.Controls.Add(this.pbCanvas);
            this.panel2.Location = new System.Drawing.Point(3, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 335);
            this.panel2.TabIndex = 4;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(933, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 333);
            this.vScrollBar1.TabIndex = 4;
            // 
            // pbCanvas
            // 
            this.pbCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCanvas.Location = new System.Drawing.Point(3, 0);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(927, 330);
            this.pbCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCanvas.TabIndex = 3;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            this.pbCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCanvas_MouseDown);
            this.pbCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbCanvas_MouseMove);
            this.pbCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbCanvas_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btThickness1);
            this.panel3.Controls.Add(this.btThickness5);
            this.panel3.Controls.Add(this.btThickness7);
            this.panel3.Controls.Add(this.btThickness3);
            this.panel3.Location = new System.Drawing.Point(482, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 98);
            this.panel3.TabIndex = 4;
            // 
            // btThickness1
            // 
            this.btThickness1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThickness1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThickness1.BackgroundImage")));
            this.btThickness1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThickness1.Image = ((System.Drawing.Image)(resources.GetObject("btThickness1.Image")));
            this.btThickness1.Location = new System.Drawing.Point(3, 3);
            this.btThickness1.Name = "btThickness1";
            this.btThickness1.Size = new System.Drawing.Size(118, 21);
            this.btThickness1.TabIndex = 0;
            this.btThickness1.UseVisualStyleBackColor = false;
            // 
            // btThickness5
            // 
            this.btThickness5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThickness5.BackgroundImage = global::MyPaint.Properties.Resources.square;
            this.btThickness5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThickness5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btThickness5.Location = new System.Drawing.Point(3, 57);
            this.btThickness5.Name = "btThickness5";
            this.btThickness5.Size = new System.Drawing.Size(118, 17);
            this.btThickness5.TabIndex = 3;
            this.btThickness5.UseVisualStyleBackColor = false;
            // 
            // btThickness7
            // 
            this.btThickness7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThickness7.BackgroundImage = global::MyPaint.Properties.Resources._4c9o5Xyoi;
            this.btThickness7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThickness7.Location = new System.Drawing.Point(3, 79);
            this.btThickness7.Name = "btThickness7";
            this.btThickness7.Size = new System.Drawing.Size(118, 17);
            this.btThickness7.TabIndex = 1;
            this.btThickness7.UseVisualStyleBackColor = false;
            // 
            // btThickness3
            // 
            this.btThickness3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThickness3.BackgroundImage = global::MyPaint.Properties.Resources.e81136ff89d964e1b8e8e4f7ff63d4cf_ellipse_by_vexels;
            this.btThickness3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThickness3.Location = new System.Drawing.Point(3, 30);
            this.btThickness3.Name = "btThickness3";
            this.btThickness3.Size = new System.Drawing.Size(118, 21);
            this.btThickness3.TabIndex = 2;
            this.btThickness3.UseVisualStyleBackColor = false;
            // 
            // colorPickEdit1
            // 
            this.colorPickEdit1.EditValue = System.Drawing.Color.Empty;
            this.colorPickEdit1.Location = new System.Drawing.Point(257, 35);
            this.colorPickEdit1.Name = "colorPickEdit1";
            this.colorPickEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorPickEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.colorPickEdit1.Size = new System.Drawing.Size(150, 20);
            this.colorPickEdit1.TabIndex = 5;
            // 
            // btDrawPencil
            // 
            this.btDrawPencil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDrawPencil.BackgroundImage = global::MyPaint.Properties.Resources._4c9o5Xyoi;
            this.btDrawPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDrawPencil.Location = new System.Drawing.Point(7, 5);
            this.btDrawPencil.Name = "btDrawPencil";
            this.btDrawPencil.Size = new System.Drawing.Size(51, 42);
            this.btDrawPencil.TabIndex = 5;
            this.btDrawPencil.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(955, 491);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.colorPickEdit1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDrawRectangle;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Button btDrawSquare;
        private System.Windows.Forms.Button btDrawEllipse;
        private System.Windows.Forms.Button btDrawCircle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btThickness1;
        private System.Windows.Forms.Button btThickness5;
        private System.Windows.Forms.Button btThickness7;
        private System.Windows.Forms.Button btThickness3;
        private System.Windows.Forms.Button btDrawLine;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DevExpress.XtraEditors.ColorPickEdit colorPickEdit1;
        private System.Windows.Forms.Button btDrawPencil;
    }
}

