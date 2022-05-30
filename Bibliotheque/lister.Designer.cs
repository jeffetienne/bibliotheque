namespace Bibliotheque
{
    partial class lister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lister));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label_home = new System.Windows.Forms.Label();
            this.label_lister = new System.Windows.Forms.Label();
            this.label_literlivre = new System.Windows.Forms.Label();
            this.button_lister = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.lineShape4,
            this.rectangleShape1,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(866, 435);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rectangleShape2.Location = new System.Drawing.Point(5, 3);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(166, 397);
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 6;
            this.lineShape4.X2 = 870;
            this.lineShape4.Y1 = 404;
            this.lineShape4.Y2 = 405;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.rectangleShape1.Location = new System.Drawing.Point(582, 45);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(279, 354);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.lineShape3.BorderWidth = 3;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 184;
            this.lineShape3.X2 = 866;
            this.lineShape3.Y1 = 37;
            this.lineShape3.Y2 = 37;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 577;
            this.lineShape2.X2 = 577;
            this.lineShape2.Y1 = 40;
            this.lineShape2.Y2 = 398;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 178;
            this.lineShape1.X2 = 178;
            this.lineShape1.Y1 = 4;
            this.lineShape1.Y2 = 405;
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_home.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home.ForeColor = System.Drawing.Color.Maroon;
            this.label_home.Location = new System.Drawing.Point(19, 365);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(56, 19);
            this.label_home.TabIndex = 3;
            this.label_home.Text = "Accueil";
            // 
            // label_lister
            // 
            this.label_lister.AutoSize = true;
            this.label_lister.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_lister.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lister.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_lister.Location = new System.Drawing.Point(107, 365);
            this.label_lister.Name = "label_lister";
            this.label_lister.Size = new System.Drawing.Size(43, 19);
            this.label_lister.TabIndex = 5;
            this.label_lister.Text = "Lister";
            // 
            // label_literlivre
            // 
            this.label_literlivre.AutoSize = true;
            this.label_literlivre.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_literlivre.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_literlivre.Location = new System.Drawing.Point(424, 5);
            this.label_literlivre.Name = "label_literlivre";
            this.label_literlivre.Size = new System.Drawing.Size(101, 28);
            this.label_literlivre.TabIndex = 6;
            this.label_literlivre.Text = "LISTER LIVRE";
            // 
            // button_lister
            // 
            this.button_lister.Image = global::Bibliotheque.Properties.Resources.b2;
            this.button_lister.Location = new System.Drawing.Point(109, 317);
            this.button_lister.Name = "button_lister";
            this.button_lister.Size = new System.Drawing.Size(41, 45);
            this.button_lister.TabIndex = 4;
            this.button_lister.UseVisualStyleBackColor = true;
            // 
            // button_home
            // 
            this.button_home.FlatAppearance.BorderSize = 2;
            this.button_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_home.Image = global::Bibliotheque.Properties.Resources.b1;
            this.button_home.Location = new System.Drawing.Point(23, 317);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(41, 45);
            this.button_home.TabIndex = 2;
            this.button_home.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bibliotheque.Properties.Resources.lister2;
            this.pictureBox1.InitialImage = global::Bibliotheque.Properties.Resources.lister2;
            this.pictureBox1.Location = new System.Drawing.Point(5, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 143);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 435);
            this.Controls.Add(this.label_literlivre);
            this.Controls.Add(this.label_lister);
            this.Controls.Add(this.button_lister);
            this.Controls.Add(this.label_home);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lister";
            this.Text = "lister";
            this.Load += new System.EventHandler(this.lister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.Button button_lister;
        private System.Windows.Forms.Label label_lister;
        private System.Windows.Forms.Label label_literlivre;
    }
}