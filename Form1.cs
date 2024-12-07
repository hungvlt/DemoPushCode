using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_02
{
  public partial class frmSoanThao : Form
  {
    private string currentFilePath = null;
    private bool isTextChanged = false;
    private bool isBold = false;
    private bool isItalic = false;
    private bool isUnderline = false;

    public frmSoanThao()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      foreach (FontFamily font in new InstalledFontCollection().Families)
      {
        cmbFonts.Items.Add(font.Name);
      }
      cmbFonts.SelectedItem = "Segoe UI";

      int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
      foreach (int size in sizes)
      {
        cmbSize.Items.Add(size);
      }
      cmbSize.SelectedItem = 12;
      rtbEditor.Font = new Font("Segoe UI", 12);
      UpdateTitle();
    }

    private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FontDialog fontDlg = new FontDialog();
      fontDlg.ShowColor = true;
      fontDlg.ShowApply = true;
      fontDlg.ShowEffects = true;
      fontDlg.ShowHelp = true;

      if (fontDlg.ShowDialog() != DialogResult.Cancel)
      {
        rtbEditor.ForeColor = fontDlg.Color;
        rtbEditor.Font = fontDlg.Font;
      }
    }

    private void miTaoMoiIcon_Click(object sender, EventArgs e)
    {
      rtbEditor.Clear();
      rtbEditor.Font = new Font("Segoe UI", 12);
      cmbFonts.SelectedItem = "Segoe UI";
      cmbSize.SelectedItem = 12;

      currentFilePath = null;
      isTextChanged = false;
      UpdateTitle();
    }

    private void miMoIcon_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "All Files|*.*|Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";

      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        try
        {
          if (openFileDialog.FileName.EndsWith(".rtf"))
          {
            rtbEditor.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
          }
          else
          {
            rtbEditor.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
          }

          currentFilePath = openFileDialog.FileName;
          isTextChanged = false;
          UpdateTitle();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Lỗi khi mở tệp: " + ex.Message);
        }
      }
    }

    private void miThoatIcon_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnTaoMoi_Click(object sender, EventArgs e)
    {
      miTaoMoiIcon.PerformClick();
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
      miLuuIcon.PerformClick();
    }

    private void btnInDam_Click(object sender, EventArgs e)
    {
      ToggleFontStyle(FontStyle.Bold, btnInDam);
    }

    private void btnInNghieng_Click(object sender, EventArgs e)
    {
      ToggleFontStyle(FontStyle.Italic, btnInNghieng);
    }

    private void btnGachDuoi_Click(object sender, EventArgs e)
    {
      ToggleFontStyle(FontStyle.Underline, btnGachDuoi);
    }

    private void miLuuIcon_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(currentFilePath))
      {
        // Kiểm tra nếu nội dung không thay đổi, ghi đè trực tiếp
        if (!IsContentChanged(currentFilePath))
          return;

        // Nếu nội dung thay đổi, ghi đè file hiện tại
        SaveFile(currentFilePath);
      }
      else
      {
        // Nếu chưa có file hiện tại, mở SaveFileDialog
        SaveAs();
      }
    }

    private void SaveAs()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";

      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        SaveFile(saveFileDialog.FileName);
      }
    }

    private void SaveFile(string filePath)
    {
      try
      {
        if (filePath.EndsWith(".rtf"))
        {
          rtbEditor.SaveFile(filePath, RichTextBoxStreamType.RichText);
        }
        else
        {
          System.IO.File.WriteAllText(filePath, rtbEditor.Text);
        }

        currentFilePath = filePath;
        isTextChanged = false;
        UpdateTitle();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi khi lưu tệp: " + ex.Message);
      }
    }

    private void UpdateTitle()
    {
      string fileName = string.IsNullOrEmpty(currentFilePath)
          ? "Tài liệu không có tiêu đề"
          : System.IO.Path.GetFileName(currentFilePath);

      if (isTextChanged)
      {
        if (!this.Text.StartsWith("*"))
        {
          this.Text = fileName + "*";
        }
      }
      else
      {
        if (this.Text.StartsWith("*"))
        {
          this.Text = fileName;
        }
        else
        {
          this.Text = fileName; // Không lặp lại tiêu đề
        }
      }
    }

    private void ToggleFontStyle(FontStyle style, ToolStripButton button)
    {
      if (rtbEditor.SelectionFont != null)
      {
        FontStyle newStyle = rtbEditor.SelectionFont.Style ^ style;
        rtbEditor.SelectionFont = new Font(rtbEditor.SelectionFont, newStyle);

        bool isActive = (rtbEditor.SelectionFont.Style & style) == style;
        UpdateButtonState(button, isActive);
      }
    }

    private void UpdateButtonState(ToolStripButton button, bool isActive)
    {
      if (isActive)
      {
        button.BackColor = Color.LightGray;
      }
      else
        button.BackColor = SystemColors.Control;
    }

    private void UpdateFont()
    {
      // Kiểm tra xem có chọn font và kích thước hợp lệ không
      if (string.IsNullOrWhiteSpace(cmbFonts.Text) || string.IsNullOrWhiteSpace(cmbSize.Text))
        return;

      string selectedFont = cmbFonts.Text;
      if (float.TryParse(cmbSize.Text, out float selectedSize))
      {
        // Kiểm tra font có tồn tại trong hệ thống không
        if (new InstalledFontCollection().Families.Any(f => f.Name.Equals(selectedFont, StringComparison.OrdinalIgnoreCase)))
        {
          // Nếu có phần văn bản đang được chọn, thay đổi font cho phần đó
          if (rtbEditor.SelectionLength > 0)
          {
            rtbEditor.SelectionFont = new Font(selectedFont, selectedSize, rtbEditor.SelectionFont?.Style ?? FontStyle.Regular);
          }
          else
          {
            // Nếu không có phần văn bản nào được chọn, thay đổi font cho văn bản mới người dùng nhập
            // Chỉ thay đổi font cho các ký tự mới nhập, không thay đổi toàn bộ văn bản
            rtbEditor.SelectionFont = new Font(selectedFont, selectedSize, rtbEditor.SelectionFont?.Style ?? FontStyle.Regular);
          }
        }
      }
      ApplyTextStyles();
    }

    private void ApplyTextStyles()
    {
      FontStyle newStyle = FontStyle.Regular;

      // Toan tu | (OR bitwise/ hoặc theo bit)
      if (isBold) newStyle |= FontStyle.Bold;
      if (isItalic) newStyle |= FontStyle.Italic;
      if (isUnderline) newStyle |= FontStyle.Underline;

      // Ap dung cho doan van ban duoc chon
      if (rtbEditor.SelectionLength > 0)
      {
        rtbEditor.SelectionFont = new Font(rtbEditor.SelectionFont, newStyle);
      }
      // Ap dung cho doan van ban ke ve sau
      else
      {
        rtbEditor.SelectionFont = new Font(rtbEditor.SelectionFont, newStyle);
      }
    }

    private bool IsContentChanged(string filePath)
    {
      if (string.IsNullOrEmpty(filePath))
        return true;

      try
      {
        if (filePath.EndsWith(".rtf"))
        {
          // So sánh nội dung RTF
          using (RichTextBox tempRtb = new RichTextBox())
          {
            tempRtb.LoadFile(filePath, RichTextBoxStreamType.RichText);
            return !tempRtb.Rtf.Equals(rtbEditor.Rtf, StringComparison.Ordinal);
          }
        }
        else
        {
          // So sánh nội dung Text
          string fileContent = System.IO.File.ReadAllText(filePath);
          return !fileContent.Equals(rtbEditor.Text, StringComparison.Ordinal);
        }
      }
      catch
      {
        return true; // Nếu có lỗi khi so sánh, coi như nội dung đã thay đổi
      }
    }

    private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdateFont();
    }

    private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdateFont();
    }

    private void cmbFonts_TextChanged(object sender, EventArgs e)
    {
      UpdateFont();
    }

    private void cmbSize_TextChanged(object sender, EventArgs e)
    {
      UpdateFont();
    }

    private void rtbEditor_TextChanged(object sender, EventArgs e)
    {
      isTextChanged = true;
      UpdateTitle();
    }

    private void rtbEditor_SelectionChanged(object sender, EventArgs e)
    {
      UpdateButtonState(btnInDam, rtbEditor.SelectionFont != null && rtbEditor.SelectionFont.Bold);
      UpdateButtonState(btnInNghieng, rtbEditor.SelectionFont != null && rtbEditor.SelectionFont.Italic);
      UpdateButtonState(btnGachDuoi, rtbEditor.SelectionFont != null && rtbEditor.SelectionFont.Underline);
    }

    private void rtbEditor_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Control)
      {
        if ((e.KeyCode == Keys.B))
        {
          isBold = !isBold;
          e.SuppressKeyPress = true;
          ApplyTextStyles();
        }
        else if ((e.KeyCode == Keys.I))
        {
          isItalic = !isItalic;
          e.SuppressKeyPress = true;
          ApplyTextStyles();
        }
        if ((e.KeyCode == Keys.U))
        {
          isUnderline = !isUnderline;
          e.SuppressKeyPress = true;
          ApplyTextStyles();
        }
      }
    }
  }
}
