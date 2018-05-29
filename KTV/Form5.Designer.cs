namespace KTV
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("组合", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("男歌手", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("女歌手", 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("大陆", 0);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("香港", 1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("台湾", 2);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("欧美", 3);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("日韩", 4);
            this.lvGender = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lvCity = new System.Windows.Forms.ListView();
            this.大陆 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.lvSinger = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvGender
            // 
            this.lvGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lvGender.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvGender.LargeImageList = this.imageList1;
            this.lvGender.Location = new System.Drawing.Point(-116, -31);
            this.lvGender.Name = "lvGender";
            this.lvGender.Size = new System.Drawing.Size(1296, 625);
            this.lvGender.TabIndex = 0;
            this.lvGender.UseCompatibleStateImageBehavior = false;
            this.lvGender.SelectedIndexChanged += new System.EventHandler(this.lvGender_SelectedIndexChanged);
            this.lvGender.Click += new System.EventHandler(this.lvGender_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "couple.png");
            this.imageList1.Images.SetKeyName(1, "male.png");
            this.imageList1.Images.SetKeyName(2, "female.png");
            // 
            // lvCity
            // 
            this.lvCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lvCity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.大陆,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            listViewItem4.Tag = "1";
            listViewItem5.Tag = "2";
            listViewItem6.Tag = "3";
            listViewItem7.Tag = "4";
            listViewItem8.Tag = "5";
            this.lvCity.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lvCity.LargeImageList = this.imageList2;
            this.lvCity.Location = new System.Drawing.Point(-136, -31);
            this.lvCity.Name = "lvCity";
            this.lvCity.Size = new System.Drawing.Size(1316, 625);
            this.lvCity.TabIndex = 1;
            this.lvCity.UseCompatibleStateImageBehavior = false;
            this.lvCity.SelectedIndexChanged += new System.EventHandler(this.lvCity_SelectedIndexChanged);
            this.lvCity.Click += new System.EventHandler(this.lvCity_Click);
            this.lvCity.DoubleClick += new System.EventHandler(this.lvCity_DoubleClick);
            // 
            // 大陆
            // 
            this.大陆.Text = " ";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "dalu.png");
            this.imageList2.Images.SetKeyName(1, "xianggang.png");
            this.imageList2.Images.SetKeyName(2, "taiwan.png");
            this.imageList2.Images.SetKeyName(3, "oumei.png");
            this.imageList2.Images.SetKeyName(4, "rihan.png");
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(175, 165);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvSinger
            // 
            this.lvSinger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lvSinger.LargeImageList = this.imageList3;
            this.lvSinger.Location = new System.Drawing.Point(-116, -31);
            this.lvSinger.Name = "lvSinger";
            this.lvSinger.Size = new System.Drawing.Size(1308, 654);
            this.lvSinger.TabIndex = 2;
            this.lvSinger.UseCompatibleStateImageBehavior = false;
            this.lvSinger.SelectedIndexChanged += new System.EventHandler(this.lvSinger_SelectedIndexChanged);
            this.lvSinger.Click += new System.EventHandler(this.lvSinger_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(1061, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(225, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(798, 448);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "song_id";
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "song_name";
            this.Column2.HeaderText = "歌曲名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "singer_name";
            this.Column3.HeaderText = "歌手";
            this.Column3.Name = "Column3";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 697);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvSinger);
            this.Controls.Add(this.lvCity);
            this.Controls.Add(this.lvGender);
            this.Name = "Form5";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvGender;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lvCity;
        private System.Windows.Forms.ColumnHeader 大陆;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ListView lvSinger;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}