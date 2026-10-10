namespace B5._2_LISTBOX___COMBOBOX_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // ===== CONTROL DECLARATIONS =====
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ListBox lstAvailableServices;
        private System.Windows.Forms.ListBox lstSelectedServices;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPayable;
        private System.Windows.Forms.GroupBox grpLeft;
        private System.Windows.Forms.GroupBox grpMiddle;
        private System.Windows.Forms.GroupBox grpRight;
        private System.Windows.Forms.GroupBox grpBottom;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblPayable;
        private System.Windows.Forms.Label lblHint;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ===== LEFT GROUP =====
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.grpLeft.Text = "Danh mục dịch vụ";
            this.grpLeft.Location = new System.Drawing.Point(15, 15);
            this.grpLeft.Size = new System.Drawing.Size(400, 560);
            this.grpLeft.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpLeft);

            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCategory.Text = "Loại dịch vụ:";
            this.lblCategory.Location = new System.Drawing.Point(15, 35);
            this.lblCategory.AutoSize = true;
            this.grpLeft.Controls.Add(this.lblCategory);

            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboCategory.Location = new System.Drawing.Point(120, 32);
            this.cboCategory.Size = new System.Drawing.Size(260, 30);
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpLeft.Controls.Add(this.cboCategory);

            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblAvailable.Text = "Dịch vụ khả dụng (double-click để thêm):";
            this.lblAvailable.Location = new System.Drawing.Point(15, 80);
            this.lblAvailable.AutoSize = true;
            this.grpLeft.Controls.Add(this.lblAvailable);

            this.lstAvailableServices = new System.Windows.Forms.ListBox();
            this.lstAvailableServices.Location = new System.Drawing.Point(15, 105);
            this.lstAvailableServices.Size = new System.Drawing.Size(370, 420);
            this.lstAvailableServices.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstAvailableServices.IntegralHeight = false;
            this.lstAvailableServices.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.grpLeft.Controls.Add(this.lstAvailableServices);

            // ===== MIDDLE GROUP (BUTTONS) =====
            this.grpMiddle = new System.Windows.Forms.GroupBox();
            this.grpMiddle.Text = "Thao tác";
            this.grpMiddle.Location = new System.Drawing.Point(425, 200);
            this.grpMiddle.Size = new System.Drawing.Size(100, 180);
            this.grpMiddle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpMiddle);

            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSelect.Text = ">";
            this.btnSelect.Location = new System.Drawing.Point(20, 20);
            this.btnSelect.Size = new System.Drawing.Size(60, 40);
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnSelect.BackColor = System.Drawing.Color.LightGreen;
            this.grpMiddle.Controls.Add(this.btnSelect);

            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemove.Text = "<";
            this.btnRemove.Location = new System.Drawing.Point(20, 75);
            this.btnRemove.Size = new System.Drawing.Size(60, 40);
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnRemove.BackColor = System.Drawing.Color.LightCoral;
            this.grpMiddle.Controls.Add(this.btnRemove);

            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearAll.Text = "<<";
            this.btnClearAll.Location = new System.Drawing.Point(20, 130);
            this.btnClearAll.Size = new System.Drawing.Size(60, 40);
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnClearAll.BackColor = System.Drawing.Color.LightYellow;
            this.grpMiddle.Controls.Add(this.btnClearAll);

            // ===== RIGHT GROUP (SELECTED) =====
            this.grpRight = new System.Windows.Forms.GroupBox();
            this.grpRight.Text = "Dịch vụ đã chọn";
            this.grpRight.Location = new System.Drawing.Point(540, 15);
            this.grpRight.Size = new System.Drawing.Size(420, 330);
            this.grpRight.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpRight);

            this.lblSelected = new System.Windows.Forms.Label();
            this.lblSelected.Text = "Danh sách đã chọn:";
            this.lblSelected.Location = new System.Drawing.Point(15, 25);
            this.lblSelected.AutoSize = true;
            this.grpRight.Controls.Add(this.lblSelected);

            this.lstSelectedServices = new System.Windows.Forms.ListBox();
            this.lstSelectedServices.Location = new System.Drawing.Point(15, 55);
            this.lstSelectedServices.Size = new System.Drawing.Size(390, 260);
            this.lstSelectedServices.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSelectedServices.IntegralHeight = false;
            this.lstSelectedServices.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.grpRight.Controls.Add(this.lstSelectedServices);

            // ===== BOTTOM GROUP (PAYMENT) =====
            this.grpBottom = new System.Windows.Forms.GroupBox();
            this.grpBottom.Text = "Thanh toán";
            this.grpBottom.Location = new System.Drawing.Point(540, 360);
            this.grpBottom.Size = new System.Drawing.Size(420, 215);
            this.grpBottom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.grpBottom);

            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotal.Text = "Tổng tiền:";
            this.lblTotal.Location = new System.Drawing.Point(20, 30);
            this.lblTotal.AutoSize = true;
            this.grpBottom.Controls.Add(this.lblTotal);

            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotal.Location = new System.Drawing.Point(170, 27);
            this.txtTotal.Size = new System.Drawing.Size(220, 30);
            this.txtTotal.ReadOnly = true;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.txtTotal.ForeColor = System.Drawing.Color.DarkBlue;
            this.grpBottom.Controls.Add(this.txtTotal);

            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscount.Text = "Chiết khấu (%):";
            this.lblDiscount.Location = new System.Drawing.Point(20, 75);
            this.lblDiscount.AutoSize = true;
            this.grpBottom.Controls.Add(this.lblDiscount);

            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.nudDiscount.Location = new System.Drawing.Point(170, 72);
            this.nudDiscount.Size = new System.Drawing.Size(100, 30);
            this.nudDiscount.Minimum = 0;
            this.nudDiscount.Maximum = 100;
            this.nudDiscount.Value = 0;
            this.nudDiscount.DecimalPlaces = 0;
            this.nudDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.grpBottom.Controls.Add(this.nudDiscount);

            this.lblPayable = new System.Windows.Forms.Label();
            this.lblPayable.Text = "Thành tiền:";
            this.lblPayable.Location = new System.Drawing.Point(20, 125);
            this.lblPayable.AutoSize = true;
            this.lblPayable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpBottom.Controls.Add(this.lblPayable);

            this.txtPayable = new System.Windows.Forms.TextBox();
            this.txtPayable.Location = new System.Drawing.Point(170, 120);
            this.txtPayable.Size = new System.Drawing.Size(220, 40);
            this.txtPayable.ReadOnly = true;
            this.txtPayable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayable.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.txtPayable.ForeColor = System.Drawing.Color.DarkRed;
            this.txtPayable.BackColor = System.Drawing.Color.FromArgb(255, 245, 245);
            this.grpBottom.Controls.Add(this.txtPayable);

            this.lblHint = new System.Windows.Forms.Label();
            this.lblHint.Text = "💡 Mẹo: Double-click dịch vụ để thêm nhanh";
            this.lblHint.Location = new System.Drawing.Point(20, 175);
            this.lblHint.AutoSize = true;
            this.lblHint.ForeColor = System.Drawing.Color.DimGray;
            this.grpBottom.Controls.Add(this.lblHint);

            // ===== FORM =====
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 620);
            this.Text = "Bảng tính tiền dịch vụ - Bài 5.2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
        }
    }
}
