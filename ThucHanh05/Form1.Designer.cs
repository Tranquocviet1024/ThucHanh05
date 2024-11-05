using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ThucHanh05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCustomers = new DataGridView();
            dgvServices = new DataGridView();
            lbInvoiceServices = new ListBox();
            btnThemkhachhang = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThemdichvu = new Button();
            btnLuu = new Button();
            panel1 = new Panel();
            txtId = new TextBox();
            txtDiachi = new TextBox();
            txtSdt = new TextBox();
            txtTen = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnThanhtoan = new Button();
            txtPrice = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(2, 20);
            dgvCustomers.Margin = new Padding(3, 2, 3, 2);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(473, 146);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // dgvServices
            // 
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.ImeMode = ImeMode.NoControl;
            dgvServices.Location = new Point(5, 20);
            dgvServices.Margin = new Padding(3, 2, 3, 2);
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.RowHeadersWidth = 51;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServices.Size = new Size(376, 90);
            dgvServices.TabIndex = 1;
            dgvServices.CellContentClick += dgvServices_CellContentClick;
            // 
            // lbInvoiceServices
            // 
            lbInvoiceServices.FormattingEnabled = true;
            lbInvoiceServices.ItemHeight = 15;
            lbInvoiceServices.Location = new Point(13, 20);
            lbInvoiceServices.Margin = new Padding(3, 2, 3, 2);
            lbInvoiceServices.Name = "lbInvoiceServices";
            lbInvoiceServices.Size = new Size(144, 124);
            lbInvoiceServices.TabIndex = 2;
            lbInvoiceServices.SelectedIndexChanged += lbInvoiceServices_SelectedIndexChanged;
            // 
            // btnThemkhachhang
            // 
            btnThemkhachhang.Location = new Point(525, 162);
            btnThemkhachhang.Margin = new Padding(3, 2, 3, 2);
            btnThemkhachhang.Name = "btnThemkhachhang";
            btnThemkhachhang.Size = new Size(82, 22);
            btnThemkhachhang.TabIndex = 3;
            btnThemkhachhang.Text = "Thêm";
            btnThemkhachhang.UseVisualStyleBackColor = true;
            btnThemkhachhang.Click += btnAddCustomer_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(613, 162);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 22);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnEditCustomer_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(720, 162);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 22);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnDeleteCustomer_Click;
            // 
            // btnThemdichvu
            // 
            btnThemdichvu.Location = new Point(153, 336);
            btnThemdichvu.Margin = new Padding(3, 2, 3, 2);
            btnThemdichvu.Name = "btnThemdichvu";
            btnThemdichvu.Size = new Size(82, 22);
            btnThemdichvu.TabIndex = 6;
            btnThemdichvu.Text = "Thêm";
            btnThemdichvu.UseVisualStyleBackColor = true;
            btnThemdichvu.Click += btnAddToInvoice_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(233, 88);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(82, 22);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtDiachi);
            panel1.Controls.Add(txtSdt);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(525, 31);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 127);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // txtId
            // 
            txtId.Location = new Point(110, 11);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(93, 23);
            txtId.TabIndex = 7;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(110, 92);
            txtDiachi.Margin = new Padding(3, 2, 3, 2);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(210, 23);
            txtDiachi.TabIndex = 6;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(110, 67);
            txtSdt.Margin = new Padding(3, 2, 3, 2);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(210, 23);
            txtSdt.TabIndex = 5;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(110, 36);
            txtTen.Margin = new Padding(3, 2, 3, 2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(210, 23);
            txtTen.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 92);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 69);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 41);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 13);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvCustomers);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThemkhachhang);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1009, 193);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvServices);
            groupBox2.Location = new Point(10, 214);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(387, 114);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin dịch vụ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnThanhtoan);
            groupBox3.Controls.Add(txtPrice);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(lbInvoiceServices);
            groupBox3.Controls.Add(btnLuu);
            groupBox3.Location = new Point(421, 214);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(456, 161);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa đơn";
            // 
            // btnThanhtoan
            // 
            btnThanhtoan.Location = new Point(321, 88);
            btnThanhtoan.Margin = new Padding(3, 2, 3, 2);
            btnThanhtoan.Name = "btnThanhtoan";
            btnThanhtoan.Size = new Size(82, 22);
            btnThanhtoan.TabIndex = 13;
            btnThanhtoan.Text = "Thanh toán";
            btnThanhtoan.UseVisualStyleBackColor = true;
            btnThanhtoan.Click += btnThanhtoan_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(251, 51);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(140, 23);
            txtPrice.TabIndex = 4;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(294, 20);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 3;
            label5.Text = "Tổng tiền:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 386);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnThemdichvu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCustomers;
        private DataGridView dgvServices;
        private ListBox lbInvoiceServices;
        private Button btnThemkhachhang;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThemdichvu;
        private Button btnLuu;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn txtName;
        private DataGridViewTextBoxColumn txtPhone;
        private DataGridViewTextBoxColumn txtAddress;
        private Panel panel1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTen;
        private TextBox txtDiachi;
        private TextBox txtSdt;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private TextBox txtPrice;
        private Button btnThanhtoan;
        private TextBox txtId;
    }
}
