namespace KiriFontGUI
{
    partial class FormAddGlyph
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
            button1 = new Button();
            txtChar = new TextBox();
            numX = new NumericUpDown();
            numY = new NumericUpDown();
            numShift = new NumericUpDown();
            numW = new NumericUpDown();
            numH = new NumericUpDown();
            Letter = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            lb_MarginLeft = new Label();
            lb_MarginVertical = new Label();
            lbMarginRight = new Label();
            bt_Cancelar = new Button();
            numMarginVertical = new NumericUpDown();
            numMarginRight = new NumericUpDown();
            numMarginLeft = new NumericUpDown();
            pbPreview = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numShift).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMarginVertical).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMarginRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMarginLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPreview).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(619, 326);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnOK_Click;
            // 
            // txtChar
            // 
            txtChar.Location = new Point(563, 21);
            txtChar.MaxLength = 1;
            txtChar.Name = "txtChar";
            txtChar.Size = new Size(150, 27);
            txtChar.TabIndex = 1;
            // 
            // numX
            // 
            numX.Location = new Point(563, 54);
            numX.Maximum = new decimal(new int[] { 8000, 0, 0, 0 });
            numX.Name = "numX";
            numX.Size = new Size(150, 27);
            numX.TabIndex = 2;
            // 
            // numY
            // 
            numY.Location = new Point(563, 87);
            numY.Maximum = new decimal(new int[] { 8000, 0, 0, 0 });
            numY.Name = "numY";
            numY.Size = new Size(150, 27);
            numY.TabIndex = 3;
            // 
            // numShift
            // 
            numShift.Location = new Point(563, 186);
            numShift.Maximum = new decimal(new int[] { 8000, 0, 0, 0 });
            numShift.Name = "numShift";
            numShift.Size = new Size(150, 27);
            numShift.TabIndex = 4;
            // 
            // numW
            // 
            numW.Location = new Point(563, 120);
            numW.Maximum = new decimal(new int[] { 8000, 0, 0, 0 });
            numW.Name = "numW";
            numW.Size = new Size(150, 27);
            numW.TabIndex = 5;
            // 
            // numH
            // 
            numH.Location = new Point(563, 153);
            numH.Maximum = new decimal(new int[] { 8000, 0, 0, 0 });
            numH.Name = "numH";
            numH.Size = new Size(150, 27);
            numH.TabIndex = 6;
            // 
            // Letter
            // 
            Letter.AutoSize = true;
            Letter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Letter.Location = new Point(501, 24);
            Letter.Name = "Letter";
            Letter.Size = new Size(56, 20);
            Letter.TabIndex = 7;
            Letter.Text = "Letter:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 281);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(521, 174);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 292);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-2, 175);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(157, 366);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(550, 243);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(473, 56);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 15;
            label1.Text = "Position X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(477, 89);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 16;
            label2.Text = "Position Y:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(497, 155);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 17;
            label9.Text = "Height:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(501, 122);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 18;
            label10.Text = "Width:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(511, 188);
            label11.Name = "label11";
            label11.Size = new Size(46, 20);
            label11.TabIndex = 19;
            label11.Text = "Shift:";
            // 
            // lb_MarginLeft
            // 
            lb_MarginLeft.AutoSize = true;
            lb_MarginLeft.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_MarginLeft.Location = new Point(465, 223);
            lb_MarginLeft.Name = "lb_MarginLeft";
            lb_MarginLeft.Size = new Size(95, 20);
            lb_MarginLeft.TabIndex = 20;
            lb_MarginLeft.Text = "Margin Left:";
            // 
            // lb_MarginVertical
            // 
            lb_MarginVertical.AutoSize = true;
            lb_MarginVertical.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_MarginVertical.Location = new Point(438, 287);
            lb_MarginVertical.Name = "lb_MarginVertical";
            lb_MarginVertical.Size = new Size(119, 20);
            lb_MarginVertical.TabIndex = 21;
            lb_MarginVertical.Text = "Margin Vertical:";
            // 
            // lbMarginRight
            // 
            lbMarginRight.AutoSize = true;
            lbMarginRight.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbMarginRight.Location = new Point(452, 254);
            lbMarginRight.Name = "lbMarginRight";
            lbMarginRight.Size = new Size(105, 20);
            lbMarginRight.TabIndex = 22;
            lbMarginRight.Text = "Margin Right:";
            // 
            // bt_Cancelar
            // 
            bt_Cancelar.Location = new Point(519, 326);
            bt_Cancelar.Name = "bt_Cancelar";
            bt_Cancelar.Size = new Size(94, 29);
            bt_Cancelar.TabIndex = 23;
            bt_Cancelar.Text = "Cancelar";
            bt_Cancelar.UseVisualStyleBackColor = true;
            bt_Cancelar.Click += bt_Cancelar_Click;
            // 
            // numMarginVertical
            // 
            numMarginVertical.Location = new Point(563, 285);
            numMarginVertical.Maximum = new decimal(new int[] { 8000, 0, 0, 0 });
            numMarginVertical.Name = "numMarginVertical";
            numMarginVertical.Size = new Size(150, 27);
            numMarginVertical.TabIndex = 24;
            // 
            // numMarginRight
            // 
            numMarginRight.Location = new Point(563, 252);
            numMarginRight.Maximum = new decimal(new int[] { 8000, 0, 0, 0 });
            numMarginRight.Name = "numMarginRight";
            numMarginRight.Size = new Size(150, 27);
            numMarginRight.TabIndex = 25;
            // 
            // numMarginLeft
            // 
            numMarginLeft.Location = new Point(563, 219);
            numMarginLeft.Maximum = new decimal(new int[] { 8000, 0, 0, 0 });
            numMarginLeft.Name = "numMarginLeft";
            numMarginLeft.Size = new Size(150, 27);
            numMarginLeft.TabIndex = 26;
            // 
            // pbPreview
            // 
            pbPreview.BackColor = SystemColors.ActiveCaptionText;
            pbPreview.Location = new Point(12, 12);
            pbPreview.Name = "pbPreview";
            pbPreview.Size = new Size(420, 300);
            pbPreview.TabIndex = 27;
            pbPreview.TabStop = false;
            pbPreview.Paint += pb_Preview_Paint;
            // 
            // FormAddGlyph
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 367);
            Controls.Add(pbPreview);
            Controls.Add(numMarginLeft);
            Controls.Add(numMarginRight);
            Controls.Add(numMarginVertical);
            Controls.Add(bt_Cancelar);
            Controls.Add(lbMarginRight);
            Controls.Add(lb_MarginVertical);
            Controls.Add(lb_MarginLeft);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Letter);
            Controls.Add(numH);
            Controls.Add(numW);
            Controls.Add(numShift);
            Controls.Add(numY);
            Controls.Add(numX);
            Controls.Add(txtChar);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddGlyph";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Glyph Editor";
            ((System.ComponentModel.ISupportInitialize)numX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numShift).EndInit();
            ((System.ComponentModel.ISupportInitialize)numW).EndInit();
            ((System.ComponentModel.ISupportInitialize)numH).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMarginVertical).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMarginRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMarginLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtChar;
        private NumericUpDown numX;
        private NumericUpDown numY;
        private NumericUpDown numShift;
        private NumericUpDown numW;
        private NumericUpDown numH;
        private Label Letter;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label1;
        private Label label2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label lb_MarginLeft;
        private Label lb_MarginVertical;
        private Label lbMarginRight;
        private Button bt_Cancelar;
        private NumericUpDown numMarginVertical;
        private NumericUpDown numMarginRight;
        private NumericUpDown numMarginLeft;
        private PictureBox pbPreview;
    }
}