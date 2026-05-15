using KirigiriLib.KiriEntry;

namespace KiriFontGUI
{
    public partial class Form1
    {
        public void UpdateTitle()
        {
            string appName = "Kirigiri Font Editor";
            string version = "v1.0";

            if (string.IsNullOrEmpty(_currentFilePath))
                this.Text = $"{appName} {version}";
            else
                this.Text = $"{appName} {version} - [{_currentFilePath}]";
        }
        private void UpdateCharacterCount()
        {
            if (manager == null) lb_TitleGrid.Text = "Character Editor (No file loaded)"; else lb_TitleGrid.Text = $"Character Editor (Total: {manager.AllEntries.Count})";

        }
        // doesn't seem efficient...
        private void SyncGridSelection(FontEntry entry)
        {
            UpdateUI();
            dgv_Glyphs.Focus();
            foreach (DataGridViewRow row in dgv_Glyphs.Rows)
            {
                if (row.DataBoundItem == entry)
                {
                    dgv_Glyphs.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }
    }
}
