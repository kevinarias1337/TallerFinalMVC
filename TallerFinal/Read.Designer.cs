namespace TallerFinal
{
    partial class Read
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Read));
            this.dbinventario1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.atraspng = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atraspng)).BeginInit();
            this.SuspendLayout();
            // 
            // dbinventario1
            // 
            this.dbinventario1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dbinventario1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbinventario1.Location = new System.Drawing.Point(34, 271);
            this.dbinventario1.Name = "dbinventario1";
            this.dbinventario1.ReadOnly = true;
            this.dbinventario1.Size = new System.Drawing.Size(222, 167);
            this.dbinventario1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar inventario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TallerFinal.Properties.Resources.kisspng_inventory_management_software_inventory_control_ca_inventory_management_5b3f7886a8ad85_8414975115308862786909;
            this.pictureBox1.Location = new System.Drawing.Point(34, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // atraspng
            // 
            this.atraspng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.atraspng.Image = global::TallerFinal.Properties.Resources.kisspng_computer_icons_arrow_left_arrow_5ac5e89fdffdc1_8459894415229195839175;
            this.atraspng.Location = new System.Drawing.Point(6, 3);
            this.atraspng.Name = "atraspng";
            this.atraspng.Size = new System.Drawing.Size(37, 37);
            this.atraspng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atraspng.TabIndex = 3;
            this.atraspng.TabStop = false;
            this.atraspng.Click += new System.EventHandler(this.Atraspng_Click);
            // 
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.Controls.Add(this.atraspng);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dbinventario1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Read";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dbinventario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atraspng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dbinventario1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox atraspng;
    }
}