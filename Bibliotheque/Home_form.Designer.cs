namespace Bibliotheque
{
    partial class BIBLIOTHEQUE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BIBLIOTHEQUE));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.testbox_aide = new System.Windows.Forms.TextBox();
            this.button_aide = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_affiche = new System.Windows.Forms.Button();
            this.button_ajout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(794, 342);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -2;
            this.lineShape1.X2 = 652;
            this.lineShape1.Y1 = 329;
            this.lineShape1.Y2 = 330;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.rectangleShape3.Location = new System.Drawing.Point(655, 143);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(128, 130);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.rectangleShape2.Location = new System.Drawing.Point(655, 13);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(129, 125);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.SystemColors.Info;
            this.rectangleShape1.Location = new System.Drawing.Point(652, 10);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(135, 320);
            // 
            // testbox_aide
            // 
            this.testbox_aide.BackColor = System.Drawing.SystemColors.Control;
            this.testbox_aide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testbox_aide.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testbox_aide.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.testbox_aide.Location = new System.Drawing.Point(659, 154);
            this.testbox_aide.Name = "testbox_aide";
            this.testbox_aide.Size = new System.Drawing.Size(121, 20);
            this.testbox_aide.TabIndex = 6;
            this.testbox_aide.Text = "Besoin d\'aide ?";
            this.testbox_aide.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_aide
            // 
            this.button_aide.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_aide.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_aide.FlatAppearance.BorderSize = 0;
            this.button_aide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button_aide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button_aide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_aide.Location = new System.Drawing.Point(707, 181);
            this.button_aide.Name = "button_aide";
            this.button_aide.Size = new System.Drawing.Size(42, 38);
            this.button_aide.TabIndex = 7;
            this.button_aide.Text = "?";
            this.button_aide.UseVisualStyleBackColor = false;
            this.button_aide.Click += new System.EventHandler(this.button_aide_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_supprimer.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.button_supprimer.FlatAppearance.BorderSize = 2;
            this.button_supprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_supprimer.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supprimer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_supprimer.Image = global::Bibliotheque.Properties.Resources.delete5;
            this.button_supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_supprimer.Location = new System.Drawing.Point(344, 180);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(295, 150);
            this.button_supprimer.TabIndex = 4;
            this.button_supprimer.Text = "ELIMINER LIVRE";
            this.button_supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_supprimer.UseVisualStyleBackColor = false;
            // 
            // button_modifier
            // 
            this.button_modifier.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_modifier.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.button_modifier.FlatAppearance.BorderSize = 2;
            this.button_modifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_modifier.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modifier.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_modifier.Image = global::Bibliotheque.Properties.Resources.images__6_3;
            this.button_modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modifier.Location = new System.Drawing.Point(12, 180);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(295, 150);
            this.button_modifier.TabIndex = 3;
            this.button_modifier.Text = "RECHERCHER LIVRE";
            this.button_modifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_modifier.UseVisualStyleBackColor = false;
            // 
            // button_affiche
            // 
            this.button_affiche.BackColor = System.Drawing.Color.White;
            this.button_affiche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_affiche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_affiche.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.button_affiche.FlatAppearance.BorderSize = 2;
            this.button_affiche.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_affiche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_affiche.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_affiche.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_affiche.Image = global::Bibliotheque.Properties.Resources.lister2;
            this.button_affiche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_affiche.Location = new System.Drawing.Point(344, 13);
            this.button_affiche.Name = "button_affiche";
            this.button_affiche.Size = new System.Drawing.Size(295, 150);
            this.button_affiche.TabIndex = 2;
            this.button_affiche.Text = "LISTER LIVRE";
            this.button_affiche.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_affiche.UseVisualStyleBackColor = false;
            this.button_affiche.Click += new System.EventHandler(this.lister_livre);
            this.button_affiche.MouseEnter += new System.EventHandler(this.button_affiche_MouseEnter);
            this.button_affiche.MouseLeave += new System.EventHandler(this.button_affiche_MouseLeave);
            // 
            // button_ajout
            // 
            this.button_ajout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_ajout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_ajout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ajout.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.button_ajout.FlatAppearance.BorderSize = 2;
            this.button_ajout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_ajout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_ajout.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajout.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_ajout.Image = global::Bibliotheque.Properties.Resources.add;
            this.button_ajout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ajout.Location = new System.Drawing.Point(12, 13);
            this.button_ajout.Name = "button_ajout";
            this.button_ajout.Size = new System.Drawing.Size(295, 150);
            this.button_ajout.TabIndex = 1;
            this.button_ajout.Text = "AJOUTER LIVRE";
            this.button_ajout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ajout.UseVisualStyleBackColor = false;
            this.button_ajout.Click += new System.EventHandler(this.ajout_livre);
            // 
            // BIBLIOTHEQUE
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(794, 342);
            this.Controls.Add(this.button_aide);
            this.Controls.Add(this.testbox_aide);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_affiche);
            this.Controls.Add(this.button_ajout);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximumSize = new System.Drawing.Size(804, 374);
            this.MinimumSize = new System.Drawing.Size(200, 150);
            this.Name = "BIBLIOTHEQUE";
            this.Text = "BIBLIOTHEQUE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ajout;
        private System.Windows.Forms.Button button_affiche;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_supprimer;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox testbox_aide;
        private System.Windows.Forms.Button button_aide;


    }
}

