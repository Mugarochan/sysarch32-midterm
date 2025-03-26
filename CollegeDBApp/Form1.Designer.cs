using System;
using System.Windows.Forms;

namespace CollegeDBApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCollegeCode;
        private System.Windows.Forms.CheckBox chkCollegeActive;
        private System.Windows.Forms.DataGridView dgvColleges;
        private System.Windows.Forms.TextBox txtCollegeName;
        private System.Windows.Forms.TextBox txtCollegeID;
        





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
            this.txtCollegeCode = new System.Windows.Forms.TextBox();
            this.chkCollegeActive = new System.Windows.Forms.CheckBox();
            this.dgvColleges = new System.Windows.Forms.DataGridView();
            this.txtCollegeName = new System.Windows.Forms.TextBox();
            this.txtCollegeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCollege = new System.Windows.Forms.Button();
            this.btnDeleteCollege = new System.Windows.Forms.Button();
            this.btnUpdateCollege = new System.Windows.Forms.Button();
            this.btnReadCollege = new System.Windows.Forms.Button();
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColleges)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCollegeCode
            // 
            this.txtCollegeCode.Location = new System.Drawing.Point(206, 120);
            this.txtCollegeCode.Name = "txtCollegeCode";
            this.txtCollegeCode.Size = new System.Drawing.Size(155, 26);
            this.txtCollegeCode.TabIndex = 3;
            this.txtCollegeCode.TextChanged += new System.EventHandler(this.txtCollegeCode_TextChanged_1);
            // 
            // chkCollegeActive
            // 
            this.chkCollegeActive.AutoSize = true;
            this.chkCollegeActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkCollegeActive.Location = new System.Drawing.Point(46, 172);
            this.chkCollegeActive.Name = "chkCollegeActive";
            this.chkCollegeActive.Size = new System.Drawing.Size(85, 26);
            this.chkCollegeActive.TabIndex = 4;
            this.chkCollegeActive.Text = "Active";
            this.chkCollegeActive.UseVisualStyleBackColor = true;
            this.chkCollegeActive.CheckedChanged += new System.EventHandler(this.chkCollegeActive_CheckedChanged_1);
            // 
            // dgvColleges
            // 
            this.dgvColleges.AllowUserToAddRows = false;
            this.dgvColleges.AllowUserToDeleteRows = false;
            this.dgvColleges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColleges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColleges.Location = new System.Drawing.Point(45, 290);
            this.dgvColleges.Name = "dgvColleges";
            this.dgvColleges.ReadOnly = true;
            this.dgvColleges.RowHeadersWidth = 62;
            this.dgvColleges.RowTemplate.Height = 28;
            this.dgvColleges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColleges.Size = new System.Drawing.Size(503, 234);
            this.dgvColleges.TabIndex = 0;
            this.dgvColleges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColleges_CellContentClick_1);
            // 
            // txtCollegeName
            // 
            this.txtCollegeName.Location = new System.Drawing.Point(206, 82);
            this.txtCollegeName.Name = "txtCollegeName";
            this.txtCollegeName.Size = new System.Drawing.Size(155, 26);
            this.txtCollegeName.TabIndex = 2;
            this.txtCollegeName.TextChanged += new System.EventHandler(this.txtCollegeName_TextChanged_1);
            // 
            // txtCollegeID
            // 
            this.txtCollegeID.Location = new System.Drawing.Point(206, 42);
            this.txtCollegeID.Name = "txtCollegeID";
            this.txtCollegeID.ReadOnly = true;
            this.txtCollegeID.Size = new System.Drawing.Size(155, 26);
            this.txtCollegeID.TabIndex = 1;
            this.txtCollegeID.TextChanged += new System.EventHandler(this.txtCollegeID_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Collage ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(41, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Collage Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(41, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Collage Code:";
            // 
            // btnAddCollege
            // 
            this.btnAddCollege.Location = new System.Drawing.Point(56, 220);
            this.btnAddCollege.Name = "btnAddCollege";
            this.btnAddCollege.Size = new System.Drawing.Size(75, 32);
            this.btnAddCollege.TabIndex = 8;
            this.btnAddCollege.Text = "Add";
            this.btnAddCollege.UseVisualStyleBackColor = true;
            this.btnAddCollege.Click += new System.EventHandler(this.btnAddCollege_Click);
            // 
            // btnDeleteCollege
            // 
            this.btnDeleteCollege.Location = new System.Drawing.Point(331, 220);
            this.btnDeleteCollege.Name = "btnDeleteCollege";
            this.btnDeleteCollege.Size = new System.Drawing.Size(75, 32);
            this.btnDeleteCollege.TabIndex = 9;
            this.btnDeleteCollege.Text = "Delete";
            this.btnDeleteCollege.UseVisualStyleBackColor = true;
            this.btnDeleteCollege.Click += new System.EventHandler(this.btnDeleteCollege_Click);
            // 
            // btnUpdateCollege
            // 
            this.btnUpdateCollege.Location = new System.Drawing.Point(190, 220);
            this.btnUpdateCollege.Name = "btnUpdateCollege";
            this.btnUpdateCollege.Size = new System.Drawing.Size(75, 32);
            this.btnUpdateCollege.TabIndex = 10;
            this.btnUpdateCollege.Text = "Update";
            this.btnUpdateCollege.UseVisualStyleBackColor = true;
            this.btnUpdateCollege.Click += new System.EventHandler(this.btnUpdateCollege_Click);
            // 
            // btnReadCollege
            // 
            this.btnReadCollege.Location = new System.Drawing.Point(465, 220);
            this.btnReadCollege.Name = "btnReadCollege";
            this.btnReadCollege.Size = new System.Drawing.Size(75, 32);
            this.btnReadCollege.TabIndex = 11;
            this.btnReadCollege.Text = "View";
            this.btnReadCollege.UseVisualStyleBackColor = true;
            this.btnReadCollege.Click += new System.EventHandler(this.btnReadCollege_Click);
            // 
            // btnOpenForm2
            // 
            this.btnOpenForm2.Location = new System.Drawing.Point(212, 530);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new System.Drawing.Size(194, 35);
            this.btnOpenForm2.TabIndex = 12;
            this.btnOpenForm2.Text = "Manage Departments";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(628, 577);
            this.Controls.Add(this.btnOpenForm2);
            this.Controls.Add(this.btnReadCollege);
            this.Controls.Add(this.btnUpdateCollege);
            this.Controls.Add(this.btnDeleteCollege);
            this.Controls.Add(this.btnAddCollege);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvColleges);
            this.Controls.Add(this.txtCollegeID);
            this.Controls.Add(this.txtCollegeName);
            this.Controls.Add(this.txtCollegeCode);
            this.Controls.Add(this.chkCollegeActive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColleges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAddCollege;
        private Button btnDeleteCollege;
        private Button btnUpdateCollege;
        private Button btnReadCollege;
        private Button btnOpenForm2;
    }
}

