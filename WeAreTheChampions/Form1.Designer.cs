namespace WeAreTheChampions
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.chkHideCompleted = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.gbNewMatch = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewMatchCancel = new FontAwesome.Sharp.IconButton();
            this.btnMatchAdd = new FontAwesome.Sharp.IconButton();
            this.cboNewTeam1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboNewTeam2 = new System.Windows.Forms.ComboBox();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.gbEditMatch = new System.Windows.Forms.GroupBox();
            this.btnEditMatchCancel = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.nudScore2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudScore1 = new System.Windows.Forms.NumericUpDown();
            this.dtpEditDate = new System.Windows.Forms.DateTimePicker();
            this.cboEditTeam2 = new System.Windows.Forms.ComboBox();
            this.cboEditTeam1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.pbGif = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.gbNewMatch.SuspendLayout();
            this.gbEditMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTeams,
            this.tsmiColors,
            this.tsmiPlayers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1310, 36);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiTeams
            // 
            this.tsmiTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiTeams.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmiTeams.Name = "tsmiTeams";
            this.tsmiTeams.Size = new System.Drawing.Size(85, 28);
            this.tsmiTeams.Text = "Teams";
            this.tsmiTeams.Click += new System.EventHandler(this.tsmiTeams_Click);
            // 
            // tsmiColors
            // 
            this.tsmiColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiColors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmiColors.Name = "tsmiColors";
            this.tsmiColors.Size = new System.Drawing.Size(82, 28);
            this.tsmiColors.Text = "Colors";
            this.tsmiColors.Click += new System.EventHandler(this.tsmiColors_Click);
            // 
            // tsmiPlayers
            // 
            this.tsmiPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiPlayers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmiPlayers.Name = "tsmiPlayers";
            this.tsmiPlayers.Size = new System.Drawing.Size(90, 28);
            this.tsmiPlayers.Text = "Players";
            this.tsmiPlayers.Click += new System.EventHandler(this.tsmiPlayers_Click);
            // 
            // chkHideCompleted
            // 
            this.chkHideCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHideCompleted.AutoSize = true;
            this.chkHideCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkHideCompleted.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkHideCompleted.Location = new System.Drawing.Point(982, 61);
            this.chkHideCompleted.Margin = new System.Windows.Forms.Padding(6);
            this.chkHideCompleted.Name = "chkHideCompleted";
            this.chkHideCompleted.Size = new System.Drawing.Size(272, 29);
            this.chkHideCompleted.TabIndex = 23;
            this.chkHideCompleted.Text = "Hide Completed Matches";
            this.chkHideCompleted.UseVisualStyleBackColor = true;
            this.chkHideCompleted.CheckedChanged += new System.EventHandler(this.chkHideCompleted_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(89, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 51);
            this.label1.TabIndex = 19;
            this.label1.Text = "Match List";
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Location = new System.Drawing.Point(15, 102);
            this.dgvMatches.Margin = new System.Windows.Forms.Padding(7);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(1280, 374);
            this.dgvMatches.TabIndex = 18;
            // 
            // gbNewMatch
            // 
            this.gbNewMatch.Controls.Add(this.label2);
            this.gbNewMatch.Controls.Add(this.btnNewMatchCancel);
            this.gbNewMatch.Controls.Add(this.btnMatchAdd);
            this.gbNewMatch.Controls.Add(this.cboNewTeam1);
            this.gbNewMatch.Controls.Add(this.label3);
            this.gbNewMatch.Controls.Add(this.label4);
            this.gbNewMatch.Controls.Add(this.label5);
            this.gbNewMatch.Controls.Add(this.cboNewTeam2);
            this.gbNewMatch.Controls.Add(this.dtpNewDate);
            this.gbNewMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbNewMatch.ForeColor = System.Drawing.Color.Maroon;
            this.gbNewMatch.Location = new System.Drawing.Point(15, 475);
            this.gbNewMatch.Name = "gbNewMatch";
            this.gbNewMatch.Size = new System.Drawing.Size(1286, 215);
            this.gbNewMatch.TabIndex = 57;
            this.gbNewMatch.TabStop = false;
            this.gbNewMatch.Text = "New Match";
            this.gbNewMatch.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(363, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 31);
            this.label2.TabIndex = 53;
            this.label2.Text = "VS";
            // 
            // btnNewMatchCancel
            // 
            this.btnNewMatchCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewMatchCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewMatchCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewMatchCancel.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnNewMatchCancel.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewMatchCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewMatchCancel.IconSize = 40;
            this.btnNewMatchCancel.Location = new System.Drawing.Point(1090, 28);
            this.btnNewMatchCancel.Name = "btnNewMatchCancel";
            this.btnNewMatchCancel.Size = new System.Drawing.Size(187, 68);
            this.btnNewMatchCancel.TabIndex = 52;
            this.btnNewMatchCancel.Text = "Cancel";
            this.btnNewMatchCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewMatchCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewMatchCancel.UseVisualStyleBackColor = false;
            this.btnNewMatchCancel.Click += new System.EventHandler(this.btnNewMatchCancel_Click);
            // 
            // btnMatchAdd
            // 
            this.btnMatchAdd.BackColor = System.Drawing.Color.OrangeRed;
            this.btnMatchAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMatchAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMatchAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnMatchAdd.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMatchAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMatchAdd.IconSize = 40;
            this.btnMatchAdd.Location = new System.Drawing.Point(856, 29);
            this.btnMatchAdd.Name = "btnMatchAdd";
            this.btnMatchAdd.Size = new System.Drawing.Size(156, 68);
            this.btnMatchAdd.TabIndex = 38;
            this.btnMatchAdd.Text = "Add";
            this.btnMatchAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMatchAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMatchAdd.UseVisualStyleBackColor = false;
            this.btnMatchAdd.Click += new System.EventHandler(this.btnMatchAdd_Click);
            // 
            // cboNewTeam1
            // 
            this.cboNewTeam1.DisplayMember = "TeamName";
            this.cboNewTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboNewTeam1.FormattingEnabled = true;
            this.cboNewTeam1.Location = new System.Drawing.Point(9, 58);
            this.cboNewTeam1.Margin = new System.Windows.Forms.Padding(6);
            this.cboNewTeam1.Name = "cboNewTeam1";
            this.cboNewTeam1.Size = new System.Drawing.Size(334, 39);
            this.cboNewTeam1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(2, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 31);
            this.label3.TabIndex = 32;
            this.label3.Text = "Team 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(426, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 31);
            this.label4.TabIndex = 33;
            this.label4.Text = "Team 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 31);
            this.label5.TabIndex = 34;
            this.label5.Text = "Match Date:";
            // 
            // cboNewTeam2
            // 
            this.cboNewTeam2.DisplayMember = "TeamName";
            this.cboNewTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboNewTeam2.FormattingEnabled = true;
            this.cboNewTeam2.Location = new System.Drawing.Point(432, 58);
            this.cboNewTeam2.Margin = new System.Windows.Forms.Padding(6);
            this.cboNewTeam2.Name = "cboNewTeam2";
            this.cboNewTeam2.Size = new System.Drawing.Size(334, 39);
            this.cboNewTeam2.TabIndex = 36;
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.CustomFormat = "MM.dd.yyyy hh:mm tt";
            this.dtpNewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpNewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNewDate.Location = new System.Drawing.Point(203, 120);
            this.dtpNewDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(334, 38);
            this.dtpNewDate.TabIndex = 37;
            // 
            // gbEditMatch
            // 
            this.gbEditMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEditMatch.Controls.Add(this.btnEditMatchCancel);
            this.gbEditMatch.Controls.Add(this.label12);
            this.gbEditMatch.Controls.Add(this.nudScore2);
            this.gbEditMatch.Controls.Add(this.label10);
            this.gbEditMatch.Controls.Add(this.label9);
            this.gbEditMatch.Controls.Add(this.nudScore1);
            this.gbEditMatch.Controls.Add(this.dtpEditDate);
            this.gbEditMatch.Controls.Add(this.cboEditTeam2);
            this.gbEditMatch.Controls.Add(this.cboEditTeam1);
            this.gbEditMatch.Controls.Add(this.label8);
            this.gbEditMatch.Controls.Add(this.label7);
            this.gbEditMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbEditMatch.ForeColor = System.Drawing.Color.Maroon;
            this.gbEditMatch.Location = new System.Drawing.Point(14, 473);
            this.gbEditMatch.Name = "gbEditMatch";
            this.gbEditMatch.Size = new System.Drawing.Size(1287, 217);
            this.gbEditMatch.TabIndex = 58;
            this.gbEditMatch.TabStop = false;
            this.gbEditMatch.Text = "Edit Match";
            this.gbEditMatch.Visible = false;
            // 
            // btnEditMatchCancel
            // 
            this.btnEditMatchCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditMatchCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditMatchCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditMatchCancel.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnEditMatchCancel.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditMatchCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditMatchCancel.IconSize = 40;
            this.btnEditMatchCancel.Location = new System.Drawing.Point(1091, 143);
            this.btnEditMatchCancel.Name = "btnEditMatchCancel";
            this.btnEditMatchCancel.Size = new System.Drawing.Size(187, 68);
            this.btnEditMatchCancel.TabIndex = 51;
            this.btnEditMatchCancel.Text = "Cancel";
            this.btnEditMatchCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditMatchCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditMatchCancel.UseVisualStyleBackColor = false;
            this.btnEditMatchCancel.Click += new System.EventHandler(this.btnEditMatchCancel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(443, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 31);
            this.label12.TabIndex = 50;
            this.label12.Text = "-";
            // 
            // nudScore2
            // 
            this.nudScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudScore2.Location = new System.Drawing.Point(484, 148);
            this.nudScore2.Margin = new System.Windows.Forms.Padding(6);
            this.nudScore2.Name = "nudScore2";
            this.nudScore2.Size = new System.Drawing.Size(45, 38);
            this.nudScore2.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(408, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 31);
            this.label10.TabIndex = 47;
            this.label10.Text = "Score";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(18, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 31);
            this.label9.TabIndex = 44;
            this.label9.Text = "Match Date";
            // 
            // nudScore1
            // 
            this.nudScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudScore1.Location = new System.Drawing.Point(380, 148);
            this.nudScore1.Margin = new System.Windows.Forms.Padding(6);
            this.nudScore1.Name = "nudScore1";
            this.nudScore1.Size = new System.Drawing.Size(45, 38);
            this.nudScore1.TabIndex = 46;
            // 
            // dtpEditDate
            // 
            this.dtpEditDate.CustomFormat = "MM.dd.yyyy hh:mm tt";
            this.dtpEditDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpEditDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEditDate.Location = new System.Drawing.Point(183, 40);
            this.dtpEditDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpEditDate.Name = "dtpEditDate";
            this.dtpEditDate.Size = new System.Drawing.Size(315, 38);
            this.dtpEditDate.TabIndex = 45;
            // 
            // cboEditTeam2
            // 
            this.cboEditTeam2.DisplayMember = "TeamName";
            this.cboEditTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboEditTeam2.FormattingEnabled = true;
            this.cboEditTeam2.Location = new System.Drawing.Point(555, 147);
            this.cboEditTeam2.Margin = new System.Windows.Forms.Padding(6);
            this.cboEditTeam2.Name = "cboEditTeam2";
            this.cboEditTeam2.Size = new System.Drawing.Size(332, 39);
            this.cboEditTeam2.TabIndex = 43;
            // 
            // cboEditTeam1
            // 
            this.cboEditTeam1.DisplayMember = "TeamName";
            this.cboEditTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboEditTeam1.FormattingEnabled = true;
            this.cboEditTeam1.Location = new System.Drawing.Point(24, 147);
            this.cboEditTeam1.Margin = new System.Windows.Forms.Padding(6);
            this.cboEditTeam1.Name = "cboEditTeam1";
            this.cboEditTeam1.Size = new System.Drawing.Size(332, 39);
            this.cboEditTeam1.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(18, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 31);
            this.label8.TabIndex = 41;
            this.label8.Text = "Team 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(782, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 31);
            this.label7.TabIndex = 42;
            this.label7.Text = "Team 2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeAreTheChampions.Properties.Resources.VS2;
            this.pictureBox1.Location = new System.Drawing.Point(15, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ıconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.ıconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.Location = new System.Drawing.Point(1261, 58);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.ıconPictureBox1.TabIndex = 31;
            this.ıconPictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 42;
            this.btnAdd.Location = new System.Drawing.Point(17, 495);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(409, 76);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseCompatibleTextRendering = true;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 42;
            this.btnDelete.Location = new System.Drawing.Point(859, 494);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(215, 76);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseCompatibleTextRendering = true;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 42;
            this.btnEdit.Location = new System.Drawing.Point(1106, 494);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(187, 76);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseCompatibleTextRendering = true;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pbGif
            // 
            this.pbGif.Image = global::WeAreTheChampions.Properties.Resources.giphy;
            this.pbGif.Location = new System.Drawing.Point(430, 495);
            this.pbGif.Name = "pbGif";
            this.pbGif.Size = new System.Drawing.Size(424, 187);
            this.pbGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGif.TabIndex = 52;
            this.pbGif.TabStop = false;
            this.pbGif.DoubleClick += new System.EventHandler(this.pbGif_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1310, 703);
            this.Controls.Add(this.pbGif);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ıconPictureBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.chkHideCompleted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMatches);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbNewMatch);
            this.Controls.Add(this.gbEditMatch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "We Are The Champions - Sports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.gbNewMatch.ResumeLayout(false);
            this.gbNewMatch.PerformLayout();
            this.gbEditMatch.ResumeLayout(false);
            this.gbEditMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTeams;
        private System.Windows.Forms.ToolStripMenuItem tsmiColors;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayers;
        private System.Windows.Forms.CheckBox chkHideCompleted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMatches;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private System.Windows.Forms.GroupBox gbNewMatch;
        private FontAwesome.Sharp.IconButton btnMatchAdd;
        private System.Windows.Forms.ComboBox cboNewTeam1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboNewTeam2;
        private System.Windows.Forms.DateTimePicker dtpNewDate;
        private System.Windows.Forms.GroupBox gbEditMatch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudScore2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudScore1;
        private System.Windows.Forms.DateTimePicker dtpEditDate;
        private System.Windows.Forms.ComboBox cboEditTeam2;
        private System.Windows.Forms.ComboBox cboEditTeam1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnEditMatchCancel;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnNewMatchCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbGif;
    }
}

