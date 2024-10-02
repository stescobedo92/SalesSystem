namespace SalesSystem.GUI.Forms
{
    partial class frmCatgory
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
            tabControlMain = new TabControl();
            tabListCategories = new TabPage();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            txbSearch = new TextBox();
            btnNew = new Button();
            tabNewCategory = new TabPage();
            btnSave = new Button();
            btnBack = new Button();
            cmbMeasurement = new ComboBox();
            lbMeasurement = new Label();
            txbCategoryName = new TextBox();
            lbNewCategory = new Label();
            tabUpdateCategory = new TabPage();
            btnSaveUpdate = new Button();
            btnBackUpdate = new Button();
            cmbCategoryMeasurement = new ComboBox();
            label2 = new Label();
            txbCategoryUpdate = new TextBox();
            label3 = new Label();
            label1 = new Label();
            cmbActive = new ComboBox();
            label4 = new Label();
            tabControlMain.SuspendLayout();
            tabListCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabNewCategory.SuspendLayout();
            tabUpdateCategory.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabListCategories);
            tabControlMain.Controls.Add(tabNewCategory);
            tabControlMain.Controls.Add(tabUpdateCategory);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(12, 51);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(740, 344);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 0;
            // 
            // tabListCategories
            // 
            tabListCategories.Controls.Add(dataGridView1);
            tabListCategories.Controls.Add(btnSearch);
            tabListCategories.Controls.Add(txbSearch);
            tabListCategories.Controls.Add(btnNew);
            tabListCategories.Location = new Point(4, 24);
            tabListCategories.Name = "tabListCategories";
            tabListCategories.Padding = new Padding(3);
            tabListCategories.Size = new Size(732, 316);
            tabListCategories.TabIndex = 0;
            tabListCategories.Text = "List";
            tabListCategories.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(711, 268);
            dataGridView1.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(650, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(500, 13);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(144, 23);
            txbSearch.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Location = new Point(14, 13);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // tabNewCategory
            // 
            tabNewCategory.Controls.Add(btnSave);
            tabNewCategory.Controls.Add(btnBack);
            tabNewCategory.Controls.Add(cmbMeasurement);
            tabNewCategory.Controls.Add(lbMeasurement);
            tabNewCategory.Controls.Add(txbCategoryName);
            tabNewCategory.Controls.Add(lbNewCategory);
            tabNewCategory.Location = new Point(4, 24);
            tabNewCategory.Name = "tabNewCategory";
            tabNewCategory.Padding = new Padding(3);
            tabNewCategory.Size = new Size(732, 316);
            tabNewCategory.TabIndex = 1;
            tabNewCategory.Text = "New";
            tabNewCategory.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(30, 90, 195);
            btnSave.Location = new Point(631, 287);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(17, 287);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // cmbMeasurement
            // 
            cmbMeasurement.Cursor = Cursors.Hand;
            cmbMeasurement.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMeasurement.FormattingEnabled = true;
            cmbMeasurement.Location = new Point(17, 97);
            cmbMeasurement.Name = "cmbMeasurement";
            cmbMeasurement.Size = new Size(686, 23);
            cmbMeasurement.TabIndex = 3;
            // 
            // lbMeasurement
            // 
            lbMeasurement.AutoSize = true;
            lbMeasurement.Location = new Point(17, 79);
            lbMeasurement.Name = "lbMeasurement";
            lbMeasurement.Size = new Size(86, 15);
            lbMeasurement.TabIndex = 2;
            lbMeasurement.Text = "Measurement: ";
            // 
            // txbCategoryName
            // 
            txbCategoryName.Location = new Point(17, 33);
            txbCategoryName.Name = "txbCategoryName";
            txbCategoryName.Size = new Size(689, 23);
            txbCategoryName.TabIndex = 1;
            // 
            // lbNewCategory
            // 
            lbNewCategory.AutoSize = true;
            lbNewCategory.Location = new Point(17, 15);
            lbNewCategory.Name = "lbNewCategory";
            lbNewCategory.Size = new Size(42, 15);
            lbNewCategory.TabIndex = 0;
            lbNewCategory.Text = "Name:";
            // 
            // tabUpdateCategory
            // 
            tabUpdateCategory.Controls.Add(cmbActive);
            tabUpdateCategory.Controls.Add(label4);
            tabUpdateCategory.Controls.Add(btnSaveUpdate);
            tabUpdateCategory.Controls.Add(btnBackUpdate);
            tabUpdateCategory.Controls.Add(cmbCategoryMeasurement);
            tabUpdateCategory.Controls.Add(label2);
            tabUpdateCategory.Controls.Add(txbCategoryUpdate);
            tabUpdateCategory.Controls.Add(label3);
            tabUpdateCategory.Location = new Point(4, 24);
            tabUpdateCategory.Name = "tabUpdateCategory";
            tabUpdateCategory.Padding = new Padding(3);
            tabUpdateCategory.Size = new Size(732, 316);
            tabUpdateCategory.TabIndex = 2;
            tabUpdateCategory.Text = "Update";
            tabUpdateCategory.UseVisualStyleBackColor = true;
            // 
            // btnSaveUpdate
            // 
            btnSaveUpdate.Cursor = Cursors.Hand;
            btnSaveUpdate.FlatStyle = FlatStyle.Flat;
            btnSaveUpdate.ForeColor = Color.FromArgb(30, 90, 195);
            btnSaveUpdate.Location = new Point(629, 283);
            btnSaveUpdate.Name = "btnSaveUpdate";
            btnSaveUpdate.Size = new Size(75, 23);
            btnSaveUpdate.TabIndex = 11;
            btnSaveUpdate.Text = "Save";
            btnSaveUpdate.UseVisualStyleBackColor = true;
            // 
            // btnBackUpdate
            // 
            btnBackUpdate.Cursor = Cursors.Hand;
            btnBackUpdate.FlatStyle = FlatStyle.Flat;
            btnBackUpdate.Location = new Point(15, 283);
            btnBackUpdate.Name = "btnBackUpdate";
            btnBackUpdate.Size = new Size(75, 23);
            btnBackUpdate.TabIndex = 10;
            btnBackUpdate.Text = "< Back";
            btnBackUpdate.UseVisualStyleBackColor = true;
            // 
            // cmbCategoryMeasurement
            // 
            cmbCategoryMeasurement.Cursor = Cursors.Hand;
            cmbCategoryMeasurement.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoryMeasurement.FormattingEnabled = true;
            cmbCategoryMeasurement.Location = new Point(18, 98);
            cmbCategoryMeasurement.Name = "cmbCategoryMeasurement";
            cmbCategoryMeasurement.Size = new Size(686, 23);
            cmbCategoryMeasurement.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 80);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 8;
            label2.Text = "Measurement: ";
            // 
            // txbCategoryUpdate
            // 
            txbCategoryUpdate.Location = new Point(15, 29);
            txbCategoryUpdate.Name = "txbCategoryUpdate";
            txbCategoryUpdate.Size = new Size(689, 23);
            txbCategoryUpdate.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 11);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 1;
            label1.Text = "Inventary / Category";
            // 
            // cmbActive
            // 
            cmbActive.Cursor = Cursors.Hand;
            cmbActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActive.FormattingEnabled = true;
            cmbActive.Location = new Point(15, 179);
            cmbActive.Name = "cmbActive";
            cmbActive.Size = new Size(686, 23);
            cmbActive.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 161);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 12;
            label4.Text = "Active: ";
            // 
            // frmCatgory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCatgory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New";
            tabControlMain.ResumeLayout(false);
            tabListCategories.ResumeLayout(false);
            tabListCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabNewCategory.ResumeLayout(false);
            tabNewCategory.PerformLayout();
            tabUpdateCategory.ResumeLayout(false);
            tabUpdateCategory.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabListCategories;
        private TabPage tabNewCategory;
        private Label label1;
        private TabPage tabUpdateCategory;
        private Button btnSearch;
        private TextBox txbSearch;
        private Button btnNew;
        private DataGridView dataGridView1;
        private ComboBox cmbMeasurement;
        private Label lbMeasurement;
        private TextBox txbCategoryName;
        private Label lbNewCategory;
        private Button btnSave;
        private Button btnBack;
        private Button btnSaveUpdate;
        private Button btnBackUpdate;
        private ComboBox cmbCategoryMeasurement;
        private Label label2;
        private TextBox txbCategoryUpdate;
        private Label label3;
        private ComboBox cmbActive;
        private Label label4;
    }
}