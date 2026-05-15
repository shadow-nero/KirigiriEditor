using KiriFontGUI.Localization;
using KirigiriLib.KiriEntry;

namespace KiriFontGUI
{
    public partial class FormAddGlyph : Form
    {
        public FontEntry NewEntry { get; private set; }
        private Bitmap _texture;
        public FormAddGlyph(Bitmap texture)
        {
            InitializeComponent();
            _texture = texture;
            numX.ValueChanged += UpdatePreview;
            numY.ValueChanged += UpdatePreview;
            numW.ValueChanged += UpdatePreview;
            numH.ValueChanged += UpdatePreview;
            pbPreview.Paint += pb_Preview_Paint;
        }
        private void UpdatePreview(object sender, EventArgs e)
        {
            pbPreview.Invalidate();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChar.Text))
            {
                MessageBox.Show(Lang.PleaseInsertChar);
                return;
            }

            NewEntry = new FontEntry(txtChar.Text[0], (short)numX.Value, (short)numY.Value, (short)numW.Value, (short)numH.Value, 0, (sbyte)numMarginLeft.Value, (sbyte)numMarginRight.Value, (sbyte)numMarginVertical.Value);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pb_Preview_Paint(object sender, PaintEventArgs e)
        {
            if (_texture == null) return;

            Graphics g = e.Graphics;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

            if ((int)numW.Value <= 0 || (int)numH.Value <= 0) return;

            Rectangle srcRect = new Rectangle((int)numX.Value, (int)numY.Value, (int)numW.Value, (int)numH.Value);

            float ratio = Math.Min((float)pbPreview.Width / (int)numW.Value, (float)pbPreview.Height / (int)numH.Value);
            float zoom = ratio * 0.8f;

            float destW = (int)numW.Value * zoom;
            float destH = (int)numH.Value * zoom;
            float destX = (pbPreview.Width - destW) / 2;
            float destY = (pbPreview.Height - destH) / 2;

            RectangleF destRect = new RectangleF(destX, destY, destW, destH);

            g.DrawImage(_texture, destRect, srcRect, GraphicsUnit.Pixel);

            using (Pen p = new Pen(Color.Red, 2))
            {
                g.DrawRectangle(p, destX, destY, destW, destH);
            }
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}