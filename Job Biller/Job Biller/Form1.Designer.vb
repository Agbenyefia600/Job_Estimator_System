<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Job_IDLabel = New System.Windows.Forms.Label()
        Me.FirstnameLabel = New System.Windows.Forms.Label()
        Me.SurnameLabel = New System.Windows.Forms.Label()
        Me.DOBLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.DiscountLabel = New System.Windows.Forms.Label()
        Me.TaxLabel = New System.Windows.Forms.Label()
        Me.SubTotalLabel = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Coppies_PipesLabel = New System.Windows.Forms.Label()
        Me.Chrome_PipeLabel = New System.Windows.Forms.Label()
        Me.Plastic_PipeLabel = New System.Windows.Forms.Label()
        Me.LabourLabel = New System.Windows.Forms.Label()
        Me.TravelLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.table = New System.Windows.Forms.TabPage()
        Me.JobDataGridView = New System.Windows.Forms.DataGridView()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstimatorDataSet = New Job_Biller.EstimatorDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblShowCal = New System.Windows.Forms.TextBox()
        Me.btnCC = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblConvert = New System.Windows.Forms.TextBox()
        Me.cmbCurrency = New System.Windows.Forms.ComboBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtConvert = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.btnEqaul = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReceiptTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkCusDiscount = New System.Windows.Forms.CheckBox()
        Me.Job_IDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TravelTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabourTextBox = New System.Windows.Forms.TextBox()
        Me.Plastic_PipeTextBox = New System.Windows.Forms.TextBox()
        Me.Chrome_PipeTextBox = New System.Windows.Forms.TextBox()
        Me.Coppies_PipesTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.TaxTextBox = New System.Windows.Forms.TextBox()
        Me.JobTableAdapter = New Job_Biller.EstimatorDataSetTableAdapters.JobTableAdapter()
        Me.TableAdapterManager = New Job_Biller.EstimatorDataSetTableAdapters.TableAdapterManager()
        Me.JobBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.JobBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.table.SuspendLayout()
        CType(Me.JobDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimatorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.JobBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JobBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Job_IDLabel
        '
        Me.Job_IDLabel.AutoSize = True
        Me.Job_IDLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Job_IDLabel.Location = New System.Drawing.Point(10, 39)
        Me.Job_IDLabel.Name = "Job_IDLabel"
        Me.Job_IDLabel.Size = New System.Drawing.Size(65, 21)
        Me.Job_IDLabel.TabIndex = 0
        Me.Job_IDLabel.Text = "Job ID:"
        '
        'FirstnameLabel
        '
        Me.FirstnameLabel.AutoSize = True
        Me.FirstnameLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstnameLabel.Location = New System.Drawing.Point(8, 110)
        Me.FirstnameLabel.Name = "FirstnameLabel"
        Me.FirstnameLabel.Size = New System.Drawing.Size(98, 21)
        Me.FirstnameLabel.TabIndex = 2
        Me.FirstnameLabel.Text = "Firstname:"
        '
        'SurnameLabel
        '
        Me.SurnameLabel.AutoSize = True
        Me.SurnameLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurnameLabel.Location = New System.Drawing.Point(6, 166)
        Me.SurnameLabel.Name = "SurnameLabel"
        Me.SurnameLabel.Size = New System.Drawing.Size(87, 21)
        Me.SurnameLabel.TabIndex = 4
        Me.SurnameLabel.Text = "Surname:"
        '
        'DOBLabel
        '
        Me.DOBLabel.AutoSize = True
        Me.DOBLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBLabel.Location = New System.Drawing.Point(10, 219)
        Me.DOBLabel.Name = "DOBLabel"
        Me.DOBLabel.Size = New System.Drawing.Size(53, 21)
        Me.DOBLabel.TabIndex = 6
        Me.DOBLabel.Text = "DOB:"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel.Location = New System.Drawing.Point(6, 267)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(80, 21)
        Me.AddressLabel.TabIndex = 8
        Me.AddressLabel.Text = "Address:"
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneLabel.Location = New System.Drawing.Point(347, 41)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(67, 21)
        Me.PhoneLabel.TabIndex = 10
        Me.PhoneLabel.Text = "Phone:"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel.Location = New System.Drawing.Point(347, 111)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(62, 21)
        Me.EmailLabel.TabIndex = 12
        Me.EmailLabel.Text = "Email:"
        '
        'DiscountLabel
        '
        Me.DiscountLabel.AutoSize = True
        Me.DiscountLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountLabel.Location = New System.Drawing.Point(344, 34)
        Me.DiscountLabel.Name = "DiscountLabel"
        Me.DiscountLabel.Size = New System.Drawing.Size(89, 21)
        Me.DiscountLabel.TabIndex = 14
        Me.DiscountLabel.Text = "Discount:"
        '
        'TaxLabel
        '
        Me.TaxLabel.AutoSize = True
        Me.TaxLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxLabel.Location = New System.Drawing.Point(344, 105)
        Me.TaxLabel.Name = "TaxLabel"
        Me.TaxLabel.Size = New System.Drawing.Size(43, 21)
        Me.TaxLabel.TabIndex = 16
        Me.TaxLabel.Text = "Tax:"
        '
        'SubTotalLabel
        '
        Me.SubTotalLabel.AutoSize = True
        Me.SubTotalLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotalLabel.Location = New System.Drawing.Point(344, 170)
        Me.SubTotalLabel.Name = "SubTotalLabel"
        Me.SubTotalLabel.Size = New System.Drawing.Size(91, 21)
        Me.SubTotalLabel.TabIndex = 18
        Me.SubTotalLabel.Text = "Sub Total:"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(344, 247)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(57, 21)
        Me.TotalLabel.TabIndex = 20
        Me.TotalLabel.Text = "Total:"
        '
        'Coppies_PipesLabel
        '
        Me.Coppies_PipesLabel.AutoSize = True
        Me.Coppies_PipesLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coppies_PipesLabel.Location = New System.Drawing.Point(5, 30)
        Me.Coppies_PipesLabel.Name = "Coppies_PipesLabel"
        Me.Coppies_PipesLabel.Size = New System.Drawing.Size(127, 21)
        Me.Coppies_PipesLabel.TabIndex = 22
        Me.Coppies_PipesLabel.Text = "Coppies Pipes:"
        '
        'Chrome_PipeLabel
        '
        Me.Chrome_PipeLabel.AutoSize = True
        Me.Chrome_PipeLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chrome_PipeLabel.Location = New System.Drawing.Point(4, 102)
        Me.Chrome_PipeLabel.Name = "Chrome_PipeLabel"
        Me.Chrome_PipeLabel.Size = New System.Drawing.Size(119, 21)
        Me.Chrome_PipeLabel.TabIndex = 24
        Me.Chrome_PipeLabel.Text = "Chrome Pipe:"
        '
        'Plastic_PipeLabel
        '
        Me.Plastic_PipeLabel.AutoSize = True
        Me.Plastic_PipeLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plastic_PipeLabel.Location = New System.Drawing.Point(5, 171)
        Me.Plastic_PipeLabel.Name = "Plastic_PipeLabel"
        Me.Plastic_PipeLabel.Size = New System.Drawing.Size(110, 21)
        Me.Plastic_PipeLabel.TabIndex = 26
        Me.Plastic_PipeLabel.Text = "Plastic Pipe:"
        '
        'LabourLabel
        '
        Me.LabourLabel.AutoSize = True
        Me.LabourLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourLabel.Location = New System.Drawing.Point(4, 241)
        Me.LabourLabel.Name = "LabourLabel"
        Me.LabourLabel.Size = New System.Drawing.Size(72, 21)
        Me.LabourLabel.TabIndex = 28
        Me.LabourLabel.Text = "Labour:"
        '
        'TravelLabel
        '
        Me.TravelLabel.AutoSize = True
        Me.TravelLabel.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TravelLabel.Location = New System.Drawing.Point(7, 303)
        Me.TravelLabel.Name = "TravelLabel"
        Me.TravelLabel.Size = New System.Drawing.Size(65, 21)
        Me.TravelLabel.TabIndex = 30
        Me.TravelLabel.Text = "Travel:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.table)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(15, 431)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1271, 301)
        Me.TabControl1.TabIndex = 0
        '
        'table
        '
        Me.table.Controls.Add(Me.JobDataGridView)
        Me.table.Location = New System.Drawing.Point(4, 26)
        Me.table.Name = "table"
        Me.table.Padding = New System.Windows.Forms.Padding(3)
        Me.table.Size = New System.Drawing.Size(1263, 271)
        Me.table.TabIndex = 0
        Me.table.Text = "Table"
        Me.table.UseVisualStyleBackColor = True
        '
        'JobDataGridView
        '
        Me.JobDataGridView.AutoGenerateColumns = False
        Me.JobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JobDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.JobDataGridView.DataSource = Me.JobBindingSource
        Me.JobDataGridView.Location = New System.Drawing.Point(6, 3)
        Me.JobDataGridView.Name = "JobDataGridView"
        Me.JobDataGridView.RowHeadersWidth = 51
        Me.JobDataGridView.RowTemplate.Height = 24
        Me.JobDataGridView.Size = New System.Drawing.Size(1251, 265)
        Me.JobDataGridView.TabIndex = 0
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataMember = "Job"
        Me.JobBindingSource.DataSource = Me.EstimatorDataSet
        '
        'EstimatorDataSet
        '
        Me.EstimatorDataSet.DataSetName = "EstimatorDataSet"
        Me.EstimatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.lblShowCal)
        Me.TabPage2.Controls.Add(Me.btnCC)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.lblConvert)
        Me.TabPage2.Controls.Add(Me.cmbCurrency)
        Me.TabPage2.Controls.Add(Me.btnReset)
        Me.TabPage2.Controls.Add(Me.btnClose)
        Me.TabPage2.Controls.Add(Me.btnConvert)
        Me.TabPage2.Controls.Add(Me.txtConvert)
        Me.TabPage2.Controls.Add(Me.lblDisplay)
        Me.TabPage2.Controls.Add(Me.btnClear)
        Me.TabPage2.Controls.Add(Me.Button11)
        Me.TabPage2.Controls.Add(Me.Button12)
        Me.TabPage2.Controls.Add(Me.Button13)
        Me.TabPage2.Controls.Add(Me.Button14)
        Me.TabPage2.Controls.Add(Me.Button15)
        Me.TabPage2.Controls.Add(Me.Button16)
        Me.TabPage2.Controls.Add(Me.Button17)
        Me.TabPage2.Controls.Add(Me.btnEqaul)
        Me.TabPage2.Controls.Add(Me.Button10)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.btnDot)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.ReceiptTextBox)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1263, 271)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Receipt"
        '
        'lblShowCal
        '
        Me.lblShowCal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblShowCal.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowCal.Location = New System.Drawing.Point(611, 36)
        Me.lblShowCal.Multiline = True
        Me.lblShowCal.Name = "lblShowCal"
        Me.lblShowCal.Size = New System.Drawing.Size(114, 29)
        Me.lblShowCal.TabIndex = 33
        '
        'btnCC
        '
        Me.btnCC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCC.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCC.Location = New System.Drawing.Point(852, 3)
        Me.btnCC.Name = "btnCC"
        Me.btnCC.Size = New System.Drawing.Size(411, 262)
        Me.btnCC.TabIndex = 31
        Me.btnCC.Text = "Currency Converter"
        Me.btnCC.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(968, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 25)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Enter Amount "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(968, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Select a Country"
        '
        'lblConvert
        '
        Me.lblConvert.BackColor = System.Drawing.Color.Silver
        Me.lblConvert.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvert.Location = New System.Drawing.Point(915, 177)
        Me.lblConvert.Multiline = True
        Me.lblConvert.Name = "lblConvert"
        Me.lblConvert.Size = New System.Drawing.Size(289, 33)
        Me.lblConvert.TabIndex = 28
        '
        'cmbCurrency
        '
        Me.cmbCurrency.AllowDrop = True
        Me.cmbCurrency.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCurrency.FormattingEnabled = True
        Me.cmbCurrency.Location = New System.Drawing.Point(926, 36)
        Me.cmbCurrency.Name = "cmbCurrency"
        Me.cmbCurrency.Size = New System.Drawing.Size(262, 39)
        Me.cmbCurrency.TabIndex = 27
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(1005, 214)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(109, 48)
        Me.btnReset.TabIndex = 26
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1134, 213)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(109, 48)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(871, 213)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(109, 48)
        Me.btnConvert.TabIndex = 24
        Me.btnConvert.Text = "Convert "
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtConvert
        '
        Me.txtConvert.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConvert.Location = New System.Drawing.Point(940, 108)
        Me.txtConvert.Multiline = True
        Me.txtConvert.Name = "txtConvert"
        Me.txtConvert.Size = New System.Drawing.Size(248, 41)
        Me.txtConvert.TabIndex = 23
        '
        'lblDisplay
        '
        Me.lblDisplay.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(611, 6)
        Me.lblDisplay.Multiline = True
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(228, 62)
        Me.lblDisplay.TabIndex = 21
        Me.lblDisplay.Text = "0"
        Me.lblDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(731, 71)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(53, 36)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(791, 192)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(49, 33)
        Me.Button11.TabIndex = 19
        Me.Button11.Text = "*"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(731, 192)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(53, 33)
        Me.Button12.TabIndex = 18
        Me.Button12.Text = "3"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(791, 153)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(49, 33)
        Me.Button13.TabIndex = 17
        Me.Button13.Text = "/"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(731, 153)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(53, 31)
        Me.Button14.TabIndex = 16
        Me.Button14.Text = "6"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(790, 118)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(49, 29)
        Me.Button15.TabIndex = 15
        Me.Button15.Text = "-"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(731, 118)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(53, 29)
        Me.Button16.TabIndex = 14
        Me.Button16.Text = "9"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(791, 71)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(49, 36)
        Me.Button17.TabIndex = 13
        Me.Button17.Text = "+"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'btnEqaul
        '
        Me.btnEqaul.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEqaul.Location = New System.Drawing.Point(731, 228)
        Me.btnEqaul.Name = "btnEqaul"
        Me.btnEqaul.Size = New System.Drawing.Size(109, 36)
        Me.btnEqaul.TabIndex = 12
        Me.btnEqaul.Text = "="
        Me.btnEqaul.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(607, 115)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(53, 34)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "7"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(607, 154)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(53, 31)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "4"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(607, 192)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(53, 31)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "1"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(607, 231)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(53, 31)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "0"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(666, 152)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(53, 35)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(666, 192)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 32)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "2"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnDot
        '
        Me.btnDot.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDot.Location = New System.Drawing.Point(662, 232)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(57, 29)
        Me.btnDot.TabIndex = 4
        Me.btnDot.Text = "."
        Me.btnDot.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(662, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 34)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "8"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(608, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "←"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReceiptTextBox
        '
        Me.ReceiptTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Receipt", True))
        Me.ReceiptTextBox.Location = New System.Drawing.Point(25, 11)
        Me.ReceiptTextBox.Multiline = True
        Me.ReceiptTextBox.Name = "ReceiptTextBox"
        Me.ReceiptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ReceiptTextBox.Size = New System.Drawing.Size(509, 254)
        Me.ReceiptTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(955, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 25)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Currency converted"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.chkCusDiscount)
        Me.Panel1.Controls.Add(Me.Job_IDLabel)
        Me.Panel1.Controls.Add(Me.Job_IDTextBox)
        Me.Panel1.Controls.Add(Me.FirstnameLabel)
        Me.Panel1.Controls.Add(Me.FirstnameTextBox)
        Me.Panel1.Controls.Add(Me.SurnameLabel)
        Me.Panel1.Controls.Add(Me.SurnameTextBox)
        Me.Panel1.Controls.Add(Me.DOBLabel)
        Me.Panel1.Controls.Add(Me.DOBDateTimePicker)
        Me.Panel1.Controls.Add(Me.AddressLabel)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Controls.Add(Me.PhoneLabel)
        Me.Panel1.Controls.Add(Me.PhoneTextBox)
        Me.Panel1.Controls.Add(Me.EmailLabel)
        Me.Panel1.Controls.Add(Me.EmailTextBox)
        Me.Panel1.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(11, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 336)
        Me.Panel1.TabIndex = 1
        '
        'chkCusDiscount
        '
        Me.chkCusDiscount.AutoSize = True
        Me.chkCusDiscount.Font = New System.Drawing.Font("Constantia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCusDiscount.Location = New System.Drawing.Point(346, 166)
        Me.chkCusDiscount.Name = "chkCusDiscount"
        Me.chkCusDiscount.Size = New System.Drawing.Size(214, 26)
        Me.chkCusDiscount.TabIndex = 34
        Me.chkCusDiscount.Text = "Customer's  Discount"
        Me.chkCusDiscount.UseVisualStyleBackColor = True
        '
        'Job_IDTextBox
        '
        Me.Job_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Job_ID", True))
        Me.Job_IDTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Job_IDTextBox.Location = New System.Drawing.Point(117, 33)
        Me.Job_IDTextBox.Multiline = True
        Me.Job_IDTextBox.Name = "Job_IDTextBox"
        Me.Job_IDTextBox.Size = New System.Drawing.Size(214, 36)
        Me.Job_IDTextBox.TabIndex = 1
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Firstname", True))
        Me.FirstnameTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(115, 104)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(216, 34)
        Me.FirstnameTextBox.TabIndex = 3
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Surname", True))
        Me.SurnameTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurnameTextBox.Location = New System.Drawing.Point(115, 160)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(216, 34)
        Me.SurnameTextBox.TabIndex = 5
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JobBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(112, 217)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(297, 28)
        Me.DOBDateTimePicker.TabIndex = 7
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(117, 267)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(343, 66)
        Me.AddressTextBox.TabIndex = 9
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox.Location = New System.Drawing.Point(427, 27)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(208, 34)
        Me.PhoneTextBox.TabIndex = 11
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(419, 103)
        Me.EmailTextBox.Multiline = True
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(216, 35)
        Me.EmailTextBox.TabIndex = 13
        '
        'TravelTextBox
        '
        Me.TravelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Travel", True))
        Me.TravelTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TravelTextBox.Location = New System.Drawing.Point(148, 290)
        Me.TravelTextBox.Name = "TravelTextBox"
        Me.TravelTextBox.Size = New System.Drawing.Size(163, 34)
        Me.TravelTextBox.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Coppies_PipesLabel)
        Me.Panel2.Controls.Add(Me.TravelLabel)
        Me.Panel2.Controls.Add(Me.LabourTextBox)
        Me.Panel2.Controls.Add(Me.TravelTextBox)
        Me.Panel2.Controls.Add(Me.LabourLabel)
        Me.Panel2.Controls.Add(Me.Plastic_PipeTextBox)
        Me.Panel2.Controls.Add(Me.Plastic_PipeLabel)
        Me.Panel2.Controls.Add(Me.Chrome_PipeTextBox)
        Me.Panel2.Controls.Add(Me.Chrome_PipeLabel)
        Me.Panel2.Controls.Add(Me.Coppies_PipesTextBox)
        Me.Panel2.Controls.Add(Me.DiscountTextBox)
        Me.Panel2.Controls.Add(Me.TotalTextBox)
        Me.Panel2.Controls.Add(Me.DiscountLabel)
        Me.Panel2.Controls.Add(Me.TotalLabel)
        Me.Panel2.Controls.Add(Me.SubTotalTextBox)
        Me.Panel2.Controls.Add(Me.TaxLabel)
        Me.Panel2.Controls.Add(Me.SubTotalLabel)
        Me.Panel2.Controls.Add(Me.TaxTextBox)
        Me.Panel2.Font = New System.Drawing.Font("Constantia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(685, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(601, 336)
        Me.Panel2.TabIndex = 2
        '
        'LabourTextBox
        '
        Me.LabourTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Labour", True))
        Me.LabourTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourTextBox.Location = New System.Drawing.Point(148, 228)
        Me.LabourTextBox.Name = "LabourTextBox"
        Me.LabourTextBox.Size = New System.Drawing.Size(163, 34)
        Me.LabourTextBox.TabIndex = 29
        '
        'Plastic_PipeTextBox
        '
        Me.Plastic_PipeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Plastic_Pipe", True))
        Me.Plastic_PipeTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plastic_PipeTextBox.Location = New System.Drawing.Point(148, 160)
        Me.Plastic_PipeTextBox.Name = "Plastic_PipeTextBox"
        Me.Plastic_PipeTextBox.Size = New System.Drawing.Size(163, 34)
        Me.Plastic_PipeTextBox.TabIndex = 27
        '
        'Chrome_PipeTextBox
        '
        Me.Chrome_PipeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Chrome_Pipe", True))
        Me.Chrome_PipeTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chrome_PipeTextBox.Location = New System.Drawing.Point(148, 95)
        Me.Chrome_PipeTextBox.Name = "Chrome_PipeTextBox"
        Me.Chrome_PipeTextBox.Size = New System.Drawing.Size(163, 34)
        Me.Chrome_PipeTextBox.TabIndex = 25
        '
        'Coppies_PipesTextBox
        '
        Me.Coppies_PipesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Coppies_Pipes", True))
        Me.Coppies_PipesTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coppies_PipesTextBox.Location = New System.Drawing.Point(148, 24)
        Me.Coppies_PipesTextBox.Name = "Coppies_PipesTextBox"
        Me.Coppies_PipesTextBox.Size = New System.Drawing.Size(163, 34)
        Me.Coppies_PipesTextBox.TabIndex = 23
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Discount", True))
        Me.DiscountTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountTextBox.Location = New System.Drawing.Point(447, 27)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(148, 34)
        Me.DiscountTextBox.TabIndex = 15
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Total", True))
        Me.TotalTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.Location = New System.Drawing.Point(447, 238)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(147, 34)
        Me.TotalTextBox.TabIndex = 21
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "SubTotal", True))
        Me.SubTotalTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotalTextBox.Location = New System.Drawing.Point(447, 161)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.Size = New System.Drawing.Size(148, 34)
        Me.SubTotalTextBox.TabIndex = 19
        '
        'TaxTextBox
        '
        Me.TaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Tax", True))
        Me.TaxTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxTextBox.Location = New System.Drawing.Point(447, 97)
        Me.TaxTextBox.Name = "TaxTextBox"
        Me.TaxTextBox.Size = New System.Drawing.Size(148, 34)
        Me.TaxTextBox.TabIndex = 17
        '
        'JobTableAdapter
        '
        Me.JobTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.JobTableAdapter = Me.JobTableAdapter
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Job_Biller.EstimatorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'JobBindingNavigator
        '
        Me.JobBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.JobBindingNavigator.BindingSource = Me.JobBindingSource
        Me.JobBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.JobBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.JobBindingNavigator.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.JobBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.JobBindingNavigatorSaveItem})
        Me.JobBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.JobBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.JobBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.JobBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.JobBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.JobBindingNavigator.Name = "JobBindingNavigator"
        Me.JobBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.JobBindingNavigator.Size = New System.Drawing.Size(1306, 31)
        Me.JobBindingNavigator.TabIndex = 3
        Me.JobBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.BackColor = System.Drawing.Color.Lime
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(91, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.BackColor = System.Drawing.Color.Red
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(71, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.BackColor = System.Drawing.Color.MediumPurple
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(101, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(143, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.BackColor = System.Drawing.Color.DarkOrange
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(103, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BindingNavigatorMoveLastItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveLastItem.MergeIndex = 1
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(98, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'JobBindingNavigatorSaveItem
        '
        Me.JobBindingNavigatorSaveItem.BackColor = System.Drawing.Color.Blue
        Me.JobBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.JobBindingNavigatorSaveItem.Name = "JobBindingNavigatorSaveItem"
        Me.JobBindingNavigatorSaveItem.Size = New System.Drawing.Size(104, 28)
        Me.JobBindingNavigatorSaveItem.Text = "Save Data"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Black
        Me.lblDate.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(18, 46)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(60, 25)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Black
        Me.lblTime.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(1197, 46)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(62, 25)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "Time"
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnReceipt)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnTotal)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 738)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1271, 85)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1051, 13)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(196, 66)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnReceipt.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.Location = New System.Drawing.Point(514, 7)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(196, 66)
        Me.btnReceipt.TabIndex = 2
        Me.btnReceipt.Text = "Receipt"
        Me.btnReceipt.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.FlatAppearance.BorderSize = 2
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(263, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(196, 66)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.FlatAppearance.BorderSize = 2
        Me.btnTotal.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(12, 8)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(196, 66)
        Me.btnTotal.TabIndex = 0
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Job_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Job_ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Firstname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Firstname"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Discount"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Discount"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Tax"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Tax"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SubTotal"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SubTotal"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Coppies_Pipes"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Coppies_Pipes"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Chrome_Pipe"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Chrome_Pipe"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Plastic_Pipe"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Plastic_Pipe"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Labour"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Labour"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Travel"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Travel"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'Form1
        '
        Me.AcceptButton = Me.btnTotal
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Job_Biller.My.Resources.Resources.download
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1306, 835)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.JobBindingNavigator)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Job Estimator"
        Me.TabControl1.ResumeLayout(False)
        Me.table.ResumeLayout(False)
        CType(Me.JobDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimatorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.JobBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JobBindingNavigator.ResumeLayout(False)
        Me.JobBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents EstimatorDataSet As EstimatorDataSet
    Friend WithEvents JobBindingSource As BindingSource
    Friend WithEvents JobTableAdapter As EstimatorDataSetTableAdapters.JobTableAdapter
    Friend WithEvents TableAdapterManager As EstimatorDataSetTableAdapters.TableAdapterManager
    Friend WithEvents JobBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents JobBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Job_IDTextBox As TextBox
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents DOBDateTimePicker As DateTimePicker
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents TaxTextBox As TextBox
    Friend WithEvents SubTotalTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents Coppies_PipesTextBox As TextBox
    Friend WithEvents Chrome_PipeTextBox As TextBox
    Friend WithEvents Plastic_PipeTextBox As TextBox
    Friend WithEvents LabourTextBox As TextBox
    Friend WithEvents TravelTextBox As TextBox
    Friend WithEvents table As TabPage
    Friend WithEvents JobDataGridView As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnReceipt As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkCusDiscount As CheckBox
    Friend WithEvents ReceiptTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents btnEqaul As Button
    Friend WithEvents lblDisplay As TextBox
    Friend WithEvents txtConvert As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCC As Button
    Friend WithEvents lblConvert As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblShowCal As TextBox
    Friend WithEvents Job_IDLabel As Label
    Friend WithEvents FirstnameLabel As Label
    Friend WithEvents SurnameLabel As Label
    Friend WithEvents DOBLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents DiscountLabel As Label
    Friend WithEvents TaxLabel As Label
    Friend WithEvents SubTotalLabel As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Coppies_PipesLabel As Label
    Friend WithEvents Chrome_PipeLabel As Label
    Friend WithEvents Plastic_PipeLabel As Label
    Friend WithEvents LabourLabel As Label
    Friend WithEvents TravelLabel As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
End Class
