namespace WindowsFormsApp12
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
            this.OK = new System.Windows.Forms.Button();
            this.IpTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SendFieldDataRichBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Set Connection",
            "Get Connection Port",
            "Get Connection Address",
            "Get Connection Address Length",
            "Get Connection",
            "Connect",
            "Disconnect",
            "Is Connected",
            "Download Dev ID",
            "Is Dev Id Exists",
            "Get Dev Type Length",
            "Get Dev Type",
            "Get Name Length",
            "Download Status",
            "Is Status Exists",
            "Is Printing",
            "Get Print Mode",
            "Get Active Text Name Length",
            "Get Active Text",
            "Print On",
            "Print Off Now",
            "Set Active Text",
            "Is Counters Exists",
            "Download Counters",
            "Get Global Counter",
            "Get Last Msg",
            "Power Off",
            "Send Field Data",
            "Get Library Version",
            "Add"});
            this.comboBox1.Location = new System.Drawing.Point(39, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(334, 133);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(41, 25);
            this.OK.TabIndex = 1;
            this.OK.Text = "Go!";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // IpTextBox
            // 
            this.IpTextBox.Location = new System.Drawing.Point(39, 66);
            this.IpTextBox.Name = "IpTextBox";
            this.IpTextBox.Size = new System.Drawing.Size(183, 22);
            this.IpTextBox.TabIndex = 2;
            this.IpTextBox.Text = "192.168.0.60";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(228, 66);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 22);
            this.PortTextBox.TabIndex = 3;
            this.PortTextBox.Text = "3000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // TextNameTextBox
            // 
            this.TextNameTextBox.Location = new System.Drawing.Point(334, 66);
            this.TextNameTextBox.Name = "TextNameTextBox";
            this.TextNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.TextNameTextBox.TabIndex = 6;
            this.TextNameTextBox.Text = "0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Text name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Send Field Data:";
            // 
            // SendFieldDataRichBox
            // 
            this.SendFieldDataRichBox.Location = new System.Drawing.Point(440, 66);
            this.SendFieldDataRichBox.Name = "SendFieldDataRichBox";
            this.SendFieldDataRichBox.Size = new System.Drawing.Size(193, 96);
            this.SendFieldDataRichBox.TabIndex = 10;
            this.SendFieldDataRichBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 190);
            this.Controls.Add(this.SendFieldDataRichBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.IpTextBox);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox IpTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox SendFieldDataRichBox;
    }
}

