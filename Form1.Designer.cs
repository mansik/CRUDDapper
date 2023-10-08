using CRUDDapper.Models;

namespace CRUDDapper
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
            components = new System.ComponentModel.Container();
            dataGridView = new DataGridView();
            studentIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            birthdayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            pnlContainer = new Panel();
            genderCheckBox = new CheckBox();
            addressTextBox = new TextBox();
            label4 = new Label();
            emailTextBox = new TextBox();
            label3 = new Label();
            label6 = new Label();
            birthdayTextBox = new TextBox();
            label5 = new Label();
            fullNameTextBox = new TextBox();
            label2 = new Label();
            studentIDTextBox = new TextBox();
            label1 = new Label();
            browseButton = new Button();
            pic = new PictureBox();
            saveButton = new Button();
            cancelButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { studentIDDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, genderDataGridViewCheckBoxColumn, birthdayDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn });
            dataGridView.DataSource = studentBindingSource;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 27;
            dataGridView.Size = new Size(370, 347);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            studentIDDataGridViewTextBoxColumn.Width = 92;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            fullNameDataGridViewTextBoxColumn.Width = 88;
            // 
            // genderDataGridViewCheckBoxColumn
            // 
            genderDataGridViewCheckBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewCheckBoxColumn.HeaderText = "Gender";
            genderDataGridViewCheckBoxColumn.Name = "genderDataGridViewCheckBoxColumn";
            genderDataGridViewCheckBoxColumn.ReadOnly = true;
            genderDataGridViewCheckBoxColumn.Width = 58;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            birthdayDataGridViewTextBoxColumn.Width = 82;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 64;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Width = 82;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(genderCheckBox);
            pnlContainer.Controls.Add(addressTextBox);
            pnlContainer.Controls.Add(label4);
            pnlContainer.Controls.Add(emailTextBox);
            pnlContainer.Controls.Add(label3);
            pnlContainer.Controls.Add(label6);
            pnlContainer.Controls.Add(birthdayTextBox);
            pnlContainer.Controls.Add(label5);
            pnlContainer.Controls.Add(fullNameTextBox);
            pnlContainer.Controls.Add(label2);
            pnlContainer.Controls.Add(studentIDTextBox);
            pnlContainer.Controls.Add(label1);
            pnlContainer.Controls.Add(browseButton);
            pnlContainer.Controls.Add(pic);
            pnlContainer.Location = new Point(388, 12);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Padding = new Padding(6);
            pnlContainer.Size = new Size(481, 346);
            pnlContainer.TabIndex = 6;
            // 
            // genderCheckBox
            // 
            genderCheckBox.AutoSize = true;
            genderCheckBox.DataBindings.Add(new Binding("Checked", studentBindingSource, "Gender", true));
            genderCheckBox.Location = new Point(225, 76);
            genderCheckBox.Name = "genderCheckBox";
            genderCheckBox.Size = new Size(45, 21);
            genderCheckBox.TabIndex = 3;
            genderCheckBox.Text = "???";
            genderCheckBox.UseVisualStyleBackColor = true;
            genderCheckBox.CheckStateChanged += genderCheckBox_CheckStateChanged;
            // 
            // addressTextBox
            // 
            addressTextBox.BackColor = SystemColors.Window;
            addressTextBox.DataBindings.Add(new Binding("Text", studentBindingSource, "Address", true));
            addressTextBox.Location = new Point(225, 165);
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(247, 86);
            addressTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 168);
            label4.Name = "label4";
            label4.Size = new Size(60, 17);
            label4.TabIndex = 2;
            label4.Text = "Address:";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = SystemColors.Window;
            emailTextBox.DataBindings.Add(new Binding("Text", studentBindingSource, "Email", true));
            emailTextBox.Location = new Point(225, 134);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(247, 25);
            emailTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 137);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 78);
            label6.Name = "label6";
            label6.Size = new Size(55, 17);
            label6.TabIndex = 2;
            label6.Text = "Gender:";
            // 
            // birthdayTextBox
            // 
            birthdayTextBox.BackColor = SystemColors.Window;
            birthdayTextBox.DataBindings.Add(new Binding("Text", studentBindingSource, "Birthday", true));
            birthdayTextBox.Location = new Point(225, 103);
            birthdayTextBox.Name = "birthdayTextBox";
            birthdayTextBox.Size = new Size(247, 25);
            birthdayTextBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 106);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 2;
            label5.Text = "Birthday:";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.BackColor = SystemColors.Window;
            fullNameTextBox.DataBindings.Add(new Binding("Text", studentBindingSource, "FullName", true));
            fullNameTextBox.Location = new Point(225, 44);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(247, 25);
            fullNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 47);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 2;
            label2.Text = "Fullname:";
            // 
            // studentIDTextBox
            // 
            studentIDTextBox.BackColor = SystemColors.Window;
            studentIDTextBox.DataBindings.Add(new Binding("Text", studentBindingSource, "StudentID", true));
            studentIDTextBox.Location = new Point(225, 13);
            studentIDTextBox.Name = "studentIDTextBox";
            studentIDTextBox.ReadOnly = true;
            studentIDTextBox.Size = new Size(247, 25);
            studentIDTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 16);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 2;
            label1.Text = "Student ID:";
            // 
            // browseButton
            // 
            browseButton.Location = new Point(31, 153);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(75, 25);
            browseButton.TabIndex = 0;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // pic
            // 
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.Location = new Point(9, 9);
            pic.Name = "pic";
            pic.Size = new Size(118, 138);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.TabIndex = 0;
            pic.TabStop = false;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(794, 364);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 25);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += btnSave_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(713, 364);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 25);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(632, 364);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 25);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(551, 364);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 25);
            editButton.TabIndex = 2;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(470, 364);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 25);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 397);
            Controls.Add(addButton);
            Controls.Add(editButton);
            Controls.Add(deleteButton);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(pnlContainer);
            Controls.Add(dataGridView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Panel pnlContainer;
        private PictureBox pic;
        private TextBox studentIDTextBox;
        private Label label1;
        private Button browseButton;
        private Button saveButton;
        private Button cancelButton;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private CheckBox genderCheckBox;
        private TextBox addressTextBox;
        private Label label4;
        private TextBox emailTextBox;
        private Label label3;
        private Label label6;
        private TextBox fullNameTextBox;
        private Label label2;
        private TextBox birthdayTextBox;
        private Label label5;
        private DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private BindingSource studentBindingSource;
    }
}