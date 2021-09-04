
namespace SpeedTestMonitor
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnStartMonitor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHour = new System.Windows.Forms.NumericUpDown();
            this.txtMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblAmoutTests = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpload = new System.Windows.Forms.NumericUpDown();
            this.txtDownload = new System.Windows.Forms.NumericUpDown();
            this.chbUpload = new System.Windows.Forms.CheckBox();
            this.chbDownload = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbStartup = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinutes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDownload)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartMonitor
            // 
            this.btnStartMonitor.Location = new System.Drawing.Point(11, 58);
            this.btnStartMonitor.Name = "btnStartMonitor";
            this.btnStartMonitor.Size = new System.Drawing.Size(132, 23);
            this.btnStartMonitor.TabIndex = 0;
            this.btnStartMonitor.Text = "Iniciar Monitoramento";
            this.btnStartMonitor.UseVisualStyleBackColor = true;
            this.btnStartMonitor.Click += new System.EventHandler(this.btnStartMonitor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minutos";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(381, 51);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(210, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Não está fazendo SpeedTest no momento.";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 162);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Download";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Purple;
            series2.Legend = "Legend1";
            series2.Name = "Upload";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(574, 300);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultados aparecem no gráfico a partir do segundo teste.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHour);
            this.groupBox1.Controls.Add(this.txtMinutes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnStartMonitor);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intervalo entre Monitoramento";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(11, 32);
            this.txtHour.Maximum = new decimal(new int[] {
            168,
            0,
            0,
            0});
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(50, 20);
            this.txtHour.TabIndex = 15;
            this.txtHour.ValueChanged += new System.EventHandler(this.txtHour_ValueChanged);
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(67, 33);
            this.txtMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(48, 20);
            this.txtMinutes.TabIndex = 14;
            this.txtMinutes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtMinutes.ValueChanged += new System.EventHandler(this.txtMinutes_ValueChanged);
            // 
            // lblAmoutTests
            // 
            this.lblAmoutTests.AutoSize = true;
            this.lblAmoutTests.Location = new System.Drawing.Point(381, 28);
            this.lblAmoutTests.Name = "lblAmoutTests";
            this.lblAmoutTests.Size = new System.Drawing.Size(106, 13);
            this.lblAmoutTests.TabIndex = 9;
            this.lblAmoutTests.Text = "Testes Realizados: 0";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "SpeedTestMonitor";
            this.notifyIcon.Visible = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(514, 133);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "Sobre";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtUpload);
            this.groupBox2.Controls.Add(this.txtDownload);
            this.groupBox2.Controls.Add(this.chbUpload);
            this.groupBox2.Controls.Add(this.chbDownload);
            this.groupBox2.Location = new System.Drawing.Point(192, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 114);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notificações";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mbps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mbps";
            // 
            // txtUpload
            // 
            this.txtUpload.Enabled = false;
            this.txtUpload.Location = new System.Drawing.Point(6, 87);
            this.txtUpload.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtUpload.Name = "txtUpload";
            this.txtUpload.Size = new System.Drawing.Size(107, 20);
            this.txtUpload.TabIndex = 13;
            this.txtUpload.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtDownload
            // 
            this.txtDownload.Enabled = false;
            this.txtDownload.Location = new System.Drawing.Point(6, 42);
            this.txtDownload.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtDownload.Name = "txtDownload";
            this.txtDownload.Size = new System.Drawing.Size(107, 20);
            this.txtDownload.TabIndex = 12;
            this.txtDownload.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chbUpload
            // 
            this.chbUpload.AutoSize = true;
            this.chbUpload.Location = new System.Drawing.Point(6, 64);
            this.chbUpload.Name = "chbUpload";
            this.chbUpload.Size = new System.Drawing.Size(157, 17);
            this.chbUpload.TabIndex = 1;
            this.chbUpload.Text = "Notificar Upload Abaixo De:";
            this.chbUpload.UseVisualStyleBackColor = true;
            this.chbUpload.CheckedChanged += new System.EventHandler(this.chbUpload_CheckedChanged);
            // 
            // chbDownload
            // 
            this.chbDownload.AutoSize = true;
            this.chbDownload.Location = new System.Drawing.Point(6, 19);
            this.chbDownload.Name = "chbDownload";
            this.chbDownload.Size = new System.Drawing.Size(171, 17);
            this.chbDownload.TabIndex = 0;
            this.chbDownload.Text = "Notificar Download Abaixo De:";
            this.chbDownload.UseVisualStyleBackColor = true;
            this.chbDownload.CheckedChanged += new System.EventHandler(this.chbDownload_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbStartup);
            this.groupBox3.Location = new System.Drawing.Point(384, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 44);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Iniciar com o Sistema";
            // 
            // chbStartup
            // 
            this.chbStartup.AutoSize = true;
            this.chbStartup.Location = new System.Drawing.Point(79, 19);
            this.chbStartup.Name = "chbStartup";
            this.chbStartup.Size = new System.Drawing.Size(15, 14);
            this.chbStartup.TabIndex = 13;
            this.chbStartup.UseVisualStyleBackColor = true;
            this.chbStartup.CheckedChanged += new System.EventHandler(this.chbStartup_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 475);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblAmoutTests);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpeedTestMonitor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinutes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDownload)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartMonitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAmoutTests;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbDownload;
        private System.Windows.Forms.CheckBox chbUpload;
        private System.Windows.Forms.NumericUpDown txtHour;
        private System.Windows.Forms.NumericUpDown txtMinutes;
        private System.Windows.Forms.NumericUpDown txtUpload;
        private System.Windows.Forms.NumericUpDown txtDownload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chbStartup;
    }
}

