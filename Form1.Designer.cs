namespace GBA_Calculator
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTotalHours = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGBA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAddSubject = new Guna.UI2.WinForms.Guna2Button();
            this.txtHours = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMark = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCalculateGBA = new Guna.UI2.WinForms.Guna2Button();
            this.lblHoursFromTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnRemoveLastSubject = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearData = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Cyan;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(88, 98);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(146, 31);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Total Hours:";
            // 
            // txtTotalHours
            // 
            this.txtTotalHours.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalHours.BorderRadius = 10;
            this.txtTotalHours.BorderThickness = 0;
            this.txtTotalHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalHours.DefaultText = "";
            this.txtTotalHours.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalHours.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalHours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalHours.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalHours.FillColor = System.Drawing.Color.Cyan;
            this.txtTotalHours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalHours.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHours.ForeColor = System.Drawing.Color.Black;
            this.txtTotalHours.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalHours.Location = new System.Drawing.Point(251, 99);
            this.txtTotalHours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalHours.Name = "txtTotalHours";
            this.txtTotalHours.PasswordChar = '\0';
            this.txtTotalHours.PlaceholderText = "";
            this.txtTotalHours.SelectedText = "";
            this.txtTotalHours.Size = new System.Drawing.Size(100, 30);
            this.txtTotalHours.TabIndex = 0;
            this.txtTotalHours.TextChanged += new System.EventHandler(this.txtSubject_TextChanged);
            this.txtTotalHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalHours_KeyPress);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Cyan;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(619, 98);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(66, 31);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "GBA:";
            // 
            // lblGBA
            // 
            this.lblGBA.BackColor = System.Drawing.Color.Cyan;
            this.lblGBA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGBA.ForeColor = System.Drawing.Color.Black;
            this.lblGBA.Location = new System.Drawing.Point(691, 98);
            this.lblGBA.Name = "lblGBA";
            this.lblGBA.Size = new System.Drawing.Size(5, 3);
            this.lblGBA.TabIndex = 3;
            this.lblGBA.Text = null;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.BorderThickness = 5;
            this.guna2GroupBox1.Controls.Add(this.btnAddSubject);
            this.guna2GroupBox1.Controls.Add(this.txtHours);
            this.guna2GroupBox1.Controls.Add(this.txtMark);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Cyan;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2GroupBox1.Location = new System.Drawing.Point(223, 166);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(501, 181);
            this.guna2GroupBox1.TabIndex = 4;
            this.guna2GroupBox1.Text = "Subject";
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSubject.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddSubject.BorderRadius = 10;
            this.btnAddSubject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSubject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSubject.FillColor = System.Drawing.Color.Cyan;
            this.btnAddSubject.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubject.ForeColor = System.Drawing.Color.Black;
            this.btnAddSubject.Location = new System.Drawing.Point(190, 118);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(125, 45);
            this.btnAddSubject.TabIndex = 6;
            this.btnAddSubject.Text = "Done";
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // txtHours
            // 
            this.txtHours.BackColor = System.Drawing.Color.Transparent;
            this.txtHours.BorderRadius = 10;
            this.txtHours.BorderThickness = 0;
            this.txtHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHours.DefaultText = "";
            this.txtHours.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHours.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHours.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHours.FillColor = System.Drawing.Color.Cyan;
            this.txtHours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHours.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.ForeColor = System.Drawing.Color.Black;
            this.txtHours.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHours.Location = new System.Drawing.Point(342, 58);
            this.txtHours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHours.Name = "txtHours";
            this.txtHours.PasswordChar = '\0';
            this.txtHours.PlaceholderText = "";
            this.txtHours.SelectedText = "";
            this.txtHours.Size = new System.Drawing.Size(100, 30);
            this.txtHours.TabIndex = 5;
            this.txtHours.TextChanged += new System.EventHandler(this.txtSubject_TextChanged);
            this.txtHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHours_KeyPress);
            // 
            // txtMark
            // 
            this.txtMark.BackColor = System.Drawing.Color.Transparent;
            this.txtMark.BorderRadius = 10;
            this.txtMark.BorderThickness = 0;
            this.txtMark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMark.DefaultText = "";
            this.txtMark.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMark.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMark.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMark.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMark.FillColor = System.Drawing.Color.Cyan;
            this.txtMark.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMark.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMark.ForeColor = System.Drawing.Color.Black;
            this.txtMark.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMark.Location = new System.Drawing.Point(104, 58);
            this.txtMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMark.Name = "txtMark";
            this.txtMark.PasswordChar = '\0';
            this.txtMark.PlaceholderText = "";
            this.txtMark.SelectedText = "";
            this.txtMark.Size = new System.Drawing.Size(100, 30);
            this.txtMark.TabIndex = 6;
            this.txtMark.TextChanged += new System.EventHandler(this.txtSubject_TextChanged);
            this.txtMark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMark_KeyPress);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Cyan;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(253, 57);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(105, 31);
            this.guna2HtmlLabel4.TabIndex = 6;
            this.guna2HtmlLabel4.Text = "Hours:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Cyan;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(28, 58);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(87, 30);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Mark:";
            // 
            // btnCalculateGBA
            // 
            this.btnCalculateGBA.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculateGBA.BorderColor = System.Drawing.Color.Transparent;
            this.btnCalculateGBA.BorderRadius = 10;
            this.btnCalculateGBA.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculateGBA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculateGBA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalculateGBA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalculateGBA.FillColor = System.Drawing.Color.Cyan;
            this.btnCalculateGBA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateGBA.ForeColor = System.Drawing.Color.Black;
            this.btnCalculateGBA.Location = new System.Drawing.Point(382, 388);
            this.btnCalculateGBA.Name = "btnCalculateGBA";
            this.btnCalculateGBA.Size = new System.Drawing.Size(168, 45);
            this.btnCalculateGBA.TabIndex = 5;
            this.btnCalculateGBA.Text = "Calculate";
            this.btnCalculateGBA.Click += new System.EventHandler(this.btnCalculateGBA_Click);
            // 
            // lblHoursFromTotal
            // 
            this.lblHoursFromTotal.BackColor = System.Drawing.Color.Cyan;
            this.lblHoursFromTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoursFromTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursFromTotal.ForeColor = System.Drawing.Color.Black;
            this.lblHoursFromTotal.Location = new System.Drawing.Point(980, 99);
            this.lblHoursFromTotal.Name = "lblHoursFromTotal";
            this.lblHoursFromTotal.Size = new System.Drawing.Size(5, 4);
            this.lblHoursFromTotal.TabIndex = 6;
            this.lblHoursFromTotal.Text = null;
            // 
            // btnRemoveLastSubject
            // 
            this.btnRemoveLastSubject.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveLastSubject.BorderColor = System.Drawing.Color.Transparent;
            this.btnRemoveLastSubject.BorderRadius = 10;
            this.btnRemoveLastSubject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveLastSubject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveLastSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveLastSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveLastSubject.FillColor = System.Drawing.Color.Cyan;
            this.btnRemoveLastSubject.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveLastSubject.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveLastSubject.Location = new System.Drawing.Point(936, 209);
            this.btnRemoveLastSubject.Name = "btnRemoveLastSubject";
            this.btnRemoveLastSubject.Size = new System.Drawing.Size(168, 45);
            this.btnRemoveLastSubject.TabIndex = 7;
            this.btnRemoveLastSubject.Text = "Remove";
            this.btnRemoveLastSubject.Click += new System.EventHandler(this.btnRemoveLastSubject_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.BackColor = System.Drawing.Color.Transparent;
            this.btnClearData.BorderColor = System.Drawing.Color.Transparent;
            this.btnClearData.BorderRadius = 10;
            this.btnClearData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearData.FillColor = System.Drawing.Color.Cyan;
            this.btnClearData.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearData.ForeColor = System.Drawing.Color.Black;
            this.btnClearData.Location = new System.Drawing.Point(936, 302);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(168, 45);
            this.btnClearData.TabIndex = 8;
            this.btnClearData.Text = "Clear";
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GBA_Calculator.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1287, 450);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnRemoveLastSubject);
            this.Controls.Add(this.lblHoursFromTotal);
            this.Controls.Add(this.btnCalculateGBA);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lblGBA);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtTotalHours);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "GBA Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalHours;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGBA;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtHours;
        private Guna.UI2.WinForms.Guna2TextBox txtMark;
        private Guna.UI2.WinForms.Guna2Button btnCalculateGBA;
        private Guna.UI2.WinForms.Guna2Button btnAddSubject;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHoursFromTotal;
        private Guna.UI2.WinForms.Guna2Button btnRemoveLastSubject;
        private Guna.UI2.WinForms.Guna2Button btnClearData;
    }
}

