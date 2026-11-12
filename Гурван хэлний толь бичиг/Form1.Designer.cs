namespace Гурван_хэлний_толь_бичиг
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelTop = new Panel();
            cmbLang = new ComboBox();
            lblLang = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            panelBottom = new Panel();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtRus = new TextBox();
            lblRus = new Label();
            txtMon = new TextBox();
            lblMon = new Label();
            txtEng = new TextBox();
            lblEng = new Label();
            statusStrip1 = new StatusStrip();
            lblCount = new ToolStripStatusLabel();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            NUmber = new DataGridViewTextBoxColumn();
            Англи = new DataGridViewTextBoxColumn();
            Монгол = new DataGridViewTextBoxColumn();
            Орос = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(cmbLang);
            panelTop.Controls.Add(lblLang);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(lblSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1010, 73);
            panelTop.TabIndex = 0;
            // 
            // cmbLang
            // 
            cmbLang.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLang.Font = new Font("Segoe UI", 10F);
            cmbLang.FormattingEnabled = true;
            cmbLang.Location = new Point(886, 19);
            cmbLang.Margin = new Padding(3, 4, 3, 4);
            cmbLang.Name = "cmbLang";
            cmbLang.Size = new Size(108, 31);
            cmbLang.TabIndex = 3;
            cmbLang.SelectedIndexChanged += cmbLang_SelectedIndexChanged;
            // 
            // lblLang
            // 
            lblLang.AutoSize = true;
            lblLang.Font = new Font("Segoe UI", 10F);
            lblLang.Location = new Point(837, 23);
            lblLang.Name = "lblLang";
            lblLang.Size = new Size(41, 23);
            lblLang.TabIndex = 2;
            lblLang.Text = "Хэл:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(74, 19);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(297, 30);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Хайх үг...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(14, 23);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(51, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Хайх:";
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnSave);
            panelBottom.Controls.Add(btnClear);
            panelBottom.Controls.Add(btnDelete);
            panelBottom.Controls.Add(btnUpdate);
            panelBottom.Controls.Add(btnAdd);
            panelBottom.Controls.Add(txtRus);
            panelBottom.Controls.Add(lblRus);
            panelBottom.Controls.Add(txtMon);
            panelBottom.Controls.Add(lblMon);
            panelBottom.Controls.Add(txtEng);
            panelBottom.Controls.Add(lblEng);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 530);
            panelBottom.Margin = new Padding(3, 4, 3, 4);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1010, 140);
            panelBottom.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9.5F);
            btnSave.Location = new Point(690, 73);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 47);
            btnSave.TabIndex = 10;
            btnSave.Text = "🌿 Санах";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9.5F);
            btnClear.Location = new Point(553, 73);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 47);
            btnClear.TabIndex = 9;
            btnClear.Text = "🔄 Цэвэрлэх";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.5F);
            btnDelete.Location = new Point(416, 73);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 47);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "🗑 Устгах";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9.5F);
            btnUpdate.Location = new Point(279, 73);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 47);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "✏ Засах";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9.5F);
            btnAdd.Location = new Point(142, 73);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 47);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+ Нэмэх";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtRus
            // 
            txtRus.Font = new Font("Segoe UI", 10F);
            txtRus.Location = new Point(712, 19);
            txtRus.Margin = new Padding(3, 4, 3, 4);
            txtRus.Name = "txtRus";
            txtRus.Size = new Size(279, 30);
            txtRus.TabIndex = 5;
            // 
            // lblRus
            // 
            lblRus.AutoSize = true;
            lblRus.Font = new Font("Segoe UI", 10F);
            lblRus.Location = new Point(661, 23);
            lblRus.Name = "lblRus";
            lblRus.Size = new Size(51, 23);
            lblRus.TabIndex = 4;
            lblRus.Text = "Орос";
            // 
            // txtMon
            // 
            txtMon.Font = new Font("Segoe UI", 10F);
            txtMon.Location = new Point(440, 19);
            txtMon.Margin = new Padding(3, 4, 3, 4);
            txtMon.Name = "txtMon";
            txtMon.Size = new Size(199, 30);
            txtMon.TabIndex = 3;
            // 
            // lblMon
            // 
            lblMon.AutoSize = true;
            lblMon.Font = new Font("Segoe UI", 10F);
            lblMon.Location = new Point(368, 23);
            lblMon.Name = "lblMon";
            lblMon.Size = new Size(71, 23);
            lblMon.TabIndex = 2;
            lblMon.Text = "Монгол";
            // 
            // txtEng
            // 
            txtEng.Font = new Font("Segoe UI", 10F);
            txtEng.Location = new Point(74, 19);
            txtEng.Margin = new Padding(3, 4, 3, 4);
            txtEng.Name = "txtEng";
            txtEng.Size = new Size(274, 30);
            txtEng.TabIndex = 1;
            // 
            // lblEng
            // 
            lblEng.AutoSize = true;
            lblEng.Font = new Font("Segoe UI", 10F);
            lblEng.Location = new Point(14, 23);
            lblEng.Name = "lblEng";
            lblEng.Size = new Size(57, 23);
            lblEng.TabIndex = 0;
            lblEng.Text = "Англи";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblCount });
            statusStrip1.Location = new Point(0, 670);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1010, 26);
            statusStrip1.TabIndex = 2;
            // 
            // lblCount
            // 
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(168, 20);
            lblCount.Text = "Нийт: 10 үг · Санасан: 0";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NUmber, Англи, Монгол, Орос });
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 73);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(669, 457);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(669, 73);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(341, 457);
            dataGridView2.TabIndex = 4;
            // 
            // NUmber
            // 
            NUmber.HeaderText = "Number";
            NUmber.MinimumWidth = 6;
            NUmber.Name = "NUmber";
            NUmber.ReadOnly = true;
            // 
            // Англи
            // 
            Англи.HeaderText = "Англи";
            Англи.MinimumWidth = 6;
            Англи.Name = "Англи";
            Англи.ReadOnly = true;
            // 
            // Монгол
            // 
            Монгол.HeaderText = "Монгол";
            Монгол.MinimumWidth = 6;
            Монгол.Name = "Монгол";
            Монгол.ReadOnly = true;
            // 
            // Орос
            // 
            Орос.HeaderText = "Орос";
            Орос.MinimumWidth = 6;
            Орос.Name = "Орос";
            Орос.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 696);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Controls.Add(statusStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Гурван хэлний толь бичиг";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ComboBox cmbLang;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRus;
        private System.Windows.Forms.Label lblRus;
        private System.Windows.Forms.TextBox txtMon;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label lblEng;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn NUmber;
        private DataGridViewTextBoxColumn Англи;
        private DataGridViewTextBoxColumn Монгол;
        private DataGridViewTextBoxColumn Орос;
    }
}