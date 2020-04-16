using System.Drawing;
namespace DrawFigureOne
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HolstPanel = new System.Windows.Forms.PictureBox();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonSegment = new System.Windows.Forms.Button();
            this.buttonPolygon = new System.Windows.Forms.Button();
            this.changePenColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HolstPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // HolstPanel
            // 
            this.HolstPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HolstPanel.Location = new System.Drawing.Point(55, 64);
            this.HolstPanel.Name = "HolstPanel";
            this.HolstPanel.Size = new System.Drawing.Size(822, 496);
            this.HolstPanel.TabIndex = 8;
            this.HolstPanel.TabStop = false;
            this.HolstPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HolstPanel_Paint);
            this.HolstPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HolstPanel_MouseDown);
            this.HolstPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HolstPanel_MouseMove);
            this.HolstPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HolstPanel_MouseUp);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("buttonEllipse.Image")));
            this.buttonEllipse.Location = new System.Drawing.Point(771, 8);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(50, 50);
            this.buttonEllipse.TabIndex = 9;
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonEllipse_MouseUp);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonRectangle.Image")));
            this.buttonRectangle.Location = new System.Drawing.Point(715, 8);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(50, 50);
            this.buttonRectangle.TabIndex = 10;
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonRectangle_MouseUp);
            // 
            // buttonSegment
            // 
            this.buttonSegment.Image = ((System.Drawing.Image)(resources.GetObject("buttonSegment.Image")));
            this.buttonSegment.Location = new System.Drawing.Point(659, 8);
            this.buttonSegment.Name = "buttonSegment";
            this.buttonSegment.Size = new System.Drawing.Size(50, 50);
            this.buttonSegment.TabIndex = 11;
            this.buttonSegment.UseVisualStyleBackColor = true;
            this.buttonSegment.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonSegment_MouseUp);
            // 
            // buttonPolygon
            // 
            this.buttonPolygon.Image = ((System.Drawing.Image)(resources.GetObject("buttonPolygon.Image")));
            this.buttonPolygon.Location = new System.Drawing.Point(827, 8);
            this.buttonPolygon.Name = "buttonPolygon";
            this.buttonPolygon.Size = new System.Drawing.Size(50, 50);
            this.buttonPolygon.TabIndex = 12;
            this.buttonPolygon.UseVisualStyleBackColor = true;
            this.buttonPolygon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonPolygon_MouseUp);
            // 
            // changePenColor
            // 
            this.changePenColor.Image = ((System.Drawing.Image)(resources.GetObject("changePenColor.Image")));
            this.changePenColor.Location = new System.Drawing.Point(167, 8);
            this.changePenColor.Name = "changePenColor";
            this.changePenColor.Size = new System.Drawing.Size(50, 50);
            this.changePenColor.TabIndex = 13;
            this.changePenColor.UseVisualStyleBackColor = true;
            this.changePenColor.Click += new System.EventHandler(this.ChangePenColor_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
            this.buttonOpen.Location = new System.Drawing.Point(55, 8);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(50, 50);
            this.buttonOpen.TabIndex = 14;
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(111, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(50, 50);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(936, 596);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.changePenColor);
            this.Controls.Add(this.buttonPolygon);
            this.Controls.Add(this.buttonSegment);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonEllipse);
            this.Controls.Add(this.HolstPanel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Графический редактор";
            ((System.ComponentModel.ISupportInitialize)(this.HolstPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox HolstPanel;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonSegment;
        private System.Windows.Forms.Button buttonPolygon;
        private System.Windows.Forms.Button changePenColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
    }
}

