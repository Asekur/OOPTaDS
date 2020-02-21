using System.Drawing;
namespace Фигня_какая_то
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
            this.ChangeButton = new System.Windows.Forms.Button();
            this.HolstPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.LightCyan;
            this.ChangeButton.Font = new System.Drawing.Font("Georgia", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChangeButton.Location = new System.Drawing.Point(390, 519);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(164, 34);
            this.ChangeButton.TabIndex = 1;
            this.ChangeButton.Text = "Change figure";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // HolstPanel
            // 
            this.HolstPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.HolstPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HolstPanel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HolstPanel.Location = new System.Drawing.Point(55, 10);
            this.HolstPanel.Name = "HolstPanel";
            this.HolstPanel.Size = new System.Drawing.Size(822, 502);
            this.HolstPanel.TabIndex = 2;
            this.HolstPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HolstPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(936, 560);
            this.Controls.Add(this.HolstPanel);
            this.Controls.Add(this.ChangeButton);
            this.Name = "Form1";
            this.Text = "Графический редактор";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Panel HolstPanel;
    }
}

