
namespace ContractTracingApp
{
    partial class Form1
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
            this.Lbl_FirstName = new System.Windows.Forms.Label();
            this.Lbl_LastName = new System.Windows.Forms.Label();
            this.Lbl_Age = new System.Windows.Forms.Label();
            this.Lbl_Address = new System.Windows.Forms.Label();
            this.Lbl_ContactNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_FirstName
            // 
            this.Lbl_FirstName.AutoSize = true;
            this.Lbl_FirstName.Location = new System.Drawing.Point(16, 27);
            this.Lbl_FirstName.Name = "Lbl_FirstName";
            this.Lbl_FirstName.Size = new System.Drawing.Size(64, 15);
            this.Lbl_FirstName.TabIndex = 0;
            this.Lbl_FirstName.Text = "First Name";
            // 
            // Lbl_LastName
            // 
            this.Lbl_LastName.AutoSize = true;
            this.Lbl_LastName.Location = new System.Drawing.Point(16, 76);
            this.Lbl_LastName.Name = "Lbl_LastName";
            this.Lbl_LastName.Size = new System.Drawing.Size(63, 15);
            this.Lbl_LastName.TabIndex = 1;
            this.Lbl_LastName.Text = "Last Name";
            // 
            // Lbl_Age
            // 
            this.Lbl_Age.AutoSize = true;
            this.Lbl_Age.Location = new System.Drawing.Point(16, 131);
            this.Lbl_Age.Name = "Lbl_Age";
            this.Lbl_Age.Size = new System.Drawing.Size(28, 15);
            this.Lbl_Age.TabIndex = 2;
            this.Lbl_Age.Text = "Age";
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.AutoSize = true;
            this.Lbl_Address.Location = new System.Drawing.Point(16, 202);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.Size = new System.Drawing.Size(49, 15);
            this.Lbl_Address.TabIndex = 3;
            this.Lbl_Address.Text = "Address";
            // 
            // Lbl_ContactNumber
            // 
            this.Lbl_ContactNumber.AutoSize = true;
            this.Lbl_ContactNumber.Location = new System.Drawing.Point(16, 256);
            this.Lbl_ContactNumber.Name = "Lbl_ContactNumber";
            this.Lbl_ContactNumber.Size = new System.Drawing.Size(96, 15);
            this.Lbl_ContactNumber.TabIndex = 4;
            this.Lbl_ContactNumber.Text = "Contact Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_ContactNumber);
            this.Controls.Add(this.Lbl_Address);
            this.Controls.Add(this.Lbl_Age);
            this.Controls.Add(this.Lbl_LastName);
            this.Controls.Add(this.Lbl_FirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_FirstName;
        private System.Windows.Forms.Label Lbl_LastName;
        private System.Windows.Forms.Label Lbl_Age;
        private System.Windows.Forms.Label Lbl_Address;
        private System.Windows.Forms.Label Lbl_ContactNumber;
    }
}

