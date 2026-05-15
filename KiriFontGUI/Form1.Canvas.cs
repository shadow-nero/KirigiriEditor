using KirigiriLib.KiriEntry;

namespace KiriFontGUI
{
    public partial class Form1
    {
        private float _zoom = 3.0f;

        private PointF _offset = new(0, 0);
        private Point _lastMousePos;
        private bool _isDragging = false;
        private Bitmap _fontTexture = null;
        private string _currentFilePath = null;
        private void RenderFontAtlas(Graphics g)
        {
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

            g.TranslateTransform(_offset.X, _offset.Y);
            g.ScaleTransform(_zoom, _zoom);

            if (_fontTexture != null) g.DrawImage(_fontTexture, 0, 0);

            DrawGlyphGrid(g);
        }
        private void DrawGlyphGrid(Graphics g)
        {
            var selectedEntry = dgv_Glyphs.CurrentRow?.DataBoundItem as FontEntry;

            using (Pen penNormal = new (Color.Cyan, 0))
            using (Pen penSelected = new (Color.Red, 0))
            {
                foreach (var entry in manager.AllEntries)
                {
                    Rectangle rect = new (entry.Xpos, entry.Ypos, entry.Width, entry.Height);
                    g.DrawRectangle(entry == selectedEntry ? penSelected : penNormal, rect);
                }
            }
        }
        private void FontLeftClick(MouseEventArgs e)
        {
            float worldX = (e.X - _offset.X) / _zoom;
            float worldY = (e.Y - _offset.Y) / _zoom;

            FontEntry clickedEntry = manager.AllEntries.FirstOrDefault(entry => worldX >= entry.Xpos && worldX <= (entry.Xpos + entry.Width) && worldY >= entry.Ypos && worldY <= (entry.Ypos + entry.Height));

            if (clickedEntry != null && pb_FontTexture.Width >= 0)
            {
                SyncGridSelection(clickedEntry);
                CenterGlyph(clickedEntry);
            }
        }
        private void CenterGlyph(FontEntry entry)
        {
            if (entry == null) return;

            _offset.X = (pb_FontTexture.Width / 2.0f) - ((entry.Xpos + entry.Width / 2.0f) * _zoom);
            _offset.Y = (pb_FontTexture.Height / 2.0f) - ((entry.Ypos + entry.Height / 2.0f) * _zoom);

            pb_FontTexture.Invalidate();
        }
        private void FontTexture_MouseDown(object sender, MouseEventArgs e)
        {
            if (manager == null) return;

            if (e.Button == MouseButtons.Right)
            {
                StartDragging(e.Location);
            }
            else if (e.Button == MouseButtons.Left)
            {
                FontLeftClick(e);
            }
        }
        private void FontTexture_Paint(object sender, PaintEventArgs e)
        {
            if (manager != null && _fontTexture != null) RenderFontAtlas(e.Graphics);
        }
        private void FontTexture_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging) UpdateDrag(e.Location);
        }

        private void FontTexture_MouseUp(object sender, MouseEventArgs e) => _isDragging = false;
        private void StartDragging(Point mousePos)
        {
            _isDragging = true;
            _lastMousePos = mousePos;
        }

        private void UpdateDrag(Point currentMousePos)
        {
            _offset.X += (currentMousePos.X - _lastMousePos.X);
            _offset.Y += (currentMousePos.Y - _lastMousePos.Y);
            _lastMousePos = currentMousePos;
            pb_FontTexture.Invalidate();
        }
    }
}
