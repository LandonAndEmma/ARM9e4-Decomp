namespace NewARM9
{
	public partial class arm9ed : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.openARM9ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.openARM9 = new global::System.Windows.Forms.OpenFileDialog();
			this.TablesTabs = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.Grid_GlobalMap = new global::System.Windows.Forms.DataGridView();
			this.Course = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.minXv = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.minYv = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maxXv = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maxYv = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.Grid_LocalMap = new global::System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.Grid_MusicSlot = new global::System.Windows.Forms.DataGridView();
			this.slotname = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sseq_id = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.saveARM9 = new global::System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.TablesTabs.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Grid_GlobalMap).BeginInit();
			this.tabPage2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Grid_LocalMap).BeginInit();
			this.tabPage3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Grid_MusicSlot).BeginInit();
			base.SuspendLayout();
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.fileToolStripMenuItem,
				this.aboutToolStripMenuItem
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new global::System.Drawing.Size(517, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.fileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.openARM9ToolStripMenuItem,
				this.saveToolStripMenuItem,
				this.saveAsToolStripMenuItem
			});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new global::System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			this.openARM9ToolStripMenuItem.Name = "openARM9ToolStripMenuItem";
			this.openARM9ToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131151;
			this.openARM9ToolStripMenuItem.Size = new global::System.Drawing.Size(146, 22);
			this.openARM9ToolStripMenuItem.Text = "Open";
			this.openARM9ToolStripMenuItem.Click += new global::System.EventHandler(this.openARM9ToolStripMenuItem_Click);
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131155;
			this.saveToolStripMenuItem.Size = new global::System.Drawing.Size(146, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new global::System.EventHandler(this.saveToolStripMenuItem_Click);
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new global::System.Drawing.Size(146, 22);
			this.saveAsToolStripMenuItem.Text = "Save as..";
			this.saveAsToolStripMenuItem.Click += new global::System.EventHandler(this.saveAsToolStripMenuItem_Click);
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new global::System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new global::System.EventHandler(this.aboutToolStripMenuItem_Click);
			this.openARM9.FileName = "openFileDialog1";
			this.openARM9.Filter = "Binary File|*.bin|All files|*.*";
			this.openARM9.Title = "Open an MKDS arm9";
			this.TablesTabs.Controls.Add(this.tabPage1);
			this.TablesTabs.Controls.Add(this.tabPage2);
			this.TablesTabs.Controls.Add(this.tabPage3);
			this.TablesTabs.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TablesTabs.Enabled = false;
			this.TablesTabs.Location = new global::System.Drawing.Point(0, 24);
			this.TablesTabs.Name = "TablesTabs";
			this.TablesTabs.SelectedIndex = 0;
			this.TablesTabs.Size = new global::System.Drawing.Size(517, 513);
			this.TablesTabs.TabIndex = 1;
			this.tabPage1.Controls.Add(this.Grid_GlobalMap);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(509, 487);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Global Map Table";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.Grid_GlobalMap.AllowUserToAddRows = false;
			this.Grid_GlobalMap.AllowUserToDeleteRows = false;
			this.Grid_GlobalMap.AllowUserToResizeRows = false;
			this.Grid_GlobalMap.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grid_GlobalMap.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Course,
				this.minXv,
				this.minYv,
				this.maxXv,
				this.maxYv
			});
			this.Grid_GlobalMap.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Grid_GlobalMap.Location = new global::System.Drawing.Point(3, 3);
			this.Grid_GlobalMap.MultiSelect = false;
			this.Grid_GlobalMap.Name = "Grid_GlobalMap";
			this.Grid_GlobalMap.RowHeadersVisible = false;
			this.Grid_GlobalMap.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.Grid_GlobalMap.Size = new global::System.Drawing.Size(503, 481);
			this.Grid_GlobalMap.TabIndex = 0;
			this.Grid_GlobalMap.CellEndEdit += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_GlobalMap_CellEndEdit);
			this.Grid_GlobalMap.CellValidating += new global::System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Grid_GlobalMap_CellValidating);
			this.Grid_GlobalMap.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.Grid_GlobalMap_KeyUp);
			this.Course.HeaderText = "Course Name";
			this.Course.Name = "Course";
			this.Course.ReadOnly = true;
			this.minXv.HeaderText = "Min X";
			this.minXv.Name = "minXv";
			this.minYv.HeaderText = "Min Y";
			this.minYv.Name = "minYv";
			this.maxXv.HeaderText = "Max X";
			this.maxXv.Name = "maxXv";
			this.maxYv.HeaderText = "Max Y";
			this.maxYv.Name = "maxYv";
			this.tabPage2.Controls.Add(this.Grid_LocalMap);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(509, 487);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Local Map Table";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.Grid_LocalMap.AllowUserToAddRows = false;
			this.Grid_LocalMap.AllowUserToDeleteRows = false;
			this.Grid_LocalMap.AllowUserToResizeRows = false;
			this.Grid_LocalMap.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grid_LocalMap.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn1,
				this.dataGridViewTextBoxColumn2,
				this.dataGridViewTextBoxColumn3,
				this.dataGridViewTextBoxColumn4,
				this.dataGridViewTextBoxColumn5
			});
			this.Grid_LocalMap.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Grid_LocalMap.Location = new global::System.Drawing.Point(3, 3);
			this.Grid_LocalMap.MultiSelect = false;
			this.Grid_LocalMap.Name = "Grid_LocalMap";
			this.Grid_LocalMap.RowHeadersVisible = false;
			this.Grid_LocalMap.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.Grid_LocalMap.Size = new global::System.Drawing.Size(503, 481);
			this.Grid_LocalMap.TabIndex = 1;
			this.Grid_LocalMap.CellEndEdit += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_LocalMap_CellEndEdit);
			this.Grid_LocalMap.CellValidating += new global::System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Grid_LocalMap_CellValidating);
			this.dataGridViewTextBoxColumn1.HeaderText = "Course Name";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.HeaderText = "Min X";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn3.HeaderText = "Min Y";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn4.HeaderText = "Max X";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn5.HeaderText = "Max Y";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.tabPage3.Controls.Add(this.Grid_MusicSlot);
			this.tabPage3.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new global::System.Drawing.Size(509, 487);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Music Slots Table";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.Grid_MusicSlot.AllowUserToAddRows = false;
			this.Grid_MusicSlot.AllowUserToDeleteRows = false;
			this.Grid_MusicSlot.AllowUserToResizeRows = false;
			this.Grid_MusicSlot.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grid_MusicSlot.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.slotname,
				this.sseq_id
			});
			this.Grid_MusicSlot.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Grid_MusicSlot.Location = new global::System.Drawing.Point(3, 3);
			this.Grid_MusicSlot.Name = "Grid_MusicSlot";
			this.Grid_MusicSlot.RowHeadersVisible = false;
			this.Grid_MusicSlot.Size = new global::System.Drawing.Size(503, 481);
			this.Grid_MusicSlot.TabIndex = 0;
			this.Grid_MusicSlot.CellEndEdit += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_MusicSlot_CellEndEdit);
			this.Grid_MusicSlot.CellValidating += new global::System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Grid_MusicSlot_CellValidating);
			this.slotname.HeaderText = "Music Slot";
			this.slotname.Name = "slotname";
			this.slotname.ReadOnly = true;
			this.sseq_id.HeaderText = "Sequence ID";
			this.sseq_id.Name = "sseq_id";
			this.saveARM9.Filter = "Binary File|*.bin|All files|*.*";
			this.saveARM9.Title = "Save arm9";
			this.saveARM9.FileOk += new global::System.ComponentModel.CancelEventHandler(this.saveARM9_FileOk);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(517, 537);
			base.Controls.Add(this.TablesTabs);
			base.Controls.Add(this.menuStrip1);
			base.MainMenuStrip = this.menuStrip1;
			base.Name = "arm9ed";
			this.Text = "ARM9 Editor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.TablesTabs.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.Grid_GlobalMap).EndInit();
			this.tabPage2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.Grid_LocalMap).EndInit();
			this.tabPage3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.Grid_MusicSlot).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		private global::System.ComponentModel.IContainer components = null;
		private global::System.Windows.Forms.MenuStrip menuStrip1;
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem openARM9ToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private global::System.Windows.Forms.OpenFileDialog openARM9;
		private global::System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private global::System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private global::System.Windows.Forms.TabControl TablesTabs;
		private global::System.Windows.Forms.TabPage tabPage1;
		private global::System.Windows.Forms.DataGridView Grid_GlobalMap;
		private global::System.Windows.Forms.TabPage tabPage2;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Course;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn minXv;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn minYv;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn maxXv;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn maxYv;
		private global::System.Windows.Forms.SaveFileDialog saveARM9;
		private global::System.Windows.Forms.DataGridView Grid_LocalMap;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private global::System.Windows.Forms.TabPage tabPage3;
		private global::System.Windows.Forms.DataGridView Grid_MusicSlot;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn slotname;
		private global::System.Windows.Forms.DataGridViewTextBoxColumn sseq_id;
	}
}