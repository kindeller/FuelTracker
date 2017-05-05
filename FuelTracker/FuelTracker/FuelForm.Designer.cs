namespace FuelTracker
{
    partial class FuelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuelForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabVehicles = new System.Windows.Forms.TabPage();
            this.vehicleDataGrid = new System.Windows.Forms.DataGridView();
            this.VehicleIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelEconomyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceTravelledColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowDetailsButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabNewRentals = new System.Windows.Forms.TabPage();
            this.comboRentalVehicleID = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textRentalReg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddVehicleRental = new System.Windows.Forms.Button();
            this.textRentalModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textRentalManufacturer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnRentVehicle = new System.Windows.Forms.Button();
            this.comboCustomerID = new System.Windows.Forms.ComboBox();
            this.tabAllRentals = new System.Windows.Forms.TabPage();
            this.dataGridViewRented = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.tabVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGrid)).BeginInit();
            this.tabNewRentals.SuspendLayout();
            this.tabAllRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRented)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVehicleToolStripMenuItem,
            this.vehicleToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.addToolStripMenuItem.Text = "New...";
            // 
            // newVehicleToolStripMenuItem
            // 
            this.newVehicleToolStripMenuItem.Name = "newVehicleToolStripMenuItem";
            this.newVehicleToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newVehicleToolStripMenuItem.Text = "Manufacturer";
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2});
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.addToolStripMenuItem2.Text = "Add...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCustomers);
            this.tabControl1.Controls.Add(this.tabVehicles);
            this.tabControl1.Controls.Add(this.tabNewRentals);
            this.tabControl1.Controls.Add(this.tabAllRentals);
            this.tabControl1.Location = new System.Drawing.Point(12, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1115, 469);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.customerDataGrid);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(1017, 443);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.Text = "All Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.AllowUserToDeleteRows = false;
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.customerName,
            this.address,
            this.licenceNumber,
            this.dataGridViewButtonColumn1});
            this.customerDataGrid.Location = new System.Drawing.Point(3, 6);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.Size = new System.Drawing.Size(1011, 303);
            this.customerDataGrid.TabIndex = 13;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Full Name";
            this.customerName.Name = "customerName";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // licenceNumber
            // 
            this.licenceNumber.HeaderText = "Licence Number";
            this.licenceNumber.Name = "licenceNumber";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Show Details";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabVehicles
            // 
            this.tabVehicles.Controls.Add(this.vehicleDataGrid);
            this.tabVehicles.Location = new System.Drawing.Point(4, 22);
            this.tabVehicles.Name = "tabVehicles";
            this.tabVehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicles.Size = new System.Drawing.Size(1017, 443);
            this.tabVehicles.TabIndex = 1;
            this.tabVehicles.Text = "All Vehicles";
            this.tabVehicles.UseVisualStyleBackColor = true;
            // 
            // vehicleDataGrid
            // 
            this.vehicleDataGrid.AllowUserToDeleteRows = false;
            this.vehicleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleIDColumn,
            this.ManufacturerColumn,
            this.ModelColumn,
            this.YearColumn,
            this.RegistrationColumn,
            this.FuelEconomyColumn,
            this.DistanceTravelledColumn,
            this.ServicesColumn,
            this.ShowDetailsButton});
            this.vehicleDataGrid.Location = new System.Drawing.Point(3, 6);
            this.vehicleDataGrid.Name = "vehicleDataGrid";
            this.vehicleDataGrid.Size = new System.Drawing.Size(1011, 303);
            this.vehicleDataGrid.TabIndex = 13;
            // 
            // VehicleIDColumn
            // 
            this.VehicleIDColumn.HeaderText = "VehicleID";
            this.VehicleIDColumn.Name = "VehicleIDColumn";
            // 
            // ManufacturerColumn
            // 
            this.ManufacturerColumn.HeaderText = "Manufacturer";
            this.ManufacturerColumn.Name = "ManufacturerColumn";
            this.ManufacturerColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ModelColumn
            // 
            this.ModelColumn.HeaderText = "Model";
            this.ModelColumn.Name = "ModelColumn";
            this.ModelColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // YearColumn
            // 
            this.YearColumn.HeaderText = "Year";
            this.YearColumn.Name = "YearColumn";
            // 
            // RegistrationColumn
            // 
            this.RegistrationColumn.HeaderText = "Registration";
            this.RegistrationColumn.Name = "RegistrationColumn";
            // 
            // FuelEconomyColumn
            // 
            this.FuelEconomyColumn.HeaderText = "Fuel Economy";
            this.FuelEconomyColumn.Name = "FuelEconomyColumn";
            // 
            // DistanceTravelledColumn
            // 
            this.DistanceTravelledColumn.HeaderText = "Distance Travelled";
            this.DistanceTravelledColumn.Name = "DistanceTravelledColumn";
            // 
            // ServicesColumn
            // 
            this.ServicesColumn.HeaderText = "Services Completed";
            this.ServicesColumn.Name = "ServicesColumn";
            // 
            // ShowDetailsButton
            // 
            this.ShowDetailsButton.HeaderText = "Show Details";
            this.ShowDetailsButton.Name = "ShowDetailsButton";
            this.ShowDetailsButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowDetailsButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabNewRentals
            // 
            this.tabNewRentals.Controls.Add(this.comboCustomerID);
            this.tabNewRentals.Controls.Add(this.btnRentVehicle);
            this.tabNewRentals.Controls.Add(this.monthCalendar1);
            this.tabNewRentals.Controls.Add(this.comboRentalVehicleID);
            this.tabNewRentals.Controls.Add(this.textBox7);
            this.tabNewRentals.Controls.Add(this.label8);
            this.tabNewRentals.Controls.Add(this.textRentalReg);
            this.tabNewRentals.Controls.Add(this.label7);
            this.tabNewRentals.Controls.Add(this.label3);
            this.tabNewRentals.Controls.Add(this.btnAddVehicleRental);
            this.tabNewRentals.Controls.Add(this.textRentalModel);
            this.tabNewRentals.Controls.Add(this.label6);
            this.tabNewRentals.Controls.Add(this.textRentalManufacturer);
            this.tabNewRentals.Controls.Add(this.label5);
            this.tabNewRentals.Controls.Add(this.label4);
            this.tabNewRentals.Controls.Add(this.label2);
            this.tabNewRentals.Controls.Add(this.label1);
            this.tabNewRentals.Location = new System.Drawing.Point(4, 22);
            this.tabNewRentals.Name = "tabNewRentals";
            this.tabNewRentals.Size = new System.Drawing.Size(1107, 443);
            this.tabNewRentals.TabIndex = 2;
            this.tabNewRentals.Text = "Add Rental";
            this.tabNewRentals.UseVisualStyleBackColor = true;
            // 
            // comboRentalVehicleID
            // 
            this.comboRentalVehicleID.FormattingEnabled = true;
            this.comboRentalVehicleID.Location = new System.Drawing.Point(308, 40);
            this.comboRentalVehicleID.Name = "comboRentalVehicleID";
            this.comboRentalVehicleID.Size = new System.Drawing.Size(227, 21);
            this.comboRentalVehicleID.TabIndex = 19;
            this.comboRentalVehicleID.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(100, 70);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Customer Name:";
            // 
            // textRentalReg
            // 
            this.textRentalReg.Enabled = false;
            this.textRentalReg.Location = new System.Drawing.Point(308, 119);
            this.textRentalReg.Name = "textRentalReg";
            this.textRentalReg.Size = new System.Drawing.Size(227, 20);
            this.textRentalReg.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Registration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rent Until:";
            // 
            // btnAddVehicleRental
            // 
            this.btnAddVehicleRental.Enabled = false;
            this.btnAddVehicleRental.Location = new System.Drawing.Point(541, 40);
            this.btnAddVehicleRental.Name = "btnAddVehicleRental";
            this.btnAddVehicleRental.Size = new System.Drawing.Size(35, 23);
            this.btnAddVehicleRental.TabIndex = 12;
            this.btnAddVehicleRental.Text = "Find";
            this.btnAddVehicleRental.UseVisualStyleBackColor = true;
            // 
            // textRentalModel
            // 
            this.textRentalModel.Enabled = false;
            this.textRentalModel.Location = new System.Drawing.Point(308, 93);
            this.textRentalModel.Name = "textRentalModel";
            this.textRentalModel.Size = new System.Drawing.Size(227, 20);
            this.textRentalModel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Model:";
            // 
            // textRentalManufacturer
            // 
            this.textRentalManufacturer.Enabled = false;
            this.textRentalManufacturer.Location = new System.Drawing.Point(308, 67);
            this.textRentalManufacturer.Name = "textRentalManufacturer";
            this.textRentalManufacturer.Size = new System.Drawing.Size(227, 20);
            this.textRentalManufacturer.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Manufacturer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vehicle ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rental Information";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(308, 148);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            // 
            // btnRentVehicle
            // 
            this.btnRentVehicle.Location = new System.Drawing.Point(369, 322);
            this.btnRentVehicle.Name = "btnRentVehicle";
            this.btnRentVehicle.Size = new System.Drawing.Size(102, 23);
            this.btnRentVehicle.TabIndex = 21;
            this.btnRentVehicle.Text = "Rent Vehicle";
            this.btnRentVehicle.UseVisualStyleBackColor = true;
            this.btnRentVehicle.Click += new System.EventHandler(this.btnRentVehicle_Click);
            // 
            // comboCustomerID
            // 
            this.comboCustomerID.FormattingEnabled = true;
            this.comboCustomerID.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.comboCustomerID.Location = new System.Drawing.Point(100, 40);
            this.comboCustomerID.Name = "comboCustomerID";
            this.comboCustomerID.Size = new System.Drawing.Size(100, 21);
            this.comboCustomerID.TabIndex = 22;
            // 
            // tabAllRentals
            // 
            this.tabAllRentals.Controls.Add(this.dataGridViewRented);
            this.tabAllRentals.Location = new System.Drawing.Point(4, 22);
            this.tabAllRentals.Name = "tabAllRentals";
            this.tabAllRentals.Size = new System.Drawing.Size(1107, 443);
            this.tabAllRentals.TabIndex = 3;
            this.tabAllRentals.Text = "Rentals";
            this.tabAllRentals.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRented
            // 
            this.dataGridViewRented.AllowUserToDeleteRows = false;
            this.dataGridViewRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRented.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.RentalCustomerName,
            this.dataGridViewButtonColumn2});
            this.dataGridViewRented.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewRented.Name = "dataGridViewRented";
            this.dataGridViewRented.Size = new System.Drawing.Size(1066, 303);
            this.dataGridViewRented.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "VehicleID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Year";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Registration";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Fuel Economy";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Distance Travelled";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Services Completed";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // RentalCustomerName
            // 
            this.RentalCustomerName.HeaderText = "Customer Name";
            this.RentalCustomerName.Name = "RentalCustomerName";
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Show Details";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FuelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 577);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FuelForm";
            this.Text = "Vehicle Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.tabVehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGrid)).EndInit();
            this.tabNewRentals.ResumeLayout(false);
            this.tabNewRentals.PerformLayout();
            this.tabAllRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRented)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.TabPage tabVehicles;
        private System.Windows.Forms.DataGridView vehicleDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelEconomyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceTravelledColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicesColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ShowDetailsButton;
        private System.Windows.Forms.TabPage tabNewRentals;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textRentalReg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddVehicleRental;
        private System.Windows.Forms.TextBox textRentalModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRentalManufacturer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenceNumber;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.ComboBox comboRentalVehicleID;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnRentVehicle;
        private System.Windows.Forms.ComboBox comboCustomerID;
        private System.Windows.Forms.TabPage tabAllRentals;
        private System.Windows.Forms.DataGridView dataGridViewRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalCustomerName;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}

