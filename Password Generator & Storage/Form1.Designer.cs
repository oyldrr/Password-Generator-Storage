namespace Password_Generator___Storage
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.numboxLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.listPasswords = new System.Windows.Forms.ListBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.listNames = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numboxLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new password";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(177, 68);
            this.textPassword.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(125, 22);
            this.textPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name of password:";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(177, 144);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(125, 30);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // numboxLength
            // 
            this.numboxLength.Location = new System.Drawing.Point(177, 107);
            this.numboxLength.Name = "numboxLength";
            this.numboxLength.Size = new System.Drawing.Size(125, 22);
            this.numboxLength.TabIndex = 4;
            this.numboxLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numboxLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Length of password:";
            // 
            // listPasswords
            // 
            this.listPasswords.FormattingEnabled = true;
            this.listPasswords.ItemHeight = 16;
            this.listPasswords.Location = new System.Drawing.Point(111, 189);
            this.listPasswords.Name = "listPasswords";
            this.listPasswords.Size = new System.Drawing.Size(191, 212);
            this.listPasswords.TabIndex = 6;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(177, 408);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(124, 30);
            this.buttonCopy.TabIndex = 7;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // listNames
            // 
            this.listNames.FormattingEnabled = true;
            this.listNames.ItemHeight = 16;
            this.listNames.Location = new System.Drawing.Point(28, 189);
            this.listNames.Name = "listNames";
            this.listNames.Size = new System.Drawing.Size(84, 212);
            this.listNames.TabIndex = 9;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(28, 408);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(124, 30);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listNames);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.listPasswords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numboxLength);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generate & Storage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numboxLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.NumericUpDown numboxLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listPasswords;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.ListBox listNames;
        private System.Windows.Forms.Button buttonDelete;
    }
}

