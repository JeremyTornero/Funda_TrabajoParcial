namespace Funda_TrabajoParcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstNoClientes = new System.Windows.Forms.ListBox();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.lstPreferencial = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewPreferencial = new System.Windows.Forms.ListView();
            this.listViewCliente = new System.Windows.Forms.ListView();
            this.listViewNoCliente = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIngresarUsuario = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btntimer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Reloj = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMontoTotalPorCadaTipoDeOperacion = new System.Windows.Forms.Button();
            this.btnOperacionMasSolicitada = new System.Windows.Forms.Button();
            this.btnVentanillaConMayorNumeroDeAtenciones = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btniniciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNoClientes
            // 
            this.lstNoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNoClientes.FormattingEnabled = true;
            this.lstNoClientes.HorizontalScrollbar = true;
            this.lstNoClientes.ItemHeight = 16;
            this.lstNoClientes.Location = new System.Drawing.Point(269, 47);
            this.lstNoClientes.Name = "lstNoClientes";
            this.lstNoClientes.Size = new System.Drawing.Size(121, 196);
            this.lstNoClientes.TabIndex = 37;
            // 
            // lstClientes
            // 
            this.lstClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.HorizontalScrollbar = true;
            this.lstClientes.ItemHeight = 16;
            this.lstClientes.Location = new System.Drawing.Point(141, 47);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(121, 196);
            this.lstClientes.TabIndex = 36;
            // 
            // lstPreferencial
            // 
            this.lstPreferencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPreferencial.FormattingEnabled = true;
            this.lstPreferencial.HorizontalScrollbar = true;
            this.lstPreferencial.ItemHeight = 16;
            this.lstPreferencial.Location = new System.Drawing.Point(13, 47);
            this.lstPreferencial.Name = "lstPreferencial";
            this.lstPreferencial.Size = new System.Drawing.Size(121, 196);
            this.lstPreferencial.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.listViewPreferencial);
            this.groupBox1.Controls.Add(this.listViewCliente);
            this.groupBox1.Controls.Add(this.listViewNoCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(429, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 450);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ventanilla 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ventanilla 2";
            // 
            // listViewPreferencial
            // 
            this.listViewPreferencial.Location = new System.Drawing.Point(10, 38);
            this.listViewPreferencial.Name = "listViewPreferencial";
            this.listViewPreferencial.Size = new System.Drawing.Size(246, 114);
            this.listViewPreferencial.TabIndex = 1;
            this.listViewPreferencial.UseCompatibleStateImageBehavior = false;
            // 
            // listViewCliente
            // 
            this.listViewCliente.Location = new System.Drawing.Point(10, 182);
            this.listViewCliente.Name = "listViewCliente";
            this.listViewCliente.Size = new System.Drawing.Size(245, 114);
            this.listViewCliente.TabIndex = 2;
            this.listViewCliente.UseCompatibleStateImageBehavior = false;
            // 
            // listViewNoCliente
            // 
            this.listViewNoCliente.Location = new System.Drawing.Point(10, 326);
            this.listViewNoCliente.Name = "listViewNoCliente";
            this.listViewNoCliente.Size = new System.Drawing.Size(245, 114);
            this.listViewNoCliente.TabIndex = 3;
            this.listViewNoCliente.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ventanilla 3";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(14, 24);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(210, 22);
            this.txtUsuario.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnIngresarUsuario);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 60);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresar nombre:";
            // 
            // btnIngresarUsuario
            // 
            this.btnIngresarUsuario.BackColor = System.Drawing.Color.Red;
            this.btnIngresarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIngresarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnIngresarUsuario.Location = new System.Drawing.Point(230, 22);
            this.btnIngresarUsuario.Name = "btnIngresarUsuario";
            this.btnIngresarUsuario.Size = new System.Drawing.Size(87, 27);
            this.btnIngresarUsuario.TabIndex = 48;
            this.btnIngresarUsuario.Text = "Registrar";
            this.btnIngresarUsuario.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lstNoClientes);
            this.groupBox3.Controls.Add(this.lstPreferencial);
            this.groupBox3.Controls.Add(this.lstClientes);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 257);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "No clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Preferencial";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(343, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btntimer);
            this.groupBox6.Controls.Add(this.pictureBox2);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.lbl_Reloj);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(13, 360);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(133, 101);
            this.groupBox6.TabIndex = 47;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tiempo";
            // 
            // btntimer
            // 
            this.btntimer.BackColor = System.Drawing.Color.Red;
            this.btntimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btntimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimer.ForeColor = System.Drawing.Color.White;
            this.btntimer.Location = new System.Drawing.Point(26, 63);
            this.btntimer.Name = "btntimer";
            this.btntimer.Size = new System.Drawing.Size(78, 27);
            this.btntimer.TabIndex = 49;
            this.btntimer.Text = "Iniciar";
            this.btntimer.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "seg.";
            // 
            // lbl_Reloj
            // 
            this.lbl_Reloj.AutoSize = true;
            this.lbl_Reloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reloj.Location = new System.Drawing.Point(36, 28);
            this.lbl_Reloj.Name = "lbl_Reloj";
            this.lbl_Reloj.Size = new System.Drawing.Size(24, 25);
            this.lbl_Reloj.TabIndex = 0;
            this.lbl_Reloj.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnMontoTotalPorCadaTipoDeOperacion);
            this.groupBox4.Controls.Add(this.btnOperacionMasSolicitada);
            this.groupBox4.Controls.Add(this.btnVentanillaConMayorNumeroDeAtenciones);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(153, 427);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 34);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reportes";
            // 
            // btnMontoTotalPorCadaTipoDeOperacion
            // 
            this.btnMontoTotalPorCadaTipoDeOperacion.BackColor = System.Drawing.Color.Red;
            this.btnMontoTotalPorCadaTipoDeOperacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMontoTotalPorCadaTipoDeOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMontoTotalPorCadaTipoDeOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMontoTotalPorCadaTipoDeOperacion.ForeColor = System.Drawing.Color.White;
            this.btnMontoTotalPorCadaTipoDeOperacion.Location = new System.Drawing.Point(206, 1);
            this.btnMontoTotalPorCadaTipoDeOperacion.Name = "btnMontoTotalPorCadaTipoDeOperacion";
            this.btnMontoTotalPorCadaTipoDeOperacion.Size = new System.Drawing.Size(33, 27);
            this.btnMontoTotalPorCadaTipoDeOperacion.TabIndex = 49;
            this.btnMontoTotalPorCadaTipoDeOperacion.Text = "3";
            this.btnMontoTotalPorCadaTipoDeOperacion.UseVisualStyleBackColor = false;
            // 
            // btnOperacionMasSolicitada
            // 
            this.btnOperacionMasSolicitada.BackColor = System.Drawing.Color.Red;
            this.btnOperacionMasSolicitada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOperacionMasSolicitada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperacionMasSolicitada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperacionMasSolicitada.ForeColor = System.Drawing.Color.White;
            this.btnOperacionMasSolicitada.Location = new System.Drawing.Point(157, 0);
            this.btnOperacionMasSolicitada.Name = "btnOperacionMasSolicitada";
            this.btnOperacionMasSolicitada.Size = new System.Drawing.Size(33, 27);
            this.btnOperacionMasSolicitada.TabIndex = 49;
            this.btnOperacionMasSolicitada.Text = "2";
            this.btnOperacionMasSolicitada.UseVisualStyleBackColor = false;
            // 
            // btnVentanillaConMayorNumeroDeAtenciones
            // 
            this.btnVentanillaConMayorNumeroDeAtenciones.BackColor = System.Drawing.Color.Red;
            this.btnVentanillaConMayorNumeroDeAtenciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVentanillaConMayorNumeroDeAtenciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVentanillaConMayorNumeroDeAtenciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentanillaConMayorNumeroDeAtenciones.ForeColor = System.Drawing.Color.White;
            this.btnVentanillaConMayorNumeroDeAtenciones.Location = new System.Drawing.Point(104, 0);
            this.btnVentanillaConMayorNumeroDeAtenciones.Name = "btnVentanillaConMayorNumeroDeAtenciones";
            this.btnVentanillaConMayorNumeroDeAtenciones.Size = new System.Drawing.Size(33, 27);
            this.btnVentanillaConMayorNumeroDeAtenciones.TabIndex = 49;
            this.btnVentanillaConMayorNumeroDeAtenciones.Text = "1";
            this.btnVentanillaConMayorNumeroDeAtenciones.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btniniciar);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(153, 360);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(263, 62);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.Red;
            this.btniniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btniniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.ForeColor = System.Drawing.Color.White;
            this.btniniciar.Location = new System.Drawing.Point(36, 21);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(185, 27);
            this.btniniciar.TabIndex = 49;
            this.btniniciar.Text = "Iniciar atención";
            this.btniniciar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(708, 474);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNoClientes;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.ListBox lstPreferencial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewPreferencial;
        private System.Windows.Forms.ListView listViewCliente;
        private System.Windows.Forms.ListView listViewNoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_Reloj;
        private System.Windows.Forms.Button btnIngresarUsuario;
        private System.Windows.Forms.Button btntimer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMontoTotalPorCadaTipoDeOperacion;
        private System.Windows.Forms.Button btnOperacionMasSolicitada;
        private System.Windows.Forms.Button btnVentanillaConMayorNumeroDeAtenciones;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btniniciar;

    }
}

