namespace IPchanger
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
            this.btnDHCP = new System.Windows.Forms.Button();
            this.btnStatic = new System.Windows.Forms.Button();
            this.txtInterfaceName = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.mask = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDHCP
            // 
            this.btnDHCP.Location = new System.Drawing.Point(195, 119);
            this.btnDHCP.Name = "btnDHCP";
            this.btnDHCP.Size = new System.Drawing.Size(227, 47);
            this.btnDHCP.TabIndex = 0;
            this.btnDHCP.Text = "DHCP";
            this.btnDHCP.UseVisualStyleBackColor = true;
            this.btnDHCP.Click += new System.EventHandler(this.btnDHCP_Click);
            // 
            // btnStatic
            // 
            this.btnStatic.Location = new System.Drawing.Point(453, 119);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(140, 47);
            this.btnStatic.TabIndex = 1;
            this.btnStatic.Text = "Static";
            this.btnStatic.UseVisualStyleBackColor = true;
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // txtInterfaceName
            // 
            this.txtInterfaceName.Location = new System.Drawing.Point(453, 172);
            this.txtInterfaceName.Name = "txtInterfaceName";
            this.txtInterfaceName.Size = new System.Drawing.Size(140, 20);
            this.txtInterfaceName.TabIndex = 2;
            this.txtInterfaceName.Text = "vEthernet (Internet)";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(453, 198);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(140, 20);
            this.ip.TabIndex = 3;
            this.ip.Text = "192.168.1.1";
            // 
            // mask
            // 
            this.mask.Location = new System.Drawing.Point(453, 224);
            this.mask.Name = "mask";
            this.mask.Size = new System.Drawing.Size(140, 20);
            this.mask.TabIndex = 4;
            this.mask.Text = "255.255.255.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mask);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.txtInterfaceName);
            this.Controls.Add(this.btnStatic);
            this.Controls.Add(this.btnDHCP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDHCP;
        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.TextBox txtInterfaceName;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox mask;
    }
}

