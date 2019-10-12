namespace XMaruView_Console_LicenseGenerator
{
    partial class LicenceGeneratorView
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RequestCode_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ActivationCode_textBox = new System.Windows.Forms.TextBox();
            this.GenerateActivationCode_button = new System.Windows.Forms.Button();
            this.GenerateRequestCode_button = new System.Windows.Forms.Button();
            this.LicenceOptionscheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CopyActivationCode_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RequestCode_textBox
            // 
            this.RequestCode_textBox.Location = new System.Drawing.Point(101, 6);
            this.RequestCode_textBox.Name = "RequestCode_textBox";
            this.RequestCode_textBox.Size = new System.Drawing.Size(191, 20);
            this.RequestCode_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Activation Code";
            // 
            // ActivationCode_textBox
            // 
            this.ActivationCode_textBox.Location = new System.Drawing.Point(101, 35);
            this.ActivationCode_textBox.Name = "ActivationCode_textBox";
            this.ActivationCode_textBox.Size = new System.Drawing.Size(191, 20);
            this.ActivationCode_textBox.TabIndex = 2;
            // 
            // GenerateActivationCode_button
            // 
            this.GenerateActivationCode_button.Location = new System.Drawing.Point(12, 97);
            this.GenerateActivationCode_button.Name = "GenerateActivationCode_button";
            this.GenerateActivationCode_button.Size = new System.Drawing.Size(150, 23);
            this.GenerateActivationCode_button.TabIndex = 4;
            this.GenerateActivationCode_button.Text = "Generate Activation Code";
            this.GenerateActivationCode_button.UseVisualStyleBackColor = true;
            this.GenerateActivationCode_button.Click += new System.EventHandler(this.GenerateActivationCode_button_Click);
            // 
            // GenerateRequestCode_button
            // 
            this.GenerateRequestCode_button.Location = new System.Drawing.Point(273, 97);
            this.GenerateRequestCode_button.Name = "GenerateRequestCode_button";
            this.GenerateRequestCode_button.Size = new System.Drawing.Size(150, 23);
            this.GenerateRequestCode_button.TabIndex = 5;
            this.GenerateRequestCode_button.Text = "Generate Request Code";
            this.GenerateRequestCode_button.UseVisualStyleBackColor = true;
            this.GenerateRequestCode_button.Click += new System.EventHandler(this.GenerateRequestCode_button_Click);
            // 
            // LicenceOptionscheckedListBox
            // 
            this.LicenceOptionscheckedListBox.FormattingEnabled = true;
            this.LicenceOptionscheckedListBox.Items.AddRange(new object[] {
            "AutoStitching ",
            "SYFM ",
            "ChiroTool",
            "GridOn",
            "HL7 ",
            "OverlayMarker ",
            "CloneImage ",
            "PrintComposer",
            "RealtimeImageProcessing ",
            "DerivedImage"});
            this.LicenceOptionscheckedListBox.Location = new System.Drawing.Point(315, 27);
            this.LicenceOptionscheckedListBox.Name = "LicenceOptionscheckedListBox";
            this.LicenceOptionscheckedListBox.Size = new System.Drawing.Size(120, 49);
            this.LicenceOptionscheckedListBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "License Options";
            // 
            // CopyActivationCode_button
            // 
            this.CopyActivationCode_button.Location = new System.Drawing.Point(12, 68);
            this.CopyActivationCode_button.Name = "CopyActivationCode_button";
            this.CopyActivationCode_button.Size = new System.Drawing.Size(150, 23);
            this.CopyActivationCode_button.TabIndex = 8;
            this.CopyActivationCode_button.Text = "Copy Activation Code";
            this.CopyActivationCode_button.UseVisualStyleBackColor = true;
            this.CopyActivationCode_button.Click += new System.EventHandler(this.CopyActivationCode_button_Click);
            // 
            // LicenceGeneratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 136);
            this.Controls.Add(this.CopyActivationCode_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LicenceOptionscheckedListBox);
            this.Controls.Add(this.GenerateRequestCode_button);
            this.Controls.Add(this.GenerateActivationCode_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActivationCode_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RequestCode_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LicenceGeneratorView";
            this.Text = "XMaruView License Generator by M0nteCarl0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RequestCode_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ActivationCode_textBox;
        private System.Windows.Forms.Button GenerateActivationCode_button;
        private System.Windows.Forms.Button GenerateRequestCode_button;
        private System.Windows.Forms.CheckedListBox LicenceOptionscheckedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CopyActivationCode_button;
    }
}

