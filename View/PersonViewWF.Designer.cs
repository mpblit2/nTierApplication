namespace View
{
    partial class PersonViewWF
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
            this.labelImie = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(12, 9);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(29, 13);
            this.labelImie.TabIndex = 0;
            this.labelImie.Text = "Imie:";
            this.labelImie.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(59, 9);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 1;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(59, 35);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 2;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(13, 38);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(40, 13);
            this.labelSalary.TabIndex = 3;
            this.labelSalary.Text = "Kwota:";
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(205, 231);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 23);
            this.buttonInput.TabIndex = 4;
            this.buttonInput.Text = "Wprowadź";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(15, 61);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(265, 164);
            this.textBoxDisplay.TabIndex = 5;
            // 
            // PersonViewWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.labelImie);
            this.Name = "PersonViewWF";
            this.Text = "PersonViewWF";
            this.Load += new System.EventHandler(this.PersonViewWF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.TextBox textBoxDisplay;
    }
}