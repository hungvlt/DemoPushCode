namespace Lab03_02
{
   partial class frmSoanThao
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoanThao));
      this.menuMain = new System.Windows.Forms.MenuStrip();
      this.miHeThong = new System.Windows.Forms.ToolStripMenuItem();
      this.miTaoMoiIcon = new System.Windows.Forms.ToolStripMenuItem();
      this.miMoIcon = new System.Windows.Forms.ToolStripMenuItem();
      this.miLuuIcon = new System.Windows.Forms.ToolStripMenuItem();
      this.miThoatIcon = new System.Windows.Forms.ToolStripMenuItem();
      this.miDinhDang = new System.Windows.Forms.ToolStripMenuItem();
      this.toolMain = new System.Windows.Forms.ToolStrip();
      this.btnTaoMoi = new System.Windows.Forms.ToolStripButton();
      this.btnLuu = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.cmbFonts = new System.Windows.Forms.ToolStripComboBox();
      this.cmbSize = new System.Windows.Forms.ToolStripComboBox();
      this.btnInDam = new System.Windows.Forms.ToolStripButton();
      this.btnInNghieng = new System.Windows.Forms.ToolStripButton();
      this.btnGachDuoi = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.rtbEditor = new System.Windows.Forms.RichTextBox();
      this.menuMain.SuspendLayout();
      this.toolMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuMain
      // 
      this.menuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
      this.menuMain.ImageScalingSize = new System.Drawing.Size(28, 28);
      this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHeThong,
            this.miDinhDang});
      this.menuMain.Location = new System.Drawing.Point(0, 0);
      this.menuMain.Name = "menuMain";
      this.menuMain.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
      this.menuMain.Size = new System.Drawing.Size(933, 38);
      this.menuMain.TabIndex = 0;
      this.menuMain.Text = "menuStrip1";
      // 
      // miHeThong
      // 
      this.miHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTaoMoiIcon,
            this.miMoIcon,
            this.miLuuIcon,
            this.miThoatIcon});
      this.miHeThong.Name = "miHeThong";
      this.miHeThong.Size = new System.Drawing.Size(118, 34);
      this.miHeThong.Text = "Hệ thống";
      // 
      // miTaoMoiIcon
      // 
      this.miTaoMoiIcon.Image = ((System.Drawing.Image)(resources.GetObject("miTaoMoiIcon.Image")));
      this.miTaoMoiIcon.Name = "miTaoMoiIcon";
      this.miTaoMoiIcon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.miTaoMoiIcon.Size = new System.Drawing.Size(315, 40);
      this.miTaoMoiIcon.Text = "Tạo mới";
      this.miTaoMoiIcon.Click += new System.EventHandler(this.miTaoMoiIcon_Click);
      // 
      // miMoIcon
      // 
      this.miMoIcon.Image = ((System.Drawing.Image)(resources.GetObject("miMoIcon.Image")));
      this.miMoIcon.Name = "miMoIcon";
      this.miMoIcon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.miMoIcon.Size = new System.Drawing.Size(315, 40);
      this.miMoIcon.Text = "Mở tập tin";
      this.miMoIcon.Click += new System.EventHandler(this.miMoIcon_Click);
      // 
      // miLuuIcon
      // 
      this.miLuuIcon.Image = ((System.Drawing.Image)(resources.GetObject("miLuuIcon.Image")));
      this.miLuuIcon.Name = "miLuuIcon";
      this.miLuuIcon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.miLuuIcon.Size = new System.Drawing.Size(315, 40);
      this.miLuuIcon.Text = "Lưu";
      this.miLuuIcon.Click += new System.EventHandler(this.miLuuIcon_Click);
      // 
      // miThoatIcon
      // 
      this.miThoatIcon.Name = "miThoatIcon";
      this.miThoatIcon.Size = new System.Drawing.Size(315, 40);
      this.miThoatIcon.Text = "Thoát";
      this.miThoatIcon.Click += new System.EventHandler(this.miThoatIcon_Click);
      // 
      // miDinhDang
      // 
      this.miDinhDang.Name = "miDinhDang";
      this.miDinhDang.Size = new System.Drawing.Size(128, 34);
      this.miDinhDang.Text = "Định dạng";
      this.miDinhDang.Click += new System.EventHandler(this.địnhDạngToolStripMenuItem_Click);
      // 
      // toolMain
      // 
      this.toolMain.ImageScalingSize = new System.Drawing.Size(28, 28);
      this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTaoMoi,
            this.btnLuu,
            this.toolStripSeparator1,
            this.cmbFonts,
            this.cmbSize,
            this.btnInDam,
            this.btnInNghieng,
            this.btnGachDuoi,
            this.toolStripSeparator2});
      this.toolMain.Location = new System.Drawing.Point(0, 38);
      this.toolMain.Name = "toolMain";
      this.toolMain.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
      this.toolMain.Size = new System.Drawing.Size(933, 38);
      this.toolMain.TabIndex = 1;
      this.toolMain.Text = "toolStrip1";
      // 
      // btnTaoMoi
      // 
      this.btnTaoMoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnTaoMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoMoi.Image")));
      this.btnTaoMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnTaoMoi.Name = "btnTaoMoi";
      this.btnTaoMoi.Size = new System.Drawing.Size(40, 32);
      this.btnTaoMoi.Text = "Tạo mới";
      this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
      // 
      // btnLuu
      // 
      this.btnLuu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
      this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnLuu.Name = "btnLuu";
      this.btnLuu.Size = new System.Drawing.Size(40, 32);
      this.btnLuu.Text = "Lưu";
      this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
      // 
      // cmbFonts
      // 
      this.cmbFonts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.cmbFonts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cmbFonts.DropDownWidth = 140;
      this.cmbFonts.Name = "cmbFonts";
      this.cmbFonts.Size = new System.Drawing.Size(253, 38);
      this.cmbFonts.SelectedIndexChanged += new System.EventHandler(this.cmbFonts_SelectedIndexChanged);
      this.cmbFonts.TextChanged += new System.EventHandler(this.cmbFonts_TextChanged);
      // 
      // cmbSize
      // 
      this.cmbSize.DropDownWidth = 75;
      this.cmbSize.Name = "cmbSize";
      this.cmbSize.Size = new System.Drawing.Size(134, 38);
      this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
      this.cmbSize.TextChanged += new System.EventHandler(this.cmbSize_TextChanged);
      // 
      // btnInDam
      // 
      this.btnInDam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnInDam.Image = ((System.Drawing.Image)(resources.GetObject("btnInDam.Image")));
      this.btnInDam.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnInDam.Name = "btnInDam";
      this.btnInDam.Size = new System.Drawing.Size(40, 32);
      this.btnInDam.Text = "In đậm";
      this.btnInDam.Click += new System.EventHandler(this.btnInDam_Click);
      // 
      // btnInNghieng
      // 
      this.btnInNghieng.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnInNghieng.Image = ((System.Drawing.Image)(resources.GetObject("btnInNghieng.Image")));
      this.btnInNghieng.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnInNghieng.Name = "btnInNghieng";
      this.btnInNghieng.Size = new System.Drawing.Size(40, 32);
      this.btnInNghieng.Text = "In nghiêng";
      this.btnInNghieng.Click += new System.EventHandler(this.btnInNghieng_Click);
      // 
      // btnGachDuoi
      // 
      this.btnGachDuoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnGachDuoi.Image = ((System.Drawing.Image)(resources.GetObject("btnGachDuoi.Image")));
      this.btnGachDuoi.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnGachDuoi.Name = "btnGachDuoi";
      this.btnGachDuoi.Size = new System.Drawing.Size(40, 32);
      this.btnGachDuoi.Text = "Gạch dưới";
      this.btnGachDuoi.Click += new System.EventHandler(this.btnGachDuoi_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
      // 
      // rtbEditor
      // 
      this.rtbEditor.BackColor = System.Drawing.SystemColors.Menu;
      this.rtbEditor.Location = new System.Drawing.Point(0, 110);
      this.rtbEditor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.rtbEditor.Name = "rtbEditor";
      this.rtbEditor.Size = new System.Drawing.Size(934, 450);
      this.rtbEditor.TabIndex = 2;
      this.rtbEditor.Text = "";
      this.rtbEditor.SelectionChanged += new System.EventHandler(this.rtbEditor_SelectionChanged);
      this.rtbEditor.TextChanged += new System.EventHandler(this.rtbEditor_TextChanged);
      this.rtbEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbEditor_KeyDown);
      // 
      // frmSoanThao
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(933, 570);
      this.Controls.Add(this.rtbEditor);
      this.Controls.Add(this.toolMain);
      this.Controls.Add(this.menuMain);
      this.MainMenuStrip = this.menuMain;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "frmSoanThao";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SOẠN THẢO VĂN BẢN";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuMain.ResumeLayout(false);
      this.menuMain.PerformLayout();
      this.toolMain.ResumeLayout(false);
      this.toolMain.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuMain;
      private System.Windows.Forms.ToolStripMenuItem miHeThong;
      private System.Windows.Forms.ToolStrip toolMain;
      private System.Windows.Forms.ToolStripButton btnTaoMoi;
      private System.Windows.Forms.ToolStripButton btnLuu;
      private System.Windows.Forms.RichTextBox rtbEditor;
      private System.Windows.Forms.ToolStripMenuItem miDinhDang;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.ToolStripComboBox cmbFonts;
      private System.Windows.Forms.ToolStripComboBox cmbSize;
      private System.Windows.Forms.ToolStripButton btnInDam;
      private System.Windows.Forms.ToolStripButton btnInNghieng;
      private System.Windows.Forms.ToolStripButton btnGachDuoi;
      private System.Windows.Forms.ToolStripMenuItem miTaoMoiIcon;
      private System.Windows.Forms.ToolStripMenuItem miMoIcon;
      private System.Windows.Forms.ToolStripMenuItem miLuuIcon;
      private System.Windows.Forms.ToolStripMenuItem miThoatIcon;
   }
}
