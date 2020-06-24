namespace Server_Swapper
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iTalk_ThemeContainer1 = new iTalk_ThemeContainer();
            this.iTalk_ComboBox1 = new iTalk_ComboBox();
            this.iTalk_Button_11 = new iTalk_Button_1();
            this.iTalk_Button_21 = new iTalk_Button_2();
            this.iTalk_ThemeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "default",
            "eastus",
            "centralus",
            "southcentralus",
            "westus",
            "brazilsouth",
            "northeurope",
            "westeurope",
            "southafricanorth",
            "eastasia",
            "southeastasia",
            "australiaeast",
            "australiasoutheast",
            "japanwest"});
            this.comboBox1.Location = new System.Drawing.Point(234, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(612, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // iTalk_ThemeContainer1
            // 
            this.iTalk_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.iTalk_ThemeContainer1.Controls.Add(this.iTalk_Button_21);
            this.iTalk_ThemeContainer1.Controls.Add(this.iTalk_Button_11);
            this.iTalk_ThemeContainer1.Controls.Add(this.iTalk_ComboBox1);
            this.iTalk_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iTalk_ThemeContainer1.DrawBottomBar = false;
            this.iTalk_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_ThemeContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_ThemeContainer1.Name = "iTalk_ThemeContainer1";
            this.iTalk_ThemeContainer1.Padding = new System.Windows.Forms.Padding(3, 28, 3, 28);
            this.iTalk_ThemeContainer1.Size = new System.Drawing.Size(347, 131);
            this.iTalk_ThemeContainer1.TabIndex = 1;
            this.iTalk_ThemeContainer1.Text = "Server Swapper V2";
            this.iTalk_ThemeContainer1.TextBottom = null;
            // 
            // iTalk_ComboBox1
            // 
            this.iTalk_ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.iTalk_ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.iTalk_ComboBox1.DropDownHeight = 100;
            this.iTalk_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iTalk_ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_ComboBox1.FormattingEnabled = true;
            this.iTalk_ComboBox1.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.iTalk_ComboBox1.IntegralHeight = false;
            this.iTalk_ComboBox1.ItemHeight = 20;
            this.iTalk_ComboBox1.Location = new System.Drawing.Point(12, 31);
            this.iTalk_ComboBox1.Name = "iTalk_ComboBox1";
            this.iTalk_ComboBox1.Size = new System.Drawing.Size(323, 26);
            this.iTalk_ComboBox1.StartIndex = 0;
            this.iTalk_ComboBox1.TabIndex = 0;
            // 
            // iTalk_Button_11
            // 
            this.iTalk_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iTalk_Button_11.Image = null;
            this.iTalk_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_11.Location = new System.Drawing.Point(12, 63);
            this.iTalk_Button_11.Name = "iTalk_Button_11";
            this.iTalk_Button_11.Size = new System.Drawing.Size(151, 40);
            this.iTalk_Button_11.TabIndex = 1;
            this.iTalk_Button_11.Text = "Cancel";
            this.iTalk_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_11.Click += new System.EventHandler(this.iTalk_Button_11_Click);
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = null;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(169, 63);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(166, 40);
            this.iTalk_Button_21.TabIndex = 2;
            this.iTalk_Button_21.Text = "Set Server";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_21.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 131);
            this.Controls.Add(this.iTalk_ThemeContainer1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Server Swapper V2";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.iTalk_ThemeContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private iTalk_ThemeContainer iTalk_ThemeContainer1;
        private iTalk_Button_2 iTalk_Button_21;
        private iTalk_Button_1 iTalk_Button_11;
        private iTalk_ComboBox iTalk_ComboBox1;
    }
}

