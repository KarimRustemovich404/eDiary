namespace eDiary
{
    partial class log_In_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_In_Form));
            this.openint_Picture = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.enter_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openint_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // openint_Picture
            // 
            this.openint_Picture.Image = global::eDiary.Properties.Resources.Иконка_в_дневник;
            this.openint_Picture.Location = new System.Drawing.Point(239, 99);
            this.openint_Picture.Name = "openint_Picture";
            this.openint_Picture.Size = new System.Drawing.Size(200, 200);
            this.openint_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openint_Picture.TabIndex = 2;
            this.openint_Picture.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginField.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(239, 334);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(200, 41);
            this.loginField.TabIndex = 3;
            // 
            // passwordField
            // 
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordField.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(239, 396);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(200, 38);
            this.passwordField.TabIndex = 4;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // enter_Btn
            // 
            this.enter_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.enter_Btn.FlatAppearance.BorderSize = 2;
            this.enter_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.enter_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enter_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enter_Btn.Location = new System.Drawing.Point(272, 473);
            this.enter_Btn.Name = "enter_Btn";
            this.enter_Btn.Size = new System.Drawing.Size(134, 41);
            this.enter_Btn.TabIndex = 5;
            this.enter_Btn.Text = "Войти";
            this.enter_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.enter_Btn.UseVisualStyleBackColor = true;
            // 
            // log_In_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.enter_Btn);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.openint_Picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "log_In_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный дневник студента";
            ((System.ComponentModel.ISupportInitialize)(this.openint_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox openint_Picture;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button enter_Btn;
    }
}

