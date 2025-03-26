using System;
using System.Windows.Forms;

namespace CollegeDBApp
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCollege = new System.Windows.Forms.ComboBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtDepartmentCode = new System.Windows.Forms.TextBox();
            this.chkDepartmentActive = new System.Windows.Forms.CheckBox();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnUpdateDepartment = new System.Windows.Forms.Button();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.btnViewDepartment = new System.Windows.Forms.Button();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(53, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(53, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(50, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "College:";
            // 
            // cmbCollege
            // 
            this.cmbCollege.FormattingEnabled = true;
            this.cmbCollege.Location = new System.Drawing.Point(252, 186);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(159, 28);
            this.cmbCollege.TabIndex = 3;
            this.cmbCollege.SelectedIndexChanged += new System.EventHandler(this.cmbCollege_SelectedIndexChanged);
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(252, 99);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(159, 26);
            this.txtDepartmentName.TabIndex = 4;
            this.txtDepartmentName.TextChanged += new System.EventHandler(this.txtDepartmentName_TextChanged);
            // 
            // txtDepartmentCode
            // 
            this.txtDepartmentCode.Location = new System.Drawing.Point(252, 147);
            this.txtDepartmentCode.Name = "txtDepartmentCode";
            this.txtDepartmentCode.Size = new System.Drawing.Size(159, 26);
            this.txtDepartmentCode.TabIndex = 5;
            this.txtDepartmentCode.TextChanged += new System.EventHandler(this.txtDepartmentCode_TextChanged);
            // 
            // chkDepartmentActive
            // 
            this.chkDepartmentActive.AutoSize = true;
            this.chkDepartmentActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkDepartmentActive.Location = new System.Drawing.Point(54, 247);
            this.chkDepartmentActive.Name = "chkDepartmentActive";
            this.chkDepartmentActive.Size = new System.Drawing.Size(92, 29);
            this.chkDepartmentActive.TabIndex = 6;
            this.chkDepartmentActive.Text = "Active";
            this.chkDepartmentActive.UseVisualStyleBackColor = true;
            this.chkDepartmentActive.CheckedChanged += new System.EventHandler(this.chkDepartmentActive_CheckedChanged);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAddDepartment.Location = new System.Drawing.Point(54, 304);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(81, 39);
            this.btnAddDepartment.TabIndex = 7;
            this.btnAddDepartment.Text = "Add";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click_1);
            // 
            // btnUpdateDepartment
            // 
            this.btnUpdateDepartment.Location = new System.Drawing.Point(185, 304);
            this.btnUpdateDepartment.Name = "btnUpdateDepartment";
            this.btnUpdateDepartment.Size = new System.Drawing.Size(81, 39);
            this.btnUpdateDepartment.TabIndex = 8;
            this.btnUpdateDepartment.Text = "Update";
            this.btnUpdateDepartment.UseVisualStyleBackColor = true;
            this.btnUpdateDepartment.Click += new System.EventHandler(this.btnUpdateDepartment_Click_1);
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Location = new System.Drawing.Point(330, 304);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(81, 39);
            this.btnDeleteDepartment.TabIndex = 9;
            this.btnDeleteDepartment.Text = "Delete";
            this.btnDeleteDepartment.UseVisualStyleBackColor = true;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // btnViewDepartment
            // 
            this.btnViewDepartment.Location = new System.Drawing.Point(467, 304);
            this.btnViewDepartment.Name = "btnViewDepartment";
            this.btnViewDepartment.Size = new System.Drawing.Size(81, 39);
            this.btnViewDepartment.TabIndex = 10;
            this.btnViewDepartment.Text = "View";
            this.btnViewDepartment.UseVisualStyleBackColor = true;
            this.btnViewDepartment.Click += new System.EventHandler(this.btnViewDepartment_Click);
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(53, 378);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.RowHeadersWidth = 62;
            this.dgvDepartments.RowTemplate.Height = 28;
            this.dgvDepartments.Size = new System.Drawing.Size(495, 264);
            this.dgvDepartments.TabIndex = 11;
            this.dgvDepartments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(53, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Department ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Location = new System.Drawing.Point(252, 63);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.ReadOnly = true;
            this.txtDepartmentID.Size = new System.Drawing.Size(159, 26);
            this.txtDepartmentID.TabIndex = 13;
            this.txtDepartmentID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(637, 693);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDepartments);
            this.Controls.Add(this.btnViewDepartment);
            this.Controls.Add(this.btnDeleteDepartment);
            this.Controls.Add(this.btnUpdateDepartment);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.chkDepartmentActive);
            this.Controls.Add(this.txtDepartmentCode);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.cmbCollege);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        

        

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCollege;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtDepartmentCode;
        private System.Windows.Forms.CheckBox chkDepartmentActive;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnUpdateDepartment;
        private System.Windows.Forms.Button btnDeleteDepartment;
        private System.Windows.Forms.Button btnViewDepartment;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private Label label4;
        private TextBox txtDepartmentID;
    }
}