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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.label_editor = new System.Windows.Forms.Label();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.textBo_categorie = new System.Windows.Forms.TextBox();
            this.textBox_editor = new System.Windows.Forms.TextBox();
            this.label_home = new System.Windows.Forms.Label();
            this.button_validation = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_validation = new System.Windows.Forms.Label();
            this.label_ajout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.rectangleShape1,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(531, 379);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 164;
            this.lineShape3.X2 = 495;
            this.lineShape3.Y1 = 4;
            this.lineShape3.Y2 = 4;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rectangleShape1.Location = new System.Drawing.Point(2, 3);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(161, 368);
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 166;
            this.lineShape2.X2 = 486;
            this.lineShape2.Y1 = 326;
            this.lineShape2.Y2 = 326;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lineShape1.X1 = 169;
            this.lineShape1.X2 = 169;
            this.lineShape1.Y1 = 67;
            this.lineShape1.Y2 = 324;
            // 
            // textBox_title
            // 
            this.textBox_title.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_title.Location = new System.Drawing.Point(303, 72);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(148, 26);
            this.textBox_title.TabIndex = 2;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_title.Location = new System.Drawing.Point(177, 72);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(86, 19);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "Titre du livre";
            this.label_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_author.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_author.Location = new System.Drawing.Point(177, 129);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(54, 19);
            this.label_author.TabIndex = 4;
            this.label_author.Text = "Auteur";
            this.label_author.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_year.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_year.Location = new System.Drawing.Point(177, 178);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(107, 19);
            this.label_year.TabIndex = 5;
            this.label_year.Text = "Année d\'édition";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(177, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Collection";
            // 
            // textBox_author
            // 
            this.textBox_author.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_author.Location = new System.Drawing.Point(303, 126);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(148, 26);
            this.textBox_author.TabIndex = 7;
            // 
            // label_editor
            // 
            this.label_editor.AutoSize = true;
            this.label_editor.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_editor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_editor.Location = new System.Drawing.Point(177, 279);
            this.label_editor.Name = "label_editor";
            this.label_editor.Size = new System.Drawing.Size(54, 19);
            this.label_editor.TabIndex = 8;
            this.label_editor.Text = "Editeur";
            // 
            // textBox_year
            // 
            this.textBox_year.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_year.Location = new System.Drawing.Point(303, 178);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(148, 26);
            this.textBox_year.TabIndex = 9;
            // 
            // textBo_categorie
            // 
            this.textBo_categorie.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBo_categorie.Location = new System.Drawing.Point(303, 230);
            this.textBo_categorie.Name = "textBo_categorie";
            this.textBo_categorie.Size = new System.Drawing.Size(148, 26);
            this.textBo_categorie.TabIndex = 10;
            // 
            // textBox_editor
            // 
            this.textBox_editor.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_editor.Location = new System.Drawing.Point(303, 277);
            this.textBox_editor.Name = "textBox_editor";
            this.textBox_editor.Size = new System.Drawing.Size(148, 26);
            this.textBox_editor.TabIndex = 11;
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_home.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home.ForeColor = System.Drawing.Color.DarkRed;
            this.label_home.Location = new System.Drawing.Point(8, 346);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(56, 19);
            this.label_home.TabIndex = 13;
            this.label_home.Text = "Accueil";
            // 
            // button_validation
            // 
            this.button_validation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.button_validation.Image = global::Ajouter.Properties.Resources.b22;
            this.button_validation.Location = new System.Drawing.Point(102, 303);
            this.button_validation.Name = "button_validation";
            this.button_validation.Size = new System.Drawing.Size(42, 40);
            this.button_validation.TabIndex = 14;
            this.button_validation.UseVisualStyleBackColor = true;
            // 
            // button_home
            // 
            this.button_home.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_home.Image = global::Ajouter.Properties.Resources.b1;
            this.button_home.Location = new System.Drawing.Point(12, 303);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(42, 40);
            this.button_home.TabIndex = 12;
            this.button_home.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ajouter.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(3, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 140);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_validation
            // 
            this.label_validation.AutoSize = true;
            this.label_validation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_validation.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_validation.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_validation.Location = new System.Drawing.Point(98, 346);
            this.label_validation.Name = "label_validation";
            this.label_validation.Size = new System.Drawing.Size(55, 19);
            this.label_validation.TabIndex = 15;
            this.label_validation.Text = "Valider";
            // 
            // label_ajout
            // 
            this.label_ajout.AutoSize = true;
            this.label_ajout.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ajout.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_ajout.Location = new System.Drawing.Point(261, 23);
            this.label_ajout.Name = "label_ajout";
            this.label_ajout.Size = new System.Drawing.Size(140, 28);
            this.label_ajout.TabIndex = 16;
            this.label_ajout.Text = "AJOUT D\'UN LIVRE";
            this.label_ajout.Click += new System.EventHandler(this.label2_Click);
            // 
            // add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(531, 379);
            this.Controls.Add(this.label_ajout);
            this.Controls.Add(this.label_validation);
            this.Controls.Add(this.button_validation);
            this.Controls.Add(this.label_home);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.textBox_editor);
            this.Controls.Add(this.textBo_categorie);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.label_editor);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Poor Richard", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_form";
            this.Text = "Ajouter Livre";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

