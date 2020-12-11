namespace WeAreTheChampions
{
    partial class ColorsForm
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
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.hsBlue = new System.Windows.Forms.HScrollBar();
            this.hsGreen = new System.Windows.Forms.HScrollBar();
            this.hsRed = new System.Windows.Forms.HScrollBar();
            this.lstColors = new System.Windows.Forms.ListBox();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblSelectedColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnAdd.Location = new System.Drawing.Point(31, 239);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(739, 65);
            this.btnAdd.TabIndex = 79;
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
            this.btnDelete.Location = new System.Drawing.Point(465, 649);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(305, 76);
            this.btnDelete.TabIndex = 78;
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
            this.btnEdit.Location = new System.Drawing.Point(33, 649);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(292, 76);
            this.btnEdit.TabIndex = 77;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseCompatibleTextRendering = true;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblBlue
            // 
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBlue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBlue.Location = new System.Drawing.Point(551, 187);
            this.lblBlue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(64, 33);
            this.lblBlue.TabIndex = 76;
            this.lblBlue.Text = "000";
            // 
            // lblRed
            // 
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRed.Location = new System.Drawing.Point(551, 78);
            this.lblRed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(64, 33);
            this.lblRed.TabIndex = 75;
            this.lblRed.Text = "000";
            // 
            // lblGreen
            // 
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGreen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGreen.Location = new System.Drawing.Point(551, 135);
            this.lblGreen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(64, 33);
            this.lblGreen.TabIndex = 74;
            this.lblGreen.Text = "000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(29, 187);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 31);
            this.label12.TabIndex = 73;
            this.label12.Text = "Blue";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(29, 135);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 31);
            this.label11.TabIndex = 72;
            this.label11.Text = "Green";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(29, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 31);
            this.label10.TabIndex = 71;
            this.label10.Text = "Red";
            // 
            // hsBlue
            // 
            this.hsBlue.LargeChange = 1;
            this.hsBlue.Location = new System.Drawing.Point(138, 195);
            this.hsBlue.Maximum = 255;
            this.hsBlue.Name = "hsBlue";
            this.hsBlue.Size = new System.Drawing.Size(407, 18);
            this.hsBlue.TabIndex = 70;
            this.hsBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsBlue_Scroll);
            // 
            // hsGreen
            // 
            this.hsGreen.LargeChange = 1;
            this.hsGreen.Location = new System.Drawing.Point(138, 143);
            this.hsGreen.Maximum = 255;
            this.hsGreen.Name = "hsGreen";
            this.hsGreen.Size = new System.Drawing.Size(407, 18);
            this.hsGreen.TabIndex = 69;
            this.hsGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsGreen_Scroll);
            // 
            // hsRed
            // 
            this.hsRed.LargeChange = 1;
            this.hsRed.Location = new System.Drawing.Point(138, 86);
            this.hsRed.Maximum = 255;
            this.hsRed.Name = "hsRed";
            this.hsRed.Size = new System.Drawing.Size(407, 18);
            this.hsRed.TabIndex = 68;
            this.hsRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsRed_Scroll);
            // 
            // lstColors
            // 
            this.lstColors.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstColors.DisplayMember = "ColorName";
            this.lstColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstColors.FormattingEnabled = true;
            this.lstColors.ItemHeight = 31;
            this.lstColors.Location = new System.Drawing.Point(34, 316);
            this.lstColors.Margin = new System.Windows.Forms.Padding(6);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(663, 314);
            this.lstColors.TabIndex = 66;
            this.lstColors.SelectedIndexChanged += new System.EventHandler(this.lstColors_SelectedIndexChanged);
            // 
            // txtColorName
            // 
            this.txtColorName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtColorName.Location = new System.Drawing.Point(230, 12);
            this.txtColorName.Margin = new System.Windows.Forms.Padding(6);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(539, 29);
            this.txtColorName.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(24, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 37);
            this.label3.TabIndex = 64;
            this.label3.Text = "Color Name : ";
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Black;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblColor.Location = new System.Drawing.Point(627, 78);
            this.lblColor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(142, 142);
            this.lblColor.TabIndex = 63;
            // 
            // lblSelectedColor
            // 
            this.lblSelectedColor.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSelectedColor.Location = new System.Drawing.Point(709, 316);
            this.lblSelectedColor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelectedColor.Name = "lblSelectedColor";
            this.lblSelectedColor.Size = new System.Drawing.Size(60, 314);
            this.lblSelectedColor.TabIndex = 80;
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(795, 731);
            this.Controls.Add(this.lblSelectedColor);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.hsBlue);
            this.Controls.Add(this.hsGreen);
            this.Controls.Add(this.hsRed);
            this.Controls.Add(this.lstColors);
            this.Controls.Add(this.txtColorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblColor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ColorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Color";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.HScrollBar hsBlue;
        private System.Windows.Forms.HScrollBar hsGreen;
        private System.Windows.Forms.HScrollBar hsRed;
        private System.Windows.Forms.ListBox lstColors;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblSelectedColor;
    }
}