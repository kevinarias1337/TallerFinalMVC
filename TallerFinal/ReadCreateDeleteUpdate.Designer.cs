namespace TallerFinal
{
    partial class ReadCreateDeleteUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadCreateDeleteUpdate));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.atraspng = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.txtdepartamento = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dbinventario1 = new System.Windows.Forms.DataGridView();
            this.btnactualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atraspng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventario1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TallerFinal.Properties.Resources.kisspng_zoho_office_suite_zoho_corporation_customer_relati_inventory_management_software_5b1d3843aa29b1_129569411528641603697;
            this.pictureBox2.Location = new System.Drawing.Point(89, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // atraspng
            // 
            this.atraspng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.atraspng.Image = global::TallerFinal.Properties.Resources.kisspng_computer_icons_arrow_left_arrow_5ac5e89fdffdc1_8459894415229195839175;
            this.atraspng.Location = new System.Drawing.Point(7, 5);
            this.atraspng.Name = "atraspng";
            this.atraspng.Size = new System.Drawing.Size(47, 40);
            this.atraspng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atraspng.TabIndex = 0;
            this.atraspng.TabStop = false;
            this.atraspng.Click += new System.EventHandler(this.Atraspng_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Departamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID:";
            this.label4.Visible = false;
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(100, 174);
            this.txtnombreproducto.MaxLength = 50;
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(100, 20);
            this.txtnombreproducto.TabIndex = 15;
            this.txtnombreproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnombreproducto_KeyPress);
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.Location = new System.Drawing.Point(100, 200);
            this.txtdepartamento.MaxLength = 20;
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtdepartamento.TabIndex = 16;
            this.txtdepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdepartamento_KeyPress);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(113, 246);
            this.txtid.MaxLength = 50;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(87, 20);
            this.txtid.TabIndex = 17;
            this.txtid.Visible = false;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(132, 223);
            this.txtprecio.MaxLength = 20;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(68, 20);
            this.txtprecio.TabIndex = 18;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtprecio_KeyPress);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(206, 167);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 37);
            this.btnmostrar.TabIndex = 19;
            this.btnmostrar.Text = "Mostrar inventario";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.Btnmostrar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(205, 210);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 20;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(205, 239);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 21;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(143, 268);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(57, 23);
            this.btncancelar.TabIndex = 22;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // dbinventario1
            // 
            this.dbinventario1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dbinventario1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbinventario1.Location = new System.Drawing.Point(12, 297);
            this.dbinventario1.Name = "dbinventario1";
            this.dbinventario1.Size = new System.Drawing.Size(268, 150);
            this.dbinventario1.TabIndex = 23;
            this.dbinventario1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dbinventario1_CellClick);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(205, 268);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 24;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.Btnactualizar_Click);
            // 
            // ReadCreateDeleteUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.dbinventario1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtdepartamento);
            this.Controls.Add(this.txtnombreproducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.atraspng);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReadCreateDeleteUpdate";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atraspng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventario1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox atraspng;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.TextBox txtdepartamento;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView dbinventario1;
        private System.Windows.Forms.Button btnactualizar;
    }
}