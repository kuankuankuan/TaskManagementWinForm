namespace TaskManagementWinForm.UI.Projects
{
    partial class AddProjectForm
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
            this.panel37 = new System.Windows.Forms.Panel();
            this.radPanel44 = new System.Windows.Forms.Panel();
            this.ProjectNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel87 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel88 = new Telerik.WinControls.UI.RadLabel();
            this.CancelRadButton = new Telerik.WinControls.UI.RadButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GroupsDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel73 = new Telerik.WinControls.UI.RadLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StatusDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.AddProjectButton = new Telerik.WinControls.UI.RadButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsersDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.panel37.SuspendLayout();
            this.radPanel44.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel73)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProjectButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.radPanel44);
            this.panel37.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel37.Location = new System.Drawing.Point(0, 0);
            this.panel37.Name = "panel37";
            this.panel37.Padding = new System.Windows.Forms.Padding(4);
            this.panel37.Size = new System.Drawing.Size(403, 30);
            this.panel37.TabIndex = 1;
            // 
            // radPanel44
            // 
            this.radPanel44.Controls.Add(this.ProjectNameTextBox);
            this.radPanel44.Controls.Add(this.radLabel87);
            this.radPanel44.Controls.Add(this.radLabel88);
            this.radPanel44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel44.Location = new System.Drawing.Point(4, 4);
            this.radPanel44.Name = "radPanel44";
            this.radPanel44.Size = new System.Drawing.Size(395, 22);
            this.radPanel44.TabIndex = 39;
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectNameTextBox.Location = new System.Drawing.Point(98, 0);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(295, 22);
            this.ProjectNameTextBox.TabIndex = 71;
            // 
            // radLabel87
            // 
            this.radLabel87.AutoSize = false;
            this.radLabel87.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel87.Location = new System.Drawing.Point(0, 0);
            this.radLabel87.Name = "radLabel87";
            this.radLabel87.Size = new System.Drawing.Size(98, 22);
            this.radLabel87.TabIndex = 4;
            this.radLabel87.Text = "Наименование: *";
            this.radLabel87.TextWrap = false;
            // 
            // radLabel88
            // 
            this.radLabel88.Dock = System.Windows.Forms.DockStyle.Right;
            this.radLabel88.Location = new System.Drawing.Point(393, 0);
            this.radLabel88.Name = "radLabel88";
            this.radLabel88.Size = new System.Drawing.Size(2, 22);
            this.radLabel88.TabIndex = 5;
            this.radLabel88.TextWrap = false;
            // 
            // CancelRadButton
            // 
            this.CancelRadButton.Location = new System.Drawing.Point(81, 126);
            this.CancelRadButton.Name = "CancelRadButton";
            this.CancelRadButton.Size = new System.Drawing.Size(118, 24);
            this.CancelRadButton.TabIndex = 11;
            this.CancelRadButton.Text = "ESC - Отмена";
            this.CancelRadButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GroupsDropDownList);
            this.panel3.Controls.Add(this.radLabel73);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(403, 30);
            this.panel3.TabIndex = 2;
            // 
            // GroupsDropDownList
            // 
            this.GroupsDropDownList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.GroupsDropDownList.DisplayMember = "group_name";
            this.GroupsDropDownList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupsDropDownList.Location = new System.Drawing.Point(61, 4);
            this.GroupsDropDownList.Name = "GroupsDropDownList";
            this.GroupsDropDownList.Size = new System.Drawing.Size(338, 22);
            this.GroupsDropDownList.TabIndex = 69;
            this.GroupsDropDownList.ValueMember = "id";
            // 
            // radLabel73
            // 
            this.radLabel73.AutoSize = false;
            this.radLabel73.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel73.Location = new System.Drawing.Point(4, 4);
            this.radLabel73.Name = "radLabel73";
            this.radLabel73.Size = new System.Drawing.Size(57, 22);
            this.radLabel73.TabIndex = 5;
            this.radLabel73.Text = "Группа:";
            this.radLabel73.TextWrap = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.StatusDropDownList);
            this.panel2.Controls.Add(this.radLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(403, 30);
            this.panel2.TabIndex = 3;
            // 
            // StatusDropDownList
            // 
            this.StatusDropDownList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.StatusDropDownList.DisplayMember = "name";
            this.StatusDropDownList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusDropDownList.Location = new System.Drawing.Point(61, 4);
            this.StatusDropDownList.Name = "StatusDropDownList";
            this.StatusDropDownList.Size = new System.Drawing.Size(338, 22);
            this.StatusDropDownList.TabIndex = 69;
            this.StatusDropDownList.ValueMember = "id";
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel1.Location = new System.Drawing.Point(4, 4);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(57, 22);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Статус:";
            this.radLabel1.TextWrap = false;
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.Location = new System.Drawing.Point(205, 126);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.Size = new System.Drawing.Size(118, 24);
            this.AddProjectButton.TabIndex = 10;
            this.AddProjectButton.Text = "F2 - Добавить";
            this.AddProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UsersDropDownList);
            this.panel1.Controls.Add(this.radLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(403, 30);
            this.panel1.TabIndex = 12;
            // 
            // UsersDropDownList
            // 
            this.UsersDropDownList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.UsersDropDownList.DisplayMember = "user_name";
            this.UsersDropDownList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersDropDownList.Location = new System.Drawing.Point(150, 4);
            this.UsersDropDownList.Name = "UsersDropDownList";
            this.UsersDropDownList.Size = new System.Drawing.Size(249, 20);
            this.UsersDropDownList.TabIndex = 69;
            this.UsersDropDownList.ValueMember = "id";
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel2.Location = new System.Drawing.Point(4, 4);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(146, 22);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Ответственный за проект:";
            this.radLabel2.TextWrap = false;
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 153);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelRadButton);
            this.Controls.Add(this.AddProjectButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel37);
            this.KeyPreview = true;
            this.Name = "AddProjectForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление проекта";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddProjectForm_KeyDown);
            this.panel37.ResumeLayout(false);
            this.radPanel44.ResumeLayout(false);
            this.radPanel44.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel73)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProjectButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel37;
        public System.Windows.Forms.Panel radPanel44;
        public Telerik.WinControls.UI.RadTextBox ProjectNameTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel87;
        private Telerik.WinControls.UI.RadLabel radLabel88;
        public Telerik.WinControls.UI.RadButton CancelRadButton;
        public System.Windows.Forms.Panel panel3;
        public Telerik.WinControls.UI.RadDropDownList GroupsDropDownList;
        private Telerik.WinControls.UI.RadLabel radLabel73;
        public System.Windows.Forms.Panel panel2;
        public Telerik.WinControls.UI.RadDropDownList StatusDropDownList;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        public Telerik.WinControls.UI.RadButton AddProjectButton;
        public System.Windows.Forms.Panel panel1;
        public Telerik.WinControls.UI.RadDropDownList UsersDropDownList;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
