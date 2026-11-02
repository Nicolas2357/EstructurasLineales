namespace ColasEstaticas
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
            lblNota = new Label();
            grpOperaciones = new GroupBox();
            btnVaciar = new Button();
            btnPeek = new Button();
            btnDesencolar = new Button();
            btnEncolar = new Button();
            btnAleatorio = new Button();
            nudValor = new NumericUpDown();
            lblValor = new Label();
            grpCapacidad = new GroupBox();
            btnCrear = new Button();
            nudCapacidad = new NumericUpDown();
            lblCapacidad = new Label();
            tabPrincipal = new TabControl();
            tabVista = new TabPage();
            picColas = new PictureBox();
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
            grpOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudValor).BeginInit();
            grpCapacidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            tabPrincipal.SuspendLayout();
            tabVista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picColas).BeginInit();
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
            lblTitulo.Size = new Size(420, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cola simple vs. Cola circular (FIFO)";
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
            lblSubtitulo.Text = "Memoria estática con índices front y rear  •  Enqueue, Dequeue, Peek, IsEmpty, IsFull  •  Estructura de Datos";
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(240, 243, 248);
            pnlLateral.Controls.Add(lblNota);
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
            grpCapacidad.Text = "1. Crear las colas";
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
            nudCapacidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudCapacidad.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
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
            btnCrear.Text = "Crear colas nuevas";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += BtnCrear_Click;
            // 
            // grpOperaciones
            // 
            grpOperaciones.Controls.Add(btnVaciar);
            grpOperaciones.Controls.Add(btnPeek);
            grpOperaciones.Controls.Add(btnDesencolar);
            grpOperaciones.Controls.Add(btnEncolar);
            grpOperaciones.Controls.Add(btnAleatorio);
            grpOperaciones.Controls.Add(nudValor);
            grpOperaciones.Controls.Add(lblValor);
            grpOperaciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpOperaciones.ForeColor = Color.FromArgb(31, 58, 96);
            grpOperaciones.Location = new Point(12, 122);
            grpOperaciones.Name = "grpOperaciones";
            grpOperaciones.Size = new Size(276, 232);
            grpOperaciones.TabIndex = 1;
            grpOperaciones.TabStop = false;
            grpOperaciones.Text = "2. Operaciones (en ambas colas)";
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
            // btnEncolar
            // 
            btnEncolar.BackColor = Color.FromArgb(0, 120, 215);
            btnEncolar.Cursor = Cursors.Hand;
            btnEncolar.FlatAppearance.BorderSize = 0;
            btnEncolar.FlatStyle = FlatStyle.Flat;
            btnEncolar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnEncolar.ForeColor = Color.White;
            btnEncolar.Location = new Point(12, 64);
            btnEncolar.Name = "btnEncolar";
            btnEncolar.Size = new Size(252, 38);
            btnEncolar.TabIndex = 3;
            btnEncolar.Text = "➜  Enqueue (encolar)";
            btnEncolar.UseVisualStyleBackColor = false;
            btnEncolar.Click += BtnEncolar_Click;
            // 
            // btnDesencolar
            // 
            btnDesencolar.Cursor = Cursors.Hand;
            btnDesencolar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDesencolar.ForeColor = Color.FromArgb(170, 30, 30);
            btnDesencolar.Location = new Point(12, 108);
            btnDesencolar.Name = "btnDesencolar";
            btnDesencolar.Size = new Size(252, 34);
            btnDesencolar.TabIndex = 4;
            btnDesencolar.Text = "Dequeue (desencolar)";
            btnDesencolar.UseVisualStyleBackColor = true;
            btnDesencolar.Click += BtnDesencolar_Click;
            // 
            // btnPeek
            // 
            btnPeek.Cursor = Cursors.Hand;
            btnPeek.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPeek.ForeColor = Color.FromArgb(25, 110, 50);
            btnPeek.Location = new Point(12, 148);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(252, 34);
            btnPeek.TabIndex = 5;
            btnPeek.Text = "Peek (ver el frente)";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += BtnPeek_Click;
            // 
            // btnVaciar
            // 
            btnVaciar.Cursor = Cursors.Hand;
            btnVaciar.FlatStyle = FlatStyle.Flat;
            btnVaciar.Font = new Font("Segoe UI", 9F);
            btnVaciar.ForeColor = Color.Black;
            btnVaciar.Location = new Point(12, 190);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(252, 30);
            btnVaciar.TabIndex = 6;
            btnVaciar.Text = "Vaciar colas";
            btnVaciar.UseVisualStyleBackColor = true;
            btnVaciar.Click += BtnVaciar_Click;
            // 
            // lblNota
            // 
            lblNota.Font = new Font("Segoe UI", 8.75F, FontStyle.Italic);
            lblNota.ForeColor = Color.FromArgb(70, 70, 70);
            lblNota.Location = new Point(14, 366);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(272, 120);
            lblNota.TabIndex = 2;
            lblNota.Text = "Cada operación se aplica a las dos colas al mismo tiempo para compararlas. Prueba: llena las colas, desencola dos elementos y vuelve a encolar. La cola simple marca \"llena\" (falso desbordamiento) y la circular reutiliza los espacios liberados.";
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
            tabVista.Controls.Add(picColas);
            tabVista.Controls.Add(grpHistorial);
            tabVista.Location = new Point(4, 30);
            tabVista.Name = "tabVista";
            tabVista.Padding = new Padding(6);
            tabVista.Size = new Size(692, 536);
            tabVista.TabIndex = 0;
            tabVista.Text = "Representación en memoria";
            tabVista.UseVisualStyleBackColor = true;
            // 
            // picColas
            // 
            picColas.BackColor = Color.White;
            picColas.Dock = DockStyle.Fill;
            picColas.Location = new Point(6, 6);
            picColas.Name = "picColas";
            picColas.Size = new Size(680, 384);
            picColas.TabIndex = 0;
            picColas.TabStop = false;
            picColas.Paint += PicColas_Paint;
            // 
            // grpHistorial
            // 
            grpHistorial.Controls.Add(lstHistorial);
            grpHistorial.Dock = DockStyle.Bottom;
            grpHistorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpHistorial.ForeColor = Color.FromArgb(31, 58, 96);
            grpHistorial.Location = new Point(6, 390);
            grpHistorial.Name = "grpHistorial";
            grpHistorial.Padding = new Padding(8);
            grpHistorial.Size = new Size(680, 140);
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
            lstHistorial.Size = new Size(664, 108);
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
            Text = "Colas estáticas – Simple y circular";
            Load += Form1_Load;
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            pnlLateral.ResumeLayout(false);
            grpOperaciones.ResumeLayout(false);
            grpOperaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudValor).EndInit();
            grpCapacidad.ResumeLayout(false);
            grpCapacidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            tabPrincipal.ResumeLayout(false);
            tabVista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picColas).EndInit();
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
        private Button btnEncolar;
        private Button btnDesencolar;
        private Button btnPeek;
        private Button btnVaciar;
        private Label lblNota;
        private TabControl tabPrincipal;
        private TabPage tabVista;
        private PictureBox picColas;
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