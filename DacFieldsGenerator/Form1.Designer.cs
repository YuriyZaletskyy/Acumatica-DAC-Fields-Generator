namespace DacFieldsGenerator
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.lblDataMemberName = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUIField = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(51, 160);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(51, 37);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(175, 20);
            this.txtMember.TabIndex = 1;
            // 
            // lblDataMemberName
            // 
            this.lblDataMemberName.AutoSize = true;
            this.lblDataMemberName.Location = new System.Drawing.Point(48, 21);
            this.lblDataMemberName.Name = "lblDataMemberName";
            this.lblDataMemberName.Size = new System.Drawing.Size(99, 13);
            this.lblDataMemberName.TabIndex = 2;
            this.lblDataMemberName.Text = "Data member name";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "int?",
            "string",
            "decimal?",
            "DateTime?"});
            this.cmbType.Location = new System.Drawing.Point(51, 83);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(175, 21);
            this.cmbType.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(48, 67);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(66, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Choose type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "UI Field";
            // 
            // txtUIField
            // 
            this.txtUIField.Location = new System.Drawing.Point(51, 134);
            this.txtUIField.Name = "txtUIField";
            this.txtUIField.Size = new System.Drawing.Size(175, 20);
            this.txtUIField.TabIndex = 5;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(275, 37);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(479, 401);
            this.txtOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUIField);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblDataMemberName);
            this.Controls.Add(this.txtMember);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.Label lblDataMemberName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUIField;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

