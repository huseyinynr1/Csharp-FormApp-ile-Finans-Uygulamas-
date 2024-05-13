namespace Alıştırma
{
    partial class Altınİslemleri
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Altınİslemleri));
            this.textBoxHesapla = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAltınEkle = new System.Windows.Forms.Button();
            this.numericUpDownAltınAdet = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxToplamHesapla = new System.Windows.Forms.TextBox();
            this.btnToplamHesapla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownGramDeger = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCeyrekDeger = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYarimDeger = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCumAltınDeger = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonBackward = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltınAdet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGramDeger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCeyrekDeger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYarimDeger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCumAltınDeger)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxHesapla
            // 
            this.textBoxHesapla.Location = new System.Drawing.Point(685, 500);
            this.textBoxHesapla.Name = "textBoxHesapla";
            this.textBoxHesapla.Size = new System.Drawing.Size(120, 20);
            this.textBoxHesapla.TabIndex = 67;
            // 
            // btnHesapla
            // 
            this.btnHesapla.AutoSize = true;
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(104)))));
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.Snow;
            this.btnHesapla.Location = new System.Drawing.Point(613, 533);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(149, 41);
            this.btnHesapla.TabIndex = 66;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(104)))));
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(300, 500);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 20);
            this.label18.TabIndex = 65;
            this.label18.Text = "Adedi";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.UseMnemonic = false;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(104)))));
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Cornsilk;
            this.label17.Location = new System.Drawing.Point(300, 460);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 20);
            this.label17.TabIndex = 64;
            this.label17.Text = "Türü";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label17.UseMnemonic = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(405, 460);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 63;
            // 
            // btnAltınEkle
            // 
            this.btnAltınEkle.AutoSize = true;
            this.btnAltınEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(104)))));
            this.btnAltınEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAltınEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAltınEkle.ForeColor = System.Drawing.Color.Snow;
            this.btnAltınEkle.Location = new System.Drawing.Point(333, 533);
            this.btnAltınEkle.Name = "btnAltınEkle";
            this.btnAltınEkle.Size = new System.Drawing.Size(149, 41);
            this.btnAltınEkle.TabIndex = 61;
            this.btnAltınEkle.Text = "Ekle";
            this.btnAltınEkle.UseVisualStyleBackColor = false;
            this.btnAltınEkle.Click += new System.EventHandler(this.btnAltınEkle_Click);
            // 
            // numericUpDownAltınAdet
            // 
            this.numericUpDownAltınAdet.Location = new System.Drawing.Point(405, 500);
            this.numericUpDownAltınAdet.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDownAltınAdet.Name = "numericUpDownAltınAdet";
            this.numericUpDownAltınAdet.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAltınAdet.TabIndex = 60;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(685, 462);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(104)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(613, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Altın Değeri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(104)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(567, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Türü";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(104)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(567, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Değer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(90)))));
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(25, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 317);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Altın Miktarı";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 30);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Miktar";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1008, 287);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(104)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.label4.Location = new System.Drawing.Point(873, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "Toplam Altın Değeri";
            // 
            // textBoxToplamHesapla
            // 
            this.textBoxToplamHesapla.Location = new System.Drawing.Point(903, 480);
            this.textBoxToplamHesapla.Name = "textBoxToplamHesapla";
            this.textBoxToplamHesapla.Size = new System.Drawing.Size(120, 20);
            this.textBoxToplamHesapla.TabIndex = 74;
            // 
            // btnToplamHesapla
            // 
            this.btnToplamHesapla.AutoSize = true;
            this.btnToplamHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(104)))));
            this.btnToplamHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToplamHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToplamHesapla.ForeColor = System.Drawing.Color.Snow;
            this.btnToplamHesapla.Location = new System.Drawing.Point(893, 533);
            this.btnToplamHesapla.Name = "btnToplamHesapla";
            this.btnToplamHesapla.Size = new System.Drawing.Size(149, 41);
            this.btnToplamHesapla.TabIndex = 75;
            this.btnToplamHesapla.Text = "Hesapla";
            this.btnToplamHesapla.UseVisualStyleBackColor = false;
            this.btnToplamHesapla.Click += new System.EventHandler(this.btnToplamHesapla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(104)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.label5.Location = new System.Drawing.Point(20, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 25);
            this.label5.TabIndex = 76;
            this.label5.Text = "Güncel Altın Fiyatları";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(104)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(24, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Gram Altın";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.UseMnemonic = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(104)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(24, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 78;
            this.label7.Text = "Tam Altın";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.UseMnemonic = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(104)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Cornsilk;
            this.label8.Location = new System.Drawing.Point(24, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 79;
            this.label8.Text = "Yarım Altın";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.UseMnemonic = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(104)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Cornsilk;
            this.label9.Location = new System.Drawing.Point(24, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 80;
            this.label9.Text = "Çeyrek Altın";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.UseMnemonic = false;
            // 
            // numericUpDownGramDeger
            // 
            this.numericUpDownGramDeger.Location = new System.Drawing.Point(128, 460);
            this.numericUpDownGramDeger.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDownGramDeger.Name = "numericUpDownGramDeger";
            this.numericUpDownGramDeger.Size = new System.Drawing.Size(93, 20);
            this.numericUpDownGramDeger.TabIndex = 81;
            // 
            // numericUpDownCeyrekDeger
            // 
            this.numericUpDownCeyrekDeger.Location = new System.Drawing.Point(129, 500);
            this.numericUpDownCeyrekDeger.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDownCeyrekDeger.Name = "numericUpDownCeyrekDeger";
            this.numericUpDownCeyrekDeger.Size = new System.Drawing.Size(93, 20);
            this.numericUpDownCeyrekDeger.TabIndex = 82;
            // 
            // numericUpDownYarimDeger
            // 
            this.numericUpDownYarimDeger.Location = new System.Drawing.Point(128, 540);
            this.numericUpDownYarimDeger.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDownYarimDeger.Name = "numericUpDownYarimDeger";
            this.numericUpDownYarimDeger.Size = new System.Drawing.Size(93, 20);
            this.numericUpDownYarimDeger.TabIndex = 83;
            // 
            // numericUpDownCumAltınDeger
            // 
            this.numericUpDownCumAltınDeger.Location = new System.Drawing.Point(129, 580);
            this.numericUpDownCumAltınDeger.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDownCumAltınDeger.Name = "numericUpDownCumAltınDeger";
            this.numericUpDownCumAltınDeger.Size = new System.Drawing.Size(93, 20);
            this.numericUpDownCumAltınDeger.TabIndex = 84;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonBackward,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1105, 25);
            this.toolStrip1.TabIndex = 85;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonBackward
            // 
            this.buttonBackward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonBackward.Image = global::Alıştırma.Properties.Resources._8666655_arrow_left_circle_icon;
            this.buttonBackward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(23, 22);
            this.buttonBackward.Text = "Geri";
            this.buttonBackward.Click += new System.EventHandler(this.buttonBackward_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Alıştırma.Properties.Resources._8666670_arrow_right_circle_icon;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "İleri";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(104)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.label10.Location = new System.Drawing.Point(333, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 25);
            this.label10.TabIndex = 86;
            this.label10.Text = "Altın Ekle";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Altınİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alıştırma.Properties.Resources.gold_bullion_999_gold_1_kilogram_of_gold_gold;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 609);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.numericUpDownCumAltınDeger);
            this.Controls.Add(this.numericUpDownYarimDeger);
            this.Controls.Add(this.numericUpDownCeyrekDeger);
            this.Controls.Add(this.numericUpDownGramDeger);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnToplamHesapla);
            this.Controls.Add(this.textBoxToplamHesapla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBoxHesapla);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAltınEkle);
            this.Controls.Add(this.numericUpDownAltınAdet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Altınİslemleri";
            this.Text = "Altın İslemleri";
            this.Load += new System.EventHandler(this.Altınİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltınAdet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGramDeger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCeyrekDeger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYarimDeger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCumAltınDeger)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxHesapla;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAltınEkle;
        private System.Windows.Forms.NumericUpDown numericUpDownAltınAdet;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxToplamHesapla;
        private System.Windows.Forms.Button btnToplamHesapla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownGramDeger;
        private System.Windows.Forms.NumericUpDown numericUpDownCeyrekDeger;
        private System.Windows.Forms.NumericUpDown numericUpDownYarimDeger;
        private System.Windows.Forms.NumericUpDown numericUpDownCumAltınDeger;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonBackward;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label10;
    }
}