namespace E_media_1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Wybierz_pllik = new System.Windows.Forms.Button();
            this.ChartFFT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Format_danych = new System.Windows.Forms.TextBox();
            this.Format_danych_odp = new System.Windows.Forms.TextBox();
            this.Rozmiar_pliku = new System.Windows.Forms.TextBox();
            this.Rozmiar_pliku_odp = new System.Windows.Forms.TextBox();
            this.Czestotliwosc_probkowania = new System.Windows.Forms.TextBox();
            this.Czestotliwosc_probkowania_odp = new System.Windows.Forms.TextBox();
            this.zakoduj_i_zapisz = new System.Windows.Forms.Button();
            this.odkoduj_i_zapisz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFFT)).BeginInit();
            this.SuspendLayout();
            // 
            // Wybierz_pllik
            // 
            this.Wybierz_pllik.Location = new System.Drawing.Point(27, 12);
            this.Wybierz_pllik.Name = "Wybierz_pllik";
            this.Wybierz_pllik.Size = new System.Drawing.Size(135, 23);
            this.Wybierz_pllik.TabIndex = 0;
            this.Wybierz_pllik.Text = "WYBIERZ PLIK";
            this.Wybierz_pllik.UseVisualStyleBackColor = true;
            this.Wybierz_pllik.Click += new System.EventHandler(this.Wybierz_pllik_Click);
            // 
            // ChartFFT
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartFFT.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartFFT.Legends.Add(legend2);
            this.ChartFFT.Location = new System.Drawing.Point(27, 132);
            this.ChartFFT.Name = "ChartFFT";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "SeriesFFT";
            this.ChartFFT.Series.Add(series2);
            this.ChartFFT.Size = new System.Drawing.Size(847, 300);
            this.ChartFFT.TabIndex = 1;
            this.ChartFFT.Text = "ChartFFT";
            this.ChartFFT.Click += new System.EventHandler(this.ChartFFT_Click);
            // 
            // Format_danych
            // 
            this.Format_danych.Location = new System.Drawing.Point(27, 52);
            this.Format_danych.Name = "Format_danych";
            this.Format_danych.ReadOnly = true;
            this.Format_danych.Size = new System.Drawing.Size(135, 20);
            this.Format_danych.TabIndex = 2;
            this.Format_danych.Text = "FORMAT DANYCH";
            this.Format_danych.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Format_danych_odp
            // 
            this.Format_danych_odp.Location = new System.Drawing.Point(168, 52);
            this.Format_danych_odp.Name = "Format_danych_odp";
            this.Format_danych_odp.ReadOnly = true;
            this.Format_danych_odp.Size = new System.Drawing.Size(126, 20);
            this.Format_danych_odp.TabIndex = 3;
            this.Format_danych_odp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rozmiar_pliku
            // 
            this.Rozmiar_pliku.Location = new System.Drawing.Point(27, 79);
            this.Rozmiar_pliku.Name = "Rozmiar_pliku";
            this.Rozmiar_pliku.ReadOnly = true;
            this.Rozmiar_pliku.Size = new System.Drawing.Size(135, 20);
            this.Rozmiar_pliku.TabIndex = 4;
            this.Rozmiar_pliku.Text = "ROZMIAR PLIKU";
            this.Rozmiar_pliku.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rozmiar_pliku_odp
            // 
            this.Rozmiar_pliku_odp.Location = new System.Drawing.Point(168, 79);
            this.Rozmiar_pliku_odp.Name = "Rozmiar_pliku_odp";
            this.Rozmiar_pliku_odp.ReadOnly = true;
            this.Rozmiar_pliku_odp.Size = new System.Drawing.Size(126, 20);
            this.Rozmiar_pliku_odp.TabIndex = 5;
            this.Rozmiar_pliku_odp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Czestotliwosc_probkowania
            // 
            this.Czestotliwosc_probkowania.Location = new System.Drawing.Point(27, 106);
            this.Czestotliwosc_probkowania.Name = "Czestotliwosc_probkowania";
            this.Czestotliwosc_probkowania.ReadOnly = true;
            this.Czestotliwosc_probkowania.Size = new System.Drawing.Size(186, 20);
            this.Czestotliwosc_probkowania.TabIndex = 6;
            this.Czestotliwosc_probkowania.Text = "CZĘSTOTLIWOŚĆ PRÓBKOWANIA";
            this.Czestotliwosc_probkowania.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Czestotliwosc_probkowania_odp
            // 
            this.Czestotliwosc_probkowania_odp.Location = new System.Drawing.Point(219, 106);
            this.Czestotliwosc_probkowania_odp.Name = "Czestotliwosc_probkowania_odp";
            this.Czestotliwosc_probkowania_odp.ReadOnly = true;
            this.Czestotliwosc_probkowania_odp.Size = new System.Drawing.Size(75, 20);
            this.Czestotliwosc_probkowania_odp.TabIndex = 7;
            this.Czestotliwosc_probkowania_odp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zakoduj_i_zapisz
            // 
            this.zakoduj_i_zapisz.Location = new System.Drawing.Point(168, 12);
            this.zakoduj_i_zapisz.Name = "zakoduj_i_zapisz";
            this.zakoduj_i_zapisz.Size = new System.Drawing.Size(130, 23);
            this.zakoduj_i_zapisz.TabIndex = 8;
            this.zakoduj_i_zapisz.Text = "ZAKODUJ I ZAPISZ";
            this.zakoduj_i_zapisz.UseVisualStyleBackColor = true;
            this.zakoduj_i_zapisz.Click += new System.EventHandler(this.zakoduj_i_zapisz_Click);
            // 
            // odkoduj_i_zapisz
            // 
            this.odkoduj_i_zapisz.Location = new System.Drawing.Point(304, 12);
            this.odkoduj_i_zapisz.Name = "odkoduj_i_zapisz";
            this.odkoduj_i_zapisz.Size = new System.Drawing.Size(126, 23);
            this.odkoduj_i_zapisz.TabIndex = 9;
            this.odkoduj_i_zapisz.Text = "ODKODUJ I ZAPISZ";
            this.odkoduj_i_zapisz.UseVisualStyleBackColor = true;
            this.odkoduj_i_zapisz.Click += new System.EventHandler(this.odkoduj_i_zapisz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 441);
            this.Controls.Add(this.odkoduj_i_zapisz);
            this.Controls.Add(this.zakoduj_i_zapisz);
            this.Controls.Add(this.Czestotliwosc_probkowania_odp);
            this.Controls.Add(this.Czestotliwosc_probkowania);
            this.Controls.Add(this.Rozmiar_pliku_odp);
            this.Controls.Add(this.Rozmiar_pliku);
            this.Controls.Add(this.Format_danych_odp);
            this.Controls.Add(this.Format_danych);
            this.Controls.Add(this.ChartFFT);
            this.Controls.Add(this.Wybierz_pllik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartFFT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Wybierz_pllik;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFFT;
        private System.Windows.Forms.TextBox Format_danych;
        private System.Windows.Forms.TextBox Format_danych_odp;
        private System.Windows.Forms.TextBox Rozmiar_pliku;
        private System.Windows.Forms.TextBox Rozmiar_pliku_odp;
        private System.Windows.Forms.TextBox Czestotliwosc_probkowania;
        private System.Windows.Forms.TextBox Czestotliwosc_probkowania_odp;
        private System.Windows.Forms.Button zakoduj_i_zapisz;
        private System.Windows.Forms.Button odkoduj_i_zapisz;

    }
}

