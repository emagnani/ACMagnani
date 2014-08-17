namespace Aceitera.Forms.Areas.Comercial
{
    partial class frm_vehiculos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_vehiculos));
            this.label12 = new System.Windows.Forms.Label();
            this.btn_insertar = new System.Windows.Forms.PictureBox();
            this.btn_eliminar = new System.Windows.Forms.PictureBox();
            this.btn_actualizar = new System.Windows.Forms.PictureBox();
            this.btn_bloquear = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ambiente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_bodega = new System.Windows.Forms.ComboBox();
            this.dgv_consulta = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cargar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.cmb_motor = new System.Windows.Forms.ComboBox();
            this.cmb_linea = new System.Windows.Forms.ComboBox();
            this.cmb_cilindraje = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_linea = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_edit = new System.Windows.Forms.TextBox();
            this.btn_modelo = new System.Windows.Forms.PictureBox();
            this.cmb_modelo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_motor = new System.Windows.Forms.PictureBox();
            this.btn_marca = new System.Windows.Forms.PictureBox();
            this.btn_cilindraje = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_busqueda = new System.Windows.Forms.Label();
            this.lst_busqueda = new System.Windows.Forms.ListBox();
            this.cmb_busqueda = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_insertar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bloquear)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_linea)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_motor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_marca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cilindraje)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 31);
            this.label12.TabIndex = 1;
            this.label12.Text = "Vehiculo";
            // 
            // btn_insertar
            // 
            this.btn_insertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insertar.Image = global::Aceitera.Properties.Resources.save;
            this.btn_insertar.Location = new System.Drawing.Point(128, 66);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(50, 50);
            this.btn_insertar.TabIndex = 17;
            this.btn_insertar.TabStop = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Image = global::Aceitera.Properties.Resources.delete;
            this.btn_eliminar.Location = new System.Drawing.Point(240, 66);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(50, 50);
            this.btn_eliminar.TabIndex = 18;
            this.btn_eliminar.TabStop = false;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.Image = global::Aceitera.Properties.Resources.refresh;
            this.btn_actualizar.Location = new System.Drawing.Point(72, 66);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(50, 50);
            this.btn_actualizar.TabIndex = 19;
            this.btn_actualizar.TabStop = false;
            // 
            // btn_bloquear
            // 
            this.btn_bloquear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bloquear.Image = global::Aceitera.Properties.Resources.edit;
            this.btn_bloquear.Location = new System.Drawing.Point(184, 66);
            this.btn_bloquear.Name = "btn_bloquear";
            this.btn_bloquear.Size = new System.Drawing.Size(50, 50);
            this.btn_bloquear.TabIndex = 20;
            this.btn_bloquear.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_ambiente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_bodega);
            this.groupBox1.Location = new System.Drawing.Point(15, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 259);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Almacenaje";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Orden de\r\nProducción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Almacen";
            // 
            // cmb_ambiente
            // 
            this.cmb_ambiente.FormattingEnabled = true;
            this.cmb_ambiente.Location = new System.Drawing.Point(84, 57);
            this.cmb_ambiente.Name = "cmb_ambiente";
            this.cmb_ambiente.Size = new System.Drawing.Size(100, 21);
            this.cmb_ambiente.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Producto";
            // 
            // cmb_bodega
            // 
            this.cmb_bodega.FormattingEnabled = true;
            this.cmb_bodega.Location = new System.Drawing.Point(84, 27);
            this.cmb_bodega.Name = "cmb_bodega";
            this.cmb_bodega.Size = new System.Drawing.Size(100, 21);
            this.cmb_bodega.TabIndex = 11;
            // 
            // dgv_consulta
            // 
            this.dgv_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_consulta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulta.Location = new System.Drawing.Point(247, 24);
            this.dgv_consulta.Name = "dgv_consulta";
            this.dgv_consulta.Size = new System.Drawing.Size(465, 259);
            this.dgv_consulta.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Aceitera.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(296, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cargar.Image = global::Aceitera.Properties.Resources.folder;
            this.btn_cargar.Location = new System.Drawing.Point(16, 66);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(50, 50);
            this.btn_cargar.TabIndex = 24;
            this.btn_cargar.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // cmb_marca
            // 
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(14, 39);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(95, 21);
            this.cmb_marca.TabIndex = 25;
            this.cmb_marca.SelectionChangeCommitted += new System.EventHandler(this.cmb_marca_SelectionChangeCommitted);
            // 
            // cmb_motor
            // 
            this.cmb_motor.FormattingEnabled = true;
            this.cmb_motor.Location = new System.Drawing.Point(14, 79);
            this.cmb_motor.Name = "cmb_motor";
            this.cmb_motor.Size = new System.Drawing.Size(95, 21);
            this.cmb_motor.TabIndex = 26;
            // 
            // cmb_linea
            // 
            this.cmb_linea.FormattingEnabled = true;
            this.cmb_linea.Location = new System.Drawing.Point(142, 39);
            this.cmb_linea.Name = "cmb_linea";
            this.cmb_linea.Size = new System.Drawing.Size(95, 21);
            this.cmb_linea.TabIndex = 27;
            this.cmb_linea.SelectionChangeCommitted += new System.EventHandler(this.cmb_linea_SelectionChangeCommitted);
            // 
            // cmb_cilindraje
            // 
            this.cmb_cilindraje.FormattingEnabled = true;
            this.cmb_cilindraje.Location = new System.Drawing.Point(144, 79);
            this.cmb_cilindraje.Name = "cmb_cilindraje";
            this.cmb_cilindraje.Size = new System.Drawing.Size(93, 21);
            this.cmb_cilindraje.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Linea:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Motor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Cilindraje:";
            // 
            // btn_linea
            // 
            this.btn_linea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_linea.Image = ((System.Drawing.Image)(resources.GetObject("btn_linea.Image")));
            this.btn_linea.Location = new System.Drawing.Point(243, 39);
            this.btn_linea.Name = "btn_linea";
            this.btn_linea.Size = new System.Drawing.Size(21, 21);
            this.btn_linea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_linea.TabIndex = 33;
            this.btn_linea.TabStop = false;
            this.btn_linea.Click += new System.EventHandler(this.btn_linea_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txt_edit);
            this.panel1.Controls.Add(this.btn_modelo);
            this.panel1.Controls.Add(this.cmb_modelo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btn_motor);
            this.panel1.Controls.Add(this.btn_marca);
            this.panel1.Controls.Add(this.btn_cilindraje);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_linea);
            this.panel1.Controls.Add(this.cmb_marca);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmb_motor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmb_linea);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_cilindraje);
            this.panel1.Location = new System.Drawing.Point(13, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 119);
            this.panel1.TabIndex = 34;
            // 
            // txt_edit
            // 
            this.txt_edit.Location = new System.Drawing.Point(270, 80);
            this.txt_edit.Name = "txt_edit";
            this.txt_edit.Size = new System.Drawing.Size(95, 20);
            this.txt_edit.TabIndex = 40;
            this.txt_edit.Visible = false;
            // 
            // btn_modelo
            // 
            this.btn_modelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modelo.Image = ((System.Drawing.Image)(resources.GetObject("btn_modelo.Image")));
            this.btn_modelo.Location = new System.Drawing.Point(371, 39);
            this.btn_modelo.Name = "btn_modelo";
            this.btn_modelo.Size = new System.Drawing.Size(21, 21);
            this.btn_modelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_modelo.TabIndex = 39;
            this.btn_modelo.TabStop = false;
            this.btn_modelo.Click += new System.EventHandler(this.btn_modelo_Click);
            // 
            // cmb_modelo
            // 
            this.cmb_modelo.FormattingEnabled = true;
            this.cmb_modelo.Location = new System.Drawing.Point(270, 39);
            this.cmb_modelo.Name = "cmb_modelo";
            this.cmb_modelo.Size = new System.Drawing.Size(95, 21);
            this.cmb_modelo.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Modelo:";
            // 
            // btn_motor
            // 
            this.btn_motor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_motor.Image = ((System.Drawing.Image)(resources.GetObject("btn_motor.Image")));
            this.btn_motor.Location = new System.Drawing.Point(115, 79);
            this.btn_motor.Name = "btn_motor";
            this.btn_motor.Size = new System.Drawing.Size(21, 21);
            this.btn_motor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_motor.TabIndex = 36;
            this.btn_motor.TabStop = false;
            this.btn_motor.Click += new System.EventHandler(this.btn_motor_Click);
            // 
            // btn_marca
            // 
            this.btn_marca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_marca.Image = ((System.Drawing.Image)(resources.GetObject("btn_marca.Image")));
            this.btn_marca.Location = new System.Drawing.Point(115, 39);
            this.btn_marca.Name = "btn_marca";
            this.btn_marca.Size = new System.Drawing.Size(21, 21);
            this.btn_marca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_marca.TabIndex = 35;
            this.btn_marca.TabStop = false;
            this.btn_marca.Click += new System.EventHandler(this.btn_marca_Click);
            // 
            // btn_cilindraje
            // 
            this.btn_cilindraje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cilindraje.Image = ((System.Drawing.Image)(resources.GetObject("btn_cilindraje.Image")));
            this.btn_cilindraje.Location = new System.Drawing.Point(243, 79);
            this.btn_cilindraje.Name = "btn_cilindraje";
            this.btn_cilindraje.Size = new System.Drawing.Size(21, 21);
            this.btn_cilindraje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_cilindraje.TabIndex = 34;
            this.btn_cilindraje.TabStop = false;
            this.btn_cilindraje.Click += new System.EventHandler(this.btn_cilindraje_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbl_busqueda);
            this.panel2.Controls.Add(this.lst_busqueda);
            this.panel2.Controls.Add(this.cmb_busqueda);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.txtbusqueda);
            this.panel2.Location = new System.Drawing.Point(550, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 434);
            this.panel2.TabIndex = 35;
            // 
            // lbl_busqueda
            // 
            this.lbl_busqueda.Location = new System.Drawing.Point(27, 38);
            this.lbl_busqueda.Name = "lbl_busqueda";
            this.lbl_busqueda.Size = new System.Drawing.Size(221, 21);
            this.lbl_busqueda.TabIndex = 6;
            // 
            // lst_busqueda
            // 
            this.lst_busqueda.BackColor = System.Drawing.SystemColors.Control;
            this.lst_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_busqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_busqueda.FormattingEnabled = true;
            this.lst_busqueda.Location = new System.Drawing.Point(29, 65);
            this.lst_busqueda.Name = "lst_busqueda";
            this.lst_busqueda.Size = new System.Drawing.Size(219, 65);
            this.lst_busqueda.TabIndex = 5;
            this.lst_busqueda.Visible = false;
            // 
            // cmb_busqueda
            // 
            this.cmb_busqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_busqueda.FormattingEnabled = true;
            this.cmb_busqueda.Items.AddRange(new object[] {
            "Ambiente",
            "Nombre"});
            this.cmb_busqueda.Location = new System.Drawing.Point(29, 14);
            this.cmb_busqueda.Name = "cmb_busqueda";
            this.cmb_busqueda.Size = new System.Drawing.Size(89, 21);
            this.cmb_busqueda.TabIndex = 4;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Aceitera.Properties.Resources.search;
            this.pictureBox7.Location = new System.Drawing.Point(3, 14);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtbusqueda.Location = new System.Drawing.Point(130, 15);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(118, 20);
            this.txtbusqueda.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Location = new System.Drawing.Point(13, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 119);
            this.panel3.TabIndex = 36;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(17, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(144, 23);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(93, 21);
            this.comboBox3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 2;
            // 
            // frm_vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 513);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_bloquear);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_vehiculos";
            this.Text = "l";
            this.Load += new System.EventHandler(this.frm_vehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_insertar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bloquear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_linea)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_motor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_marca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cilindraje)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox btn_insertar;
        private System.Windows.Forms.PictureBox btn_eliminar;
        private System.Windows.Forms.PictureBox btn_actualizar;
        private System.Windows.Forms.PictureBox btn_bloquear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_ambiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_bodega;
        private System.Windows.Forms.DataGridView dgv_consulta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_cargar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmb_marca;
        private System.Windows.Forms.ComboBox cmb_motor;
        private System.Windows.Forms.ComboBox cmb_linea;
        private System.Windows.Forms.ComboBox cmb_cilindraje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btn_linea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_modelo;
        private System.Windows.Forms.ComboBox cmb_modelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btn_motor;
        private System.Windows.Forms.PictureBox btn_marca;
        private System.Windows.Forms.PictureBox btn_cilindraje;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_busqueda;
        private System.Windows.Forms.ListBox lst_busqueda;
        private System.Windows.Forms.ComboBox cmb_busqueda;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.TextBox txt_edit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;

    }
}