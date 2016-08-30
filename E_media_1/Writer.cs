using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_media_1
{
    class Writer
    {
        private byte[] DataArray { get; set; }
        private byte[] HeaderArray { get; set; }

        public Writer(byte[] dataArray, byte[] headerArray)
        {
            this.DataArray = dataArray;
            this.HeaderArray = headerArray;
        }

        public void WriteData(string pathDestination)
        {
            using (FileStream fs = new FileStream(pathDestination, FileMode.Create, FileAccess.Write))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(this.HeaderArray);
                bw.Write(this.DataArray);
            }
        }
    }
}
