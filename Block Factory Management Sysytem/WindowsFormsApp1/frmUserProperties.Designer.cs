namespace WindowsFormsApp1
{
    partial class frmUserProperties
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("المبيعات");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("المشتريات");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("الانتاج");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("الكل", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.is_active = new System.Windows.Forms.CheckBox();
            this.treeUserPermission = new System.Windows.Forms.TreeView();
            this.cbEmp = new System.Windows.Forms.ComboBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(265, 276);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 30);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(362, 276);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(89, 30);
            this.btnApply.TabIndex = 33;
            this.btnApply.Text = "حفظ";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // is_active
            // 
            this.is_active.AutoSize = true;
            this.is_active.Checked = true;
            this.is_active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.is_active.Location = new System.Drawing.Point(304, 210);
            this.is_active.Name = "is_active";
            this.is_active.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.is_active.Size = new System.Drawing.Size(50, 24);
            this.is_active.TabIndex = 45;
            this.is_active.Text = "نشط";
            this.is_active.UseVisualStyleBackColor = true;
            // 
            // treeUserPermission
            // 
            this.treeUserPermission.CheckBoxes = true;
            this.treeUserPermission.Location = new System.Drawing.Point(12, 110);
            this.treeUserPermission.Name = "treeUserPermission";
            treeNode1.Name = "Sales";
            treeNode1.Text = "المبيعات";
            treeNode2.Name = "Purch";
            treeNode2.Text = "المشتريات";
            treeNode3.Name = "Production";
            treeNode3.Text = "الانتاج";
            treeNode4.Name = "All";
            treeNode4.Text = "الكل";
            this.treeUserPermission.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeUserPermission.Size = new System.Drawing.Size(342, 94);
            this.treeUserPermission.TabIndex = 44;
            this.treeUserPermission.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeUserPermission_AfterCheck);
            // 
            // cbEmp
            // 
            this.cbEmp.FormattingEnabled = true;
            this.cbEmp.Location = new System.Drawing.Point(12, 67);
            this.cbEmp.Name = "cbEmp";
            this.cbEmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbEmp.Size = new System.Drawing.Size(342, 28);
            this.cbEmp.TabIndex = 43;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 35);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUsername.Size = new System.Drawing.Size(342, 26);
            this.txtUsername.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 113);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "السماح بالوصول الى : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 73);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "حساب الموظف : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 41);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "اسم المستخدم :";
            // 
            // frmUserProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 320);
            this.Controls.Add(this.is_active);
            this.Controls.Add(this.treeUserPermission);
            this.Controls.Add(this.cbEmp);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUserProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خصائص الحساب";
            this.Load += new System.EventHandler(this.frmUserProperties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox is_active;
        private System.Windows.Forms.TreeView treeUserPermission;
        private System.Windows.Forms.ComboBox cbEmp;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}