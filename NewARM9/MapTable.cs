using LibEndianBinaryIO;

namespace NewARM9
{
    public class MapTable
    {
        public MapTable(EndianBinaryReaderEx er)
        {
            for (int i = 0; i < 55; i++)
            {
                this.Table[i].minX = er.ReadInt16();
                this.Table[i].minY = er.ReadInt16();
                this.Table[i].maxX = er.ReadInt16();
                this.Table[i].maxY = er.ReadInt16();
            }
        }
        public void SetValue(int index, MapTable.Values newCoord)
        {
            this.Table[index] = newCoord;
        }
        public void Write(EndianBinaryWriter er)
        {
            for (int i = 0; i < 55; i++)
            {
                er.Write(this.Table[i].minX);
                er.Write(this.Table[i].minY);
                er.Write(this.Table[i].maxX);
                er.Write(this.Table[i].maxY);
            }
        }
        public MapTable.Values[] Table = new MapTable.Values[55];
        public struct Values
        {
            public short minX;
            public short minY;
            public short maxX;
            public short maxY;
        }
    }
}
