﻿
namespace GUI
{
    partial class Photoshop
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series46 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series47 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series48 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series49 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series50 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series51 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series52 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series53 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series54 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_suma = new System.Windows.Forms.Button();
            this.button_odejmowanie = new System.Windows.Forms.Button();
            this.button_różnica = new System.Windows.Forms.Button();
            this.button_mnozenie = new System.Windows.Forms.Button();
            this.button_mn_odw = new System.Windows.Forms.Button();
            this.button_negacja = new System.Windows.Forms.Button();
            this.button_ciemniejsze = new System.Windows.Forms.Button();
            this.button_jasniejsze = new System.Windows.Forms.Button();
            this.button_wylaczenie = new System.Windows.Forms.Button();
            this.button_nakladka = new System.Windows.Forms.Button();
            this.button_ost_sw = new System.Windows.Forms.Button();
            this.button_lag_sw = new System.Windows.Forms.Button();
            this.button_rozcienczenie = new System.Windows.Forms.Button();
            this.button_wypalanie = new System.Windows.Forms.Button();
            this.button_reflect = new System.Windows.Forms.Button();
            this.button_przezroczystosc = new System.Windows.Forms.Button();
            this.pictureBox_zdj_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_zdj_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_wynik = new System.Windows.Forms.PictureBox();
            this.numericUpDown_przezroczystoc = new System.Windows.Forms.NumericUpDown();
            this.Czyszczenie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_negatyw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar_jasnosc = new System.Windows.Forms.TrackBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.button_histogram = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zdj_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zdj_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_wynik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_przezroczystoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_jasnosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_suma
            // 
            this.button_suma.Location = new System.Drawing.Point(13, 13);
            this.button_suma.Name = "button_suma";
            this.button_suma.Size = new System.Drawing.Size(126, 23);
            this.button_suma.TabIndex = 0;
            this.button_suma.Text = "Suma";
            this.button_suma.UseVisualStyleBackColor = true;
            this.button_suma.Click += new System.EventHandler(this.suma_click);
            // 
            // button_odejmowanie
            // 
            this.button_odejmowanie.Location = new System.Drawing.Point(13, 43);
            this.button_odejmowanie.Name = "button_odejmowanie";
            this.button_odejmowanie.Size = new System.Drawing.Size(126, 23);
            this.button_odejmowanie.TabIndex = 1;
            this.button_odejmowanie.Text = "Odejmowanie";
            this.button_odejmowanie.UseVisualStyleBackColor = true;
            // 
            // button_różnica
            // 
            this.button_różnica.Location = new System.Drawing.Point(13, 73);
            this.button_różnica.Name = "button_różnica";
            this.button_różnica.Size = new System.Drawing.Size(126, 23);
            this.button_różnica.TabIndex = 2;
            this.button_różnica.Text = "Różnica";
            this.button_różnica.UseVisualStyleBackColor = true;
            this.button_różnica.Click += new System.EventHandler(this.roznica_click);
            // 
            // button_mnozenie
            // 
            this.button_mnozenie.Location = new System.Drawing.Point(13, 103);
            this.button_mnozenie.Name = "button_mnozenie";
            this.button_mnozenie.Size = new System.Drawing.Size(126, 23);
            this.button_mnozenie.TabIndex = 3;
            this.button_mnozenie.Text = "Mnożenie";
            this.button_mnozenie.UseVisualStyleBackColor = true;
            this.button_mnozenie.Click += new System.EventHandler(this.mnozenie_click);
            // 
            // button_mn_odw
            // 
            this.button_mn_odw.Location = new System.Drawing.Point(13, 133);
            this.button_mn_odw.Name = "button_mn_odw";
            this.button_mn_odw.Size = new System.Drawing.Size(126, 23);
            this.button_mn_odw.TabIndex = 4;
            this.button_mn_odw.Text = "Mnożenie Odwrotności";
            this.button_mn_odw.UseVisualStyleBackColor = true;
            this.button_mn_odw.Click += new System.EventHandler(this.mn_odw_click);
            // 
            // button_negacja
            // 
            this.button_negacja.Location = new System.Drawing.Point(13, 163);
            this.button_negacja.Name = "button_negacja";
            this.button_negacja.Size = new System.Drawing.Size(126, 23);
            this.button_negacja.TabIndex = 5;
            this.button_negacja.Text = "Negacja";
            this.button_negacja.UseVisualStyleBackColor = true;
            this.button_negacja.Click += new System.EventHandler(this.negacja_click);
            // 
            // button_ciemniejsze
            // 
            this.button_ciemniejsze.Location = new System.Drawing.Point(13, 193);
            this.button_ciemniejsze.Name = "button_ciemniejsze";
            this.button_ciemniejsze.Size = new System.Drawing.Size(126, 23);
            this.button_ciemniejsze.TabIndex = 6;
            this.button_ciemniejsze.Text = "Ciemniejsze";
            this.button_ciemniejsze.UseVisualStyleBackColor = true;
            this.button_ciemniejsze.Click += new System.EventHandler(this.ciemniejsze_click);
            // 
            // button_jasniejsze
            // 
            this.button_jasniejsze.Location = new System.Drawing.Point(13, 223);
            this.button_jasniejsze.Name = "button_jasniejsze";
            this.button_jasniejsze.Size = new System.Drawing.Size(126, 23);
            this.button_jasniejsze.TabIndex = 7;
            this.button_jasniejsze.Text = "Jaśniejsze";
            this.button_jasniejsze.UseVisualStyleBackColor = true;
            this.button_jasniejsze.Click += new System.EventHandler(this.jasniejsze_click);
            // 
            // button_wylaczenie
            // 
            this.button_wylaczenie.Location = new System.Drawing.Point(13, 254);
            this.button_wylaczenie.Name = "button_wylaczenie";
            this.button_wylaczenie.Size = new System.Drawing.Size(126, 23);
            this.button_wylaczenie.TabIndex = 8;
            this.button_wylaczenie.Text = "Wyłączenie";
            this.button_wylaczenie.UseVisualStyleBackColor = true;
            this.button_wylaczenie.Click += new System.EventHandler(this.wyl_click);
            // 
            // button_nakladka
            // 
            this.button_nakladka.Location = new System.Drawing.Point(13, 283);
            this.button_nakladka.Name = "button_nakladka";
            this.button_nakladka.Size = new System.Drawing.Size(126, 23);
            this.button_nakladka.TabIndex = 9;
            this.button_nakladka.Text = "Nakładka";
            this.button_nakladka.UseVisualStyleBackColor = true;
            this.button_nakladka.Click += new System.EventHandler(this.nakladka_click);
            // 
            // button_ost_sw
            // 
            this.button_ost_sw.Location = new System.Drawing.Point(13, 314);
            this.button_ost_sw.Name = "button_ost_sw";
            this.button_ost_sw.Size = new System.Drawing.Size(126, 23);
            this.button_ost_sw.TabIndex = 10;
            this.button_ost_sw.Text = "Ostre światło";
            this.button_ost_sw.UseVisualStyleBackColor = true;
            this.button_ost_sw.Click += new System.EventHandler(this.ostre_click);
            // 
            // button_lag_sw
            // 
            this.button_lag_sw.Location = new System.Drawing.Point(13, 343);
            this.button_lag_sw.Name = "button_lag_sw";
            this.button_lag_sw.Size = new System.Drawing.Size(126, 23);
            this.button_lag_sw.TabIndex = 11;
            this.button_lag_sw.Text = "Łagodne światło";
            this.button_lag_sw.UseVisualStyleBackColor = true;
            this.button_lag_sw.Click += new System.EventHandler(this.lagodne_click);
            // 
            // button_rozcienczenie
            // 
            this.button_rozcienczenie.Location = new System.Drawing.Point(13, 373);
            this.button_rozcienczenie.Name = "button_rozcienczenie";
            this.button_rozcienczenie.Size = new System.Drawing.Size(126, 23);
            this.button_rozcienczenie.TabIndex = 12;
            this.button_rozcienczenie.Text = "Rozcieńczenie";
            this.button_rozcienczenie.UseVisualStyleBackColor = true;
            this.button_rozcienczenie.Click += new System.EventHandler(this.rozcienczenie_click);
            // 
            // button_wypalanie
            // 
            this.button_wypalanie.Location = new System.Drawing.Point(13, 403);
            this.button_wypalanie.Name = "button_wypalanie";
            this.button_wypalanie.Size = new System.Drawing.Size(126, 23);
            this.button_wypalanie.TabIndex = 13;
            this.button_wypalanie.Text = "Wypalanie";
            this.button_wypalanie.UseVisualStyleBackColor = true;
            this.button_wypalanie.Click += new System.EventHandler(this.wypalanie_click);
            // 
            // button_reflect
            // 
            this.button_reflect.Location = new System.Drawing.Point(13, 433);
            this.button_reflect.Name = "button_reflect";
            this.button_reflect.Size = new System.Drawing.Size(126, 23);
            this.button_reflect.TabIndex = 14;
            this.button_reflect.Text = "Reflect mode";
            this.button_reflect.UseVisualStyleBackColor = true;
            this.button_reflect.Click += new System.EventHandler(this.reflect_click);
            // 
            // button_przezroczystosc
            // 
            this.button_przezroczystosc.Location = new System.Drawing.Point(13, 463);
            this.button_przezroczystosc.Name = "button_przezroczystosc";
            this.button_przezroczystosc.Size = new System.Drawing.Size(126, 23);
            this.button_przezroczystosc.TabIndex = 15;
            this.button_przezroczystosc.Text = "Przeźroczystość";
            this.button_przezroczystosc.UseVisualStyleBackColor = true;
            this.button_przezroczystosc.Click += new System.EventHandler(this.przezroczystosc_click);
            // 
            // pictureBox_zdj_1
            // 
            this.pictureBox_zdj_1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox_zdj_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_zdj_1.Image = global::GUI.Properties.Resources.floppy_disk;
            this.pictureBox_zdj_1.Location = new System.Drawing.Point(193, 13);
            this.pictureBox_zdj_1.Name = "pictureBox_zdj_1";
            this.pictureBox_zdj_1.Size = new System.Drawing.Size(230, 291);
            this.pictureBox_zdj_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_zdj_1.TabIndex = 16;
            this.pictureBox_zdj_1.TabStop = false;
            this.pictureBox_zdj_1.Click += new System.EventHandler(this.Picture_Box_click);
            // 
            // pictureBox_zdj_2
            // 
            this.pictureBox_zdj_2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox_zdj_2.Image = global::GUI.Properties.Resources.folder;
            this.pictureBox_zdj_2.Location = new System.Drawing.Point(457, 13);
            this.pictureBox_zdj_2.Name = "pictureBox_zdj_2";
            this.pictureBox_zdj_2.Size = new System.Drawing.Size(230, 293);
            this.pictureBox_zdj_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_zdj_2.TabIndex = 17;
            this.pictureBox_zdj_2.TabStop = false;
            this.pictureBox_zdj_2.Click += new System.EventHandler(this.PictureBox_click1);
            // 
            // pictureBox_wynik
            // 
            this.pictureBox_wynik.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox_wynik.Location = new System.Drawing.Point(718, 13);
            this.pictureBox_wynik.Name = "pictureBox_wynik";
            this.pictureBox_wynik.Size = new System.Drawing.Size(230, 293);
            this.pictureBox_wynik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_wynik.TabIndex = 18;
            this.pictureBox_wynik.TabStop = false;
            // 
            // numericUpDown_przezroczystoc
            // 
            this.numericUpDown_przezroczystoc.Location = new System.Drawing.Point(145, 463);
            this.numericUpDown_przezroczystoc.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_przezroczystoc.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numericUpDown_przezroczystoc.Name = "numericUpDown_przezroczystoc";
            this.numericUpDown_przezroczystoc.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_przezroczystoc.TabIndex = 19;
            this.numericUpDown_przezroczystoc.Scroll += new System.Windows.Forms.ScrollEventHandler(this.wartosc_prze);
            // 
            // Czyszczenie
            // 
            this.Czyszczenie.Location = new System.Drawing.Point(13, 521);
            this.Czyszczenie.Name = "Czyszczenie";
            this.Czyszczenie.Size = new System.Drawing.Size(126, 23);
            this.Czyszczenie.TabIndex = 20;
            this.Czyszczenie.Text = "Wyczysc";
            this.Czyszczenie.UseVisualStyleBackColor = true;
            this.Czyszczenie.Click += new System.EventHandler(this.Czyszenie_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Wynik";
            // 
            // button_negatyw
            // 
            this.button_negatyw.Location = new System.Drawing.Point(13, 492);
            this.button_negatyw.Name = "button_negatyw";
            this.button_negatyw.Size = new System.Drawing.Size(126, 23);
            this.button_negatyw.TabIndex = 22;
            this.button_negatyw.Text = "Negatyw";
            this.button_negatyw.UseVisualStyleBackColor = true;
            this.button_negatyw.Click += new System.EventHandler(this.Negatyw_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "JASNOSC: ";
            // 
            // trackBar_jasnosc
            // 
            this.trackBar_jasnosc.Location = new System.Drawing.Point(789, 343);
            this.trackBar_jasnosc.Maximum = 100;
            this.trackBar_jasnosc.Minimum = -100;
            this.trackBar_jasnosc.Name = "trackBar_jasnosc";
            this.trackBar_jasnosc.Size = new System.Drawing.Size(104, 45);
            this.trackBar_jasnosc.TabIndex = 24;
            this.trackBar_jasnosc.Scroll += new System.EventHandler(this.jasnosc_scroll);
            // 
            // chart1
            // 
            chartArea16.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.chart1.Legends.Add(legend16);
            this.chart1.Location = new System.Drawing.Point(183, 521);
            this.chart1.Name = "chart1";
            series46.BorderColor = System.Drawing.Color.Red;
            series46.ChartArea = "ChartArea1";
            series46.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series46.Color = System.Drawing.Color.Red;
            series46.Legend = "Legend1";
            series46.Name = "red";
            series47.BorderColor = System.Drawing.Color.Green;
            series47.ChartArea = "ChartArea1";
            series47.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series47.Color = System.Drawing.Color.Green;
            series47.Legend = "Legend1";
            series47.Name = "green";
            series48.BorderColor = System.Drawing.Color.Blue;
            series48.ChartArea = "ChartArea1";
            series48.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series48.Color = System.Drawing.Color.Blue;
            series48.Legend = "Legend1";
            series48.Name = "blue";
            this.chart1.Series.Add(series46);
            this.chart1.Series.Add(series47);
            this.chart1.Series.Add(series48);
            this.chart1.Size = new System.Drawing.Size(525, 100);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Histogram photo 1";
            // 
            // chart2
            // 
            chartArea17.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.chart2.Legends.Add(legend17);
            this.chart2.Location = new System.Drawing.Point(183, 630);
            this.chart2.Name = "chart2";
            series49.BorderColor = System.Drawing.Color.Red;
            series49.ChartArea = "ChartArea1";
            series49.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series49.Color = System.Drawing.Color.Red;
            series49.Legend = "Legend1";
            series49.Name = "red";
            series50.BorderColor = System.Drawing.Color.Green;
            series50.ChartArea = "ChartArea1";
            series50.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series50.Color = System.Drawing.Color.Green;
            series50.Legend = "Legend1";
            series50.Name = "green";
            series51.BorderColor = System.Drawing.Color.Blue;
            series51.ChartArea = "ChartArea1";
            series51.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series51.Color = System.Drawing.Color.Blue;
            series51.Legend = "Legend1";
            series51.Name = "blue";
            this.chart2.Series.Add(series49);
            this.chart2.Series.Add(series50);
            this.chart2.Series.Add(series51);
            this.chart2.Size = new System.Drawing.Size(525, 100);
            this.chart2.TabIndex = 26;
            this.chart2.Text = "chart2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 673);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Histogram photo 2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chart3
            // 
            chartArea18.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chart3.Legends.Add(legend18);
            this.chart3.Location = new System.Drawing.Point(183, 749);
            this.chart3.Name = "chart3";
            series52.BorderColor = System.Drawing.Color.Red;
            series52.ChartArea = "ChartArea1";
            series52.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series52.Color = System.Drawing.Color.Red;
            series52.Legend = "Legend1";
            series52.Name = "red";
            series53.BorderColor = System.Drawing.Color.Green;
            series53.ChartArea = "ChartArea1";
            series53.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series53.Color = System.Drawing.Color.Green;
            series53.Legend = "Legend1";
            series53.Name = "green";
            series54.BorderColor = System.Drawing.Color.Blue;
            series54.ChartArea = "ChartArea1";
            series54.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series54.Color = System.Drawing.Color.Blue;
            series54.Legend = "Legend1";
            series54.Name = "blue";
            this.chart3.Series.Add(series52);
            this.chart3.Series.Add(series53);
            this.chart3.Series.Add(series54);
            this.chart3.Size = new System.Drawing.Size(525, 100);
            this.chart3.TabIndex = 28;
            this.chart3.Text = "chart3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 796);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Histogram photo wyniku";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button_histogram
            // 
            this.button_histogram.Location = new System.Drawing.Point(789, 394);
            this.button_histogram.Name = "button_histogram";
            this.button_histogram.Size = new System.Drawing.Size(112, 23);
            this.button_histogram.TabIndex = 30;
            this.button_histogram.Text = "Generuj histogram";
            this.button_histogram.UseVisualStyleBackColor = true;
            this.button_histogram.Click += new System.EventHandler(this.Generuj_click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(319, 321);
            this.trackBar1.Maximum = 0;
            this.trackBar1.Minimum = -126;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 31;
            this.trackBar1.ValueChanged += new System.EventHandler(this.Scroll_value);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(319, 394);
            this.trackBar2.Maximum = 126;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 32;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Zmniejszenie kontrastu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Zwiekszenie kontrastu";
            // 
            // Photoshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 886);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button_histogram);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.trackBar_jasnosc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_negatyw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Czyszczenie);
            this.Controls.Add(this.numericUpDown_przezroczystoc);
            this.Controls.Add(this.pictureBox_wynik);
            this.Controls.Add(this.pictureBox_zdj_2);
            this.Controls.Add(this.pictureBox_zdj_1);
            this.Controls.Add(this.button_przezroczystosc);
            this.Controls.Add(this.button_reflect);
            this.Controls.Add(this.button_wypalanie);
            this.Controls.Add(this.button_rozcienczenie);
            this.Controls.Add(this.button_lag_sw);
            this.Controls.Add(this.button_ost_sw);
            this.Controls.Add(this.button_nakladka);
            this.Controls.Add(this.button_wylaczenie);
            this.Controls.Add(this.button_jasniejsze);
            this.Controls.Add(this.button_ciemniejsze);
            this.Controls.Add(this.button_negacja);
            this.Controls.Add(this.button_mn_odw);
            this.Controls.Add(this.button_mnozenie);
            this.Controls.Add(this.button_różnica);
            this.Controls.Add(this.button_odejmowanie);
            this.Controls.Add(this.button_suma);
            this.Name = "Photoshop";
            this.Text = "GUI by Szymon Kudrewicz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.odejmowanie_click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zdj_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zdj_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_wynik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_przezroczystoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_jasnosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_suma;
        private System.Windows.Forms.Button button_odejmowanie;
        private System.Windows.Forms.Button button_różnica;
        private System.Windows.Forms.Button button_mnozenie;
        private System.Windows.Forms.Button button_mn_odw;
        private System.Windows.Forms.Button button_negacja;
        private System.Windows.Forms.Button button_ciemniejsze;
        private System.Windows.Forms.Button button_jasniejsze;
        private System.Windows.Forms.Button button_wylaczenie;
        private System.Windows.Forms.Button button_nakladka;
        private System.Windows.Forms.Button button_ost_sw;
        private System.Windows.Forms.Button button_lag_sw;
        private System.Windows.Forms.Button button_rozcienczenie;
        private System.Windows.Forms.Button button_wypalanie;
        private System.Windows.Forms.Button button_reflect;
        private System.Windows.Forms.Button button_przezroczystosc;
        private System.Windows.Forms.PictureBox pictureBox_zdj_1;
        private System.Windows.Forms.PictureBox pictureBox_zdj_2;
        private System.Windows.Forms.PictureBox pictureBox_wynik;
        private System.Windows.Forms.NumericUpDown numericUpDown_przezroczystoc;
        private System.Windows.Forms.Button Czyszczenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_negatyw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar_jasnosc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_histogram;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

