namespace TallerFinal
{
    partial class ReadCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadCreate));
            this.btnmostrar = new System.Windows.Forms.Button();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtdepartamento = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dbinventario1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.atraspng = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atraspng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(205, 223);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 37);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "Mostrar inventario";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.Btnmostrar_Click);
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreproducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnombreproducto.Location = new System.Drawing.Point(89, 224);
            this.txtnombreproducto.MaxLength = 50;
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(110, 18);
            this.txtnombreproducto.TabIndex = 2;
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtprecio.Location = new System.Drawing.Point(89, 245);
            this.txtprecio.MaxLength = 50;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(110, 18);
            this.txtprecio.TabIndex = 3;
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepartamento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdepartamento.Location = new System.Drawing.Point(89, 266);
            this.txtdepartamento.MaxLength = 50;
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(110, 18);
            this.txtdepartamento.TabIndex = 4;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(205, 266);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // dbinventario1
            // 
            this.dbinventario1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dbinventario1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbinventario1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dbinventario1.Location = new System.Drawing.Point(23, 297);
            this.dbinventario1.Name = "dbinventario1";
            this.dbinventario1.ReadOnly = true;
            this.dbinventario1.Size = new System.Drawing.Size(240, 150);
            this.dbinventario1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Departamento:";
            // 
            // atraspng
            // 
            this.atraspng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.atraspng.Image = global::TallerFinal.Properties.Resources.kisspng_computer_icons_arrow_left_arrow_5ac5e89fdffdc1_8459894415229195839175;
            this.atraspng.Location = new System.Drawing.Point(7, 6);
            this.atraspng.Name = "atraspng";
            this.atraspng.Size = new System.Drawing.Size(47, 40);
            this.atraspng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atraspng.TabIndex = 7;
            this.atraspng.TabStop = false;
            this.atraspng.Click += new System.EventHandler(this.Atraspng_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TallerFinal.Properties.Resources.kisspng_inventory_management_software_inventory_turnover_g_inventory_management_5b38fde2592084_5869066315304616663651;
            this.pictureBox1.Location = new System.Drawing.Point(60, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ReadCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.atraspng);
            this.Controls.Add(this.dbinventario1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtdepartamento);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtnombreproducto);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReadCreate";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dbinventario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atraspng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtdepartamento;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dbinventario1;
        private System.Windows.Forms.PictureBox atraspng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}