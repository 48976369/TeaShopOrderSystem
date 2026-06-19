using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaShopOrderSystem.Models;
using TeaShopOrderSystem.Services;

namespace TeaShopOrderSystem
{
    public partial class MainForm : Form
    {
        private List<Drink> drinks = new List<Drink>();
        private List<OrderItem> cartItems = new List<OrderItem>();
        private BindingSource cartSource = new BindingSource();
        private BindingSource menuSource = new BindingSource();
        private List<OrderRecord> orderRecords = new List<OrderRecord>();
        private BindingSource orderSource = new BindingSource();
        public MainForm()
        {
            InitializeComponent();

            SetupCartGrid();

            InitializeComboBoxes();
            LoadDrinkData();
            BindOrderButtons();
            RefreshCart();
            SetupMenuGrid();
            BindMenuButtons();
            SetupOrderGrid();
            LoadOrderData();
            BindHistoryButtons();
        }
        private void InitializeComboBoxes()
        {
            cmbSize.Items.Clear();
            cmbSize.Items.Add("中杯");
            cmbSize.Items.Add("大杯");
            cmbSize.SelectedIndex = 0;

            cmbSugar.Items.Clear();
            cmbSugar.Items.Add("正常糖");
            cmbSugar.Items.Add("少糖");
            cmbSugar.Items.Add("半糖");
            cmbSugar.Items.Add("微糖");
            cmbSugar.Items.Add("無糖");
            cmbSugar.SelectedIndex = 0;

            cmbIce.Items.Clear();
            cmbIce.Items.Add("正常冰");
            cmbIce.Items.Add("少冰");
            cmbIce.Items.Add("微冰");
            cmbIce.Items.Add("去冰");
            cmbIce.Items.Add("熱");
            cmbIce.SelectedIndex = 0;

            clbToppings.Items.Clear();
            clbToppings.Items.Add("珍珠");
            clbToppings.Items.Add("椰果");
            clbToppings.Items.Add("布丁");
            clbToppings.Items.Add("仙草");

            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("茶類");
            cmbCategory.Items.Add("奶茶類");
            cmbCategory.Items.Add("果茶類");
            cmbCategory.Items.Add("其他");
            cmbCategory.SelectedIndex = 0;

            cmbDrink.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSugar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIce.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadDrinkData()
        {
            drinks = FileService.LoadDrinks();

            RefreshDrinkComboBox();
            RefreshMenuGrid();
        }
        private void RefreshDrinkComboBox()
        {
            cmbDrink.Items.Clear();

            foreach (Drink drink in drinks)
            {
                if (drink.Available)
                {
                    cmbDrink.Items.Add(drink.Name);
                }
            }

            if (cmbDrink.Items.Count > 0)
            {
                cmbDrink.SelectedIndex = 0;
            }
        }

        private void RefreshMenuGrid()
        {
            menuSource.DataSource = null;
            menuSource.DataSource = drinks;

            SetMenuColumnHeaders();

            dgvMenu.ClearSelection();
        }

        private void SetMenuColumnHeaders()
        {
            if (dgvMenu.Columns.Contains("Id"))
                dgvMenu.Columns["Id"].HeaderText = "飲料編號";

            if (dgvMenu.Columns.Contains("Name"))
                dgvMenu.Columns["Name"].HeaderText = "飲料名稱";

            if (dgvMenu.Columns.Contains("Category"))
                dgvMenu.Columns["Category"].HeaderText = "分類";

            if (dgvMenu.Columns.Contains("BasePrice"))
                dgvMenu.Columns["BasePrice"].HeaderText = "基本價格";

            if (dgvMenu.Columns.Contains("Available"))
                dgvMenu.Columns["Available"].HeaderText = "是否上架";
        }
        private void BindMenuButtons()
        {
            btnAddDrink.Click += BtnAddDrink_Click;
            btnUpdateDrink.Click += BtnUpdateDrink_Click;
            btnDeleteDrink.Click += BtnDeleteDrink_Click;
            btnSaveMenu.Click += BtnSaveMenu_Click;
            dgvMenu.CellClick += DgvMenu_CellClick;
        }
        private void BtnAddDrink_Click(object sender, EventArgs e)
        {
            string id = txtDrinkId.Text.Trim();
            string name = txtDrinkName.Text.Trim();
            string category = cmbCategory.Text.Trim();
            string priceText = txtBasePrice.Text.Trim();
            bool available = chkAvailable.Checked;

            if (id == "" || name == "" || category == "" || priceText == "")
            {
                MessageBox.Show("請完整輸入飲料資料");
                return;
            }

            int price = 0;

            if (!int.TryParse(priceText, out price))
            {
                MessageBox.Show("基本價格請輸入數字");
                return;
            }

            if (price < 0)
            {
                MessageBox.Show("基本價格不能小於 0");
                return;
            }

            foreach (Drink drink in drinks)
            {
                if (drink.Id == id)
                {
                    MessageBox.Show("飲料編號已經存在，請換一個編號");
                    return;
                }

                if (drink.Name == name)
                {
                    MessageBox.Show("飲料名稱已經存在，請換一個名稱");
                    return;
                }
            }

            Drink newDrink = new Drink(id, name, category, price, available);

            drinks.Add(newDrink);

            RefreshMenuGrid();
            RefreshDrinkComboBox();
            ClearDrinkInput();

            MessageBox.Show("新增飲料成功");
        }
        private void BtnUpdateDrink_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count == 0)
            {
                MessageBox.Show("請先選擇要修改的飲料");
                return;
            }

