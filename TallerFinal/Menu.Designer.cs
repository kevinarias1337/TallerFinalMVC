namespace TallerFinal
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuread = new System.Windows.Forms.Button();
            this.menureadcreate = new System.Windows.Forms.Button();
            this.menureadcreatedelete = new System.Windows.Forms.Button();
            this.menucrud = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuread
            // 
            this.menuread.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menuread.Location = new System.Drawing.Point(91, 130);
            this.menuread.Name = "menuread";
            this.menuread.Size = new System.Drawing.Size(110, 26);
            this.menuread.TabIndex = 0;
            this.menuread.Text = "Read";
            this.menuread.UseVisualStyleBackColor = true;
            this.menuread.Click += new System.EventHandler(this.Menuread_Click);
            // 
            // menureadcreate
            // 
            this.menureadcreate.ForeColor = System.Drawing.Color.Navy;
            this.menureadcreate.Location = new System.Drawing.Point(91, 169);
            this.menureadcreate.Name = "menureadcreate";
            this.menureadcreate.Size = new System.Drawing.Size(110, 26);
            this.menureadcreate.TabIndex = 1;
            this.menureadcreate.Text = "Read/Create";
            this.menureadcreate.UseVisualStyleBackColor = true;
            this.menureadcreate.Click += new System.EventHandler(this.Menureadcreate_Click);
            // 
            // menureadcreatedelete
            // 
            this.menureadcreatedelete.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menureadcreatedelete.Location = new System.Drawing.Point(86, 208);
            this.menureadcreatedelete.Name = "menureadcreatedelete";
            this.menureadcreatedelete.Size = new System.Drawing.Size(121, 26);
            this.menureadcreatedelete.TabIndex = 2;
            this.menureadcreatedelete.Text = "Read/Create/Delete";
            this.menureadcreatedelete.UseVisualStyleBackColor = true;
            this.menureadcreatedelete.Click += new System.EventHandler(this.Menureadcreatedelete_Click);
            // 
            // menucrud
            // 
            this.menucrud.ForeColor = System.Drawing.Color.Black;
            this.menucrud.Location = new System.Drawing.Point(71, 247);
            this.menucrud.Name = "menucrud";
            this.menucrud.Size = new System.Drawing.Size(157, 26);
            this.menucrud.TabIndex = 3;
            this.menucrud.Text = "Read/Create/Delete/Update";
            this.menucrud.UseVisualStyleBackColor = true;
            this.menucrud.Click += new System.EventHandler(this.Menucrud_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.salir.ForeColor = System.Drawing.Color.Red;
            this.salir.Location = new System.Drawing.Point(170, 393);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(110, 26);
            this.salir.TabIndex = 4;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TallerFinal.Properties.Resources.kisspng_ergonomics_in_the_warehouse_warehouse_management_s_5b0a65b6ec0273_3397523715274080549667;
            this.pictureBox2.Location = new System.Drawing.Point(12, 295);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TallerFinal.Properties.Resources.kisspng_clip_art_inventory_management_software_inventory_c_apakah_manajemen_inventory_itu_penting_article_5c0bfccfb7f956_3592651915442894877536;
            this.pictureBox1.Location = new System.Drawing.Point(52, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.menucrud);
            this.Controls.Add(this.menureadcreatedelete);
            this.Controls.Add(this.menureadcreate);
            this.Controls.Add(this.menuread);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menú";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuread;
        private System.Windows.Forms.Button menureadcreate;
        private System.Windows.Forms.Button menureadcreatedelete;
        private System.Windows.Forms.Button menucrud;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}