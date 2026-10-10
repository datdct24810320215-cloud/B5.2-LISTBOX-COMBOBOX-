#nullable disable
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace B5._2_LISTBOX___COMBOBOX_
{
    public partial class Form1 : Form
    {
        private class Service
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public override string ToString() => $"{Name} — {Price:N0} VNĐ";
        }

        private readonly Dictionary<string, List<Service>> _catalog = new()
        {
            ["Khám bệnh"] = new List<Service>
            {
                new Service { Name = "Khám tổng quát", Price = 150000m },
                new Service { Name = "Khám chuyên khoa", Price = 200000m }
            },
            ["Xét nghiệm"] = new List<Service>
            {
                new Service { Name = "Xét nghiệm máu", Price = 120000m },
                new Service { Name = "Xét nghiệm nước tiểu", Price = 80000m }
            },
            ["Chụp X-Quang"] = new List<Service>
            {
                new Service { Name = "X-Quang ngực", Price = 250000m },
                new Service { Name = "X-Quang cột sống", Price = 300000m }
            },
            ["Vắc-xin"] = new List<Service>
            {
                new Service { Name = "Vaccine A", Price = 350000m },
                new Service { Name = "Vaccine B", Price = 400000m }
            }
        };

        public Form1()
        {
            InitializeComponent();

            // Wire events immediately after InitializeComponent
            this.Load += Form1_Load;
            cboCategory.SelectedIndexChanged += CboCategory_SelectedIndexChanged;
            btnSelect.Click += BtnSelect_Click;
            btnRemove.Click += BtnRemove_Click;
            btnClearAll.Click += BtnClearAll_Click;
            lstAvailableServices.DoubleClick += LstAvailableServices_DoubleClick;
            nudDiscount.ValueChanged += NudDiscount_ValueChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCategory.Items.Clear();
            foreach (var key in _catalog.Keys)
                cboCategory.Items.Add(key);

            if (cboCategory.Items.Count > 0)
                cboCategory.SelectedIndex = 0; // triggers SelectedIndexChanged
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();
            if (cboCategory.SelectedItem is string cat && _catalog.TryGetValue(cat, out var list))
            {
                foreach (var s in list)
                    lstAvailableServices.Items.Add(s);
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
            => MoveSelected(lstAvailableServices, lstSelectedServices, true);

        private void BtnRemove_Click(object sender, EventArgs e)
            => MoveSelected(lstSelectedServices, lstAvailableServices, true);

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.Items.Count == 0) return;
            if (MessageBox.Show("Xóa tất cả dịch vụ đã chọn?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            lstSelectedServices.Items.Clear();
            UpdateTotals();
        }

        private void LstAvailableServices_DoubleClick(object sender, EventArgs e)
            => MoveSelected(lstAvailableServices, lstSelectedServices, true);

        private void NudDiscount_ValueChanged(object sender, EventArgs e)
            => UpdateTotals();

        private void MoveSelected(ListBox from, ListBox to, bool removeFromSource)
        {
            var items = from.SelectedItems.Cast<object>().ToArray();
            if (items.Length == 0) return;

            foreach (var it in items)
            {
                if (!to.Items.Cast<object>().Any(x => x.ToString() == it.ToString()))
                    to.Items.Add(it);
            }

            if (removeFromSource)
                foreach (var it in items) from.Items.Remove(it);

            UpdateTotals();
        }

        private void UpdateTotals()
        {
            decimal total = 0m;
            foreach (var item in lstSelectedServices.Items)
                if (item is Service s) total += s.Price;

            txtTotal.Text = total.ToString("N0") + " VNĐ";

            decimal discountPercent = nudDiscount.Value;
            decimal payable = total * (1 - discountPercent / 100m);
            if (payable < 0) payable = 0;
            txtPayable.Text = payable.ToString("N0") + " VNĐ";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
    }
}