            Drink selectedDrink = dgvMenu.SelectedRows[0].DataBoundItem as Drink;

            if (selectedDrink == null)
            {
                MessageBox.Show("選取的資料不正確");
                return;
            }

            string id = txtDrinkId.Text.Trim();
            string name = txtDrinkName.Text.Trim();
            string category = cmbCategory.Text.Trim();
            string priceText = txtBasePrice.Text.Trim();
            bool available = chkAvailable.Checked;

            if (id == "" || name == "" || category == "" || priceText == "")
            {
                MessageBox.Show("請完整輸入飲料資料");
                return;
            }

            int price = 0;

            if (!int.TryParse(priceText, out price))
            {
                MessageBox.Show("基本價格請輸入數字");
                return;
            }

            if (price < 0)
            {
                MessageBox.Show("基本價格不能小於 0");
                return;
            }

            foreach (Drink drink in drinks)
            {
                if (drink != selectedDrink && drink.Id == id)
                {
                    MessageBox.Show("飲料編號已經被其他飲料使用");
                    return;
                }

                if (drink != selectedDrink && drink.Name == name)
                {
                    MessageBox.Show("飲料名稱已經被其他飲料使用");
                    return;
                }
            }

            selectedDrink.Id = id;
            selectedDrink.Name = name;
            selectedDrink.Category = category;
            selectedDrink.BasePrice = price;
            selectedDrink.Available = available;

            RefreshMenuGrid();
            RefreshDrinkComboBox();
            ClearDrinkInput();

