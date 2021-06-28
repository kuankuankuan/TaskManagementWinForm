namespace TaskManagementWinForm.UI
{
    partial class AutorizationForm
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
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.RegistrationLabel = new Telerik.WinControls.UI.RadLabel();
            this.userTextBox = new Telerik.WinControls.UI.RadDropDownList();
            this.SaveCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.NotAutorizedLabel = new Telerik.WinControls.UI.RadLabel();
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.lineRingWaitingBarIndicatorElement1 = new Telerik.WinControls.UI.LineRingWaitingBarIndicatorElement();
            this.AutorizationButton = new Telerik.WinControls.UI.RadButton();
            this.radPanel5 = new Telerik.WinControls.UI.RadPanel();
            this.versionLabel = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.passwordTextBox = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotAutorizedLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutorizationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).BeginInit();
            this.radPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.versionLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel3
            // 
            this.radPanel3.BackColor = System.Drawing.Color.White;
            this.radPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radPanel3.Controls.Add(this.RegistrationLabel);
            this.radPanel3.Controls.Add(this.userTextBox);
            this.radPanel3.Controls.Add(this.SaveCheckBox);
            this.radPanel3.Controls.Add(this.NotAutorizedLabel);
            this.radPanel3.Controls.Add(this.radWaitingBar1);
            this.radPanel3.Controls.Add(this.AutorizationButton);
            this.radPanel3.Controls.Add(this.radPanel5);
            this.radPanel3.Controls.Add(this.radLabel2);
            this.radPanel3.Controls.Add(this.radLabel1);
            this.radPanel3.Controls.Add(this.passwordTextBox);
            this.radPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel3.Location = new System.Drawing.Point(0, 0);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(293, 351);
            this.radPanel3.TabIndex = 2;
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.RegistrationLabel.Location = new System.Drawing.Point(72, 218);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(141, 25);
            this.RegistrationLabel.TabIndex = 14;
            this.RegistrationLabel.Text = "Зарегистриваться";
            this.RegistrationLabel.Click += new System.EventHandler(this.RegistrationLabel_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.userTextBox.Location = new System.Drawing.Point(32, 44);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(229, 27);
            this.userTextBox.TabIndex = 13;
            this.userTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userTextBox_KeyDown);
            this.userTextBox.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.userTextBox_SelectedIndexChanged);
            // 
            // SaveCheckBox
            // 
            this.SaveCheckBox.Location = new System.Drawing.Point(32, 147);
            this.SaveCheckBox.Name = "SaveCheckBox";
            this.SaveCheckBox.Size = new System.Drawing.Size(117, 18);
            this.SaveCheckBox.TabIndex = 12;
            this.SaveCheckBox.Text = "Запомнить пароль";
            // 
            // NotAutorizedLabel
            // 
            this.NotAutorizedLabel.AutoSize = false;
            this.NotAutorizedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotAutorizedLabel.ForeColor = System.Drawing.Color.Maroon;
            this.NotAutorizedLabel.Location = new System.Drawing.Point(17, 248);
            this.NotAutorizedLabel.Name = "NotAutorizedLabel";
            this.NotAutorizedLabel.Size = new System.Drawing.Size(262, 48);
            this.NotAutorizedLabel.TabIndex = 8;
            this.NotAutorizedLabel.Text = "Авторизация в системе не выполнена";
            this.NotAutorizedLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.NotAutorizedLabel.Visible = false;
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.AssociatedControl = this.radPanel3;
            this.radWaitingBar1.Location = new System.Drawing.Point(105, 228);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.ShowItemToolTips = false;
            this.radWaitingBar1.Size = new System.Drawing.Size(70, 70);
            this.radWaitingBar1.TabIndex = 11;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.Visible = false;
            this.radWaitingBar1.WaitingIndicators.Add(this.lineRingWaitingBarIndicatorElement1);
            this.radWaitingBar1.WaitingSpeed = 70;
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.LineRing;
            ((Telerik.WinControls.UI.RadWaitingBarElement)(this.radWaitingBar1.GetChildAt(0))).WaitingSpeed = 70;
            ((Telerik.WinControls.UI.WaitingBarContentElement)(this.radWaitingBar1.GetChildAt(0).GetChildAt(0))).WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.LineRing;
            ((Telerik.WinControls.UI.WaitingBarSeparatorElement)(this.radWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Dash = false;
            // 
            // lineRingWaitingBarIndicatorElement1
            // 
            this.lineRingWaitingBarIndicatorElement1.AutoSize = false;
            this.lineRingWaitingBarIndicatorElement1.Bounds = new System.Drawing.Rectangle(0, 0, 70, 70);
            this.lineRingWaitingBarIndicatorElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.lineRingWaitingBarIndicatorElement1.Name = "lineRingWaitingBarIndicatorElement1";
            this.lineRingWaitingBarIndicatorElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.lineRingWaitingBarIndicatorElement1.UseCompatibleTextRendering = false;
            // 
            // AutorizationButton
            // 
            this.AutorizationButton.Location = new System.Drawing.Point(84, 173);
            this.AutorizationButton.Name = "AutorizationButton";
            this.AutorizationButton.Size = new System.Drawing.Size(118, 38);
            this.AutorizationButton.TabIndex = 10;
            this.AutorizationButton.Text = "Войти в систему";
            this.AutorizationButton.Click += new System.EventHandler(this.AutorizationButton_Click);
            // 
            // radPanel5
            // 
            this.radPanel5.BackColor = System.Drawing.Color.White;
            this.radPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radPanel5.Controls.Add(this.versionLabel);
            this.radPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel5.Location = new System.Drawing.Point(0, 307);
            this.radPanel5.Name = "radPanel5";
            this.radPanel5.Size = new System.Drawing.Size(293, 44);
            this.radPanel5.TabIndex = 9;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = false;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.versionLabel.Location = new System.Drawing.Point(4, 13);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(289, 20);
            this.versionLabel.TabIndex = 11;
            this.versionLabel.Text = "версия ";
            this.versionLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.radLabel2.Location = new System.Drawing.Point(28, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(147, 25);
            this.radLabel2.TabIndex = 8;
            this.radLabel2.Text = "Имя пользователя";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.radLabel1.Location = new System.Drawing.Point(28, 83);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(158, 25);
            this.radLabel1.TabIndex = 7;
            this.radLabel1.Text = "Пароль для доступа";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(32, 114);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(229, 27);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // AutorizationForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(293, 351);
            this.Controls.Add(this.radPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AutorizationForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Activated += new System.EventHandler(this.AutorizationForm_Activated);
            this.Load += new System.EventHandler(this.AutorizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            this.radPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotAutorizedLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutorizationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).EndInit();
            this.radPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.versionLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadDropDownList userTextBox;
        private Telerik.WinControls.UI.RadCheckBox SaveCheckBox;
        private Telerik.WinControls.UI.RadLabel NotAutorizedLabel;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.UI.LineRingWaitingBarIndicatorElement lineRingWaitingBarIndicatorElement1;
        private Telerik.WinControls.UI.RadButton AutorizationButton;
        private Telerik.WinControls.UI.RadPanel radPanel5;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox passwordTextBox;
        private Telerik.WinControls.UI.RadLabel versionLabel;
        private Telerik.WinControls.UI.RadLabel RegistrationLabel;
    }
}
