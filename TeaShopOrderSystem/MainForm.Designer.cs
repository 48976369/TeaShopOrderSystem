namespace TeaShopOrderSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.grpOrderInput = new System.Windows.Forms.GroupBox();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnRemoveCartItem = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.clbToppings = new System.Windows.Forms.CheckedListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.cmbIce = new System.Windows.Forms.ComboBox();
            this.lblIce = new System.Windows.Forms.Label();
            this.cmbSugar = new System.Windows.Forms.ComboBox();
            this.lblSugar = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.cmbDrink = new System.Windows.Forms.ComboBox();
            this.lblDrink = new System.Windows.Forms.Label();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.grpMenuInput = new System.Windows.Forms.GroupBox();
            this.btnSaveMenu = new System.Windows.Forms.Button();
            this.btnDeleteDrink = new System.Windows.Forms.Button();
            this.btnUpdateDrink = new System.Windows.Forms.Button();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtDrinkName = new System.Windows.Forms.TextBox();
            this.lblDrinkName = new System.Windows.Forms.Label();
            this.txtDrinkId = new System.Windows.Forms.TextBox();
            this.lblDrinkId = new System.Windows.Forms.Label();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblTodayRevenue = new System.Windows.Forms.Label();
            this.lblTodayOrderCount = new System.Windows.Forms.Label();
            this.btnShowAllOrders = new System.Windows.Forms.Button();
            this.btnSearchByKeyword = new System.Windows.Forms.Button();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.lblSearchKeyword = new System.Windows.Forms.Label();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.grpOrderInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.tabMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.grpMenuInput.SuspendLayout();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabOrder);
            this.tabMain.Controls.Add(this.tabMenu);
            this.tabMain.Controls.Add(this.tabHistory);
            this.tabMain.Location = new System.Drawing.Point(20, 20);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(940, 580);
            this.tabMain.TabIndex = 0;
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.btnFinishOrder);
            this.tabOrder.Controls.Add(this.lblTotal);
            this.tabOrder.Controls.Add(this.dgvCart);
            this.tabOrder.Controls.Add(this.grpOrderInput);
            this.tabOrder.Location = new System.Drawing.Point(4, 22);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(932, 554);
            this.tabOrder.TabIndex = 0;
            this.tabOrder.Text = "點餐";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnFinishOrder.Location = new System.Drawing.Point(760, 435);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(140, 40);
            this.btnFinishOrder.TabIndex = 3;
            this.btnFinishOrder.Text = "完成訂單";
            this.btnFinishOrder.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("新細明體", 14F);
            this.lblTotal.Location = new System.Drawing.Point(370, 440);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(250, 30);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "目前總金額：$0";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(370, 30);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(530, 390);
            this.dgvCart.TabIndex = 1;
            // 
            // grpOrderInput
            // 
            this.grpOrderInput.Controls.Add(this.btnClearCart);
            this.grpOrderInput.Controls.Add(this.btnRemoveCartItem);
            this.grpOrderInput.Controls.Add(this.btnAddToCart);
            this.grpOrderInput.Controls.Add(this.nudQuantity);
            this.grpOrderInput.Controls.Add(this.clbToppings);
            this.grpOrderInput.Controls.Add(this.lblQuantity);
            this.grpOrderInput.Controls.Add(this.lblToppings);
            this.grpOrderInput.Controls.Add(this.cmbIce);
            this.grpOrderInput.Controls.Add(this.lblIce);
            this.grpOrderInput.Controls.Add(this.cmbSugar);
            this.grpOrderInput.Controls.Add(this.lblSugar);
            this.grpOrderInput.Controls.Add(this.cmbSize);
            this.grpOrderInput.Controls.Add(this.lblSize);
            this.grpOrderInput.Controls.Add(this.cmbDrink);
            this.grpOrderInput.Controls.Add(this.lblDrink);
            this.grpOrderInput.Location = new System.Drawing.Point(20, 20);
            this.grpOrderInput.Name = "grpOrderInput";
            this.grpOrderInput.Size = new System.Drawing.Size(330, 360);
            this.grpOrderInput.TabIndex = 0;
            this.grpOrderInput.TabStop = false;
            this.grpOrderInput.Text = "飲料選擇區";
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(215, 325);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(90, 30);
            this.btnClearCart.TabIndex = 15;
            this.btnClearCart.Text = "清空購物車";
            this.btnClearCart.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCartItem
            // 
            this.btnRemoveCartItem.Location = new System.Drawing.Point(125, 325);
            this.btnRemoveCartItem.Name = "btnRemoveCartItem";
            this.btnRemoveCartItem.Size = new System.Drawing.Size(80, 30);
            this.btnRemoveCartItem.TabIndex = 14;
            this.btnRemoveCartItem.Text = "刪除選取";
            this.btnRemoveCartItem.UseVisualStyleBackColor = true;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(25, 325);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(90, 30);
            this.btnAddToCart.TabIndex = 13;
            this.btnAddToCart.Text = "加入購物車";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(95, 288);
            this.nudQuantity.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(80, 22);
            this.nudQuantity.TabIndex = 12;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // clbToppings
            // 
            this.clbToppings.FormattingEnabled = true;
            this.clbToppings.Location = new System.Drawing.Point(95, 192);
            this.clbToppings.Name = "clbToppings";
            this.clbToppings.Size = new System.Drawing.Size(180, 72);
            this.clbToppings.TabIndex = 11;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(25, 290);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(41, 12);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "數量：";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(25, 195);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(41, 12);
            this.lblToppings.TabIndex = 8;
            this.lblToppings.Text = "加料：";
            // 
            // cmbIce
            // 
            this.cmbIce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIce.FormattingEnabled = true;
            this.cmbIce.Location = new System.Drawing.Point(95, 152);
            this.cmbIce.Name = "cmbIce";
            this.cmbIce.Size = new System.Drawing.Size(180, 20);
            this.cmbIce.TabIndex = 7;
            // 
            // lblIce
            // 
            this.lblIce.AutoSize = true;
            this.lblIce.Location = new System.Drawing.Point(25, 155);
            this.lblIce.Name = "lblIce";
            this.lblIce.Size = new System.Drawing.Size(41, 12);
            this.lblIce.TabIndex = 6;
            this.lblIce.Text = "冰塊：";
            // 
            // cmbSugar
            // 
            this.cmbSugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSugar.FormattingEnabled = true;
            this.cmbSugar.Location = new System.Drawing.Point(95, 112);
            this.cmbSugar.Name = "cmbSugar";
            this.cmbSugar.Size = new System.Drawing.Size(180, 20);
            this.cmbSugar.TabIndex = 5;
            // 
            // lblSugar
            // 
            this.lblSugar.AutoSize = true;
            this.lblSugar.Location = new System.Drawing.Point(25, 115);
            this.lblSugar.Name = "lblSugar";
            this.lblSugar.Size = new System.Drawing.Size(41, 12);
            this.lblSugar.TabIndex = 4;
            this.lblSugar.Text = "甜度：";
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(95, 72);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(180, 20);
            this.cmbSize.TabIndex = 3;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(25, 75);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(41, 12);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "尺寸：";
            // 
            // cmbDrink
            // 
            this.cmbDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.Location = new System.Drawing.Point(95, 32);
            this.cmbDrink.Name = "cmbDrink";
            this.cmbDrink.Size = new System.Drawing.Size(180, 20);
            this.cmbDrink.TabIndex = 1;
            // 
            // lblDrink
            // 
            this.lblDrink.AutoSize = true;
            this.lblDrink.Location = new System.Drawing.Point(25, 35);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(41, 12);
            this.lblDrink.TabIndex = 0;
            this.lblDrink.Text = "飲料：";
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.dgvMenu);
            this.tabMenu.Controls.Add(this.grpMenuInput);
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(932, 554);
            this.tabMenu.TabIndex = 1;
            this.tabMenu.Text = "菜單管理";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(370, 30);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(530, 450);
            this.dgvMenu.TabIndex = 1;
            // 
            // grpMenuInput
            // 
            this.grpMenuInput.Controls.Add(this.btnSaveMenu);
            this.grpMenuInput.Controls.Add(this.btnDeleteDrink);
            this.grpMenuInput.Controls.Add(this.btnUpdateDrink);
            this.grpMenuInput.Controls.Add(this.btnAddDrink);
            this.grpMenuInput.Controls.Add(this.cmbCategory);
            this.grpMenuInput.Controls.Add(this.chkAvailable);
            this.grpMenuInput.Controls.Add(this.txtBasePrice);
            this.grpMenuInput.Controls.Add(this.lblBasePrice);
            this.grpMenuInput.Controls.Add(this.lblCategory);
            this.grpMenuInput.Controls.Add(this.txtDrinkName);
            this.grpMenuInput.Controls.Add(this.lblDrinkName);
            this.grpMenuInput.Controls.Add(this.txtDrinkId);
            this.grpMenuInput.Controls.Add(this.lblDrinkId);
            this.grpMenuInput.Location = new System.Drawing.Point(20, 20);
            this.grpMenuInput.Name = "grpMenuInput";
            this.grpMenuInput.Size = new System.Drawing.Size(330, 330);
            this.grpMenuInput.TabIndex = 0;
            this.grpMenuInput.TabStop = false;
            this.grpMenuInput.Text = "飲料資料輸入區";
            // 
            // btnSaveMenu
            // 
            this.btnSaveMenu.Location = new System.Drawing.Point(25, 275);
            this.btnSaveMenu.Name = "btnSaveMenu";
            this.btnSaveMenu.Size = new System.Drawing.Size(290, 35);
            this.btnSaveMenu.TabIndex = 13;
            this.btnSaveMenu.Text = "儲存菜單";
            this.btnSaveMenu.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDrink
            // 
            this.btnDeleteDrink.Location = new System.Drawing.Point(225, 235);
            this.btnDeleteDrink.Name = "btnDeleteDrink";
            this.btnDeleteDrink.Size = new System.Drawing.Size(90, 30);
            this.btnDeleteDrink.TabIndex = 12;
            this.btnDeleteDrink.Text = "刪除飲料";
            this.btnDeleteDrink.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDrink
            // 
            this.btnUpdateDrink.Location = new System.Drawing.Point(125, 235);
            this.btnUpdateDrink.Name = "btnUpdateDrink";
            this.btnUpdateDrink.Size = new System.Drawing.Size(90, 30);
            this.btnUpdateDrink.TabIndex = 11;
            this.btnUpdateDrink.Text = "修改飲料";
            this.btnUpdateDrink.UseVisualStyleBackColor = true;
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Location = new System.Drawing.Point(25, 235);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(90, 30);
            this.btnAddDrink.TabIndex = 10;
            this.btnAddDrink.Text = "新增飲料";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(110, 112);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(170, 20);
            this.cmbCategory.TabIndex = 9;
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Location = new System.Drawing.Point(110, 192);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(72, 16);
            this.chkAvailable.TabIndex = 8;
            this.chkAvailable.Text = "是否上架";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(110, 152);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(170, 22);
            this.txtBasePrice.TabIndex = 7;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(25, 155);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(65, 12);
            this.lblBasePrice.TabIndex = 5;
            this.lblBasePrice.Text = "基本價格：";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(25, 115);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(41, 12);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "分類：";
            // 
            // txtDrinkName
            // 
            this.txtDrinkName.Location = new System.Drawing.Point(110, 72);
            this.txtDrinkName.Name = "txtDrinkName";
            this.txtDrinkName.Size = new System.Drawing.Size(170, 22);
            this.txtDrinkName.TabIndex = 3;
            // 
            // lblDrinkName
            // 
            this.lblDrinkName.AutoSize = true;
            this.lblDrinkName.Location = new System.Drawing.Point(25, 75);
            this.lblDrinkName.Name = "lblDrinkName";
            this.lblDrinkName.Size = new System.Drawing.Size(65, 12);
            this.lblDrinkName.TabIndex = 2;
            this.lblDrinkName.Text = "飲料名稱：";
            // 
            // txtDrinkId
            // 
            this.txtDrinkId.Location = new System.Drawing.Point(110, 32);
            this.txtDrinkId.Name = "txtDrinkId";
            this.txtDrinkId.Size = new System.Drawing.Size(170, 22);
            this.txtDrinkId.TabIndex = 1;
            // 
            // lblDrinkId
            // 
            this.lblDrinkId.AutoSize = true;
            this.lblDrinkId.Location = new System.Drawing.Point(25, 35);
            this.lblDrinkId.Name = "lblDrinkId";
            this.lblDrinkId.Size = new System.Drawing.Size(65, 12);
            this.lblDrinkId.TabIndex = 0;
            this.lblDrinkId.Text = "飲料編號：";
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.dgvOrders);
            this.tabHistory.Controls.Add(this.grpSearch);
            this.tabHistory.Location = new System.Drawing.Point(4, 22);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Size = new System.Drawing.Size(932, 554);
            this.tabHistory.TabIndex = 2;
            this.tabHistory.Text = "歷史訂單";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(20, 170);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(880, 330);
            this.dgvOrders.TabIndex = 1;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblTodayRevenue);
            this.grpSearch.Controls.Add(this.lblTodayOrderCount);
            this.grpSearch.Controls.Add(this.btnShowAllOrders);
            this.grpSearch.Controls.Add(this.btnSearchByKeyword);
            this.grpSearch.Controls.Add(this.txtSearchKeyword);
            this.grpSearch.Controls.Add(this.lblSearchKeyword);
            this.grpSearch.Controls.Add(this.btnSearchByDate);
            this.grpSearch.Controls.Add(this.dtpSearchDate);
            this.grpSearch.Controls.Add(this.lblSearchDate);
            this.grpSearch.Location = new System.Drawing.Point(20, 20);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(880, 130);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "查詢區";
            // 
            // lblTodayRevenue
            // 
            this.lblTodayRevenue.Location = new System.Drawing.Point(25, 85);
            this.lblTodayRevenue.Name = "lblTodayRevenue";
            this.lblTodayRevenue.Size = new System.Drawing.Size(180, 25);
            this.lblTodayRevenue.TabIndex = 8;
            this.lblTodayRevenue.Text = "今日營業額：$0";
            // 
            // lblTodayOrderCount
            // 
            this.lblTodayOrderCount.Location = new System.Drawing.Point(230, 85);
            this.lblTodayOrderCount.Name = "lblTodayOrderCount";
            this.lblTodayOrderCount.Size = new System.Drawing.Size(220, 25);
            this.lblTodayOrderCount.TabIndex = 7;
            this.lblTodayOrderCount.Text = "今日訂單數：0";
            // 
            // btnShowAllOrders
            // 
            this.btnShowAllOrders.Location = new System.Drawing.Point(760, 28);
            this.btnShowAllOrders.Name = "btnShowAllOrders";
            this.btnShowAllOrders.Size = new System.Drawing.Size(90, 30);
            this.btnShowAllOrders.TabIndex = 6;
            this.btnShowAllOrders.Text = "顯示全部";
            this.btnShowAllOrders.UseVisualStyleBackColor = true;
            // 
            // btnSearchByKeyword
            // 
            this.btnSearchByKeyword.Location = new System.Drawing.Point(640, 28);
            this.btnSearchByKeyword.Name = "btnSearchByKeyword";
            this.btnSearchByKeyword.Size = new System.Drawing.Size(100, 30);
            this.btnSearchByKeyword.TabIndex = 5;
            this.btnSearchByKeyword.Text = "關鍵字查詢";
            this.btnSearchByKeyword.UseVisualStyleBackColor = true;
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Location = new System.Drawing.Point(460, 30);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(160, 22);
            this.txtSearchKeyword.TabIndex = 4;
            // 
            // lblSearchKeyword
            // 
            this.lblSearchKeyword.AutoSize = true;
            this.lblSearchKeyword.Location = new System.Drawing.Point(390, 35);
            this.lblSearchKeyword.Name = "lblSearchKeyword";
            this.lblSearchKeyword.Size = new System.Drawing.Size(53, 12);
            this.lblSearchKeyword.TabIndex = 3;
            this.lblSearchKeyword.Text = "關鍵字：";
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Location = new System.Drawing.Point(260, 28);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(100, 30);
            this.btnSearchByDate.TabIndex = 2;
            this.btnSearchByDate.Text = "依日期查詢";
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Location = new System.Drawing.Point(80, 30);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(160, 22);
            this.dtpSearchDate.TabIndex = 1;
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.Location = new System.Drawing.Point(25, 35);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(41, 12);
            this.lblSearchDate.TabIndex = 0;
            this.lblSearchDate.Text = "日期：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.tabMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "飲料店點餐管理系統";
            this.tabMain.ResumeLayout(false);
            this.tabOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.grpOrderInput.ResumeLayout(false);
            this.grpOrderInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.tabMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.grpMenuInput.ResumeLayout(false);
            this.grpMenuInput.PerformLayout();
            this.tabHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.GroupBox grpOrderInput;
        private System.Windows.Forms.CheckedListBox clbToppings;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.ComboBox cmbIce;
        private System.Windows.Forms.Label lblIce;
        private System.Windows.Forms.ComboBox cmbSugar;
        private System.Windows.Forms.Label lblSugar;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cmbDrink;
        private System.Windows.Forms.Label lblDrink;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnRemoveCartItem;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.GroupBox grpMenuInput;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtDrinkName;
        private System.Windows.Forms.Label lblDrinkName;
        private System.Windows.Forms.TextBox txtDrinkId;
        private System.Windows.Forms.Label lblDrinkId;
        private System.Windows.Forms.Button btnSaveMenu;
        private System.Windows.Forms.Button btnDeleteDrink;
        private System.Windows.Forms.Button btnUpdateDrink;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblTodayRevenue;
        private System.Windows.Forms.Label lblTodayOrderCount;
        private System.Windows.Forms.Button btnShowAllOrders;
        private System.Windows.Forms.Button btnSearchByKeyword;
        private System.Windows.Forms.TextBox txtSearchKeyword;
        private System.Windows.Forms.Label lblSearchKeyword;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.Label lblSearchDate;
    }
}

