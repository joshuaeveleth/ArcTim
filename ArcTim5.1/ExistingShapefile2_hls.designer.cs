namespace ArcTim
{
    partial class ExistingShapefile2_hls
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Head = new System.Windows.Forms.ComboBox();
            this.comboBox_Name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Head";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // comboBox_Head
            // 
            this.comboBox_Head.FormattingEnabled = true;
            this.comboBox_Head.Location = new System.Drawing.Point(194, 52);
            this.comboBox_Head.Name = "comboBox_Head";
            this.comboBox_Head.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Head.TabIndex = 3;
            // 
            // comboBox_Name
            // 
            this.comboBox_Name.FormattingEnabled = true;
            this.comboBox_Name.Location = new System.Drawing.Point(194, 80);
            this.comboBox_Name.Name = "comboBox_Name";
            this.comboBox_Name.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Select the attribute for each parameter type...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExistingShapefile2_hls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 199);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Name);
            this.Controls.Add(this.comboBox_Head);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExistingShapefile2_hls";
            this.Text = "Convert Existing Shapefile - step 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Head;
        private System.Windows.Forms.ComboBox comboBox_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}