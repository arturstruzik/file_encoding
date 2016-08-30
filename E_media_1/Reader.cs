using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace E_media_1
{
    public class Reader
    {
        public string Format { get; private set; } // format
        public int ChunkSize { get; private set; } //size of file
        public int NumChannels { get; private set; } //ilość kanałów
        public int SampleRate { get; private set; } //czestotliwosc probkowania
        public int BitsPerSample { get; private set; } //ilosc bitwow na probke

        public byte[] DataArray { get; private set; }
        public byte[] HeaderArray { get; private set; }

        public static string HexToAscii(string hexString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hexString.Length; i += 2)
            {
                string hs = hexString.Substring(i, 2);
                sb.Insert(0, Convert.ToString(Convert.ToChar(Int32.Parse(hs, System.Globalization.NumberStyles.HexNumber))));
            }

            return sb.ToString();
        }

        public void ReadData(string pathSouce)
        {
            byte[] dataArray;
            using (FileStream fsSource = new FileStream(pathSouce, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(fsSource))
                {
                    int chunkID = reader.ReadInt32();
                    int chunkSize = reader.ReadInt32();
                    int format = reader.ReadInt32();
                    int fmtID = reader.ReadInt32();
                    int fmtSize = reader.ReadInt32();
                    int audioFormat = reader.ReadInt16();
                    int numChannels = reader.ReadInt16();
                    int sampleRate = reader.ReadInt32();
                    int byteRate = reader.ReadInt32();
                    int fmtBlockAlign = reader.ReadInt16();
                    int bitsPerSample = reader.ReadInt16();
                    int dataSubchunkID = reader.ReadInt32();
                    int dataSize = reader.ReadInt32();
                    dataArray = reader.ReadBytes(dataSize);

                    this.ChunkSize = chunkSize + 8;
                    this.Format = HexToAscii(format.ToString("X"));
                    this.NumChannels = numChannels;
                    this.SampleRate = sampleRate;
                    this.BitsPerSample = bitsPerSample;
                    this.DataArray = dataArray;
                }
            }

            using (FileStream fsSource = new FileStream(pathSouce, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader headerReader = new BinaryReader(fsSource))
                {
                    this.HeaderArray = headerReader.ReadBytes(44);
                }
            }

            //#####################################################
            // JEST PIĘKNIE :D
            //#####################################################
        }
    }
}
