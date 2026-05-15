using KirigiriLib;
using KirigiriLib.KiriEntry;
using System.Reflection;

namespace KiriFontGUI
{
    public partial class Form1 : Form
    {
        private FontManager manager;
        public Form1()
        {
            InitializeComponent();
            UpdateTitle();
            UpdateCharacterCount();
            pb_FontTexture.MouseWheel += (s, e) =>
            {
                float oldZoom = _zoom;

                if (e.Delta > 0)
                    _zoom *= 1.1f;
                else
                    _zoom /= 1.1f;

                _zoom = Math.Clamp(_zoom, 0.1f, 15.0f);

                pb_FontTexture.Invalidate();
            };
            SetDoubleBuffered(dgv_Glyphs);

            imgBackground = Properties.Resources.bg_default;
            imgSprite = Properties.Resources.sprite_default;
            imgTextBox = Properties.Resources.box_default;
        }
        public static void SetDoubleBuffered(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, control, new object[] { true });
        }
        private void openfontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new())
            {
                ofd.Title = "Open Spike Chunsoft Font File";
                ofd.Filter = "Font Files (*.font)|*.font|All Files (*.*)|*.*";
                ofd.CheckFileExists = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        LoadFont(ofd.FileName);
                        MessageBox.Show($"Successfully loaded {manager.AllEntries.Count} glyphs!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading font: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void LoadFont(string filePath)
        {
            try
            {
                manager = new FontManager(filePath);
                _currentFilePath = filePath;
                pb_preview.Invalidate();
                UpdateUI();

            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load font: {ex.Message}");
            }
        }
        private void UpdateUI()
        {
            if (manager == null) return;
            this.BindingContext[manager.AllEntries].SuspendBinding();
            this.BindingContext[manager.AllEntries].ResumeBinding();
            dgv_Glyphs.AutoGenerateColumns = false;

            dgv_Glyphs.DataSource = null;
            dgv_Glyphs.DataSource = manager.AllEntries;

            UpdateCharacterCount();
            UpdateTitle();
            pb_preview.Invalidate();

            pb_preview.Invalidate();
            pb_FontTexture.Invalidate();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) e.Cancel = true;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new())
            {
                ofd.Title = "Select both .font and Texture (PNG/BMP)";
                ofd.Multiselect = true;
                ofd.Filter = "Font and Image Files|*.font;*.png;*.jpg;*.bmp|All Files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    if (ofd.FileNames.Length < 2)
                    {
                        MessageBox.Show("Please select both the .font file and the texture image at the same time (Hold Ctrl or Shift).", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string fontPath = null;
                    string texturePath = null;

                    foreach (string file in ofd.FileNames)
                    {
                        string ext = Path.GetExtension(file).ToLower();
                        if (ext == ".font") fontPath = file; else if (ext == ".png" || ext == ".bmp" || ext == ".jpg") texturePath = file;
                    }

                    if (fontPath != null && texturePath != null)
                    {
                        try
                        {
                            LoadFont(fontPath);
                            LoadTexture(texturePath);

                            MessageBox.Show("Font and Texture loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Could not identify one .font file and one image file in your selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void loadTextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new())
            {
                ofd.Title = "Select Source Texture (PNG)";
                ofd.Filter = "Image Files (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|All Files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        LoadTexture(ofd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void LoadTexture(string filePath)
        {
            try
            {
                using (var tempImage = Image.FromFile(filePath))
                {
                    if (_fontTexture != null) _fontTexture.Dispose();
                    _fontTexture = new Bitmap(tempImage);
                    pb_FontTexture.Image = null;
                }

                //_zoom = 1.0f;
                _offset = new PointF(0, 0);
                pb_FontTexture.Invalidate();
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load texture: {ex.Message}");
            }
        }


        private void dgv_Glyphs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_Glyphs.Rows)
            {
                var entry = (FontEntry)row.DataBoundItem;
                if (entry != null)
                {
                    row.Cells["colChar"].Value = entry.Char;
                    row.Cells["colUnicode"].Value = $"U+{(int)entry.Char:X4}";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _offset = new PointF(0, 0);
            pb_FontTexture.Invalidate();
        }
        private void dgv_Glyphs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Glyphs.CurrentRow == null || manager == null) return;

            var entry = dgv_Glyphs.CurrentRow.DataBoundItem as FontEntry;
            CenterGlyph(entry);
            return;
        }
        private void dgv_Glyphs_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgv_Glyphs.DataSource == null || e.RowIndex < 0 || e.RowIndex >= dgv_Glyphs.RowCount) return;

            string colName = dgv_Glyphs.Columns[e.ColumnIndex].Name;

            if (colName == "colChar")
            {
                string input = e.FormattedValue.ToString();
                if (string.IsNullOrEmpty(input) || input.Length > 1)
                {
                    MessageBox.Show("The 'Char' column accepts exactly 1 character.", "Error");
                    e.Cancel = true;
                    dgv_Glyphs.CancelEdit();
                    return;
                }
            }

            string[] strictlyPositive = { "colX", "colY", "colW", "colH" };
            string[] allowNegative = { "colAdvX", "colMarginLeft", "colMarginRight", "colMarginVertical" };

            if (strictlyPositive.Contains(colName) || allowNegative.Contains(colName))
            {
                if (!short.TryParse(e.FormattedValue.ToString(), out short val))
                {
                    MessageBox.Show("This field accepts only short integers", "Type Error");
                    e.Cancel = true;
                    dgv_Glyphs.CancelEdit();
                }
                else if (val < 0 && strictlyPositive.Contains(colName))
                {
                    MessageBox.Show("Position values (X,Y) and size (W,H) cannot be negative", "Value Error");
                    e.Cancel = true;
                    dgv_Glyphs.CancelEdit();
                }
            }
        }
        private void bt_Remove_jp_Click(object sender, EventArgs e) => RemoveAllJapaneseGlyph();
        private void savefontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manager == null) return;

            if (string.IsNullOrEmpty(_currentFilePath))
            {
                savefontAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                try
                {
                    manager.Save(_currentFilePath);
                    MessageBox.Show("Font updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving font: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void savefontAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new())
            {
                sfd.Title = "Save Spike Chunsoft Font File";
                sfd.Filter = "Font Files (*.font)|*.font|All Files (*.*)|*.*";

                if (!string.IsNullOrEmpty(_currentFilePath)) sfd.FileName = Path.GetFileName(_currentFilePath);

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        manager.Save(sfd.FileName);
                        _currentFilePath = sfd.FileName;
                        UpdateUI();
                        MessageBox.Show("Font saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving font: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (manager == null) return;

            using (FormAddGlyph frm = new(_fontTexture))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    manager.Add(frm.NewEntry);
                    SyncGridSelection(frm.NewEntry);
                }
            }
        }
    }
}
