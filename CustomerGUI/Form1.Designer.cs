namespace CustomerGUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.гостиница_DBDataSet = new CustomerGUI.Гостиница_DBDataSet();
            this.постояльцыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.постояльцыTableAdapter = new CustomerGUI.Гостиница_DBDataSetTableAdapters.постояльцыTableAdapter();
            this.tableAdapterManager = new CustomerGUI.Гостиница_DBDataSetTableAdapters.TableAdapterManager();
            this.постояльцыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prev_first_btn = new System.Windows.Forms.Button();
            this.prev_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.next_last_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.гостиница_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постояльцыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постояльцыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // гостиница_DBDataSet
            // 
            this.гостиница_DBDataSet.DataSetName = "Гостиница_DBDataSet";
            this.гостиница_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // постояльцыBindingSource
            // 
            this.постояльцыBindingSource.DataMember = "постояльцы";
            this.постояльцыBindingSource.DataSource = this.гостиница_DBDataSet;
            // 
            // постояльцыTableAdapter
            // 
            this.постояльцыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CustomerGUI.Гостиница_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.постояльцыTableAdapter = this.постояльцыTableAdapter;
            // 
            // постояльцыDataGridView
            // 
            this.постояльцыDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.постояльцыDataGridView.AutoGenerateColumns = false;
            this.постояльцыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.постояльцыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.постояльцыDataGridView.DataSource = this.постояльцыBindingSource;
            this.постояльцыDataGridView.Location = new System.Drawing.Point(0, 100);
            this.постояльцыDataGridView.Name = "постояльцыDataGridView";
            this.постояльцыDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.постояльцыDataGridView.Size = new System.Drawing.Size(800, 201);
            this.постояльцыDataGridView.TabIndex = 1;
            this.постояльцыDataGridView.SelectionChanged += new System.EventHandler(this.постояльцыDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "код_постояльца";
            this.dataGridViewTextBoxColumn1.HeaderText = "код_постояльца";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "фио_постояльца";
            this.dataGridViewTextBoxColumn2.HeaderText = "фио_постояльца";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "паспортные_данные";
            this.dataGridViewTextBoxColumn3.HeaderText = "паспортные_данные";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "данные_реквизитов";
            this.dataGridViewTextBoxColumn4.HeaderText = "данные_реквизитов";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(256, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 20);
            this.textBox3.TabIndex = 7;
            // 
            // delete_btn
            // 
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("delete_btn.Image")));
            this.delete_btn.Location = new System.Drawing.Point(289, 64);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(30, 30);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("edit_btn.Image")));
            this.edit_btn.Location = new System.Drawing.Point(253, 64);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(30, 30);
            this.edit_btn.TabIndex = 3;
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_btn.Image")));
            this.add_btn.Location = new System.Drawing.Point(217, 64);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(30, 30);
            this.add_btn.TabIndex = 2;
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО постояльца";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Паспортные данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Данные реквизитов";
            // 
            // prev_first_btn
            // 
            this.prev_first_btn.Image = ((System.Drawing.Image)(resources.GetObject("prev_first_btn.Image")));
            this.prev_first_btn.Location = new System.Drawing.Point(12, 64);
            this.prev_first_btn.Name = "prev_first_btn";
            this.prev_first_btn.Size = new System.Drawing.Size(30, 30);
            this.prev_first_btn.TabIndex = 11;
            this.prev_first_btn.UseVisualStyleBackColor = true;
            this.prev_first_btn.Click += new System.EventHandler(this.prev_first_btn_Click);
            // 
            // prev_btn
            // 
            this.prev_btn.Image = ((System.Drawing.Image)(resources.GetObject("prev_btn.Image")));
            this.prev_btn.Location = new System.Drawing.Point(48, 64);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(30, 30);
            this.prev_btn.TabIndex = 12;
            this.prev_btn.UseVisualStyleBackColor = true;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Image = ((System.Drawing.Image)(resources.GetObject("next_btn.Image")));
            this.next_btn.Location = new System.Drawing.Point(145, 64);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(30, 30);
            this.next_btn.TabIndex = 13;
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // next_last_btn
            // 
            this.next_last_btn.Image = ((System.Drawing.Image)(resources.GetObject("next_last_btn.Image")));
            this.next_last_btn.Location = new System.Drawing.Point(181, 64);
            this.next_last_btn.Name = "next_last_btn";
            this.next_last_btn.Size = new System.Drawing.Size(30, 30);
            this.next_last_btn.TabIndex = 14;
            this.next_last_btn.UseVisualStyleBackColor = true;
            this.next_last_btn.Click += new System.EventHandler(this.next_last_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 3);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.next_last_btn);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.prev_btn);
            this.Controls.Add(this.prev_first_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.постояльцыDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.гостиница_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постояльцыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постояльцыDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Гостиница_DBDataSet гостиница_DBDataSet;
        private System.Windows.Forms.BindingSource постояльцыBindingSource;
        private Гостиница_DBDataSetTableAdapters.постояльцыTableAdapter постояльцыTableAdapter;
        private Гостиница_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView постояльцыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button prev_first_btn;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button next_last_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

