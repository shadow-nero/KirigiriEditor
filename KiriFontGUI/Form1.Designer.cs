namespace KiriFontGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openfontToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            loadTextureToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            savefontToolStripMenuItem = new ToolStripMenuItem();
            savefontAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tbc_Font = new TabControl();
            tb_Glyph = new TabPage();
            groupBox1 = new GroupBox();
            bt_ResetScale = new Button();
            tb_fontScale = new TrackBar();
            lbl_scaleValue = new Label();
            gb_Scene = new GroupBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            tb_Speaker = new TextBox();
            lb_Background = new Label();
            label2 = new Label();
            lb_sprite = new Label();
            lb_Speaker = new Label();
            label1 = new Label();
            tb_preview = new TextBox();
            pb_preview = new PictureBox();
            tp_CharEditor = new TabPage();
            bt_ResetView = new Button();
            btnRemove = new Button();
            bt_Remove_jp = new Button();
            btnAdd = new Button();
            lb_TitleGrid = new Label();
            dgv_Glyphs = new DataGridView();
            colChar = new DataGridViewTextBoxColumn();
            colUnicode = new DataGridViewTextBoxColumn();
            colX = new DataGridViewTextBoxColumn();
            colY = new DataGridViewTextBoxColumn();
            colW = new DataGridViewTextBoxColumn();
            colH = new DataGridViewTextBoxColumn();
            ColAdvX = new DataGridViewTextBoxColumn();
            colMarginLeft = new DataGridViewTextBoxColumn();
            colMarginRight = new DataGridViewTextBoxColumn();
            colMarginVertical = new DataGridViewTextBoxColumn();
            pb_FontTexture = new PictureBox();
            menuStrip1.SuspendLayout();
            tbc_Font.SuspendLayout();
            tb_Glyph.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tb_fontScale).BeginInit();
            gb_Scene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_preview).BeginInit();
            tp_CharEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Glyphs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_FontTexture).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1290, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openfontToolStripMenuItem, toolStripMenuItem1, loadTextureToolStripMenuItem, toolStripSeparator1, savefontToolStripMenuItem, savefontAsToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openfontToolStripMenuItem
            // 
            openfontToolStripMenuItem.Name = "openfontToolStripMenuItem";
            openfontToolStripMenuItem.Size = new Size(243, 26);
            openfontToolStripMenuItem.Text = "Open .font";
            openfontToolStripMenuItem.Click += openfontToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(243, 26);
            toolStripMenuItem1.Text = "Open .font and Texture";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // loadTextureToolStripMenuItem
            // 
            loadTextureToolStripMenuItem.Name = "loadTextureToolStripMenuItem";
            loadTextureToolStripMenuItem.Size = new Size(243, 26);
            loadTextureToolStripMenuItem.Text = "Load Texture (.png, ...)";
            loadTextureToolStripMenuItem.Click += loadTextureToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(240, 6);
            // 
            // savefontToolStripMenuItem
            // 
            savefontToolStripMenuItem.Name = "savefontToolStripMenuItem";
            savefontToolStripMenuItem.Size = new Size(243, 26);
            savefontToolStripMenuItem.Text = "Save .font";
            savefontToolStripMenuItem.Click += savefontToolStripMenuItem_Click;
            // 
            // savefontAsToolStripMenuItem
            // 
            savefontAsToolStripMenuItem.Name = "savefontAsToolStripMenuItem";
            savefontAsToolStripMenuItem.Size = new Size(243, 26);
            savefontAsToolStripMenuItem.Text = "Save .font As...";
            savefontAsToolStripMenuItem.Click += savefontAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(240, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(243, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // tbc_Font
            // 
            tbc_Font.Controls.Add(tb_Glyph);
            tbc_Font.Controls.Add(tp_CharEditor);
            tbc_Font.Dock = DockStyle.Fill;
            tbc_Font.Location = new Point(0, 28);
            tbc_Font.Name = "tbc_Font";
            tbc_Font.SelectedIndex = 0;
            tbc_Font.Size = new Size(1290, 579);
            tbc_Font.TabIndex = 1;
            // 
            // tb_Glyph
            // 
            tb_Glyph.BackColor = Color.White;
            tb_Glyph.Controls.Add(groupBox1);
            tb_Glyph.Controls.Add(gb_Scene);
            tb_Glyph.Controls.Add(label1);
            tb_Glyph.Controls.Add(tb_preview);
            tb_Glyph.Controls.Add(pb_preview);
            tb_Glyph.Location = new Point(4, 29);
            tb_Glyph.Name = "tb_Glyph";
            tb_Glyph.Padding = new Padding(3);
            tb_Glyph.Size = new Size(1282, 546);
            tb_Glyph.TabIndex = 0;
            tb_Glyph.Text = "Dialogue Simulator";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(bt_ResetScale);
            groupBox1.Controls.Add(tb_fontScale);
            groupBox1.Controls.Add(lbl_scaleValue);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(732, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(542, 101);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Font";
            // 
            // bt_ResetScale
            // 
            bt_ResetScale.FlatStyle = FlatStyle.Flat;
            bt_ResetScale.Location = new Point(406, 26);
            bt_ResetScale.Name = "bt_ResetScale";
            bt_ResetScale.Size = new Size(130, 29);
            bt_ResetScale.TabIndex = 7;
            bt_ResetScale.Text = "Reset Scale";
            bt_ResetScale.UseVisualStyleBackColor = true;
            bt_ResetScale.Click += ResetScale_Click;
            // 
            // tb_fontScale
            // 
            tb_fontScale.BackColor = Color.White;
            tb_fontScale.Location = new Point(130, 26);
            tb_fontScale.Maximum = 200;
            tb_fontScale.Minimum = 10;
            tb_fontScale.Name = "tb_fontScale";
            tb_fontScale.Size = new Size(270, 56);
            tb_fontScale.TabIndex = 7;
            tb_fontScale.TickFrequency = 10;
            tb_fontScale.Value = 55;
            tb_fontScale.Scroll += FontScale_Scroll;
            // 
            // lbl_scaleValue
            // 
            lbl_scaleValue.AutoSize = true;
            lbl_scaleValue.Location = new Point(16, 26);
            lbl_scaleValue.Name = "lbl_scaleValue";
            lbl_scaleValue.Size = new Size(83, 20);
            lbl_scaleValue.TabIndex = 0;
            lbl_scaleValue.Text = "Scale: 0,55";
            // 
            // gb_Scene
            // 
            gb_Scene.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gb_Scene.Controls.Add(comboBox2);
            gb_Scene.Controls.Add(textBox1);
            gb_Scene.Controls.Add(label3);
            gb_Scene.Controls.Add(comboBox1);
            gb_Scene.Controls.Add(tb_Speaker);
            gb_Scene.Controls.Add(lb_Background);
            gb_Scene.Controls.Add(label2);
            gb_Scene.Controls.Add(lb_sprite);
            gb_Scene.Controls.Add(lb_Speaker);
            gb_Scene.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gb_Scene.Location = new Point(732, 237);
            gb_Scene.Name = "gb_Scene";
            gb_Scene.Size = new Size(542, 177);
            gb_Scene.TabIndex = 5;
            gb_Scene.TabStop = false;
            gb_Scene.Text = "Scene";
            // 
            // comboBox2
            // 
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(130, 133);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(227, 28);
            comboBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(130, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "Normal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 85);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(130, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 28);
            comboBox1.TabIndex = 6;
            // 
            // tb_Speaker
            // 
            tb_Speaker.Enabled = false;
            tb_Speaker.Location = new Point(130, 32);
            tb_Speaker.Name = "tb_Speaker";
            tb_Speaker.Size = new Size(227, 27);
            tb_Speaker.TabIndex = 4;
            // 
            // lb_Background
            // 
            lb_Background.AutoSize = true;
            lb_Background.Location = new Point(6, 136);
            lb_Background.Name = "lb_Background";
            lb_Background.Size = new Size(93, 20);
            lb_Background.TabIndex = 3;
            lb_Background.Text = "Background";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 102);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Mode";
            // 
            // lb_sprite
            // 
            lb_sprite.AutoSize = true;
            lb_sprite.Location = new Point(49, 68);
            lb_sprite.Name = "lb_sprite";
            lb_sprite.Size = new Size(50, 20);
            lb_sprite.TabIndex = 1;
            lb_sprite.Text = "Sprite";
            // 
            // lb_Speaker
            // 
            lb_Speaker.AutoSize = true;
            lb_Speaker.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_Speaker.Location = new Point(32, 35);
            lb_Speaker.Name = "lb_Speaker";
            lb_Speaker.Size = new Size(64, 20);
            lb_Speaker.TabIndex = 0;
            lb_Speaker.Text = "Speaker";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(732, 6);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 4;
            label1.Text = "Preview Text";
            // 
            // tb_preview
            // 
            tb_preview.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_preview.Location = new Point(732, 29);
            tb_preview.Multiline = true;
            tb_preview.Name = "tb_preview";
            tb_preview.Size = new Size(542, 95);
            tb_preview.TabIndex = 3;
            tb_preview.TabStop = false;
            tb_preview.Text = "Atenção: A execução começará em 3, 2, 1... \r\nA esperança vencerá o desespero? purupuru";
            tb_preview.TextChanged += Preview_TextChanged;
            // 
            // pb_preview
            // 
            pb_preview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pb_preview.BackColor = Color.Black;
            pb_preview.Location = new Point(6, 6);
            pb_preview.Name = "pb_preview";
            pb_preview.Size = new Size(720, 408);
            pb_preview.TabIndex = 2;
            pb_preview.TabStop = false;
            pb_preview.Paint += Preview_Paint;
            // 
            // tp_CharEditor
            // 
            tp_CharEditor.Controls.Add(bt_ResetView);
            tp_CharEditor.Controls.Add(btnRemove);
            tp_CharEditor.Controls.Add(bt_Remove_jp);
            tp_CharEditor.Controls.Add(btnAdd);
            tp_CharEditor.Controls.Add(lb_TitleGrid);
            tp_CharEditor.Controls.Add(dgv_Glyphs);
            tp_CharEditor.Controls.Add(pb_FontTexture);
            tp_CharEditor.Location = new Point(4, 29);
            tp_CharEditor.Name = "tp_CharEditor";
            tp_CharEditor.Padding = new Padding(3);
            tp_CharEditor.Size = new Size(1282, 546);
            tp_CharEditor.TabIndex = 1;
            tp_CharEditor.Text = "Character Editor";
            tp_CharEditor.UseVisualStyleBackColor = true;
            // 
            // bt_ResetView
            // 
            bt_ResetView.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_ResetView.AutoSize = true;
            bt_ResetView.FlatStyle = FlatStyle.Flat;
            bt_ResetView.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bt_ResetView.Location = new Point(1165, 494);
            bt_ResetView.Name = "bt_ResetView";
            bt_ResetView.Size = new Size(109, 36);
            bt_ResetView.TabIndex = 2;
            bt_ResetView.Text = "Reset View";
            bt_ResetView.UseVisualStyleBackColor = true;
            bt_ResetView.Click += button1_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemove.Location = new Point(855, 494);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(152, 36);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove Selected";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += BtnRemove_Click;
            // 
            // bt_Remove_jp
            // 
            bt_Remove_jp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_Remove_jp.FlatStyle = FlatStyle.Flat;
            bt_Remove_jp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bt_Remove_jp.Location = new Point(1013, 494);
            bt_Remove_jp.Name = "bt_Remove_jp";
            bt_Remove_jp.Size = new Size(146, 36);
            bt_Remove_jp.TabIndex = 5;
            bt_Remove_jp.Text = "Clean Japanese";
            bt_Remove_jp.UseVisualStyleBackColor = true;
            bt_Remove_jp.Click += bt_Remove_jp_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(731, 494);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 36);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Glyph";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // lb_TitleGrid
            // 
            lb_TitleGrid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lb_TitleGrid.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lb_TitleGrid.Location = new Point(639, 6);
            lb_TitleGrid.Name = "lb_TitleGrid";
            lb_TitleGrid.Size = new Size(296, 23);
            lb_TitleGrid.TabIndex = 6;
            lb_TitleGrid.Text = "Character Editor (Waiting for file...)";
            // 
            // dgv_Glyphs
            // 
            dgv_Glyphs.AllowUserToAddRows = false;
            dgv_Glyphs.AllowUserToDeleteRows = false;
            dgv_Glyphs.AllowUserToResizeColumns = false;
            dgv_Glyphs.AllowUserToResizeRows = false;
            dgv_Glyphs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgv_Glyphs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_Glyphs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_Glyphs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Glyphs.Columns.AddRange(new DataGridViewColumn[] { colChar, colUnicode, colX, colY, colW, colH, ColAdvX, colMarginLeft, colMarginRight, colMarginVertical });
            dgv_Glyphs.Location = new Point(639, 32);
            dgv_Glyphs.Name = "dgv_Glyphs";
            dgv_Glyphs.RowHeadersVisible = false;
            dgv_Glyphs.RowHeadersWidth = 51;
            dgv_Glyphs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Glyphs.Size = new Size(635, 456);
            dgv_Glyphs.TabIndex = 1;
            dgv_Glyphs.CellValidating += dgv_Glyphs_CellValidating;
            dgv_Glyphs.DataBindingComplete += dgv_Glyphs_DataBindingComplete;
            dgv_Glyphs.SelectionChanged += dgv_Glyphs_SelectionChanged;
            // 
            // colChar
            // 
            colChar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colChar.FillWeight = 85F;
            colChar.HeaderText = "UTF-16";
            colChar.MinimumWidth = 2;
            colChar.Name = "colChar";
            colChar.ReadOnly = true;
            colChar.Resizable = DataGridViewTriState.False;
            // 
            // colUnicode
            // 
            colUnicode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUnicode.FillWeight = 90F;
            colUnicode.HeaderText = "Unicode";
            colUnicode.MinimumWidth = 2;
            colUnicode.Name = "colUnicode";
            colUnicode.ReadOnly = true;
            colUnicode.Resizable = DataGridViewTriState.False;
            // 
            // colX
            // 
            colX.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colX.DataPropertyName = "Xpos";
            colX.FillWeight = 60F;
            colX.HeaderText = "X";
            colX.MinimumWidth = 2;
            colX.Name = "colX";
            colX.Resizable = DataGridViewTriState.False;
            // 
            // colY
            // 
            colY.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colY.DataPropertyName = "Ypos";
            colY.FillWeight = 60F;
            colY.HeaderText = "Y";
            colY.MinimumWidth = 2;
            colY.Name = "colY";
            colY.Resizable = DataGridViewTriState.False;
            // 
            // colW
            // 
            colW.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colW.DataPropertyName = "Width";
            colW.FillWeight = 80F;
            colW.HeaderText = "Width";
            colW.MinimumWidth = 2;
            colW.Name = "colW";
            colW.Resizable = DataGridViewTriState.False;
            // 
            // colH
            // 
            colH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colH.DataPropertyName = "Height";
            colH.FillWeight = 80F;
            colH.HeaderText = "Height";
            colH.MinimumWidth = 2;
            colH.Name = "colH";
            colH.Resizable = DataGridViewTriState.False;
            // 
            // ColAdvX
            // 
            ColAdvX.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColAdvX.DataPropertyName = "AdvanceX";
            ColAdvX.HeaderText = "AdvanceX";
            ColAdvX.MinimumWidth = 2;
            ColAdvX.Name = "ColAdvX";
            ColAdvX.Resizable = DataGridViewTriState.False;
            // 
            // colMarginLeft
            // 
            colMarginLeft.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMarginLeft.DataPropertyName = "MarginLeft";
            colMarginLeft.FillWeight = 85F;
            colMarginLeft.HeaderText = "Margin Left";
            colMarginLeft.MinimumWidth = 2;
            colMarginLeft.Name = "colMarginLeft";
            colMarginLeft.Resizable = DataGridViewTriState.False;
            // 
            // colMarginRight
            // 
            colMarginRight.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMarginRight.DataPropertyName = "MarginRight";
            colMarginRight.FillWeight = 85F;
            colMarginRight.HeaderText = "Margin Right";
            colMarginRight.MinimumWidth = 2;
            colMarginRight.Name = "colMarginRight";
            colMarginRight.Resizable = DataGridViewTriState.False;
            // 
            // colMarginVertical
            // 
            colMarginVertical.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMarginVertical.DataPropertyName = "MarginVertical";
            colMarginVertical.FillWeight = 85F;
            colMarginVertical.HeaderText = "Margin Vertical";
            colMarginVertical.MinimumWidth = 2;
            colMarginVertical.Name = "colMarginVertical";
            colMarginVertical.Resizable = DataGridViewTriState.False;
            // 
            // pb_FontTexture
            // 
            pb_FontTexture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pb_FontTexture.BackColor = Color.Black;
            pb_FontTexture.Location = new Point(3, 6);
            pb_FontTexture.Name = "pb_FontTexture";
            pb_FontTexture.Size = new Size(630, 532);
            pb_FontTexture.TabIndex = 0;
            pb_FontTexture.TabStop = false;
            pb_FontTexture.Paint += FontTexture_Paint;
            pb_FontTexture.MouseDown += FontTexture_MouseDown;
            pb_FontTexture.MouseMove += FontTexture_MouseMove;
            pb_FontTexture.MouseUp += FontTexture_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 607);
            Controls.Add(tbc_Font);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Font Editor";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tbc_Font.ResumeLayout(false);
            tb_Glyph.ResumeLayout(false);
            tb_Glyph.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tb_fontScale).EndInit();
            gb_Scene.ResumeLayout(false);
            gb_Scene.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_preview).EndInit();
            tp_CharEditor.ResumeLayout(false);
            tp_CharEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Glyphs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_FontTexture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openfontToolStripMenuItem;
        private ToolStripMenuItem loadTextureToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem savefontToolStripMenuItem;
        private ToolStripMenuItem savefontAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TabControl tbc_Font;
        private TabPage tb_Glyph;
        private TabPage tp_CharEditor;
        private PictureBox pb_preview;
        private TextBox tb_preview;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label label1;
        private PictureBox pb_FontTexture;
        private DataGridView dgv_Glyphs;
        private Button bt_ResetView;
        private Button btnRemove;
        private Button btnAdd;
        private Button bt_Remove_jp;
        private Label lb_TitleGrid;
        private DataGridViewTextBoxColumn colChar;
        private DataGridViewTextBoxColumn colUnicode;
        private DataGridViewTextBoxColumn colX;
        private DataGridViewTextBoxColumn colY;
        private DataGridViewTextBoxColumn colW;
        private DataGridViewTextBoxColumn colH;
        private DataGridViewTextBoxColumn ColAdvX;
        private DataGridViewTextBoxColumn colMarginLeft;
        private DataGridViewTextBoxColumn colMarginRight;
        private DataGridViewTextBoxColumn colMarginVertical;
        private GroupBox gb_Scene;
        private TextBox tb_Speaker;
        private Label lb_Background;
        private Label label2;
        private Label lb_sprite;
        private Label lb_Speaker;
        private Label label3;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Label lbl_scaleValue;
        private TrackBar tb_fontScale;
        private Button bt_ResetScale;
    }
}
