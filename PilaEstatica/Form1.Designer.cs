namespace PilaEstatica
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            pnlEncabezado = new Panel();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlLateral = new Panel();
            grpEstado = new GroupBox();
            lblLlenaValor = new Label();
            lblTitLlena = new Label();
            lblVaciaValor = new Label();
            lblTitVacia = new Label();
            lblTopValor = new Label();
            lblTitTop = new Label();
            lblCantidadValor = new Label();
            lblTitCantidad = new Label();
            lblCapacidadValor = new Label();
            lblTitCapacidad = new Label();
            grpOperaciones = new GroupBox();
            btnVaciar = new Button();
            btnPeek = new Button();
            btnPop = new Button();
            btnPush = new Button();
            btnAleatorio = new Button();
            nudValor = new NumericUpDown();
            lblValor = new Label();
            grpCapacidad = new GroupBox();
            btnCrear = new Button();
            nudCapacidad = new NumericUpDown();
            lblCapacidad = new Label();
            tabPrincipal = new TabControl();
            tabVista = new TabPage();
            picPila = new PictureBox();
            grpHistorial = new GroupBox();
            lstHistorial = new ListBox();
            tabPruebas = new TabPage();
            lstPruebas = new ListBox();
            pnlBarraPruebas = new Panel();
            lblResumen = new Label();
            btnPruebas = new Button();
            statusStrip = new StatusStrip();
            lblEstado = new ToolStripStatusLabel();
            pnlEncabezado.SuspendLayout();
            pnlLateral.SuspendLayout();
            grpEstado.SuspendLayout();
            grpOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudValor).BeginInit();
            grpCapacidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            tabPrincipal.SuspendLayout();
            tabVista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPila).BeginInit();
            grpHistorial.SuspendLayout();
            tabPruebas.SuspendLayout();
            pnlBarraPruebas.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(31, 58, 96);
            pnlEncabezado.Controls.Add(lblSubtitulo);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1000, 68);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(18, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(280, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Pila estática (LIFO)";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9.75F);
            lblSubtitulo.ForeColor = Color.FromArgb(200, 215, 235);
            lblSubtitulo.Location = new Point(21, 40);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(430, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Arreglo de tamaño fijo con índice top  •  Push, Pop, Peek, IsEmpty, IsFull  •  Estructura de Datos";
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(240, 243, 248);
            pnlLateral.Controls.Add(grpEstado);
            pnlLateral.Controls.Add(grpOperaciones);
            pnlLateral.Controls.Add(grpCapacidad);
            pnlLateral.Dock = DockStyle.Left;
            pnlLateral.Location = new Point(0, 68);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(300, 570);
            pnlLateral.TabIndex = 1;
            // 
            // grpCapacidad
            // 
            grpCapacidad.Controls.Add(btnCrear);
            grpCapacidad.Controls.Add(nudCapacidad);
            grpCapacidad.Controls.Add(lblCapacidad);
            grpCapacidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpCapacidad.ForeColor = Color.FromArgb(31, 58, 96);
            grpCapacidad.Location = new Point(12, 12);
            grpCapacidad.Name = "grpCapacidad";
            grpCapacidad.Size = new Size(276, 102);
            grpCapacidad.TabIndex = 0;
            grpCapacidad.TabStop = false;
            grpCapacidad.Text = "1. Crear la pila";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Font = new Font("Segoe UI", 9F);
            lblCapacidad.ForeColor = Color.Black;
            lblCapacidad.Location = new Point(12, 31);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(130, 15);
            lblCapacidad.TabIndex = 0;
            lblCapacidad.Text = "Capacidad del arreglo:";
            // 
            // nudCapacidad
            // 
            nudCapacidad.Font = new Font("Segoe UI", 9F);
            nudCapacidad.Location = new Point(180, 28);
            nudCapacidad.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nudCapacidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(84, 23);
            nudCapacidad.TabIndex = 1;
            nudCapacidad.TextAlign = HorizontalAlignment.Center;
            nudCapacidad.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // btnCrear
            // 
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.Font = new Font("Segoe UI", 9F);
            btnCrear.ForeColor = Color.Black;
            btnCrear.Location = new Point(12, 60);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(252, 30);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear pila nueva";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += BtnCrear_Click;
            // 
            // grpOperaciones
            // 
            grpOperaciones.Controls.Add(btnVaciar);
            grpOperaciones.Controls.Add(btnPeek);
            grpOperaciones.Controls.Add(btnPop);
            grpOperaciones.Controls.Add(btnPush);
            grpOperaciones.Controls.Add(btnAleatorio);
            grpOperaciones.Controls.Add(nudValor);
            grpOperaciones.Controls.Add(lblValor);
            grpOperaciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpOperaciones.ForeColor = Color.FromArgb(31, 58, 96);
            grpOperaciones.Location = new Point(12, 122);
            grpOperaciones.Name = "grpOperaciones";
            grpOperaciones.Size = new Size(276, 190);
            grpOperaciones.TabIndex = 1;
            grpOperaciones.TabStop = false;
            grpOperaciones.Text = "2. Operaciones";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 9F);
            lblValor.ForeColor = Color.Black;
            lblValor.Location = new Point(12, 31);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(36, 15);
            lblValor.TabIndex = 0;
            lblValor.Text = "Valor:";
            // 
            // nudValor
            // 
            nudValor.Font = new Font("Segoe UI", 9F);
            nudValor.Location = new Point(60, 28);
            nudValor.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudValor.Minimum = new decimal(new int[] { 999, 0, 0, int.MinValue });
            nudValor.Name = "nudValor";
            nudValor.Size = new Size(110, 23);
            nudValor.TabIndex = 1;
            nudValor.TextAlign = HorizontalAlignment.Center;
            nudValor.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnAleatorio
            // 
            btnAleatorio.Cursor = Cursors.Hand;
            btnAleatorio.Font = new Font("Segoe UI", 9F);
            btnAleatorio.ForeColor = Color.Black;
            btnAleatorio.Location = new Point(178, 27);
            btnAleatorio.Name = "btnAleatorio";
            btnAleatorio.Size = new Size(86, 25);
            btnAleatorio.TabIndex = 2;
            btnAleatorio.Text = "Aleatorio";
            btnAleatorio.UseVisualStyleBackColor = true;
            btnAleatorio.Click += BtnAleatorio_Click;
            // 
            // btnPush
            // 
            btnPush.BackColor = Color.FromArgb(0, 120, 215);
            btnPush.Cursor = Cursors.Hand;
            btnPush.FlatAppearance.BorderSize = 0;
            btnPush.FlatStyle = FlatStyle.Flat;
            btnPush.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnPush.ForeColor = Color.White;
            btnPush.Location = new Point(12, 64);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(252, 38);
            btnPush.TabIndex = 3;
            btnPush.Text = "▲  Push (apilar)";
            btnPush.UseVisualStyleBackColor = false;
            btnPush.Click += BtnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Cursor = Cursors.Hand;
            btnPop.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPop.ForeColor = Color.FromArgb(170, 30, 30);
            btnPop.Location = new Point(12, 108);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(123, 34);
            btnPop.TabIndex = 4;
            btnPop.Text = "▼  Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += BtnPop_Click;
            // 
            // btnPeek
            // 
            btnPeek.Cursor = Cursors.Hand;
            btnPeek.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPeek.ForeColor = Color.FromArgb(25, 110, 50);
            btnPeek.Location = new Point(141, 108);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(123, 34);
            btnPeek.TabIndex = 5;
            btnPeek.Text = "👁  Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += BtnPeek_Click;
            // 
            // btnVaciar
            // 
            btnVaciar.Cursor = Cursors.Hand;
            btnVaciar.FlatStyle = FlatStyle.Flat;
            btnVaciar.Font = new Font("Segoe UI", 9F);
            btnVaciar.ForeColor = Color.Black;
            btnVaciar.Location = new Point(12, 148);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(252, 30);
            btnVaciar.TabIndex = 6;
            btnVaciar.Text = "Vaciar pila";
            btnVaciar.UseVisualStyleBackColor = true;
            btnVaciar.Click += BtnVaciar_Click;
            // 
            // grpEstado
            // 
            grpEstado.Controls.Add(lblLlenaValor);
            grpEstado.Controls.Add(lblTitLlena);
            grpEstado.Controls.Add(lblVaciaValor);
            grpEstado.Controls.Add(lblTitVacia);
            grpEstado.Controls.Add(lblTopValor);
            grpEstado.Controls.Add(lblTitTop);
            grpEstado.Controls.Add(lblCantidadValor);
            grpEstado.Controls.Add(lblTitCantidad);
            grpEstado.Controls.Add(lblCapacidadValor);
            grpEstado.Controls.Add(lblTitCapacidad);
            grpEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpEstado.ForeColor = Color.FromArgb(31, 58, 96);
            grpEstado.Location = new Point(12, 320);
            grpEstado.Name = "grpEstado";
            grpEstado.Size = new Size(276, 172);
            grpEstado.TabIndex = 2;
            grpEstado.TabStop = false;
            grpEstado.Text = "3. Estado de la pila";
            // 
            // lblTitCapacidad
            // 
            lblTitCapacidad.AutoSize = true;
            lblTitCapacidad.Font = new Font("Segoe UI", 9F);
            lblTitCapacidad.ForeColor = Color.DimGray;
            lblTitCapacidad.Location = new Point(14, 30);
            lblTitCapacidad.Name = "lblTitCapacidad";
            lblTitCapacidad.Size = new Size(66, 15);
            lblTitCapacidad.TabIndex = 0;
            lblTitCapacidad.Text = "Capacidad:";
            // 
            // lblCapacidadValor
            // 
            lblCapacidadValor.AutoSize = true;
            lblCapacidadValor.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblCapacidadValor.ForeColor = Color.Black;
            lblCapacidadValor.Location = new Point(150, 28);
            lblCapacidadValor.Name = "lblCapacidadValor";
            lblCapacidadValor.Size = new Size(16, 18);
            lblCapacidadValor.TabIndex = 1;
            lblCapacidadValor.Text = "—";
            // 
            // lblTitCantidad
            // 
            lblTitCantidad.AutoSize = true;
            lblTitCantidad.Font = new Font("Segoe UI", 9F);
            lblTitCantidad.ForeColor = Color.DimGray;
            lblTitCantidad.Location = new Point(14, 58);
            lblTitCantidad.Name = "lblTitCantidad";
            lblTitCantidad.Size = new Size(58, 15);
            lblTitCantidad.TabIndex = 2;
            lblTitCantidad.Text = "Cantidad:";
            // 
            // lblCantidadValor
            // 
            lblCantidadValor.AutoSize = true;
            lblCantidadValor.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblCantidadValor.ForeColor = Color.Black;
            lblCantidadValor.Location = new Point(150, 56);
            lblCantidadValor.Name = "lblCantidadValor";
            lblCantidadValor.Size = new Size(16, 18);
            lblCantidadValor.TabIndex = 3;
            lblCantidadValor.Text = "—";
            // 
            // lblTitTop
            // 
            lblTitTop.AutoSize = true;
            lblTitTop.Font = new Font("Segoe UI", 9F);
            lblTitTop.ForeColor = Color.DimGray;
            lblTitTop.Location = new Point(14, 86);
            lblTitTop.Name = "lblTitTop";
            lblTitTop.Size = new Size(92, 15);
            lblTitTop.TabIndex = 4;
            lblTitTop.Text = "Índice top:";
            // 
            // lblTopValor
            // 
            lblTopValor.AutoSize = true;
            lblTopValor.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblTopValor.ForeColor = Color.FromArgb(0, 90, 200);
            lblTopValor.Location = new Point(150, 84);
            lblTopValor.Name = "lblTopValor";
            lblTopValor.Size = new Size(16, 18);
            lblTopValor.TabIndex = 5;
            lblTopValor.Text = "—";
            // 
            // lblTitVacia
            // 
            lblTitVacia.AutoSize = true;
            lblTitVacia.Font = new Font("Segoe UI", 9F);
            lblTitVacia.ForeColor = Color.DimGray;
            lblTitVacia.Location = new Point(14, 114);
            lblTitVacia.Name = "lblTitVacia";
            lblTitVacia.Size = new Size(60, 15);
            lblTitVacia.TabIndex = 6;
            lblTitVacia.Text = "IsEmpty():";
            // 
            // lblVaciaValor
            // 
            lblVaciaValor.AutoSize = true;
            lblVaciaValor.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblVaciaValor.ForeColor = Color.Black;
            lblVaciaValor.Location = new Point(150, 112);
            lblVaciaValor.Name = "lblVaciaValor";
            lblVaciaValor.Size = new Size(16, 18);
            lblVaciaValor.TabIndex = 7;
            lblVaciaValor.Text = "—";
            // 
            // lblTitLlena
            // 
            lblTitLlena.AutoSize = true;
            lblTitLlena.Font = new Font("Segoe UI", 9F);
            lblTitLlena.ForeColor = Color.DimGray;
            lblTitLlena.Location = new Point(14, 142);
            lblTitLlena.Name = "lblTitLlena";
            lblTitLlena.Size = new Size(50, 15);
            lblTitLlena.TabIndex = 8;
            lblTitLlena.Text = "IsFull():";
            // 
            // lblLlenaValor
            // 
            lblLlenaValor.AutoSize = true;
            lblLlenaValor.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblLlenaValor.ForeColor = Color.Black;
            lblLlenaValor.Location = new Point(150, 140);
            lblLlenaValor.Name = "lblLlenaValor";
            lblLlenaValor.Size = new Size(16, 18);
            lblLlenaValor.TabIndex = 9;
            lblLlenaValor.Text = "—";
            // 
            // tabPrincipal
            // 
            tabPrincipal.Controls.Add(tabVista);
            tabPrincipal.Controls.Add(tabPruebas);
            tabPrincipal.Dock = DockStyle.Fill;
            tabPrincipal.Font = new Font("Segoe UI", 9.75F);
            tabPrincipal.Location = new Point(300, 68);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.Padding = new Point(12, 5);
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(700, 570);
            tabPrincipal.TabIndex = 2;
            // 
            // tabVista
            // 
            tabVista.Controls.Add(picPila);
            tabVista.Controls.Add(grpHistorial);
            tabVista.Location = new Point(4, 30);
            tabVista.Name = "tabVista";
            tabVista.Padding = new Padding(6);
            tabVista.Size = new Size(692, 536);
            tabVista.TabIndex = 0;
            tabVista.Text = "Representación en memoria";
            tabVista.UseVisualStyleBackColor = true;
            // 
            // picPila
            // 
            picPila.BackColor = Color.White;
            picPila.Dock = DockStyle.Fill;
            picPila.Location = new Point(6, 6);
            picPila.Name = "picPila";
            picPila.Size = new Size(420, 524);
            picPila.TabIndex = 0;
            picPila.TabStop = false;
            picPila.Paint += PicPila_Paint;
            // 
            // grpHistorial
            // 
            grpHistorial.Controls.Add(lstHistorial);
            grpHistorial.Dock = DockStyle.Right;
            grpHistorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpHistorial.ForeColor = Color.FromArgb(31, 58, 96);
            grpHistorial.Location = new Point(426, 6);
            grpHistorial.Name = "grpHistorial";
            grpHistorial.Padding = new Padding(8);
            grpHistorial.Size = new Size(260, 524);
            grpHistorial.TabIndex = 1;
            grpHistorial.TabStop = false;
            grpHistorial.Text = "Historial de operaciones";
            // 
            // lstHistorial
            // 
            lstHistorial.BorderStyle = BorderStyle.None;
            lstHistorial.Dock = DockStyle.Fill;
            lstHistorial.Font = new Font("Consolas", 9F);
            lstHistorial.ForeColor = Color.Black;
            lstHistorial.HorizontalScrollbar = true;
            lstHistorial.IntegralHeight = false;
            lstHistorial.ItemHeight = 14;
            lstHistorial.Location = new Point(8, 24);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(244, 492);
            lstHistorial.TabIndex = 0;
            // 
            // tabPruebas
            // 
            tabPruebas.Controls.Add(lstPruebas);
            tabPruebas.Controls.Add(pnlBarraPruebas);
            tabPruebas.Location = new Point(4, 30);
            tabPruebas.Name = "tabPruebas";
            tabPruebas.Padding = new Padding(8);
            tabPruebas.Size = new Size(692, 536);
            tabPruebas.TabIndex = 1;
            tabPruebas.Text = "Pruebas automáticas";
            tabPruebas.UseVisualStyleBackColor = true;
            // 
            // pnlBarraPruebas
            // 
            pnlBarraPruebas.Controls.Add(lblResumen);
            pnlBarraPruebas.Controls.Add(btnPruebas);
            pnlBarraPruebas.Dock = DockStyle.Top;
            pnlBarraPruebas.Location = new Point(8, 8);
            pnlBarraPruebas.Name = "pnlBarraPruebas";
            pnlBarraPruebas.Size = new Size(676, 50);
            pnlBarraPruebas.TabIndex = 0;
            // 
            // btnPruebas
            // 
            btnPruebas.BackColor = Color.FromArgb(0, 120, 215);
            btnPruebas.Cursor = Cursors.Hand;
            btnPruebas.FlatAppearance.BorderSize = 0;
            btnPruebas.FlatStyle = FlatStyle.Flat;
            btnPruebas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPruebas.ForeColor = Color.White;
            btnPruebas.Location = new Point(0, 8);
            btnPruebas.Name = "btnPruebas";
            btnPruebas.Size = new Size(200, 34);
            btnPruebas.TabIndex = 0;
            btnPruebas.Text = "▶  Ejecutar pruebas";
            btnPruebas.UseVisualStyleBackColor = false;
            btnPruebas.Click += BtnPruebas_Click;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblResumen.Location = new Point(215, 15);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(0, 20);
            lblResumen.TabIndex = 1;
            // 
            // lstPruebas
            // 
            lstPruebas.BorderStyle = BorderStyle.FixedSingle;
            lstPruebas.Dock = DockStyle.Fill;
            lstPruebas.Font = new Font("Consolas", 10F);
            lstPruebas.HorizontalScrollbar = true;
            lstPruebas.IntegralHeight = false;
            lstPruebas.ItemHeight = 15;
            lstPruebas.Location = new Point(8, 58);
            lstPruebas.Name = "lstPruebas";
            lstPruebas.Size = new Size(676, 470);
            lstPruebas.TabIndex = 1;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lblEstado });
            statusStrip.Location = new Point(0, 638);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1000, 22);
            statusStrip.TabIndex = 3;
            // 
            // lblEstado
            // 
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(35, 17);
            lblEstado.Text = "Listo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 660);
            Controls.Add(tabPrincipal);
            Controls.Add(pnlLateral);
            Controls.Add(pnlEncabezado);
            Controls.Add(statusStrip);
            MinimumSize = new Size(1016, 699);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pila estática – Implementación con arreglo";
            Load += Form1_Load;
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            pnlLateral.ResumeLayout(false);
            grpEstado.ResumeLayout(false);
            grpEstado.PerformLayout();
            grpOperaciones.ResumeLayout(false);
            grpOperaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudValor).EndInit();
            grpCapacidad.ResumeLayout(false);
            grpCapacidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            tabPrincipal.ResumeLayout(false);
            tabVista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPila).EndInit();
            grpHistorial.ResumeLayout(false);
            tabPruebas.ResumeLayout(false);
            pnlBarraPruebas.ResumeLayout(false);
            pnlBarraPruebas.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel pnlLateral;
        private GroupBox grpCapacidad;
        private Label lblCapacidad;
        private NumericUpDown nudCapacidad;
        private Button btnCrear;
        private GroupBox grpOperaciones;
        private Label lblValor;
        private NumericUpDown nudValor;
        private Button btnAleatorio;
        private Button btnPush;
        private Button btnPop;
        private Button btnPeek;
        private Button btnVaciar;
        private GroupBox grpEstado;
        private Label lblTitCapacidad;
        private Label lblCapacidadValor;
        private Label lblTitCantidad;
        private Label lblCantidadValor;
        private Label lblTitTop;
        private Label lblTopValor;
        private Label lblTitVacia;
        private Label lblVaciaValor;
        private Label lblTitLlena;
        private Label lblLlenaValor;
        private TabControl tabPrincipal;
        private TabPage tabVista;
        private PictureBox picPila;
        private GroupBox grpHistorial;
        private ListBox lstHistorial;
        private TabPage tabPruebas;
        private Panel pnlBarraPruebas;
        private Button btnPruebas;
        private Label lblResumen;
        private ListBox lstPruebas;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblEstado;
    }
}