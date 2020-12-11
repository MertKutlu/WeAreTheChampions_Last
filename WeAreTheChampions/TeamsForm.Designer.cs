namespace WeAreTheChampions
{
    partial class TeamsForm
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
            this.lblColor2 = new System.Windows.Forms.Label();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboColor2 = new System.Windows.Forms.ComboBox();
            this.cboColor1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnListPlayers = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblColor4 = new System.Windows.Forms.Label();
            this.lblColor3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColor2
            // 
            this.lblColor2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor2.Location = new System.Drawing.Point(339, 85);
            this.lblColor2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(33, 33);
            this.lblColor2.TabIndex = 33;
            // 
            // lblColor1
            // 
            this.lblColor1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor1.Location = new System.Drawing.Point(339, 29);
            this.lblColor1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(33, 33);
            this.lblColor1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 31;
            this.label4.Text = "2nd Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(9, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "1st Color:";
            // 
            // cboColor2
            // 
            this.cboColor2.DisplayMember = "ColorName";
            this.cboColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboColor2.FormattingEnabled = true;
            this.cboColor2.Location = new System.Drawing.Point(121, 85);
            this.cboColor2.Margin = new System.Windows.Forms.Padding(6);
            this.cboColor2.Name = "cboColor2";
            this.cboColor2.Size = new System.Drawing.Size(198, 33);
            this.cboColor2.TabIndex = 29;
            this.cboColor2.SelectedIndexChanged += new System.EventHandler(this.cboColor2_SelectedIndexChanged);
            // 
            // cboColor1
            // 
            this.cboColor1.DisplayMember = "ColorName";
            this.cboColor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboColor1.FormattingEnabled = true;
            this.cboColor1.Location = new System.Drawing.Point(121, 29);
            this.cboColor1.Margin = new System.Windows.Forms.Padding(6);
            this.cboColor1.Name = "cboColor1";
            this.cboColor1.Size = new System.Drawing.Size(198, 33);
            this.cboColor1.TabIndex = 28;
            this.cboColor1.SelectedIndexChanged += new System.EventHandler(this.cboColor1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Team Name :";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeamName.Location = new System.Drawing.Point(9, 92);
            this.txtTeamName.Margin = new System.Windows.Forms.Padding(6);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(274, 32);
            this.txtTeamName.TabIndex = 22;
            // 
            // lstTeams
            // 
            this.lstTeams.DisplayMember = "TeamName";
            this.lstTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.ItemHeight = 25;
            this.lstTeams.Location = new System.Drawing.Point(36, 293);
            this.lstTeams.Margin = new System.Windows.Forms.Padding(7);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(701, 429);
            this.lstTeams.TabIndex = 21;
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.lstTeams_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 42;
            this.btnDelete.Location = new System.Drawing.Point(542, 740);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(195, 64);
            this.btnDelete.TabIndex = 41;
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
            this.btnEdit.Location = new System.Drawing.Point(33, 740);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(182, 64);
            this.btnEdit.TabIndex = 40;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseCompatibleTextRendering = true;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 40;
            this.btnAdd.Location = new System.Drawing.Point(6, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(689, 52);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnListPlayers
            // 
            this.btnListPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListPlayers.BackColor = System.Drawing.Color.Chocolate;
            this.btnListPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListPlayers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListPlayers.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnListPlayers.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListPlayers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListPlayers.IconSize = 40;
            this.btnListPlayers.Location = new System.Drawing.Point(36, 231);
            this.btnListPlayers.Name = "btnListPlayers";
            this.btnListPlayers.Size = new System.Drawing.Size(701, 52);
            this.btnListPlayers.TabIndex = 43;
            this.btnListPlayers.Text = " List Players";
            this.btnListPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListPlayers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListPlayers.UseVisualStyleBackColor = false;
            this.btnListPlayers.Click += new System.EventHandler(this.btnListPlayers_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTeamName);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 213);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Team";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblColor1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboColor1);
            this.groupBox2.Controls.Add(this.lblColor2);
            this.groupBox2.Controls.Add(this.cboColor2);
            this.groupBox2.Controls.Add(this.ıconPictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(312, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 131);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "         ";
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ıconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.ıconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 49;
            this.ıconPictureBox1.Location = new System.Drawing.Point(23, 0);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(56, 49);
            this.ıconPictureBox1.TabIndex = 34;
            this.ıconPictureBox1.TabStop = false;
            // 
            // lblColor4
            // 
            this.lblColor4.Location = new System.Drawing.Point(740, 231);
            this.lblColor4.Name = "lblColor4";
            this.lblColor4.Size = new System.Drawing.Size(27, 491);
            this.lblColor4.TabIndex = 45;
            // 
            // lblColor3
            // 
            this.lblColor3.Location = new System.Drawing.Point(3, 231);
            this.lblColor3.Name = "lblColor3";
            this.lblColor3.Size = new System.Drawing.Size(27, 491);
            this.lblColor3.TabIndex = 46;
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(770, 807);
            this.Controls.Add(this.lblColor3);
            this.Controls.Add(this.lblColor4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListPlayers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lstTeams);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TeamsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teams";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblColor2;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboColor2;
        private System.Windows.Forms.ComboBox cboColor1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.ListBox lstTeams;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnListPlayers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private System.Windows.Forms.Label lblColor4;
        private System.Windows.Forms.Label lblColor3;
    }
}