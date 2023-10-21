namespace EmployeeFormApp
{
    partial class EmployeeFormApp
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
            this.OpenView = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.bttnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.DOE = new System.Windows.Forms.DateTimePicker();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenView
            // 
            this.OpenView.Location = new System.Drawing.Point(552, 173);
            this.OpenView.Name = "OpenView";
            this.OpenView.Size = new System.Drawing.Size(122, 86);
            this.OpenView.TabIndex = 20;
            this.OpenView.Text = "OpenView";
            this.OpenView.UseVisualStyleBackColor = true;
            this.OpenView.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Location = new System.Drawing.Point(178, 49);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(348, 32);
            this.txtSurname.TabIndex = 0;
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(451, 357);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(75, 52);
            this.bttnSave.TabIndex = 5;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Surname";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirstName.Location = new System.Drawing.Point(178, 104);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(348, 32);
            this.txtFirstName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-5, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date of Employment";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Department";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Role";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picEmployee
            // 
            this.picEmployee.Location = new System.Drawing.Point(552, 49);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(100, 100);
            this.picEmployee.TabIndex = 12;
            this.picEmployee.TabStop = false;
            // 
            // DOE
            // 
            this.DOE.Location = new System.Drawing.Point(223, 174);
            this.DOE.Name = "DOE";
            this.DOE.Size = new System.Drawing.Size(303, 22);
            this.DOE.TabIndex = 2;
            // 
            // cmbDepart
            // 
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Items.AddRange(new object[] {
            "Application Dev",
            "Human Resources",
            "Project Manager",
            "Marketing"});
            this.cmbDepart.Location = new System.Drawing.Point(178, 238);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(348, 24);
            this.cmbDepart.TabIndex = 3;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Backend Dev",
            "Fronend Dev",
            "Data Analyst ",
            "Test Engineer"});
            this.cmbRole.Location = new System.Drawing.Point(178, 306);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(348, 24);
            this.cmbRole.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 21;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(178, 12);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(348, 22);
            this.id.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(92, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Id";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(291, 357);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 52);
            this.Delete.TabIndex = 24;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // EmployeeFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.cmbDepart);
            this.Controls.Add(this.DOE);
            this.Controls.Add(this.picEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.OpenView);
            this.Name = "EmployeeFormApp";
            this.Text = "EmployeeFormApp";
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenView;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.DateTimePicker DOE;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Delete;
    }
}

