namespace TaskManagementWinForm.UI.Task
{
    partial class AddTaskForm
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
            this.CancelRadButton = new Telerik.WinControls.UI.RadButton();
            this.AddProjectButton = new Telerik.WinControls.UI.RadButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StatusDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ProjectsPanel = new System.Windows.Forms.Panel();
            this.ProjectsDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel73 = new Telerik.WinControls.UI.RadLabel();
            this.panel37 = new System.Windows.Forms.Panel();
            this.TaskNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel87 = new Telerik.WinControls.UI.RadLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PriorityDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.UsersDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.GroupPanel = new System.Windows.Forms.Panel();
            this.GroupsDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DedlineDateTime = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.StartDateTime = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProjectButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.ProjectsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel73)).BeginInit();
            this.panel37.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel87)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            this.GroupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DedlineDateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelRadButton
            // 
            this.CancelRadButton.Location = new System.Drawing.Point(40, 225);
            this.CancelRadButton.Name = "CancelRadButton";
            this.CancelRadButton.Size = new System.Drawing.Size(118, 24);
            this.CancelRadButton.TabIndex = 16;
            this.CancelRadButton.Text = "ESC - Отмена";
            this.CancelRadButton.Click += new System.EventHandler(this.CancelRadButton_Click);
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.Location = new System.Drawing.Point(164, 225);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.Size = new System.Drawing.Size(118, 24);
            this.AddProjectButton.TabIndex = 15;
            this.AddProjectButton.Text = "F2 - Добавить";
            this.AddProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.StatusDropDownList);
            this.panel2.Controls.Add(this.radLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(367, 30);
            this.panel2.TabIndex = 14;
            // 
            // StatusDropDownList
            // 
            this.StatusDropDownList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.StatusDropDownList.DisplayMember = "name";
            this.StatusDropDownList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusDropDownList.Location = new System.Drawing.Point(61, 4);
            this.StatusDropDownList.Name = "StatusDropDownList";
            this.StatusDropDownList.Size = new System.Drawing.Size(302, 20);
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
            // ProjectsPanel
            // 
            this.ProjectsPanel.Controls.Add(this.ProjectsDropDownList);
            this.ProjectsPanel.Controls.Add(this.radLabel73);
            this.ProjectsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectsPanel.Location = new System.Drawing.Point(0, 60);
            this.ProjectsPanel.Name = "ProjectsPanel";
            this.ProjectsPanel.Padding = new System.Windows.Forms.Padding(4);
            this.ProjectsPanel.Size = new System.Drawing.Size(367, 30);
            this.ProjectsPanel.TabIndex = 13;
            // 
            // ProjectsDropDownList
            // 
            this.ProjectsDropDownList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ProjectsDropDownList.DisplayMember = "project_name";
            this.ProjectsDropDownList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsDropDownList.Location = new System.Drawing.Point(61, 4);
            this.ProjectsDropDownList.Name = "ProjectsDropDownList";
            this.ProjectsDropDownList.Size = new System.Drawing.Size(302, 20);
            this.ProjectsDropDownList.TabIndex = 69;
            this.ProjectsDropDownList.ValueMember = "id";
            // 
            // radLabel73
            // 
            this.radLabel73.AutoSize = false;
            this.radLabel73.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel73.Location = new System.Drawing.Point(4, 4);
            this.radLabel73.Name = "radLabel73";
            this.radLabel73.Size = new System.Drawing.Size(57, 22);
            this.radLabel73.TabIndex = 5;
            this.radLabel73.Text = "Проект:";
            this.radLabel73.TextWrap = false;
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.TaskNameTextBox);
            this.panel37.Controls.Add(this.radLabel87);
            this.panel37.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel37.Location = new System.Drawing.Point(0, 0);
            this.panel37.Name = "panel37";
            this.panel37.Padding = new System.Windows.Forms.Padding(4);
            this.panel37.Size = new System.Drawing.Size(367, 30);
            this.panel37.TabIndex = 12;
            // 
            // TaskNameTextBox
            // 
            this.TaskNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskNameTextBox.Location = new System.Drawing.Point(102, 4);
            this.TaskNameTextBox.Name = "TaskNameTextBox";
            this.TaskNameTextBox.Size = new System.Drawing.Size(261, 20);
            this.TaskNameTextBox.TabIndex = 73;
            // 
            // radLabel87
            // 
            this.radLabel87.AutoSize = false;
            this.radLabel87.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel87.Location = new System.Drawing.Point(4, 4);
            this.radLabel87.Name = "radLabel87";
            this.radLabel87.Size = new System.Drawing.Size(98, 22);
            this.radLabel87.TabIndex = 72;
            this.radLabel87.Text = "Наименование: *";
            this.radLabel87.TextWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PriorityDropDownList);
            this.panel1.Controls.Add(this.radLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(367, 30);
            this.panel1.TabIndex = 17;
            // 
            // PriorityDropDownList
            // 
            this.PriorityDropDownList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.PriorityDropDownList.DisplayMember = "name";
            this.PriorityDropDownList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityDropDownList.Location = new System.Drawing.Point(77, 4);
            this.PriorityDropDownList.Name = "PriorityDropDownList";
            this.PriorityDropDownList.Size = new System.Drawing.Size(286, 20);
            this.PriorityDropDownList.TabIndex = 69;
            this.PriorityDropDownList.ValueMember = "id";
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel2.Location = new System.Drawing.Point(4, 4);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(73, 22);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Приоритет:";
            this.radLabel2.TextWrap = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 150);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(4);
            this.panel4.Size = new System.Drawing.Size(367, 30);
            this.panel4.TabIndex = 65;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.UsersDropDownList);
            this.panel5.Controls.Add(this.radLabel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 180);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(4);
            this.panel5.Size = new System.Drawing.Size(367, 30);
            this.panel5.TabIndex = 66;
            // 
            // UsersDropDownList
            // 
            this.UsersDropDownList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.UsersDropDownList.DisplayMember = "user_name";
            this.UsersDropDownList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersDropDownList.Location = new System.Drawing.Point(102, 4);
            this.UsersDropDownList.Name = "UsersDropDownList";
            this.UsersDropDownList.Size = new System.Drawing.Size(261, 20);
            this.UsersDropDownList.TabIndex = 69;
            this.UsersDropDownList.ValueMember = "id";
            // 
            // radLabel4
            // 
            this.radLabel4.AutoSize = false;
            this.radLabel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel4.Location = new System.Drawing.Point(4, 4);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(98, 22);
            this.radLabel4.TabIndex = 5;
            this.radLabel4.Text = "Ответственный:";
            this.radLabel4.TextWrap = false;
            // 
            // GroupPanel
            // 
            this.GroupPanel.Controls.Add(this.GroupsDropDownList);
            this.GroupPanel.Controls.Add(this.radLabel5);
            this.GroupPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupPanel.Location = new System.Drawing.Point(0, 30);
            this.GroupPanel.Name = "GroupPanel";
            this.GroupPanel.Padding = new System.Windows.Forms.Padding(4);
            this.GroupPanel.Size = new System.Drawing.Size(367, 30);
            this.GroupPanel.TabIndex = 67;
            // 
            // GroupsDropDownList
            // 
            this.GroupsDropDownList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.GroupsDropDownList.DisplayMember = "group_name";
            this.GroupsDropDownList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupsDropDownList.Location = new System.Drawing.Point(61, 4);
            this.GroupsDropDownList.Name = "GroupsDropDownList";
            this.GroupsDropDownList.Size = new System.Drawing.Size(302, 20);
            this.GroupsDropDownList.TabIndex = 69;
            this.GroupsDropDownList.ValueMember = "id";
            this.GroupsDropDownList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.GroupsDropDownList_SelectedIndexChanged);
            // 
            // radLabel5
            // 
            this.radLabel5.AutoSize = false;
            this.radLabel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel5.Location = new System.Drawing.Point(4, 4);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(57, 22);
            this.radLabel5.TabIndex = 5;
            this.radLabel5.Text = "Группа:";
            this.radLabel5.TextWrap = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DedlineDateTime);
            this.panel3.Controls.Add(this.radLabel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(188, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 22);
            this.panel3.TabIndex = 32;
            // 
            // DedlineDateTime
            // 
            this.DedlineDateTime.AutoSize = false;
            this.DedlineDateTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.DedlineDateTime.Location = new System.Drawing.Point(83, 0);
            this.DedlineDateTime.Name = "DedlineDateTime";
            this.DedlineDateTime.Size = new System.Drawing.Size(93, 22);
            this.DedlineDateTime.TabIndex = 33;
            this.DedlineDateTime.TabStop = false;
            this.DedlineDateTime.Value = new System.DateTime(((long)(0)));
            // 
            // radLabel3
            // 
            this.radLabel3.AutoSize = false;
            this.radLabel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel3.Location = new System.Drawing.Point(0, 0);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(83, 22);
            this.radLabel3.TabIndex = 32;
            this.radLabel3.Text = "Крайний срок:";
            this.radLabel3.TextWrap = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.StartDateTime);
            this.panel6.Controls.Add(this.radLabel6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 22);
            this.panel6.TabIndex = 33;
            // 
            // StartDateTime
            // 
            this.StartDateTime.AutoSize = false;
            this.StartDateTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.StartDateTime.Location = new System.Drawing.Point(83, 0);
            this.StartDateTime.Name = "StartDateTime";
            this.StartDateTime.Size = new System.Drawing.Size(93, 22);
            this.StartDateTime.TabIndex = 33;
            this.StartDateTime.TabStop = false;
            this.StartDateTime.Value = new System.DateTime(((long)(0)));
            // 
            // radLabel6
            // 
            this.radLabel6.AutoSize = false;
            this.radLabel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel6.Location = new System.Drawing.Point(0, 0);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(83, 22);
            this.radLabel6.TabIndex = 32;
            this.radLabel6.Text = "Дата начала:";
            this.radLabel6.TextWrap = false;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 257);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelRadButton);
            this.Controls.Add(this.AddProjectButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ProjectsPanel);
            this.Controls.Add(this.GroupPanel);
            this.Controls.Add(this.panel37);
            this.KeyPreview = true;
            this.Name = "AddTaskForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление задачи";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddTaskForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProjectButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ProjectsPanel.ResumeLayout(false);
            this.ProjectsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel73)).EndInit();
            this.panel37.ResumeLayout(false);
            this.panel37.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel87)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            this.GroupPanel.ResumeLayout(false);
            this.GroupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DedlineDateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StartDateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Telerik.WinControls.UI.RadButton CancelRadButton;
        public Telerik.WinControls.UI.RadButton AddProjectButton;
        public System.Windows.Forms.Panel panel2;
        public Telerik.WinControls.UI.RadDropDownList StatusDropDownList;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        public System.Windows.Forms.Panel ProjectsPanel;
        public Telerik.WinControls.UI.RadDropDownList ProjectsDropDownList;
        private Telerik.WinControls.UI.RadLabel radLabel73;
        public System.Windows.Forms.Panel panel37;
        public System.Windows.Forms.Panel panel1;
        public Telerik.WinControls.UI.RadDropDownList PriorityDropDownList;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        public System.Windows.Forms.Panel panel4;
        public Telerik.WinControls.UI.RadTextBox TaskNameTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel87;
        public System.Windows.Forms.Panel panel5;
        public Telerik.WinControls.UI.RadDropDownList UsersDropDownList;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        public Telerik.WinControls.UI.RadDropDownList GroupsDropDownList;
        public System.Windows.Forms.Panel GroupPanel;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private System.Windows.Forms.Panel panel6;
        public Telerik.WinControls.UI.RadDateTimePicker StartDateTime;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private System.Windows.Forms.Panel panel3;
        public Telerik.WinControls.UI.RadDateTimePicker DedlineDateTime;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
