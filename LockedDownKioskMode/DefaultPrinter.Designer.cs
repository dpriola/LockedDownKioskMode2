namespace LockedDownKioskMode
{
    partial class DefaultPrinter
    {
        //Global Variables Here
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button CurrentDefaultButton;
        private System.Windows.Forms.Button SetDefaultButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListBox PrinterListBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.CurrentDefaultButton = new System.Windows.Forms.Button();
            this.SetDefaultButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PrinterListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CurrentDefaultButton
            // 
            this.CurrentDefaultButton.Location = new System.Drawing.Point(12, 12);
            this.CurrentDefaultButton.Name = "CurrentDefaultButton";
            this.CurrentDefaultButton.Size = new System.Drawing.Size(315, 32);
            this.CurrentDefaultButton.TabIndex = 0;
            this.CurrentDefaultButton.Text = "Click To Check Current Default Printer";
            this.CurrentDefaultButton.UseVisualStyleBackColor = true;
            this.CurrentDefaultButton.Click += new System.EventHandler(this.CurrentDefaultButton_Click);
            // 
            // SetDefaultButton
            // 
            this.SetDefaultButton.Location = new System.Drawing.Point(12, 415);
            this.SetDefaultButton.Name = "SetDefaultButton";
            this.SetDefaultButton.Size = new System.Drawing.Size(112, 23);
            this.SetDefaultButton.TabIndex = 1;
            this.SetDefaultButton.Text = "Set As Default";
            this.SetDefaultButton.UseVisualStyleBackColor = true;
            this.SetDefaultButton.Click += new System.EventHandler(this.SetDefaultButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(252, 415);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PrinterListBox
            // 
            this.PrinterListBox.FormattingEnabled = true;
            this.PrinterListBox.Location = new System.Drawing.Point(12, 50);
            this.PrinterListBox.Name = "PrinterListBox";
            this.PrinterListBox.Size = new System.Drawing.Size(315, 355);
            this.PrinterListBox.TabIndex = 4;
            // 
            // DefaultPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.PrinterListBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SetDefaultButton);
            this.Controls.Add(this.CurrentDefaultButton);
            this.Name = "DefaultPrinter";
            this.Text = "DefaultPrinter";
            this.ResumeLayout(false);

        }
        #endregion
    }
}