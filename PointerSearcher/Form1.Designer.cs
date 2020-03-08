namespace PointerSearcher
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRead = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMainStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMainEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeapStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeapEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTargetAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxDepth = new System.Windows.Forms.TextBox();
            this.textBoxOffsetNum = new System.Windows.Forms.TextBox();
            this.textBoxOffsetAddress = new System.Windows.Forms.TextBox();
            this.buttonNarrowDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.BOX_value = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CodeBuilder_BOX = new System.Windows.Forms.RichTextBox();
            this.working_BOX = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_hex = new System.Windows.Forms.RadioButton();
            this.radio_dec = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(14, 256);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(158, 25);
            this.buttonRead.TabIndex = 0;
            this.buttonRead.Text = "Read 1st Dump Data";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 287);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(646, 149);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPath,
            this.ColumnMainStart,
            this.ColumnMainEnd,
            this.ColumnHeapStart,
            this.ColumnHeapEnd,
            this.ColumnTargetAddress});
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(646, 163);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // ColumnPath
            // 
            this.ColumnPath.HeaderText = "Path";
            this.ColumnPath.Name = "ColumnPath";
            this.ColumnPath.ToolTipText = "Path of Noexs dump data";
            // 
            // ColumnMainStart
            // 
            this.ColumnMainStart.HeaderText = "MainStart";
            this.ColumnMainStart.Name = "ColumnMainStart";
            this.ColumnMainStart.ToolTipText = "main start address";
            // 
            // ColumnMainEnd
            // 
            this.ColumnMainEnd.HeaderText = "MainEnd";
            this.ColumnMainEnd.Name = "ColumnMainEnd";
            this.ColumnMainEnd.ToolTipText = "main end address";
            // 
            // ColumnHeapStart
            // 
            this.ColumnHeapStart.HeaderText = "HeapStart";
            this.ColumnHeapStart.Name = "ColumnHeapStart";
            this.ColumnHeapStart.ToolTipText = "heap start address";
            // 
            // ColumnHeapEnd
            // 
            this.ColumnHeapEnd.HeaderText = "HeapEnd";
            this.ColumnHeapEnd.Name = "ColumnHeapEnd";
            this.ColumnHeapEnd.ToolTipText = "heap end address";
            // 
            // ColumnTargetAddress
            // 
            this.ColumnTargetAddress.HeaderText = "TargetAddress";
            this.ColumnTargetAddress.Name = "ColumnTargetAddress";
            this.ColumnTargetAddress.ToolTipText = "address you want to find a pointer of this dump data";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(257, 256);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(158, 25);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Reset and Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxDepth
            // 
            this.textBoxDepth.Location = new System.Drawing.Point(72, 217);
            this.textBoxDepth.Name = "textBoxDepth";
            this.textBoxDepth.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepth.TabIndex = 4;
            // 
            // textBoxOffsetNum
            // 
            this.textBoxOffsetNum.Location = new System.Drawing.Point(315, 217);
            this.textBoxOffsetNum.Name = "textBoxOffsetNum";
            this.textBoxOffsetNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxOffsetNum.TabIndex = 5;
            // 
            // textBoxOffsetAddress
            // 
            this.textBoxOffsetAddress.Location = new System.Drawing.Point(558, 217);
            this.textBoxOffsetAddress.Name = "textBoxOffsetAddress";
            this.textBoxOffsetAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxOffsetAddress.TabIndex = 6;
            // 
            // buttonNarrowDown
            // 
            this.buttonNarrowDown.Location = new System.Drawing.Point(500, 256);
            this.buttonNarrowDown.Name = "buttonNarrowDown";
            this.buttonNarrowDown.Size = new System.Drawing.Size(158, 25);
            this.buttonNarrowDown.TabIndex = 7;
            this.buttonNarrowDown.Text = "Narrow Down Result";
            this.buttonNarrowDown.UseVisualStyleBackColor = true;
            this.buttonNarrowDown.Click += new System.EventHandler(this.buttonNarrowDown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "MaxDepth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "OffsetNum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "OffsetRange";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 444);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(565, 25);
            this.progressBar1.TabIndex = 11;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(583, 444);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 25);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.Text = "8 bit";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(58, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "16 bit";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(180, 35);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(51, 17);
            this.radioButton4.TabIndex = 17;
            this.radioButton4.Text = "64 bit";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(115, 14);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 17);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "32 bit";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Value";
            // 
            // BOX_value
            // 
            this.BOX_value.Location = new System.Drawing.Point(42, 11);
            this.BOX_value.Name = "BOX_value";
            this.BOX_value.Size = new System.Drawing.Size(100, 20);
            this.BOX_value.TabIndex = 19;
            this.BOX_value.Text = "999";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Export Results as Code List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CodeBuilder_BOX
            // 
            this.CodeBuilder_BOX.Location = new System.Drawing.Point(13, 639);
            this.CodeBuilder_BOX.Name = "CodeBuilder_BOX";
            this.CodeBuilder_BOX.Size = new System.Drawing.Size(646, 133);
            this.CodeBuilder_BOX.TabIndex = 21;
            this.CodeBuilder_BOX.Text = "";
            this.CodeBuilder_BOX.Visible = false;
            // 
            // working_BOX
            // 
            this.working_BOX.Location = new System.Drawing.Point(12, 778);
            this.working_BOX.Name = "working_BOX";
            this.working_BOX.Size = new System.Drawing.Size(645, 20);
            this.working_BOX.TabIndex = 22;
            this.working_BOX.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(14, 484);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 36);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_dec);
            this.groupBox2.Controls.Add(this.radio_hex);
            this.groupBox2.Controls.Add(this.BOX_value);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(199, 484);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 36);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // radio_hex
            // 
            this.radio_hex.AutoSize = true;
            this.radio_hex.Location = new System.Drawing.Point(148, 14);
            this.radio_hex.Name = "radio_hex";
            this.radio_hex.Size = new System.Drawing.Size(42, 17);
            this.radio_hex.TabIndex = 20;
            this.radio_hex.Text = "hex";
            this.radio_hex.UseVisualStyleBackColor = true;
            // 
            // radio_dec
            // 
            this.radio_dec.AutoSize = true;
            this.radio_dec.Checked = true;
            this.radio_dec.Location = new System.Drawing.Point(196, 14);
            this.radio_dec.Name = "radio_dec";
            this.radio_dec.Size = new System.Drawing.Size(43, 17);
            this.radio_dec.TabIndex = 21;
            this.radio_dec.TabStop = true;
            this.radio_dec.Text = "dec";
            this.radio_dec.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.working_BOX);
            this.Controls.Add(this.CodeBuilder_BOX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNarrowDown);
            this.Controls.Add(this.textBoxOffsetAddress);
            this.Controls.Add(this.textBoxOffsetNum);
            this.Controls.Add(this.textBoxDepth);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PointerSearcher 0.04b";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxDepth;
        private System.Windows.Forms.TextBox textBoxOffsetNum;
        private System.Windows.Forms.TextBox textBoxOffsetAddress;
        private System.Windows.Forms.Button buttonNarrowDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMainStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMainEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeapStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeapEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTargetAddress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BOX_value;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox CodeBuilder_BOX;
        private System.Windows.Forms.TextBox working_BOX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_dec;
        private System.Windows.Forms.RadioButton radio_hex;
    }
}

