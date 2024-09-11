using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GBA_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> Marks = new List<int>();
        List<int> Hours = new List<int>();
        private double _GetPointEquivalence(int Mark)
        {
            if (Mark >= 98) return 4;
            if (Mark >= 95) return 3.75;
            if (Mark >= 90) return 3.5;
            if (Mark >= 85) return 3.25;
            if (Mark >= 80) return 3;
            if (Mark >= 75) return 2.75;
            if (Mark >= 70) return 2.5;
            if (Mark >= 65) return 2.25;
            if (Mark >= 60) return 2;
            if (Mark >= 55) return 1.75;
            if (Mark >= 50) return 1.5;
            return 0;
        }
        private int _GetTotalHours()
        {
            int TotalHours = 0;
            foreach (int i in Hours)
                TotalHours += i;
            return TotalHours;
        }
        private bool _IsHoursEnd()
        {
            return _GetTotalHours() + Convert.ToInt32(txtHours.Text) > Convert.ToInt32(txtTotalHours.Text);
        }
        private void _GetRemainHours()
        {
            lblHoursFromTotal.Text = _GetTotalHours().ToString() + "/" + txtTotalHours.Text + " Hours";
        }
        private void _AddSubject()
        {
            Marks.Add(Convert.ToInt32(txtMark.Text));
            Hours.Add(Convert.ToInt32(txtHours.Text));
            _GetRemainHours();
            txtMark.Text = "";
            txtHours.Text = "";
        }
        private void txtTotalHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTotalHours.Text.Length == 3)
            {
                if (!(e.Handled = !(e.KeyChar == (char)Keys.Back))) return;
                e.Handled = true;
                return;
            }
            if (txtTotalHours.Text.Length == 0) e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) && e.KeyChar != '0');
            else e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)));
        }
        private void txtMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMark.Text.Length == 3)
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                    return;
                }
                e.Handled = true;
                return;
            }
            if (txtMark.Text.Length == 2)
            {
                if ((txtMark.Text.Equals("10") && e.KeyChar == '0') || e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                    return;
                }
                e.Handled = true;
                return;
            }
            if (txtMark.Text.Length == 0) e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) && e.KeyChar != '0');
            else e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)));
        }
        private void txtHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtHours.Text.Length == 1)
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                    return;
                }
                e.Handled = true;
                return;
            }
            if (txtHours.Text.Length == 0) e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) && e.KeyChar != '0');
            else e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)));
        }
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            _AddSubject();
            btnRemoveLastSubject.Enabled = true;
            btnClearData.Enabled = true;
            if (_GetTotalHours() == Convert.ToInt32(txtTotalHours.Text))
            {
                btnCalculateGBA.Enabled = true;
                btnAddSubject.Enabled = false;
                txtHours.Enabled = false;
                txtMark.Enabled = false;
            }
            txtTotalHours.Enabled = false;
        }
        private void btnRemoveLastSubject_Click(object sender, EventArgs e)
        {
            Marks.RemoveAt(Marks.Count - 1);
            Hours.RemoveAt(Hours.Count - 1);
            _GetRemainHours();
            if (Marks.Count == 0) btnRemoveLastSubject.Enabled = false;
            txtHours.Enabled = true;
            txtMark.Enabled = true;
        }
        private void btnClearData_Click(object sender, EventArgs e)
        {
            Marks.Clear();
            Hours.Clear();
            txtHours.Clear();
            txtMark.Clear();
            txtTotalHours.Clear();
            lblGBA.Text = string.Empty;
            lblHoursFromTotal.Text = string.Empty;
            btnAddSubject.Enabled = false;
            btnCalculateGBA.Enabled = false;
            btnClearData.Enabled = false;
            btnRemoveLastSubject.Enabled = false;
            txtTotalHours.Enabled = true;
            txtHours.Enabled = true;
            txtMark.Enabled = true;
        }
        private void btnCalculateGBA_Click(object sender, EventArgs e)
        {
            double GBA = 0;
            for (int i = 0; i < Marks.Count; i++)
                GBA += _GetPointEquivalence(Marks[i]) * Hours[i];
            GBA /= Convert.ToInt32(txtTotalHours.Text);
            lblGBA.Text = GBA.ToString() + "/4.0";
            btnCalculateGBA.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnAddSubject.Enabled = false;
            btnCalculateGBA.Enabled = false;
            btnClearData.Enabled = false;
            btnRemoveLastSubject.Enabled = false;
        }
        private void txtSubject_TextChanged(object sender, EventArgs e)
        {
            if (txtMark.Text != string.Empty && txtHours.Text != string.Empty && txtTotalHours.Text != string.Empty && _IsHoursEnd())
            {
                btnAddSubject.Enabled = false;
                return;
            }
            if (txtTotalHours.Text == string.Empty) return;
            if (_GetTotalHours() == Convert.ToInt32(txtTotalHours.Text)) return;
            if (txtMark.Text != string.Empty && txtHours.Text != string.Empty && txtTotalHours.Text != string.Empty) btnAddSubject.Enabled = true;
            else btnAddSubject.Enabled = false;
        }
    }
}