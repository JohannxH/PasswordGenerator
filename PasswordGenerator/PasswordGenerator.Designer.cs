namespace PasswordGenerator
{
    partial class frmPasswordGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.chkAmbiguous = new System.Windows.Forms.CheckBox();
            this.chkNumeric = new System.Windows.Forms.CheckBox();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gbControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(133, 193);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.ReadOnly = true;
            this.txtNewPassword.Size = new System.Drawing.Size(178, 23);
            this.txtNewPassword.TabIndex = 0;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(133, 167);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(178, 23);
            this.txtLength.TabIndex = 1;
            this.txtLength.Text = "8";
            // 
            // chkLower
            // 
            this.chkLower.AutoSize = true;
            this.chkLower.Checked = true;
            this.chkLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLower.Location = new System.Drawing.Point(6, 24);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(86, 19);
            this.chkLower.TabIndex = 3;
            this.chkLower.Text = "Lower Case";
            this.chkLower.UseVisualStyleBackColor = true;
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.chkAmbiguous);
            this.gbControls.Controls.Add(this.chkNumeric);
            this.gbControls.Controls.Add(this.chkUpper);
            this.gbControls.Controls.Add(this.chkLower);
            this.gbControls.Location = new System.Drawing.Point(12, 12);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(299, 149);
            this.gbControls.TabIndex = 4;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // chkAmbiguous
            // 
            this.chkAmbiguous.AutoSize = true;
            this.chkAmbiguous.Location = new System.Drawing.Point(6, 99);
            this.chkAmbiguous.Name = "chkAmbiguous";
            this.chkAmbiguous.Size = new System.Drawing.Size(147, 19);
            this.chkAmbiguous.TabIndex = 5;
            this.chkAmbiguous.Text = "Ambiguous Characters";
            this.chkAmbiguous.UseVisualStyleBackColor = true;
            // 
            // chkNumeric
            // 
            this.chkNumeric.AutoSize = true;
            this.chkNumeric.Checked = true;
            this.chkNumeric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumeric.Location = new System.Drawing.Point(6, 74);
            this.chkNumeric.Name = "chkNumeric";
            this.chkNumeric.Size = new System.Drawing.Size(131, 19);
            this.chkNumeric.TabIndex = 4;
            this.chkNumeric.Text = "Numeric Characters";
            this.chkNumeric.UseVisualStyleBackColor = true;
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Location = new System.Drawing.Point(6, 49);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(86, 19);
            this.chkUpper.TabIndex = 0;
            this.chkUpper.Text = "Upper Case";
            this.chkUpper.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password Length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Generated password:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(236, 222);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frmPasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 264);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtNewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPasswordGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNewPassword;
        private TextBox txtLength;
        private CheckBox chkLower;
        private GroupBox gbControls;
        private CheckBox chkUpper;
        private CheckBox chkAmbiguous;
        private CheckBox chkNumeric;
        private Label label1;
        private Label label2;
        private Button btnGenerate;
    }
}
