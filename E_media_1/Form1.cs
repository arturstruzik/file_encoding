using Exocortex.DSP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_media_1
{
    public partial class Form1 : Form
    {
        private byte[] DataArray { get; set; }
        private byte[] EncryptedDataArray { get; set; }
        private byte[] CipherDataArray { get; set; }
        private byte[] HeaderArray { get; set; }
        private byte[] Key { get; set; }
        private byte[] IV { get; set; }

        public Form1()
        {
            InitializeComponent();
            ChartFFT.Legends.RemoveAt(0);
            ChartFFT.ChartAreas[0].AxisY.Title = "Moc";
            ChartFFT.ChartAreas[0].AxisX.Title = "Częstotliwość [Hz]";
            zakoduj_i_zapisz.Enabled = false;
            odkoduj_i_zapisz.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Wybierz_pllik_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    Reader reader = new Reader();
                    reader.ReadData(file);
                    Czestotliwosc_probkowania_odp.Text = reader.SampleRate.ToString() + " Hz";
                    Rozmiar_pliku_odp.Text = reader.ChunkSize.ToString() + " bytes";
                    Format_danych_odp.Text = reader.Format;

                    FourierTransform fourier = new FourierTransform(reader.DataArray);
                    for (int i = 0; i < fourier.FFTdata.Length; i=i+2 )
                    {
                        ChartFFT.Series["SeriesFFT"].Points.AddY(fourier.FFTdata[i]);
                    }

                    DataArray = reader.DataArray;
                    HeaderArray = reader.HeaderArray;
                    zakoduj_i_zapisz.Enabled = true;
                }
                catch (IOException)
                {
                }
            }
        }

        private void ChartFFT_Click(object sender, EventArgs e)
        {       
        }

        private void zakoduj_i_zapisz_Click(object sender, EventArgs e)
        {
            int size = -1;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = saveFileDialog1.FileName;
                try
                {
                    using (Aes myaes = Aes.Create())
                    {
                        this.Key = myaes.Key;
                        this.IV = myaes.IV;
                    }
                    this.EncryptedDataArray = Encrypt.Encrypt_Aes(this.DataArray, this.Key, this.IV);

                    Writer wr = new Writer(this.EncryptedDataArray, this.HeaderArray);
                    wr.WriteData(file);
                    odkoduj_i_zapisz.Enabled = true;
                }
                catch (IOException)
                {
                }
            }
        }

        private void odkoduj_i_zapisz_Click(object sender, EventArgs e)
        {
            int size = -1;
            SaveFileDialog saveFileDialog2 = new SaveFileDialog();
            DialogResult result = saveFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = saveFileDialog2.FileName;
                try
                {
                    this.CipherDataArray = Encrypt.Decrypt_Aes(this.EncryptedDataArray, this.Key, this.IV);
                    
                    Writer wr = new Writer(this.CipherDataArray, this.HeaderArray);
                    wr.WriteData(file);
                }
                catch (IOException)
                {
                }
            }
        }
    }
}
