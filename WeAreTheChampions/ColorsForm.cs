using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class ColorsForm : Form
    {
        private WeAreTheChampionsContext db;

        public ColorsForm(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            ListColors();
        }

        private void ListColors()
        {
            lstColors.DataSource = db.Colors.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var colorName = txtColorName.Text.UpperCaseFirst().Trim();
            if (colorName == "")
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }
            if (btnAdd.Text == "Save")
            {
                var selectedColor = (Models.Color)lstColors.SelectedItem;
                selectedColor.ColorName = txtColorName.Text.UpperCaseFirst();
                selectedColor.Red = Convert.ToByte(lblRed.Text);
                selectedColor.Green = Convert.ToByte(lblGreen.Text);
                selectedColor.Blue = Convert.ToByte(lblBlue.Text);
                btnAdd.Text = "Add";
                btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
                btnAdd.BackColor = System.Drawing.Color.OrangeRed;
                db.SaveChanges();
                ListColors();
                ResetColorsForm();
                btnDelete.Show();
                btnEdit.Show();
                return;

            }
            var color = new Models.Color
            {
                ColorName = txtColorName.Text.UpperCaseFirst(),
                Red = Convert.ToByte(lblRed.Text),
                Green = Convert.ToByte(lblGreen.Text),
                Blue = Convert.ToByte(lblBlue.Text)
            };
            if (db.Colors.Any(x => x.ColorName == color.ColorName))
            {
                MessageBox.Show("Please enter different color name.");
                return;
            }
            db.Colors.Add(color);
            db.SaveChanges();
            ListColors();
            ResetColorsForm();
        }

        private void ResetColorsForm()
        {
            lstColors.Enabled = true;
            btnAdd.Text = "Add ";
            txtColorName.Clear();
            lblBlue.Text = lblRed.Text = lblGreen.Text = "000";
            lblColor.BackColor = System.Drawing.Color.Black;
            hsBlue.Value = hsRed.Value = hsGreen.Value = hsBlue.Minimum;
        }

        private void hsRed_Scroll(object sender, ScrollEventArgs e)
        {
            lblRed.Text = hsRed.Value.ToString();
            lblColor.BackColor = System.Drawing.Color.FromArgb(Convert.ToByte(lblRed.Text), Convert.ToByte(lblGreen.Text), Convert.ToByte(lblBlue.Text));
        }

        private void hsGreen_Scroll(object sender, ScrollEventArgs e)
        {
            lblGreen.Text = hsGreen.Value.ToString();
            lblColor.BackColor = System.Drawing.Color.FromArgb(Convert.ToByte(lblRed.Text), Convert.ToByte(lblGreen.Text), Convert.ToByte(lblBlue.Text));
        }

        private void hsBlue_Scroll(object sender, ScrollEventArgs e)
        {
            lblBlue.Text = hsBlue.Value.ToString();
            lblColor.BackColor = System.Drawing.Color.FromArgb(Convert.ToByte(lblRed.Text), Convert.ToByte(lblGreen.Text), Convert.ToByte(lblBlue.Text));
        }

        private void lstColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedColor = (Models.Color)lstColors.SelectedItem;
            lblSelectedColor.BackColor = System.Drawing.Color.FromArgb(selectedColor.Red, selectedColor.Green, selectedColor.Blue);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstColors.SelectedIndex == 0)
                lblSelectedColor.BackColor = System.Drawing.Color.Transparent;
            if (lstColors.SelectedIndex < 0)
                return;
            var selectedColor = (Models.Color)lstColors.SelectedItem;
            db.Colors.Remove(selectedColor);
            db.SaveChanges();
            ListColors();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstColors.SelectedIndex < 0)
                return;
            var selectedColor = (Models.Color)lstColors.SelectedItem;
            txtColorName.Text = selectedColor.ColorName;
            lblBlue.Text = selectedColor.Blue.ToString();
            lblRed.Text = selectedColor.Red.ToString();
            lblGreen.Text = selectedColor.Green.ToString();
            btnAdd.Text = "Save";
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            lstColors.Enabled = false;
            lblColor.BackColor = lblSelectedColor.BackColor;
            hsGreen.Value = Convert.ToInt32(selectedColor.Green);
            hsBlue.Value = Convert.ToInt32(selectedColor.Blue);
            hsRed.Value = Convert.ToInt32(selectedColor.Red);
            btnDelete.Hide();
            btnEdit.Hide();
        }
    }
}
