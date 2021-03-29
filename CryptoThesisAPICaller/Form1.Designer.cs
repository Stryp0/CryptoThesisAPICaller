
namespace CryptoThesisAPICaller
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
            this.runButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.apiTextBox = new System.Windows.Forms.TextBox();
            this.blockchainComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(13, 86);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(290, 23);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Futtatás";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "API kód:";
            // 
            // apiTextBox
            // 
            this.apiTextBox.Location = new System.Drawing.Point(69, 12);
            this.apiTextBox.Name = "apiTextBox";
            this.apiTextBox.Size = new System.Drawing.Size(234, 23);
            this.apiTextBox.TabIndex = 2;
            this.apiTextBox.Text = "A___CnifAdmUCbVl036CxYNhY6WXhDur";
            // 
            // blockchainComboBox
            // 
            this.blockchainComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blockchainComboBox.FormattingEnabled = true;
            this.blockchainComboBox.Items.AddRange(new object[] {
            "Bitcoin",
            "Bitcoin Cash",
            "Dash"});
            this.blockchainComboBox.Location = new System.Drawing.Point(142, 41);
            this.blockchainComboBox.Name = "blockchainComboBox";
            this.blockchainComboBox.Size = new System.Drawing.Size(161, 23);
            this.blockchainComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kiválasztott blokklánc:";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(12, 162);
            this.logTextBox.MaxLength = 2000000;
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(290, 189);
            this.logTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Naplózott adatok:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.blockchainComboBox);
            this.Controls.Add(this.apiTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blockchair API hívás futtató";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apiTextBox;
        private System.Windows.Forms.ComboBox blockchainComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

