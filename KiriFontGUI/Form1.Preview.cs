namespace KiriFontGUI
{
    public partial class Form1
    {
        private Bitmap imgBackground, imgSprite, imgTextBox;

        private void Preview_Paint(object sender, PaintEventArgs e)
        {
            if (manager == null || _fontTexture == null || string.IsNullOrEmpty(tb_preview.Text)) return;

            Graphics g = e.Graphics;

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            int boxHeight = (int)(pb_preview.Height * 0.3);
            int dynamicOffset = (int)(pb_preview.Height * 0.05);
            int boxY = pb_preview.Height - boxHeight - dynamicOffset;

            DrawPreviewBackground(g, boxY, boxHeight);
            DrawPreviewText(g, boxY, boxHeight);
        }
        private void DrawPreviewBackground(Graphics g, int boxY, int boxHeight)
        {
            if (imgBackground != null)
            {
                g.DrawImage(imgBackground, 0, 0, pb_preview.Width, pb_preview.Height);
            }
            else
            {
                g.Clear(Color.Black);
            }

            if (imgTextBox != null) g.DrawImage(imgTextBox, new Rectangle(0, boxY, pb_preview.Width, boxHeight));

        }
        private void DrawPreviewText(Graphics g, int boxY, int boxHeight)
        {
            float scale = ((float)pb_preview.Width / 480f) * (tb_fontScale.Value / 100f);
            float paddingX = pb_preview.Width * 0.05f;
            float paddingY = boxHeight * 0.1f;

            float cursorX = paddingX, startX = paddingX;
            float cursorY = boxY + paddingY;

            float linhaEspacamento = (manager.LetterSpacing / 2f) * scale;

            foreach (char c in tb_preview.Text)
            {
                if (c == '\n' || c == '\r')
                {
                    if (c == '\n')
                    {
                        cursorX = startX;
                        cursorY += linhaEspacamento;
                    }
                    continue;
                }

                var entry = manager.AllEntries.FirstOrDefault(x => x.Char == c);

                if (entry != null)
                {
                    Rectangle srcRect = new(entry.Xpos, entry.Ypos, entry.Width, entry.Height);
                    RectangleF destRect = new(cursorX + ((entry.MarginLeft / 2) * scale), cursorY - entry.MarginVertical * scale, entry.Width * scale, entry.Height * scale);

                    g.DrawImage(_fontTexture, destRect, srcRect, GraphicsUnit.Pixel);
                    cursorX += (entry.Width * scale) + ((entry.MarginLeft / 2) * scale) + ((entry.MarginRight / 2) * scale);
                } else cursorX += (pb_preview.Width * 0.02f);
            }
        }
        private void Preview_TextChanged(object sender, EventArgs e) => pb_preview.Invalidate();
        private void FontScale_Scroll(object sender, EventArgs e)
        {
            lbl_scaleValue.Text = $"Scale: {tb_fontScale.Value / 100f:F2}";
            pb_preview.Invalidate();
        }
        private void ResetScale_Click(object sender, EventArgs e)
        {
            tb_fontScale.Value = 55;
            lbl_scaleValue.Text = $"Scale: {tb_fontScale.Value / 100f:F2}";
            pb_preview.Invalidate();
        }
    }
}
