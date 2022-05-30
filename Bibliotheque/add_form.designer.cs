namespace Ajouter
{
    partial class add_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_form));
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_accueil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4});
            this.shapeContainer2.Size = new System.Drawing.Size(512, 338);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 156;
            this.lineShape4.X2 = 156;
            this.lineShape4.Y1 = 35;
            this.lineShape4.Y2 = 301;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 157;
            this.lineShape5.X2 = 465;
            this.lineShape5.Y1 = 302;
            this.lineShape5.Y2 = 302;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bibliotheque.Properties.Resources.add;
            this.pictureBox2.Location = new System.Drawing.Point(12, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 144);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button_accueil
            // 
            this.button_accueil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_accueil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_accueil.Image = global::Bibliotheque.Properties.Resources.b11;
            this.button_accueil.Location = new System.Drawing.Point(12, 264);
            this.button_accueil.Name = "button_accueil";
            this.button_accueil.Size = new System.Drawing.Size(42, 39);
            this.button_accueil.TabIndex = 2;
            this.button_accueil.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(8, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Accueil";
            // 
            // add_form
            // 
            this.ClientSize = new System.Drawing.Size(512, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_accueil);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.shapeContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_form";
            this.Load += new System.EventHandler(this.add_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_author;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label_editor;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.TextBox textBo_categorie;
        private System.Windows.Forms.TextBox textBox_editor;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.Button button_validation;
        private System.Windows.Forms.Label label_validation;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Label label_ajout;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_accueil;
        private System.Windows.Forms.Label label2;
    }
}

