namespace WindowsForms
{
    partial class EmployeeForm
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
            this.lblEId = new System.Windows.Forms.Label();
            this.lblEname = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHRA = new System.Windows.Forms.Label();
            this.lblTA = new System.Windows.Forms.Label();
            this.lblDA = new System.Windows.Forms.Label();
            this.lblPF = new System.Windows.Forms.Label();
            this.lblGSal = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.txtEid = new System.Windows.Forms.TextBox();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtBSal = new System.Windows.Forms.TextBox();
            this.txtHRA = new System.Windows.Forms.TextBox();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.txtGSal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEId
            // 
            this.lblEId.AutoSize = true;
            this.lblEId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEId.Location = new System.Drawing.Point(28, 20);
            this.lblEId.Name = "lblEId";
            this.lblEId.Size = new System.Drawing.Size(73, 25);
            this.lblEId.TabIndex = 0;
            this.lblEId.Text = "Emp Id";
            this.lblEId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEname
            // 
            this.lblEname.AutoSize = true;
            this.lblEname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEname.Location = new System.Drawing.Point(28, 68);
            this.lblEname.Name = "lblEname";
            this.lblEname.Size = new System.Drawing.Size(106, 25);
            this.lblEname.TabIndex = 1;
            this.lblEname.Text = "Emp name";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(28, 122);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(53, 25);
            this.lblDept.TabIndex = 2;
            this.lblDept.Text = "Dept";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Basic Salary";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblHRA
            // 
            this.lblHRA.AutoSize = true;
            this.lblHRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRA.Location = new System.Drawing.Point(28, 235);
            this.lblHRA.Name = "lblHRA";
            this.lblHRA.Size = new System.Drawing.Size(53, 25);
            this.lblHRA.TabIndex = 4;
            this.lblHRA.Text = "HRA";
            this.lblHRA.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTA
            // 
            this.lblTA.AutoSize = true;
            this.lblTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTA.Location = new System.Drawing.Point(28, 301);
            this.lblTA.Name = "lblTA";
            this.lblTA.Size = new System.Drawing.Size(39, 25);
            this.lblTA.TabIndex = 5;
            this.lblTA.Text = "TA";
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDA.Location = new System.Drawing.Point(28, 375);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(40, 25);
            this.lblDA.TabIndex = 6;
            this.lblDA.Text = "DA";
            this.lblDA.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblPF
            // 
            this.lblPF.AutoSize = true;
            this.lblPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPF.Location = new System.Drawing.Point(28, 439);
            this.lblPF.Name = "lblPF";
            this.lblPF.Size = new System.Drawing.Size(37, 25);
            this.lblPF.TabIndex = 7;
            this.lblPF.Text = "PF";
            // 
            // lblGSal
            // 
            this.lblGSal.AutoSize = true;
            this.lblGSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGSal.Location = new System.Drawing.Point(28, 501);
            this.lblGSal.Name = "lblGSal";
            this.lblGSal.Size = new System.Drawing.Size(125, 25);
            this.lblGSal.TabIndex = 8;
            this.lblGSal.Text = "Gross Salary";
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(217, 123);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(152, 28);
            this.cmbDept.TabIndex = 9;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmbDept_SelectedIndexChanged);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblmsg.Location = new System.Drawing.Point(465, 126);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(93, 25);
            this.lblmsg.TabIndex = 10;
            this.lblmsg.Text = "Message";
            // 
            // txtEid
            // 
            this.txtEid.Location = new System.Drawing.Point(217, 12);
            this.txtEid.Name = "txtEid";
            this.txtEid.Size = new System.Drawing.Size(152, 26);
            this.txtEid.TabIndex = 11;
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(217, 69);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(152, 26);
            this.txtEname.TabIndex = 12;
            this.txtEname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBSal
            // 
            this.txtBSal.Location = new System.Drawing.Point(218, 182);
            this.txtBSal.Name = "txtBSal";
            this.txtBSal.Size = new System.Drawing.Size(151, 26);
            this.txtBSal.TabIndex = 13;
            this.txtBSal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtHRA
            // 
            this.txtHRA.Location = new System.Drawing.Point(217, 236);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.Size = new System.Drawing.Size(151, 26);
            this.txtHRA.TabIndex = 14;
            // 
            // txtTA
            // 
            this.txtTA.Location = new System.Drawing.Point(216, 300);
            this.txtTA.Name = "txtTA";
            this.txtTA.Size = new System.Drawing.Size(152, 26);
            this.txtTA.TabIndex = 15;
            this.txtTA.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtDA
            // 
            this.txtDA.Location = new System.Drawing.Point(218, 374);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(151, 26);
            this.txtDA.TabIndex = 16;
            // 
            // txtPF
            // 
            this.txtPF.Location = new System.Drawing.Point(216, 438);
            this.txtPF.Name = "txtPF";
            this.txtPF.Size = new System.Drawing.Size(152, 26);
            this.txtPF.TabIndex = 17;
            // 
            // txtGSal
            // 
            this.txtGSal.Location = new System.Drawing.Point(218, 500);
            this.txtGSal.Name = "txtGSal";
            this.txtGSal.Size = new System.Drawing.Size(151, 26);
            this.txtGSal.TabIndex = 18;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Red;
            this.btnCalculate.Location = new System.Drawing.Point(470, 471);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(154, 33);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDisplay.Location = new System.Drawing.Point(643, 471);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(148, 33);
            this.btnDisplay.TabIndex = 20;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1062, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 589);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtGSal);
            this.Controls.Add(this.txtPF);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.txtTA);
            this.Controls.Add(this.txtHRA);
            this.Controls.Add(this.txtBSal);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.txtEid);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.lblGSal);
            this.Controls.Add(this.lblPF);
            this.Controls.Add(this.lblDA);
            this.Controls.Add(this.lblTA);
            this.Controls.Add(this.lblHRA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblEname);
            this.Controls.Add(this.lblEId);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEId;
        private System.Windows.Forms.Label lblEname;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHRA;
        private System.Windows.Forms.Label lblTA;
        private System.Windows.Forms.Label lblDA;
        private System.Windows.Forms.Label lblPF;
        private System.Windows.Forms.Label lblGSal;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.TextBox txtEid;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtBSal;
        private System.Windows.Forms.TextBox txtHRA;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.TextBox txtGSal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnExit;
    }
}