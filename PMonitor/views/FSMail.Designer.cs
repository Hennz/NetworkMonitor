﻿namespace PMonitor.views
{
    partial class FSMail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSMail));
            this.monitorDataSet = new PMonitor.monitorDataSet();
            this.software_mail_listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.software_mail_listTableAdapter = new PMonitor.monitorDataSetTableAdapters.software_mail_listTableAdapter();
            this.tableAdapterManager = new PMonitor.monitorDataSetTableAdapters.TableAdapterManager();
            this.softwareTableAdapter = new PMonitor.monitorDataSetTableAdapters.softwareTableAdapter();
            this.usersTableAdapter = new PMonitor.monitorDataSetTableAdapters.usersTableAdapter();
            this.software_mail_listBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.software_mail_listBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.software_mail_listDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vsoftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vsoftTableAdapter = new PMonitor.monitorDataSetTableAdapters.vsoftTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.software_mail_listBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.software_mail_listBindingNavigator)).BeginInit();
            this.software_mail_listBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.software_mail_listDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsoftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // monitorDataSet
            // 
            this.monitorDataSet.DataSetName = "monitorDataSet";
            this.monitorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // software_mail_listBindingSource
            // 
            this.software_mail_listBindingSource.DataMember = "software_mail_list";
            this.software_mail_listBindingSource.DataSource = this.monitorDataSet;
            // 
            // software_mail_listTableAdapter
            // 
            this.software_mail_listTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.action_typesTableAdapter = null;
            this.tableAdapterManager.auditTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.check_typesTableAdapter = null;
            this.tableAdapterManager.floorsTableAdapter = null;
            this.tableAdapterManager.hardware_mail_listTableAdapter = null;
            this.tableAdapterManager.hardwaresTableAdapter = null;
            this.tableAdapterManager.monitoringTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.roomsTableAdapter = null;
            this.tableAdapterManager.software_mail_listTableAdapter = this.software_mail_listTableAdapter;
            this.tableAdapterManager.softwareTableAdapter = this.softwareTableAdapter;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PMonitor.monitorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // softwareTableAdapter
            // 
            this.softwareTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // software_mail_listBindingNavigator
            // 
            this.software_mail_listBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.software_mail_listBindingNavigator.BindingSource = this.software_mail_listBindingSource;
            this.software_mail_listBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.software_mail_listBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.software_mail_listBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.software_mail_listBindingNavigatorSaveItem});
            this.software_mail_listBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.software_mail_listBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.software_mail_listBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.software_mail_listBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.software_mail_listBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.software_mail_listBindingNavigator.Name = "software_mail_listBindingNavigator";
            this.software_mail_listBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.software_mail_listBindingNavigator.Size = new System.Drawing.Size(444, 25);
            this.software_mail_listBindingNavigator.TabIndex = 0;
            this.software_mail_listBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // software_mail_listBindingNavigatorSaveItem
            // 
            this.software_mail_listBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.software_mail_listBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("software_mail_listBindingNavigatorSaveItem.Image")));
            this.software_mail_listBindingNavigatorSaveItem.Name = "software_mail_listBindingNavigatorSaveItem";
            this.software_mail_listBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.software_mail_listBindingNavigatorSaveItem.Text = "Save Data";
            this.software_mail_listBindingNavigatorSaveItem.Click += new System.EventHandler(this.software_mail_listBindingNavigatorSaveItem_Click);
            // 
            // software_mail_listDataGridView
            // 
            this.software_mail_listDataGridView.AllowUserToAddRows = false;
            this.software_mail_listDataGridView.AutoGenerateColumns = false;
            this.software_mail_listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.software_mail_listDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.software_mail_listDataGridView.DataSource = this.software_mail_listBindingSource;
            this.software_mail_listDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.software_mail_listDataGridView.Location = new System.Drawing.Point(0, 25);
            this.software_mail_listDataGridView.Name = "software_mail_listDataGridView";
            this.software_mail_listDataGridView.Size = new System.Drawing.Size(444, 327);
            this.software_mail_listDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_user";
            this.dataGridViewTextBoxColumn2.DataSource = this.usersBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "nick";
            this.dataGridViewTextBoxColumn2.FillWeight = 200F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Пользователь";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "id";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.monitorDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_software";
            this.dataGridViewTextBoxColumn3.DataSource = this.vsoftBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "dd";
            this.dataGridViewTextBoxColumn3.FillWeight = 200F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Тест";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "id";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // vsoftBindingSource
            // 
            this.vsoftBindingSource.DataMember = "vsoft";
            this.vsoftBindingSource.DataSource = this.monitorDataSet;
            // 
            // softwareBindingSource
            // 
            this.softwareBindingSource.DataMember = "software";
            this.softwareBindingSource.DataSource = this.monitorDataSet;
            // 
            // vsoftTableAdapter
            // 
            this.vsoftTableAdapter.ClearBeforeFill = true;
            // 
            // FSMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 352);
            this.Controls.Add(this.software_mail_listDataGridView);
            this.Controls.Add(this.software_mail_listBindingNavigator);
            this.MaximizeBox = false;
            this.Name = "FSMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список рассылки по тестам";
            this.Load += new System.EventHandler(this.FSMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.software_mail_listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.software_mail_listBindingNavigator)).EndInit();
            this.software_mail_listBindingNavigator.ResumeLayout(false);
            this.software_mail_listBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.software_mail_listDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsoftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private monitorDataSet monitorDataSet;
        private System.Windows.Forms.BindingSource software_mail_listBindingSource;
        private monitorDataSetTableAdapters.software_mail_listTableAdapter software_mail_listTableAdapter;
        private monitorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator software_mail_listBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton software_mail_listBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView software_mail_listDataGridView;
        private monitorDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private monitorDataSetTableAdapters.softwareTableAdapter softwareTableAdapter;
        private System.Windows.Forms.BindingSource softwareBindingSource;
        private System.Windows.Forms.BindingSource vsoftBindingSource;
        private monitorDataSetTableAdapters.vsoftTableAdapter vsoftTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
    }
}