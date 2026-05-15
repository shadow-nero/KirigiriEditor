using KiriFontGUI.Localization;

namespace KiriFontGUI
{
    public partial class Form1
    {
        private void RemoveSelectedGlyph()
        {
            if (dgv_Glyphs.SelectedRows.Count == 0) return;

            var confirm = MessageBox.Show(Lang.RemoveSelected, Lang.Confirm, MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes) return;
                
            foreach (DataGridViewRow row in dgv_Glyphs.SelectedRows) if (row.Cells[0].Value != null) manager.Remove(Convert.ToChar(row.Cells[0].Value));
            UpdateUI();
        }
        private void RemoveAllJapaneseGlyph()
        {
            if (manager == null) return;

            var confirm = MessageBox.Show(Lang.RemoveAllJapanese, Lang.Confirm, MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            dgv_Glyphs.EndEdit();
            manager.RemoveAfterFirstJapaneseChar();
            UpdateUI();
        }
        private void BtnRemove_Click(object sender, EventArgs e) => RemoveSelectedGlyph();
    }
}
