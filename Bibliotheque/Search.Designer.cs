namespace Bibliotheque
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label_accueil = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.button_accueil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_search = new System.Windows.Forms.Label();
            this.textbox_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label_auteur = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_collrction = new System.Windows.Forms.Label();
            this.textBox_collection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_year = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label_titlesearch = new System.Windows.Forms.Label();
            this.label_auteursearch = new System.Windows.Forms.Label();
            this.textBox_titlesearch = new System.Windows.Forms.TextBox();
            this.textBox_auteursearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.rectangleShape1,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(803, 306);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 124;
            this.lineShape1.X2 = 124;
            this.lineShape1.Y1 = 20;
            this.lineShape1.Y2 = 276;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 130;
            this.lineShape2.X2 = 782;
            this.lineShape2.Y1 = 289;
            this.lineShape2.Y2 = 289;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rectangleShape1.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(4, 0);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(116, 303);
            // 
            // label_accueil
            // 
            this.label_accueil.AutoSize = true;
            this.label_accueil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_accueil.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_accueil.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_accueil.Location = new System.Drawing.Point(4, 284);
            this.label_accueil.Name = "label_accueil";
            this.label_accueil.Size = new System.Drawing.Size(56, 19);
            this.label_accueil.TabIndex = 3;
            this.label_accueil.Text = "Accueil";
            // 
            // button_search
            // 
            this.button_search.FlatAppearance.BorderSize = 2;
            this.button_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_search.Image = global::Bibliotheque.Properties.Resources.s1;
            this.button_search.Location = new System.Drawing.Point(69, 240);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(39, 41);
            this.button_search.TabIndex = 4;
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_accueil
            // 
            this.button_accueil.FlatAppearance.BorderSize = 2;
            this.button_accueil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_accueil.Image = global::Bibliotheque.Properties.Resources.b1;
            this.button_accueil.Location = new System.Drawing.Point(8, 240);
            this.button_accueil.Name = "button_accueil";
            this.button_accueil.Size = new System.Drawing.Size(39, 41);
            this.button_accueil.TabIndex = 2;
            this.button_accueil.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bibliotheque.Properties.Resources.images__6_5;
            this.pictureBox1.Location = new System.Drawing.Point(8, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_search.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_search.Location = new System.Drawing.Point(66, 284);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(49, 19);
            this.label_search.TabIndex = 5;
            this.label_search.Text = "Search";
            // 
            // textbox_title
            // 
            this.textbox_title.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_title.Location = new System.Drawing.Point(613, 58);
            this.textbox_title.Name = "textbox_title";
            this.textbox_title.Size = new System.Drawing.Size(169, 26);
            this.textbox_title.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(471, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Titre du livre";
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 458;
            this.lineShape3.X2 = 458;
            this.lineShape3.Y1 = 41;
            this.lineShape3.Y2 = 286;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 156;
            this.lineShape4.X2 = 781;
            this.lineShape4.Y1 = 33;
            this.lineShape4.Y2 = 33;
            // 
            // label_auteur
            // 
            this.label_auteur.AutoSize = true;
            this.label_auteur.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_auteur.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_auteur.Location = new System.Drawing.Point(475, 106);
            this.label_auteur.Name = "label_auteur";
            this.label_auteur.Size = new System.Drawing.Size(54, 19);
            this.label_auteur.TabIndex = 8;
            this.label_auteur.Text = "Auteur";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(613, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 26);
            this.textBox1.TabIndex = 9;
            // 
            // label_collrction
            // 
            this.label_collrction.AutoSize = true;
            this.label_collrction.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_collrction.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_collrction.Location = new System.Drawing.Point(475, 153);
            this.label_collrction.Name = "label_collrction";
            this.label_collrction.Size = new System.Drawing.Size(72, 19);
            this.label_collrction.TabIndex = 10;
            this.label_collrction.Text = "Collection";
            // 
            // textBox_collection
            // 
            this.textBox_collection.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_collection.Location = new System.Drawing.Point(613, 151);
            this.textBox_collection.Name = "textBox_collection";
            this.textBox_collection.Size = new System.Drawing.Size(169, 26);
            this.textBox_collection.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(479, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Edition";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(613, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 26);
            this.textBox2.TabIndex = 13;
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_year.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_year.Location = new System.Drawing.Point(475, 250);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(107, 19);
            this.label_year.TabIndex = 14;
            this.label_year.Text = "Année d\'édition";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(613, 248);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 26);
            this.textBox3.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(386, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Recherche d\'un livre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 158;
            this.lineShape5.X2 = 444;
            this.lineShape5.Y1 = 117;
            this.lineShape5.Y2 = 117;
            // 
            // label_titlesearch
            // 
            this.label_titlesearch.AutoSize = true;
            this.label_titlesearch.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titlesearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_titlesearch.Location = new System.Drawing.Point(154, 41);
            this.label_titlesearch.Name = "label_titlesearch";
            this.label_titlesearch.Size = new System.Drawing.Size(86, 19);
            this.label_titlesearch.TabIndex = 17;
            this.label_titlesearch.Text = "Titre du livre";
            // 
            // label_auteursearch
            // 
            this.label_auteursearch.AutoSize = true;
            this.label_auteursearch.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_auteursearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_auteursearch.Location = new System.Drawing.Point(155, 92);
            this.label_auteursearch.Name = "label_auteursearch";
            this.label_auteursearch.Size = new System.Drawing.Size(54, 19);
            this.label_auteursearch.TabIndex = 18;
            this.label_auteursearch.Text = "Auteur";
            // 
            // textBox_titlesearch
            // 
            this.textBox_titlesearch.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_titlesearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_titlesearch.Location = new System.Drawing.Point(283, 39);
            this.textBox_titlesearch.Name = "textBox_titlesearch";
            this.textBox_titlesearch.Size = new System.Drawing.Size(162, 26);
            this.textBox_titlesearch.TabIndex = 19;
            this.textBox_titlesearch.TextChanged += new System.EventHandler(this.textBox_titlesearch_TextChanged);
            // 
            // textBox_auteursearch
            // 
            this.textBox_auteursearch.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_auteursearch.Location = new System.Drawing.Point(283, 90);
            this.textBox_auteursearch.Name = "textBox_auteursearch";
            this.textBox_auteursearch.Size = new System.Drawing.Size(162, 26);
            this.textBox_auteursearch.TabIndex = 20;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 306);
            this.Controls.Add(this.textBox_auteursearch);
            this.Controls.Add(this.textBox_titlesearch);
            this.Controls.Add(this.label_auteursearch);
            this.Controls.Add(this.label_titlesearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_collection);
            this.Controls.Add(this.label_collrction);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_auteur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_title);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label_accueil);
            this.Controls.Add(this.button_accueil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.Text = "search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button button_accueil;
        private System.Windows.Forms.Label label_accueil;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textbox_title;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Label label_auteur;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_collrction;
        private System.Windows.Forms.TextBox textBox_collection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Label label_titlesearch;
        private System.Windows.Forms.Label label_auteursearch;
        private System.Windows.Forms.TextBox textBox_titlesearch;
        private System.Windows.Forms.TextBox textBox_auteursearch;
    }
}