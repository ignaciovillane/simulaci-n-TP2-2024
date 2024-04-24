namespace tp2_2024
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblDistribucion = new System.Windows.Forms.Label();
            this.cmbDistribucion = new System.Windows.Forms.ComboBox();
            this.lblIntervalos = new System.Windows.Forms.Label();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblLambda = new System.Windows.Forms.Label();
            this.numericUpDownLambda = new System.Windows.Forms.NumericUpDown();
            this.lblMedia = new System.Windows.Forms.Label();
            this.numericUpDownMedia = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDesviacion = new System.Windows.Forms.NumericUpDown();
            this.lblDesviacion = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvNumerosRandom = new System.Windows.Forms.DataGridView();
            this.dgvTablaDeFrecuencias = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGenerarExcel = new System.Windows.Forms.Button();
            this.lblTablaNumerosAleatorios = new System.Windows.Forms.Label();
            this.lblTablaDeFrecuencias = new System.Windows.Forms.Label();
            this.lblGrafico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesviacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerosRandom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDeFrecuencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDistribucion
            // 
            this.lblDistribucion.AutoSize = true;
            this.lblDistribucion.Location = new System.Drawing.Point(13, 13);
            this.lblDistribucion.Name = "lblDistribucion";
            this.lblDistribucion.Size = new System.Drawing.Size(92, 20);
            this.lblDistribucion.TabIndex = 0;
            this.lblDistribucion.Text = "Distribución";
            // 
            // cmbDistribucion
            // 
            this.cmbDistribucion.FormattingEnabled = true;
            this.cmbDistribucion.Location = new System.Drawing.Point(122, 13);
            this.cmbDistribucion.Name = "cmbDistribucion";
            this.cmbDistribucion.Size = new System.Drawing.Size(121, 28);
            this.cmbDistribucion.TabIndex = 1;
            this.cmbDistribucion.SelectedIndexChanged += new System.EventHandler(this.cmbDistribucion_SelectedIndexChanged);
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.AutoSize = true;
            this.lblIntervalos.Location = new System.Drawing.Point(13, 70);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(78, 20);
            this.lblIntervalos.TabIndex = 2;
            this.lblIntervalos.Text = "Intervalos";
            // 
            // cmbIntervalos
            // 
            this.cmbIntervalos.FormattingEnabled = true;
            this.cmbIntervalos.Location = new System.Drawing.Point(122, 70);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(121, 28);
            this.cmbIntervalos.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(13, 128);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(113, 126);
            this.numericUpDownCantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownCantidad.TabIndex = 5;
            // 
            // lblLambda
            // 
            this.lblLambda.AutoSize = true;
            this.lblLambda.Location = new System.Drawing.Point(17, 190);
            this.lblLambda.Name = "lblLambda";
            this.lblLambda.Size = new System.Drawing.Size(67, 20);
            this.lblLambda.TabIndex = 6;
            this.lblLambda.Text = "Lambda";
            // 
            // numericUpDownLambda
            // 
            this.numericUpDownLambda.Location = new System.Drawing.Point(113, 190);
            this.numericUpDownLambda.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownLambda.Name = "numericUpDownLambda";
            this.numericUpDownLambda.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownLambda.TabIndex = 7;
            this.numericUpDownLambda.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(17, 236);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(52, 20);
            this.lblMedia.TabIndex = 8;
            this.lblMedia.Text = "Media";
            // 
            // numericUpDownMedia
            // 
            this.numericUpDownMedia.Location = new System.Drawing.Point(113, 236);
            this.numericUpDownMedia.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMedia.Name = "numericUpDownMedia";
            this.numericUpDownMedia.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownMedia.TabIndex = 9;
            // 
            // numericUpDownDesviacion
            // 
            this.numericUpDownDesviacion.Location = new System.Drawing.Point(113, 298);
            this.numericUpDownDesviacion.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDesviacion.Name = "numericUpDownDesviacion";
            this.numericUpDownDesviacion.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownDesviacion.TabIndex = 10;
            this.numericUpDownDesviacion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDesviacion
            // 
            this.lblDesviacion.AutoSize = true;
            this.lblDesviacion.Location = new System.Drawing.Point(17, 303);
            this.lblDesviacion.Name = "lblDesviacion";
            this.lblDesviacion.Size = new System.Drawing.Size(86, 20);
            this.lblDesviacion.TabIndex = 11;
            this.lblDesviacion.Text = "Desviacion";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(21, 357);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(20, 20);
            this.lblA.TabIndex = 12;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(21, 406);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(20, 20);
            this.lblB.TabIndex = 13;
            this.lblB.Text = "B";
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(113, 350);
            this.numericUpDownA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownA.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownA.TabIndex = 14;
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(113, 406);
            this.numericUpDownB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownB.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownB.TabIndex = 15;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(30, 487);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(113, 41);
            this.btnGenerar.TabIndex = 16;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvNumerosRandom
            // 
            this.dgvNumerosRandom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumerosRandom.Location = new System.Drawing.Point(309, 55);
            this.dgvNumerosRandom.Name = "dgvNumerosRandom";
            this.dgvNumerosRandom.RowHeadersWidth = 62;
            this.dgvNumerosRandom.RowTemplate.Height = 28;
            this.dgvNumerosRandom.Size = new System.Drawing.Size(622, 322);
            this.dgvNumerosRandom.TabIndex = 17;
            // 
            // dgvTablaDeFrecuencias
            // 
            this.dgvTablaDeFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaDeFrecuencias.Location = new System.Drawing.Point(995, 55);
            this.dgvTablaDeFrecuencias.Name = "dgvTablaDeFrecuencias";
            this.dgvTablaDeFrecuencias.RowHeadersWidth = 62;
            this.dgvTablaDeFrecuencias.RowTemplate.Height = 28;
            this.dgvTablaDeFrecuencias.Size = new System.Drawing.Size(800, 322);
            this.dgvTablaDeFrecuencias.TabIndex = 18;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(369, 427);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1024, 531);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // btnGenerarExcel
            // 
            this.btnGenerarExcel.Location = new System.Drawing.Point(1525, 406);
            this.btnGenerarExcel.Name = "btnGenerarExcel";
            this.btnGenerarExcel.Size = new System.Drawing.Size(219, 48);
            this.btnGenerarExcel.TabIndex = 20;
            this.btnGenerarExcel.Text = "generar excel";
            this.btnGenerarExcel.UseVisualStyleBackColor = true;
            this.btnGenerarExcel.Click += new System.EventHandler(this.btnGenerarExcel_Click);
            // 
            // lblTablaNumerosAleatorios
            // 
            this.lblTablaNumerosAleatorios.AutoSize = true;
            this.lblTablaNumerosAleatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablaNumerosAleatorios.Location = new System.Drawing.Point(447, 13);
            this.lblTablaNumerosAleatorios.Name = "lblTablaNumerosAleatorios";
            this.lblTablaNumerosAleatorios.Size = new System.Drawing.Size(359, 32);
            this.lblTablaNumerosAleatorios.TabIndex = 21;
            this.lblTablaNumerosAleatorios.Text = "Tabla números aleatorios";
            // 
            // lblTablaDeFrecuencias
            // 
            this.lblTablaDeFrecuencias.AutoSize = true;
            this.lblTablaDeFrecuencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablaDeFrecuencias.Location = new System.Drawing.Point(1233, 13);
            this.lblTablaDeFrecuencias.Name = "lblTablaDeFrecuencias";
            this.lblTablaDeFrecuencias.Size = new System.Drawing.Size(298, 32);
            this.lblTablaDeFrecuencias.TabIndex = 22;
            this.lblTablaDeFrecuencias.Text = "Tabla de frecuencias";
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafico.Location = new System.Drawing.Point(843, 384);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(113, 32);
            this.lblGrafico.TabIndex = 23;
            this.lblGrafico.Text = "Gráfico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 963);
            this.Controls.Add(this.lblGrafico);
            this.Controls.Add(this.lblTablaDeFrecuencias);
            this.Controls.Add(this.lblTablaNumerosAleatorios);
            this.Controls.Add(this.btnGenerarExcel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvTablaDeFrecuencias);
            this.Controls.Add(this.dgvNumerosRandom);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblDesviacion);
            this.Controls.Add(this.numericUpDownDesviacion);
            this.Controls.Add(this.numericUpDownMedia);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.numericUpDownLambda);
            this.Controls.Add(this.lblLambda);
            this.Controls.Add(this.numericUpDownCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbIntervalos);
            this.Controls.Add(this.lblIntervalos);
            this.Controls.Add(this.cmbDistribucion);
            this.Controls.Add(this.lblDistribucion);
            this.Name = "Form1";
            this.Text = "Tp Nº2 Grupo2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesviacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerosRandom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDeFrecuencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDistribucion;
        private System.Windows.Forms.ComboBox cmbDistribucion;
        private System.Windows.Forms.Label lblIntervalos;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Label lblLambda;
        private System.Windows.Forms.NumericUpDown numericUpDownLambda;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.NumericUpDown numericUpDownMedia;
        private System.Windows.Forms.NumericUpDown numericUpDownDesviacion;
        private System.Windows.Forms.Label lblDesviacion;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvNumerosRandom;
        private System.Windows.Forms.DataGridView dgvTablaDeFrecuencias;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnGenerarExcel;
        private System.Windows.Forms.Label lblTablaNumerosAleatorios;
        private System.Windows.Forms.Label lblTablaDeFrecuencias;
        private System.Windows.Forms.Label lblGrafico;
    }
}

