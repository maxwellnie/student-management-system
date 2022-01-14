namespace 学生选课系统
{
    partial class frmSC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSelText = new System.Windows.Forms.TextBox();
            this.btnSelAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSelcondition = new System.Windows.Forms.ComboBox();
            this.dgrdvResult = new 学生选课系统.FUIDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSelText);
            this.panel1.Controls.Add(this.btnSelAll);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbSelcondition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 53);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1035, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "查询值：";
            // 
            // txtSelText
            // 
            this.txtSelText.Location = new System.Drawing.Point(1038, 22);
            this.txtSelText.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelText.Name = "txtSelText";
            this.txtSelText.Size = new System.Drawing.Size(132, 26);
            this.txtSelText.TabIndex = 2;
            this.txtSelText.TextChanged += new System.EventHandler(this.txtSelText_TextChanged);
            // 
            // btnSelAll
            // 
            this.btnSelAll.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSelAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelAll.FlatAppearance.BorderSize = 0;
            this.btnSelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelAll.ForeColor = System.Drawing.Color.White;
            this.btnSelAll.Image = global::学生选课系统.Properties.Resources.查询__1_;
            this.btnSelAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelAll.Location = new System.Drawing.Point(245, 0);
            this.btnSelAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelAll.Name = "btnSelAll";
            this.btnSelAll.Size = new System.Drawing.Size(125, 53);
            this.btnSelAll.TabIndex = 9;
            this.btnSelAll.Text = "查询全部";
            this.btnSelAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelAll.UseVisualStyleBackColor = false;
            this.btnSelAll.Click += new System.EventHandler(this.btnSelAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::学生选课系统.Properties.Resources.删除;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(125, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 53);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除记录";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btmFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::学生选课系统.Properties.Resources.添加__1_;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 53);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加记录";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnUpdataC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(890, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "查询内容：";
            // 
            // cmbSelcondition
            // 
            this.cmbSelcondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelcondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelcondition.FormattingEnabled = true;
            this.cmbSelcondition.Items.AddRange(new object[] {
            "学生学号",
            "课程编号"});
            this.cmbSelcondition.Location = new System.Drawing.Point(893, 22);
            this.cmbSelcondition.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSelcondition.Name = "cmbSelcondition";
            this.cmbSelcondition.Size = new System.Drawing.Size(131, 24);
            this.cmbSelcondition.TabIndex = 1;
            this.cmbSelcondition.SelectedIndexChanged += new System.EventHandler(this.cmbSelcondition_SelectedIndexChanged);
            // 
            // dgrdvResult
            // 
            this.dgrdvResult.AllowUserToAddRows = false;
            this.dgrdvResult.AllowUserToDeleteRows = false;
            this.dgrdvResult.AllowUserToResizeColumns = false;
            this.dgrdvResult.AllowUserToResizeRows = false;
            this.dgrdvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrdvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrdvResult.BackgroundColor = System.Drawing.Color.White;
            this.dgrdvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrdvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgrdvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrdvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrdvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdvResult.EnableHeadersVisualStyles = false;
            this.dgrdvResult.GridColor = System.Drawing.Color.Blue;
            this.dgrdvResult.Location = new System.Drawing.Point(0, 53);
            this.dgrdvResult.Name = "dgrdvResult";
            this.dgrdvResult.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrdvResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrdvResult.RowHeadersVisible = false;
            this.dgrdvResult.RowTemplate.Height = 23;
            this.dgrdvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdvResult.Size = new System.Drawing.Size(1170, 497);
            this.dgrdvResult.TabIndex = 3;
            this.dgrdvResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdvResult_CellContentClick);
            this.dgrdvResult.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdvResult_CellMouseDown_1);
            // 
            // frmSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgrdvResult);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩管理";
            this.Load += new System.EventHandler(this.frmSC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FUIDataGridView dgrdvResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSelText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSelcondition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelAll;
    }
}