﻿using System.ComponentModel;
using System.Windows.Forms;

namespace FunctionForm.User
{
    partial class FrmAddRole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btnAddRole = new System.Windows.Forms.Button();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.txtRolename = new System.Windows.Forms.TextBox();
            this.lblResource = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.btnAddPriviege = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbActionGroup = new System.Windows.Forms.ComboBox();
            this.chklstAction = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCollection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbResourceType = new System.Windows.Forms.ComboBox();
            this.lblResourceType = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstPriviege = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(367, 525);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(100, 30);
            this.btnAddRole.TabIndex = 0;
            this.btnAddRole.Text = "Add Role";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(35, 532);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(73, 17);
            this.lblRoleName.TabIndex = 1;
            this.lblRoleName.Text = "Role Name";
            // 
            // txtRolename
            // 
            this.txtRolename.Location = new System.Drawing.Point(120, 529);
            this.txtRolename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRolename.Name = "txtRolename";
            this.txtRolename.Size = new System.Drawing.Size(241, 23);
            this.txtRolename.TabIndex = 2;
            // 
            // lblResource
            // 
            this.lblResource.AutoSize = true;
            this.lblResource.Location = new System.Drawing.Point(22, 29);
            this.lblResource.Name = "lblResource";
            this.lblResource.Size = new System.Drawing.Size(62, 17);
            this.lblResource.TabIndex = 4;
            this.lblResource.Text = "Resource";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(22, 153);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(44, 17);
            this.lblAction.TabIndex = 5;
            this.lblAction.Text = "Action";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(233, 54);
            this.cmbDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(210, 25);
            this.cmbDatabase.TabIndex = 6;
            this.cmbDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbDatabase_SelectedIndexChanged);
            // 
            // btnAddPriviege
            // 
            this.btnAddPriviege.Location = new System.Drawing.Point(96, 255);
            this.btnAddPriviege.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPriviege.Name = "btnAddPriviege";
            this.btnAddPriviege.Size = new System.Drawing.Size(147, 30);
            this.btnAddPriviege.TabIndex = 15;
            this.btnAddPriviege.Text = "Add Priviege";
            this.btnAddPriviege.UseVisualStyleBackColor = true;
            this.btnAddPriviege.Click += new System.EventHandler(this.btnAddPriviege_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Action Type Group";
            // 
            // cmbActionGroup
            // 
            this.cmbActionGroup.FormattingEnabled = true;
            this.cmbActionGroup.Location = new System.Drawing.Point(233, 120);
            this.cmbActionGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbActionGroup.Name = "cmbActionGroup";
            this.cmbActionGroup.Size = new System.Drawing.Size(210, 25);
            this.cmbActionGroup.TabIndex = 13;
            this.cmbActionGroup.SelectedIndexChanged += new System.EventHandler(this.cmbActionGroup_SelectedIndexChanged);
            // 
            // chklstAction
            // 
            this.chklstAction.FormattingEnabled = true;
            this.chklstAction.Location = new System.Drawing.Point(96, 153);
            this.chklstAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chklstAction.Name = "chklstAction";
            this.chklstAction.Size = new System.Drawing.Size(354, 94);
            this.chklstAction.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Collection";
            // 
            // cmbCollection
            // 
            this.cmbCollection.FormattingEnabled = true;
            this.cmbCollection.Location = new System.Drawing.Point(233, 87);
            this.cmbCollection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCollection.Name = "cmbCollection";
            this.cmbCollection.Size = new System.Drawing.Size(210, 25);
            this.cmbCollection.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "DataBase";
            // 
            // cmbResourceType
            // 
            this.cmbResourceType.FormattingEnabled = true;
            this.cmbResourceType.Location = new System.Drawing.Point(233, 21);
            this.cmbResourceType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbResourceType.Name = "cmbResourceType";
            this.cmbResourceType.Size = new System.Drawing.Size(210, 25);
            this.cmbResourceType.TabIndex = 8;
            // 
            // lblResourceType
            // 
            this.lblResourceType.AutoSize = true;
            this.lblResourceType.Location = new System.Drawing.Point(104, 29);
            this.lblResourceType.Name = "lblResourceType";
            this.lblResourceType.Size = new System.Drawing.Size(36, 17);
            this.lblResourceType.TabIndex = 7;
            this.lblResourceType.Text = "Type";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 500);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstPriviege);
            this.tabPage1.Controls.Add(this.btnAddPriviege);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblResource);
            this.tabPage1.Controls.Add(this.cmbActionGroup);
            this.tabPage1.Controls.Add(this.lblAction);
            this.tabPage1.Controls.Add(this.chklstAction);
            this.tabPage1.Controls.Add(this.cmbDatabase);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblResourceType);
            this.tabPage1.Controls.Add(this.cmbCollection);
            this.tabPage1.Controls.Add(this.cmbResourceType);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(469, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add privilege";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(469, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Roles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstPriviege
            // 
            this.lstPriviege.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstPriviege.FullRowSelect = true;
            this.lstPriviege.GridLines = true;
            this.lstPriviege.Location = new System.Drawing.Point(25, 293);
            this.lstPriviege.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstPriviege.Name = "lstPriviege";
            this.lstPriviege.Size = new System.Drawing.Size(424, 170);
            this.lstPriviege.TabIndex = 16;
            this.lstPriviege.UseCompatibleStateImageBehavior = false;
            this.lstPriviege.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Resource";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Action";
            this.columnHeader2.Width = 276;
            // 
            // FrmAddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtRolename);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.btnAddRole);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Custom Role";
            this.Load += new System.EventHandler(this.frmAddRole_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddRole;
        private Label lblRoleName;
        private TextBox txtRolename;
        private Label lblResource;
        private Label lblAction;
        private ComboBox cmbDatabase;
        private ComboBox cmbResourceType;
        private Label lblResourceType;
        private Label label1;
        private Label label2;
        private ComboBox cmbCollection;
        private Label label3;
        private ComboBox cmbActionGroup;
        private CheckedListBox chklstAction;
        private Button btnAddPriviege;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView lstPriviege;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}