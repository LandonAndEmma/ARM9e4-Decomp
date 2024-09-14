using LibEndianBinaryIO;
using System.IO;

namespace NewARM9
{
    public class ARM9
    {
        private ARM9.GameRegion GetGameRegion(EndianBinaryReaderEx er)
        {
            er.BaseStream.Position = 1493168L;
            ARM9.GameRegion result;
            if (er.ReadByte() == 141)
            {
                result = ARM9.GameRegion.European;
            }
            else
            {
                er.BaseStream.Position = 1496612L;
                if (er.ReadByte() == 141)
                {
                    result = ARM9.GameRegion.Japanese;
                }
                else
                {
                    result = ARM9.GameRegion.American;
                }
            }
            return result;
        }
        public ARM9(byte[] Data, string path)
        {
            this.path = path;
            EndianBinaryReaderEx endianBinaryReaderEx = new EndianBinaryReaderEx(new MemoryStream(Data), Endianness.LittleEndian);
            try
            {
                ARM9.GameRegion gameRegion = this.GetGameRegion(endianBinaryReaderEx);
                this.addresses = new ARM9.Addresses(gameRegion);
                endianBinaryReaderEx.BaseStream.Position = (long)((ulong)this.addresses.MusicTable);
                this.MusicSlotTable = new MusicTable(endianBinaryReaderEx);
                endianBinaryReaderEx.BaseStream.Position = (long)((ulong)this.addresses.GlobalMapTable);
                this.GlobalMapTable = new MapTable(endianBinaryReaderEx);
                this.LocalMapTable = new MapTable(endianBinaryReaderEx);
            }
            finally
            {
                endianBinaryReaderEx.Close();
            }
        }
        public void Overwrite()
        {
            FileStream fileStream = File.OpenWrite(this.path);
            EndianBinaryWriter endianBinaryWriter = new EndianBinaryWriter(fileStream, Endianness.LittleEndian);
            try
            {
                endianBinaryWriter.BaseStream.Position = (long)((ulong)this.addresses.MusicTable);
                this.MusicSlotTable.Write(endianBinaryWriter);
                endianBinaryWriter.BaseStream.Position = (long)((ulong)this.addresses.GlobalMapTable);
                this.GlobalMapTable.Write(endianBinaryWriter);
                this.LocalMapTable.Write(endianBinaryWriter);
            }
            finally
            {
                endianBinaryWriter.Close();
                fileStream.Close();
            }
        }
        public byte[] Write()
        {
            MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(this.path));
            EndianBinaryWriter endianBinaryWriter = new EndianBinaryWriter(memoryStream, Endianness.LittleEndian);
            try
            {
                endianBinaryWriter.BaseStream.Position = (long)((ulong)this.addresses.MusicTable);
                this.MusicSlotTable.Write(endianBinaryWriter);
                endianBinaryWriter.BaseStream.Position = (long)((ulong)this.addresses.GlobalMapTable);
                this.GlobalMapTable.Write(endianBinaryWriter);
                this.LocalMapTable.Write(endianBinaryWriter);
            }
            finally
            {
                endianBinaryWriter.Close();
            }
            return memoryStream.ToArray();
        }
        public string path;
        private ARM9.Addresses addresses;
        public MusicTable MusicSlotTable;
        public MapTable GlobalMapTable;
        public MapTable LocalMapTable;
        private enum GameRegion
        {
            American,
            European,
            Japanese
        }
        private class Addresses
        {
            public uint MusicTable
            {
                get
                {
                    return this.musicTable;
                }
            }
            public uint GlobalMapTable
            {
                get
                {
                    return this.globalMapTable;
                }
            }
            public Addresses(ARM9.GameRegion region)
            {
                this.musicTable = 0U;
                this.globalMapTable = 0U;
                switch (region)
                {
                    case ARM9.GameRegion.American:
                        this.musicTable = 0U;
                        this.globalMapTable = 0U;
                        break;
                    case ARM9.GameRegion.European:
                        this.musicTable = 1388908U;
                        this.globalMapTable = 1476004U;
                        break;
                    case ARM9.GameRegion.Japanese:
                        this.musicTable = 1392024U;
                        this.globalMapTable = 1479432U;
                        break;
                }
            }
            private uint musicTable;
            private uint globalMapTable;
        }
    }
}