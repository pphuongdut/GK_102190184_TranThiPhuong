
namespace GK_102190184_TranThiPhuong
{
    partial class Form1
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
            this.groupBox_DSGV = new System.Windows.Forms.GroupBox();
            this.datagridview_dsGV = new System.Windows.Forms.DataGridView();
            this.cbb_Sort = new System.Windows.Forms.ComboBox();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_search_type = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cbbCoso = new System.Windows.Forms.ComboBox();
            this.label_lsh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_DSGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_dsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_DSGV
            // 
            this.groupBox_DSGV.Controls.Add(this.datagridview_dsGV);
            this.groupBox_DSGV.Controls.Add(this.cbb_Sort);
            this.groupBox_DSGV.Controls.Add(this.btn_sort);
            this.groupBox_DSGV.Controls.Add(this.btn_delete);
            this.groupBox_DSGV.Controls.Add(this.btn_edit);
            this.groupBox_DSGV.Controls.Add(this.btn_add);
            this.groupBox_DSGV.Location = new System.Drawing.Point(46, 144);
            this.groupBox_DSGV.Name = "groupBox_DSGV";
            this.groupBox_DSGV.Size = new System.Drawing.Size(700, 254);
            this.groupBox_DSGV.TabIndex = 8;
            this.groupBox_DSGV.TabStop = false;
            this.groupBox_DSGV.Text = "Danh sách Giảng Viên";
            // 
            // datagridview_dsGV
            // 
            this.datagridview_dsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_dsGV.EnableHeadersVisualStyles = false;
            this.datagridview_dsGV.Location = new System.Drawing.Point(20, 32);
            this.datagridview_dsGV.Name = "datagridview_dsGV";
            this.datagridview_dsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_dsGV.Size = new System.Drawing.Size(657, 150);
            this.datagridview_dsGV.TabIndex = 11;
            // 
            // cbb_Sort
            // 
            this.cbb_Sort.FormattingEnabled = true;
            this.cbb_Sort.Location = new System.Drawing.Point(556, 214);
            this.cbb_Sort.Name = "cbb_Sort";
            this.cbb_Sort.Size = new System.Drawing.Size(121, 21);
            this.cbb_Sort.TabIndex = 10;
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(481, 212);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(46, 23);
            this.btn_sort.TabIndex = 9;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(145, 212);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(42, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Del";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(76, 212);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(42, 23);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(11, 212);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(43, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nội dung tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // cbb_search_type
            // 
            this.cbb_search_type.FormattingEnabled = true;
            this.cbb_search_type.Location = new System.Drawing.Point(625, 56);
            this.cbb_search_type.Name = "cbb_search_type";
            this.cbb_search_type.Size = new System.Drawing.Size(121, 21);
            this.cbb_search_type.TabIndex = 11;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(671, 117);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(646, 88);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 12;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cbbCoso
            // 
            this.cbbCoso.FormattingEnabled = true;
            this.cbbCoso.Location = new System.Drawing.Point(43, 87);
            this.cbbCoso.Name = "cbbCoso";
            this.cbbCoso.Size = new System.Drawing.Size(121, 21);
            this.cbbCoso.TabIndex = 9;
            this.cbbCoso.Text = "Chọn cơ sở";
            this.cbbCoso.SelectedIndexChanged += new System.EventHandler(this.cbbCoso_SelectedIndexChanged);
            // 
            // label_lsh
            // 
            this.label_lsh.AutoSize = true;
            this.label_lsh.Location = new System.Drawing.Point(43, 59);
            this.label_lsh.Name = "label_lsh";
            this.label_lsh.Size = new System.Drawing.Size(34, 13);
            this.label_lsh.TabIndex = 10;
            this.label_lsh.Text = "Cơ sở";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "QUẢN LÝ GIẢNG VIÊN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_search_type);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.cbbCoso);
            this.Controls.Add(this.label_lsh);
            this.Controls.Add(this.groupBox_DSGV);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Giảng Viên";
            this.groupBox_DSGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_dsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_DSGV;
        private System.Windows.Forms.DataGridView datagridview_dsGV;
        private System.Windows.Forms.ComboBox cbb_Sort;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_search_type;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cbbCoso;
        private System.Windows.Forms.Label label_lsh;
        private System.Windows.Forms.Label label3;
    }
}

