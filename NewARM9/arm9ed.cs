using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace NewARM9
{
    public partial class arm9ed : Form
    {
        public arm9ed()
        {
            this.InitializeComponent();
        }
        private void openARM9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openARM9.ShowDialog() == DialogResult.OK && this.openARM9.FileName.Length > 0)
            {
                string fileName = this.openARM9.FileName;
                try
                {
                    this.arnine = new ARM9(File.ReadAllBytes(fileName), fileName);
                    this.TablesTabs.Enabled = true;
                    this.Text = "ARM9 Editor (" + fileName + ")";
                    this.FillGlobalMapTable();
                    this.FillLocalMapTable();
                    this.FillMusicSlotTable();
                }
                catch (IOException)
                {
                    MessageBox.Show("Error when reading from file!");
                }
            }
        }
        private void saveARM9_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = this.saveARM9.FileName;
            File.Create(fileName).Close();
            File.WriteAllBytes(fileName, this.arnine.Write());
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveARM9.ShowDialog();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.arnine.Overwrite();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ARM9 Editor\nErmiisoft 2016");
        }
        public void FillMusicSlotTable()
        {
            foreach (object obj in this.Grid_MusicSlot.Columns)
            {
                DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
                dataGridViewColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.Grid_MusicSlot.Rows.Clear();
            int num = 0;
            foreach (MusicTable.Entry entry in this.arnine.MusicSlotTable.Entries)
            {
                this.Grid_MusicSlot.Rows.Add(new object[]
                {
                    this.SlotList[num],
                    entry.SSEQ_ID
                });
                num++;
            }
        }
        private void Grid_MusicSlot_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.Grid_MusicSlot.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format("{0:0}", sbyte.Parse(this.Grid_MusicSlot.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture));
            this.arnine.MusicSlotTable.Entries[e.RowIndex].SSEQ_ID = sbyte.Parse(this.Grid_MusicSlot.Rows[e.RowIndex].Cells[1].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture);
        }
        private void Grid_MusicSlot_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                sbyte b;
                if (!sbyte.TryParse(e.FormattedValue.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture, out b))
                {
                    MessageBox.Show("The input isn't valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    e.Cancel = true;
                }
            }
        }
        public void FillGlobalMapTable()
        {
            foreach (object obj in this.Grid_GlobalMap.Columns)
            {
                DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
                dataGridViewColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.Grid_GlobalMap.Rows.Clear();
            int num = 0;
            foreach (MapTable.Values values in this.arnine.GlobalMapTable.Table)
            {
                this.Grid_GlobalMap.Rows.Add(new object[]
                {
                    this.CourseList[num],
                    values.minX,
                    values.minY,
                    values.maxX,
                    values.maxY
                });
                num++;
            }
        }
        private void Grid_GlobalMap_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    {
                        short num;
                        if (!short.TryParse(e.FormattedValue.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture, out num))
                        {
                            MessageBox.Show("The input isn't valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            e.Cancel = true;
                        }
                        break;
                    }
            }
        }
        private void Grid_GlobalMap_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.Grid_GlobalMap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format("{0:0}", short.Parse(this.Grid_GlobalMap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture));
            switch (e.ColumnIndex)
            {
                case 1:
                    this.arnine.GlobalMapTable.Table[e.RowIndex].minX = short.Parse(this.Grid_GlobalMap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture);
                    break;
                case 2:
                    this.arnine.GlobalMapTable.Table[e.RowIndex].minY = short.Parse(this.Grid_GlobalMap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture);
                    break;
                case 3:
                    this.arnine.GlobalMapTable.Table[e.RowIndex].maxX = short.Parse(this.Grid_GlobalMap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture);
                    break;
                case 4:
                    this.arnine.GlobalMapTable.Table[e.RowIndex].maxY = short.Parse(this.Grid_GlobalMap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture);
                    break;
            }
        }
        private void Grid_GlobalMap_KeyUp(object sender, KeyEventArgs e)
        {
        }
        public void FillLocalMapTable()
        {
            foreach (object obj in this.Grid_LocalMap.Columns)
            {
                DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
                dataGridViewColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.Grid_LocalMap.Rows.Clear();
            int num = 0;
            foreach (MapTable.Values values in this.arnine.LocalMapTable.Table)
            {
                this.Grid_LocalMap.Rows.Add(new object[]
                {
                    this.CourseList[num],
                    values.minX,
                    values.minY,
                    values.maxX,
                    values.maxY
                });
                num++;
            }
        }
        private void Grid_LocalMap_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    {
                        short num;
                        if (!short.TryParse(e.FormattedValue.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture, out num))
                        {
                            MessageBox.Show("The input isn't valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            e.Cancel = true;
                        }
                        break;
                    }
            }
        }
        private void Grid_LocalMap_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.Grid_LocalMap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format("{0:0}", short.Parse(this.Grid_LocalMap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture));
            switch (e.ColumnIndex)
            {
                case 1:
                    this.arnine.LocalMapTable.Table[e.RowIndex].minX = short.Parse(this.Grid_LocalMap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture);
                    break;
                case 2:
                    this.arnine.LocalMapTable.Table[e.RowIndex].minY = short.Parse(this.Grid_LocalMap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture);
                    break;
                case 3:
                    this.arnine.LocalMapTable.Table[e.RowIndex].maxX = short.Parse(this.Grid_LocalMap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture);
                    break;
                case 4:
                    this.arnine.LocalMapTable.Table[e.RowIndex].maxY = short.Parse(this.Grid_LocalMap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture);
                    break;
            }
        }
        private ARM9 arnine;
        private string[] SlotList = new string[]
        {
            "Unknown",
            "Course Intro 2",
            "Course Intro 1",
            "Course Intro 3",
            "Course Intro 4",
            "Battle Mode Intro",
            "Boss Intro",
            "Figure-8 Circuit",
            "GCN Luigi Circuit",
            "GCN Yoshi Circuit",
            "Cheep Cheep Beach",
            "Yoshi Falls",
            "GCN Baby Park",
            "N64 Moo Moo Farm",
            "N64 Frappe Snowland",
            "Delfino Sqare",
            "Airship Fortress",
            "Wario Stadium",
            "GCN Mushroom Bridge",
            "Peach Gardens",
            "Luigi's Mansion",
            "SNES Mario Circuit 1",
            "SNES Koopa Beach 2",
            "SNES Donut Plains 1",
            "SNES Choco Island 2",
            "GBA Peach Circuit",
            "GBA Luigi Circuit",
            "Shroom Ridge",
            "N64 Choco Mountain",
            "N64 Banshee Boardwalk",
            "DK Pass",
            "Desert Hills",
            "Waluigi Pinball",
            "Tick-Tock Clock",
            "Mario Circuit",
            "Rainbow Road",
            "GBA Bowser Castle 2",
            "Bowser Castle",
            "GBA Sky Garden",
            "Battle Stage Theme",
            "Boss Battle Theme",
            "Jingle",
            "GP Results",
            "Credits",
            "Credits True",
            "Wi-Fi Menu",
            "Multiplayer Menu",
            "Records Menu",
            "Options Menu",
            "Intro",
            "Singleplayer Menu",
            "Unknown",
            "Mario Circuit"
        };
        private string[] CourseList = new string[]
        {
            "Unused",
            "GCN Yoshi Circuit",
            "old_mario_gc",
            "luigi_course",
            "dokan_course",
            "test1_course",
            "donkey_course",
            "wario_course",
            "nokonoko_course",
            "GCN Baby Park",
            "SNES Mario Circuit 1",
            "N64 Moo Moo Farm",
            "GBA Bowser Castle 2",
            "GBA Peach Circuit",
            "GCN Luigi Circuit",
            "SNES Koopa Beach 2",
            "N64 Frappe Snowland",
            "Tick-Tock Clock",
            "Luigi's Mansion",
            "Airship Fortress",
            "Figure 8 Circuit",
            "test_circle",
            "Yoshi Falls",
            "N64 Banshee Boardwalk",
            "Shroom Ridge",
            "Mario Circuit",
            "Peach Gardens",
            "Desert Hills",
            "Delfino Square",
            "Rainbow Road",
            "DK Pass",
            "Cheep Cheep Beach",
            "Bowser Castle",
            "Waluigi Pinball",
            "Wario Stadium",
            "SNES Donut Plains 1",
            "N64 Choco Mountain",
            "GBA Luigi Circuit",
            "GCN Mushroom Bridge",
            "SNES Choco Island 2",
            "GBA Sky Garden",
            "mini_block_course",
            "Block Fort",
            "Pipe Plaza",
            "Nintendo DS",
            "Twilight House",
            "Palm Shore",
            "Shortcake",
            "MR Stage 1",
            "MR Stage 2",
            "MR Stage 3",
            "MR Stage 3",
            "Award",
            "Staffroll",
            "StaffrollTrue"
        };
    }
}