namespace CarRentalSystem
{
    partial class Splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Mycar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            Myprogress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            Percentage = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Mycar).BeginInit();
            Myprogress.SuspendLayout();
            SuspendLayout();
            // 
            // Mycar
            // 
            Mycar.FillColor = Color.FromArgb(30, 58, 138);
            Mycar.Image = (Image)resources.GetObject("Mycar.Image");
            Mycar.ImageRotate = 0F;
            Mycar.Location = new Point(35, 51);
            Mycar.Name = "Mycar";
            Mycar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            Mycar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Mycar.Size = new Size(146, 112);
            Mycar.SizeMode = PictureBoxSizeMode.Zoom;
            Mycar.TabIndex = 0;
            Mycar.TabStop = false;
            // 
            // Myprogress
            // 
            Myprogress.Controls.Add(Percentage);
            Myprogress.Controls.Add(Mycar);
            Myprogress.FillColor = Color.FromArgb(30, 58, 138);
            Myprogress.FillThickness = 8;
            Myprogress.Font = new Font("Segoe UI", 12F);
            Myprogress.ForeColor = Color.White;
            Myprogress.Location = new Point(351, 111);
            Myprogress.Minimum = 0;
            Myprogress.Name = "Myprogress";
            Myprogress.ProgressColor = Color.White;
            Myprogress.ProgressColor2 = Color.White;
            Myprogress.ProgressThickness = 8;
            Myprogress.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Myprogress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Myprogress.Size = new Size(215, 215);
            Myprogress.TabIndex = 1;
            Myprogress.Text = "guna2CircleProgressBar1";
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Percentage.ForeColor = Color.FromArgb(229, 231, 235);
            Percentage.Location = new Point(95, 166);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(25, 24);
            Percentage.TabIndex = 4;
            Percentage.Text = "%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(229, 231, 235);
            label1.Location = new Point(258, 23);
            label1.Name = "label1";
            label1.Size = new Size(402, 54);
            label1.TabIndex = 2;
            label1.Text = "CAR RENTAL SYSTEM";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(229, 231, 235);
            label2.Location = new Point(377, 353);
            label2.Name = "label2";
            label2.Size = new Size(170, 24);
            label2.TabIndex = 3;
            label2.Text = "Rent. Ride. Repeat.";
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 58, 138);
            ClientSize = new Size(909, 418);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Myprogress);
            Name = "Splash";
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)Mycar).EndInit();
            Myprogress.ResumeLayout(false);
            Myprogress.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox Mycar;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Myprogress;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label Percentage;
    }
}