            MessageBox.Show("修改飲料成功");
        }
        private void BtnDeleteDrink_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count == 0)
            {
                MessageBox.Show("請先選擇要刪除的飲料");
                return;
            }

            Drink selectedDrink = dgvMenu.SelectedRows[0].DataBoundItem as Drink;

            if (selectedDrink == null)
            {
                MessageBox.Show("選取的資料不正確");
                return;
            }

            DialogResult result = MessageBox.Show(
                "確定要刪除「" + selectedDrink.Name + "」嗎？",
                "確認刪除",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            drinks.Remove(selectedDrink);

            RefreshMenuGrid();
            RefreshDrinkComboBox();
            ClearDrinkInput();

            MessageBox.Show("刪除飲料成功");
        }
        private void BtnSaveMenu_Click(object sender, EventArgs e)
        {
            FileService.SaveDrinks(drinks);

            RefreshMenuGrid();
            RefreshDrinkComboBox();

            MessageBox.Show("菜單已儲存到 drinks.csv");
        }
        private void DgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvMenu.SelectedRows.Count == 0)
            {
                return;
            }

            Drink selectedDrink = dgvMenu.SelectedRows[0].DataBoundItem as Drink;

            if (selectedDrink == null)
            {
                return;
            }

            txtDrinkId.Text = selectedDrink.Id;
            txtDrinkName.Text = selectedDrink.Name;
            cmbCategory.Text = selectedDrink.Category;
            txtBasePrice.Text = selectedDrink.BasePrice.ToString();
            chkAvailable.Checked = selectedDrink.Available;
        }
        private void ClearDrinkInput()
        {
            txtDrinkId.Clear();
            txtDrinkName.Clear();
            txtBasePrice.Clear();

            if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0;
            }

            chkAvailable.Checked = true;
        }
        private void BindOrderButtons()
        {
            btnAddToCart.Click += BtnAddToCart_Click;
            btnRemoveCartItem.Click += BtnRemoveCartItem_Click;
            btnClearCart.Click += BtnClearCart_Click;
            btnFinishOrder.Click += BtnFinishOrder_Click;
        }
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (cmbDrink.SelectedItem == null)
            {
                MessageBox.Show("請先選擇飲料");
                return;
            }

            Drink selectedDrink = GetSelectedDrink();

            if (selectedDrink == null)
            {
                MessageBox.Show("找不到飲料資料");
                return;
            }

            string drinkName = selectedDrink.Name;
            string size = cmbSize.Text;
            string sugar = cmbSugar.Text;
            string ice = cmbIce.Text;
            string toppings = GetSelectedToppings();
            int quantity = Convert.ToInt32(nudQuantity.Value);
            int unitPrice = CalculateUnitPrice(selectedDrink);

            OrderItem item = new OrderItem(
                drinkName,
                size,
                sugar,
                ice,
                toppings,
                quantity,
                unitPrice
            );

            cartItems.Add(item);

            RefreshCart();
            LoadOrderData();
        }
        private void BtnRemoveCartItem_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("購物車目前是空的");
                return;
            }

            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("請先選擇要刪除的項目");
                return;
            }

            OrderItem selectedItem = dgvCart.SelectedRows[0].DataBoundItem as OrderItem;

            if (selectedItem == null)
            {
                MessageBox.Show("選取的資料不正確，請重新選擇");
                return;
            }

            cartItems.Remove(selectedItem);
            RefreshCart();
        }
        private void BtnClearCart_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("購物車目前是空的");
                return;
            }

            DialogResult result = MessageBox.Show(
                "確定要清空購物車嗎？",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                cartItems.Clear();
                RefreshCart();
            }
        }
        private Drink GetSelectedDrink()
        {
            string selectedName = cmbDrink.Text;

            foreach (Drink drink in drinks)
            {
                if (drink.Name == selectedName)
                {
                    return drink;
                }
            }

            return null;
        }

        private string GetSelectedToppings()
        {
            List<string> toppings = new List<string>();

            foreach (object item in clbToppings.CheckedItems)
            {
                toppings.Add(item.ToString());
            }

            if (toppings.Count == 0)
            {
                return "無";
            }

            return string.Join("、", toppings);
        }

        private int CalculateUnitPrice(Drink drink)
        {
            int price = drink.BasePrice;

            if (cmbSize.Text == "大杯")
            {
                price += 10;
            }

            foreach (object item in clbToppings.CheckedItems)
            {
                string topping = item.ToString();

                if (topping == "布丁")
                {
                    price += 15;
                }
                else
                {
                    price += 10;
                }
            }

            return price;
        }

        private void RefreshCart()
        {
            cartSource.ResetBindings(false);

            SetCartColumnHeaders();

            dgvCart.ClearSelection();

            UpdateTotal();
        }

        private void SetCartColumnHeaders()
        {
            if (dgvCart.Columns.Contains("DrinkName"))
                dgvCart.Columns["DrinkName"].HeaderText = "飲料";

            if (dgvCart.Columns.Contains("Size"))
                dgvCart.Columns["Size"].HeaderText = "尺寸";

            if (dgvCart.Columns.Contains("Sugar"))
                dgvCart.Columns["Sugar"].HeaderText = "甜度";

            if (dgvCart.Columns.Contains("Ice"))
                dgvCart.Columns["Ice"].HeaderText = "冰塊";

            if (dgvCart.Columns.Contains("Toppings"))
                dgvCart.Columns["Toppings"].HeaderText = "加料";

            if (dgvCart.Columns.Contains("Quantity"))
                dgvCart.Columns["Quantity"].HeaderText = "數量";

            if (dgvCart.Columns.Contains("UnitPrice"))
                dgvCart.Columns["UnitPrice"].HeaderText = "單價";

            if (dgvCart.Columns.Contains("Subtotal"))
                dgvCart.Columns["Subtotal"].HeaderText = "小計";
        }

        private void UpdateTotal()
        {
            int total = GetCartTotal();

            lblTotal.Text = "目前總金額：$" + total;
        }
        private int GetCartTotal()
        {
            int total = 0;

            foreach (OrderItem item in cartItems)
            {
                total += item.Subtotal;
            }

            return total;
        }
        private void SetupCartGrid()
        {
            dgvCart.ReadOnly = true;
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.MultiSelect = false;
            dgvCart.AutoGenerateColumns = true;

            cartSource.DataSource = cartItems;
            dgvCart.DataSource = cartSource;
        }
        private void BtnFinishOrder_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("購物車是空的，請先加入飲料");
                return;
            }

            DialogResult result = MessageBox.Show(
                "確定要完成訂單嗎？",
                "確認訂單",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            string orderId = GenerateOrderId();
            DateTime orderTime = DateTime.Now;
            int total = GetCartTotal();

            List<OrderRecord> records = new List<OrderRecord>();

            foreach (OrderItem item in cartItems)
            {
                OrderRecord record = new OrderRecord(
                    orderId,
                    orderTime,
                    item.DrinkName,
                    item.Size,
                    item.Sugar,
                    item.Ice,
                    item.Toppings,
                    item.Quantity,
                    item.Subtotal,
                    total
                );

                records.Add(record);
            }

            FileService.SaveOrderRecords(records);

            MessageBox.Show(
                "訂單完成！\n訂單編號：" + orderId + "\n總金額：$" + total,
                "完成",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            cartItems.Clear();
            RefreshCart();

        }
        private string GenerateOrderId()
        {
            return "O" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
        private void SetupMenuGrid()
        {
            dgvMenu.ReadOnly = true;
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.AllowUserToDeleteRows = false;
            dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenu.MultiSelect = false;
            dgvMenu.AutoGenerateColumns = true;

            menuSource.DataSource = drinks;
            dgvMenu.DataSource = menuSource;
        }
        private void SetupOrderGrid()
        {
            dgvOrders.ReadOnly = true;
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.MultiSelect = false;
            dgvOrders.AutoGenerateColumns = true;

            orderSource.DataSource = orderRecords;
            dgvOrders.DataSource = orderSource;
        }
        private void LoadOrderData()
        {
            orderRecords = FileService.LoadOrderRecords();

            RefreshOrderGrid(orderRecords);
            UpdateTodayStatistics();
        }
        private void RefreshOrderGrid(List<OrderRecord> records)
        {
            orderSource.DataSource = null;
            orderSource.DataSource = records;

            SetOrderColumnHeaders();

            dgvOrders.ClearSelection();
        }
        private void SetOrderColumnHeaders()
        {
            if (dgvOrders.Columns.Contains("OrderId"))
                dgvOrders.Columns["OrderId"].HeaderText = "訂單編號";

            if (dgvOrders.Columns.Contains("OrderTime"))
                dgvOrders.Columns["OrderTime"].HeaderText = "訂單時間";

            if (dgvOrders.Columns.Contains("DrinkName"))
                dgvOrders.Columns["DrinkName"].HeaderText = "飲料";

            if (dgvOrders.Columns.Contains("Size"))
                dgvOrders.Columns["Size"].HeaderText = "尺寸";

            if (dgvOrders.Columns.Contains("Sugar"))
                dgvOrders.Columns["Sugar"].HeaderText = "甜度";

            if (dgvOrders.Columns.Contains("Ice"))
                dgvOrders.Columns["Ice"].HeaderText = "冰塊";

            if (dgvOrders.Columns.Contains("Toppings"))
                dgvOrders.Columns["Toppings"].HeaderText = "加料";

            if (dgvOrders.Columns.Contains("Quantity"))
                dgvOrders.Columns["Quantity"].HeaderText = "數量";

            if (dgvOrders.Columns.Contains("Subtotal"))
                dgvOrders.Columns["Subtotal"].HeaderText = "小計";

            if (dgvOrders.Columns.Contains("Total"))
                dgvOrders.Columns["Total"].HeaderText = "訂單總額";
        }
        private void BindHistoryButtons()
        {
            btnSearchByDate.Click += BtnSearchByDate_Click;
            btnSearchByKeyword.Click += BtnSearchByKeyword_Click;
            btnShowAllOrders.Click += BtnShowAllOrders_Click;
        }
        private void BtnShowAllOrders_Click(object sender, EventArgs e)
        {
            LoadOrderData();
            RefreshOrderGrid(orderRecords);
        }
        private void BtnSearchByDate_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpSearchDate.Value.Date;

            List<OrderRecord> result = new List<OrderRecord>();

            foreach (OrderRecord record in orderRecords)
            {
                if (record.OrderTime.Date == selectedDate)
                {
                    result.Add(record);
                }
            }

            RefreshOrderGrid(result);

            if (result.Count == 0)
            {
                MessageBox.Show("查無此日期的訂單");
            }
        }
        private void BtnSearchByKeyword_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchKeyword.Text.Trim();

            if (keyword == "")
            {
                MessageBox.Show("請輸入關鍵字");
                return;
            }

            List<OrderRecord> result = new List<OrderRecord>();

            foreach (OrderRecord record in orderRecords)
            {
                bool matchOrderId = record.OrderId.Contains(keyword);
                bool matchDrinkName = record.DrinkName.Contains(keyword);
                bool matchSugar = record.Sugar.Contains(keyword);
                bool matchIce = record.Ice.Contains(keyword);
                bool matchToppings = record.Toppings.Contains(keyword);

                if (matchOrderId || matchDrinkName || matchSugar || matchIce || matchToppings)
                {
                    result.Add(record);
                }
            }

            RefreshOrderGrid(result);

            if (result.Count == 0)
            {
                MessageBox.Show("查無符合關鍵字的訂單");
            }
        }
        private void UpdateTodayStatistics()
        {
            DateTime today = DateTime.Today;

            int todayRevenue = 0;
            List<string> todayOrderIds = new List<string>();

            foreach (OrderRecord record in orderRecords)
            {
                if (record.OrderTime.Date == today)
                {
                    if (!todayOrderIds.Contains(record.OrderId))
                    {
                        todayOrderIds.Add(record.OrderId);
                        todayRevenue += record.Total;
                    }
                }
            }

            lblTodayOrderCount.Text = "今日訂單數：" + todayOrderIds.Count;
            lblTodayRevenue.Text = "今日營業額：$" + todayRevenue;
        }
    }
}
