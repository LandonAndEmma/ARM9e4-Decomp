using LibEndianBinaryIO;

namespace NewARM9
{
    public class MusicTable
    {
        public MusicTable(EndianBinaryReaderEx er)
        {
            for (int i = 0; i < 53; i++)
            {
                this.Entries[i].Unknown1 = er.ReadSByte();
                this.Entries[i].SSEQ_ID = er.ReadSByte();
                this.Entries[i].Unknown2 = er.ReadSByte();
                this.Entries[i].Unknown3 = er.ReadSByte();
            }
        }
        public void Write(EndianBinaryWriter er)
        {
            for (int i = 0; i < 53; i++)
            {
                er.Write(this.Entries[i].Unknown1);
                er.Write(this.Entries[i].SSEQ_ID);
                er.Write(this.Entries[i].Unknown2);
                er.Write(this.Entries[i].Unknown3);
            }
        }
        public MusicTable.Entry[] Entries = new MusicTable.Entry[53];
        public struct Entry
        {
            public sbyte Unknown1;
            public sbyte SSEQ_ID;
            public sbyte Unknown2;
            public sbyte Unknown3;
        }
    }
}
