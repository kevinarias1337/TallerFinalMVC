namespace TallerFinal
{
    partial class ReadCreateDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadCreateDelete));
            this.dbinventario1 = new System.Windows.Forms.DataGridView();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.txtdepartamento = new System.Windows.Forms.TextBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.atraaspng = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atraaspng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbinventario1
            // 
            this.dbinventario1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dbinventario1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbinventario1.Location = new System.Drawing.Point(21, 307);
            this.dbinventario1.Name = "dbinventario1";
            this.dbinventario1.ReadOnly = true;
            this.dbinventario1.Size = new System.Drawing.Size(247, 131);
            this.dbinventario1.TabIndex = 2;
            this.dbinventario1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dbinventario1_CellClick);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(84, 232);
            this.txtprecio.MaxLength = 20;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 3;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtprecio_KeyPress);
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(84, 206);
            this.txtnombreproducto.MaxLength = 50;
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(100, 20);
            this.txtnombreproducto.TabIndex = 4;
            this.txtnombreproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnombreproducto_KeyPress);
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.Location = new System.Drawing.Point(97, 258);
            this.txtdepartamento.MaxLength = 50;
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(87, 20);
            this.txtdepartamento.TabIndex = 5;
            this.txtdepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdepartamento_KeyPress);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(190, 209);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 37);
            this.btnmostrar.TabIndex = 6;
            this.btnmostrar.Text = "Mostrar inventario";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.Btnmostrar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(190, 282);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(190, 253);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Precio:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(48, 283);
            this.txtid.MaxLength = 20;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(68, 20);
            this.txtid.TabIndex = 12;
            this.txtid.Visible = false;
            this.txtid.Click += new System.EventHandler(this.Txtid_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID:";
            this.label4.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(121, 282);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(57, 23);
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // atraaspng
            // 
            this.atraaspng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.atraaspng.Image = global::TallerFinal.Properties.Resources.kisspng_computer_icons_arrow_left_arrow_5ac5e89fdffdc1_8459894415229195839175;
            this.atraaspng.Location = new System.Drawing.Point(8, 9);
            this.atraaspng.Name = "atraaspng";
            this.atraaspng.Size = new System.Drawing.Size(47, 40);
            this.atraaspng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atraaspng.TabIndex = 1;
            this.atraaspng.TabStop = false;
            this.atraaspng.Click += new System.EventHandler(this.Atraaspng_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TallerFinal.Properties.Resources.kisspng_inventory_management_software_warehouse_management_inventory_management_5b43314a90e3b5_9336076715311301865935;
            this.pictureBox1.Location = new System.Drawing.Point(70, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ReadCreateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.txtdepartamento);
            this.Controls.Add(this.txtnombreproducto);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.dbinventario1);
            this.Controls.Add(this.atraaspng);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReadCreateDelete";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dbinventario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atraaspng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox atraaspng;
        private System.Windows.Forms.DataGridView dbinventario1;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.TextBox txtdepartamento;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncancelar;
    }
}