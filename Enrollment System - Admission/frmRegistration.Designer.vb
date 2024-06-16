<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistration))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApplicantID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtLastName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtFirstName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtMI = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtAddress = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtBarangay = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtCity = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtContact = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtAge = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtBirthdate = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtGuardianName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtGuardianCN = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BunifuCustomLabel17 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbTranscriptRec = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel16 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbBirthCert = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbMedCert = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel14 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbGoodMoral = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbPicture = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1069, 23)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(1046, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1069, 67)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Applicant Registration"
        '
        'txtApplicantID
        '
        Me.txtApplicantID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApplicantID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtApplicantID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtApplicantID.HintForeColor = System.Drawing.Color.Empty
        Me.txtApplicantID.HintText = ""
        Me.txtApplicantID.isPassword = False
        Me.txtApplicantID.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtApplicantID.LineIdleColor = System.Drawing.Color.Black
        Me.txtApplicantID.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtApplicantID.LineThickness = 3
        Me.txtApplicantID.Location = New System.Drawing.Point(7, 24)
        Me.txtApplicantID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApplicantID.Name = "txtApplicantID"
        Me.txtApplicantID.Size = New System.Drawing.Size(159, 43)
        Me.txtApplicantID.TabIndex = 4
        Me.txtApplicantID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(6, 71)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(96, 20)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "Applicant ID"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(173, 71)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(86, 20)
        Me.BunifuCustomLabel2.TabIndex = 7
        Me.BunifuCustomLabel2.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLastName.HintForeColor = System.Drawing.Color.Empty
        Me.txtLastName.HintText = ""
        Me.txtLastName.isPassword = False
        Me.txtLastName.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtLastName.LineIdleColor = System.Drawing.Color.Black
        Me.txtLastName.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtLastName.LineThickness = 3
        Me.txtLastName.Location = New System.Drawing.Point(177, 24)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(159, 43)
        Me.txtLastName.TabIndex = 6
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(346, 71)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(86, 20)
        Me.BunifuCustomLabel3.TabIndex = 9
        Me.BunifuCustomLabel3.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFirstName.HintForeColor = System.Drawing.Color.Empty
        Me.txtFirstName.HintText = ""
        Me.txtFirstName.isPassword = False
        Me.txtFirstName.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtFirstName.LineIdleColor = System.Drawing.Color.Black
        Me.txtFirstName.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtFirstName.LineThickness = 3
        Me.txtFirstName.Location = New System.Drawing.Point(350, 24)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(159, 43)
        Me.txtFirstName.TabIndex = 8
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(513, 71)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(100, 20)
        Me.BunifuCustomLabel4.TabIndex = 11
        Me.BunifuCustomLabel4.Text = "Middle Initial "
        '
        'txtMI
        '
        Me.txtMI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMI.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMI.HintForeColor = System.Drawing.Color.Empty
        Me.txtMI.HintText = ""
        Me.txtMI.isPassword = False
        Me.txtMI.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtMI.LineIdleColor = System.Drawing.Color.Black
        Me.txtMI.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtMI.LineThickness = 3
        Me.txtMI.Location = New System.Drawing.Point(517, 24)
        Me.txtMI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(159, 43)
        Me.txtMI.TabIndex = 10
        Me.txtMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(3, 67)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(68, 20)
        Me.BunifuCustomLabel5.TabIndex = 13
        Me.BunifuCustomLabel5.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAddress.HintForeColor = System.Drawing.Color.Empty
        Me.txtAddress.HintText = ""
        Me.txtAddress.isPassword = False
        Me.txtAddress.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtAddress.LineIdleColor = System.Drawing.Color.Black
        Me.txtAddress.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtAddress.LineThickness = 3
        Me.txtAddress.Location = New System.Drawing.Point(7, 20)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(328, 43)
        Me.txtAddress.TabIndex = 12
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(3, 138)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(77, 20)
        Me.BunifuCustomLabel6.TabIndex = 15
        Me.BunifuCustomLabel6.Text = "Barangay"
        '
        'txtBarangay
        '
        Me.txtBarangay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBarangay.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtBarangay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBarangay.HintForeColor = System.Drawing.Color.Empty
        Me.txtBarangay.HintText = ""
        Me.txtBarangay.isPassword = False
        Me.txtBarangay.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtBarangay.LineIdleColor = System.Drawing.Color.Black
        Me.txtBarangay.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtBarangay.LineThickness = 3
        Me.txtBarangay.Location = New System.Drawing.Point(7, 91)
        Me.txtBarangay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBarangay.Name = "txtBarangay"
        Me.txtBarangay.Size = New System.Drawing.Size(328, 43)
        Me.txtBarangay.TabIndex = 14
        Me.txtBarangay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(6, 209)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(35, 20)
        Me.BunifuCustomLabel7.TabIndex = 17
        Me.BunifuCustomLabel7.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCity.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCity.HintForeColor = System.Drawing.Color.Empty
        Me.txtCity.HintText = ""
        Me.txtCity.isPassword = False
        Me.txtCity.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtCity.LineIdleColor = System.Drawing.Color.Black
        Me.txtCity.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtCity.LineThickness = 3
        Me.txtCity.Location = New System.Drawing.Point(7, 162)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(328, 43)
        Me.txtCity.TabIndex = 16
        Me.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(6, 67)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(125, 20)
        Me.BunifuCustomLabel8.TabIndex = 19
        Me.BunifuCustomLabel8.Text = "Contact Number"
        '
        'txtContact
        '
        Me.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContact.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContact.HintForeColor = System.Drawing.Color.Empty
        Me.txtContact.HintText = ""
        Me.txtContact.isPassword = False
        Me.txtContact.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtContact.LineIdleColor = System.Drawing.Color.Black
        Me.txtContact.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtContact.LineThickness = 3
        Me.txtContact.Location = New System.Drawing.Point(7, 20)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(328, 43)
        Me.txtContact.TabIndex = 18
        Me.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtApplicantID)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel1)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel2)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox1.Controls.Add(Me.txtMI)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(699, 106)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAddress)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel5)
        Me.GroupBox2.Controls.Add(Me.txtBarangay)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel6)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel7)
        Me.GroupBox2.Controls.Add(Me.txtCity)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 246)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Address"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAge)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel10)
        Me.GroupBox3.Controls.Add(Me.txtBirthdate)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel9)
        Me.GroupBox3.Controls.Add(Me.txtContact)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel8)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(363, 267)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(349, 246)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Information"
        '
        'txtAge
        '
        Me.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAge.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAge.HintForeColor = System.Drawing.Color.Empty
        Me.txtAge.HintText = ""
        Me.txtAge.isPassword = False
        Me.txtAge.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtAge.LineIdleColor = System.Drawing.Color.Black
        Me.txtAge.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtAge.LineThickness = 3
        Me.txtAge.Location = New System.Drawing.Point(7, 163)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(328, 43)
        Me.txtAge.TabIndex = 23
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(6, 210)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(38, 20)
        Me.BunifuCustomLabel10.TabIndex = 24
        Me.BunifuCustomLabel10.Text = "Age"
        '
        'txtBirthdate
        '
        Me.txtBirthdate.BackColor = System.Drawing.Color.Black
        Me.txtBirthdate.BorderRadius = 0
        Me.txtBirthdate.ForeColor = System.Drawing.Color.White
        Me.txtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.txtBirthdate.FormatCustom = Nothing
        Me.txtBirthdate.Location = New System.Drawing.Point(7, 103)
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.Size = New System.Drawing.Size(328, 36)
        Me.txtBirthdate.TabIndex = 22
        Me.txtBirthdate.Value = New Date(2024, 4, 7, 23, 9, 12, 204)
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(6, 142)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(81, 20)
        Me.BunifuCustomLabel9.TabIndex = 21
        Me.BunifuCustomLabel9.Text = "Birth Date"
        '
        'txtGuardianName
        '
        Me.txtGuardianName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGuardianName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtGuardianName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtGuardianName.HintForeColor = System.Drawing.Color.Empty
        Me.txtGuardianName.HintText = ""
        Me.txtGuardianName.isPassword = False
        Me.txtGuardianName.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtGuardianName.LineIdleColor = System.Drawing.Color.Black
        Me.txtGuardianName.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtGuardianName.LineThickness = 3
        Me.txtGuardianName.Location = New System.Drawing.Point(7, 20)
        Me.txtGuardianName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuardianName.Name = "txtGuardianName"
        Me.txtGuardianName.Size = New System.Drawing.Size(328, 43)
        Me.txtGuardianName.TabIndex = 25
        Me.txtGuardianName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(3, 67)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(121, 20)
        Me.BunifuCustomLabel11.TabIndex = 26
        Me.BunifuCustomLabel11.Text = "Guardian Name"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtGuardianCN)
        Me.GroupBox4.Controls.Add(Me.BunifuCustomLabel12)
        Me.GroupBox4.Controls.Add(Me.txtGuardianName)
        Me.GroupBox4.Controls.Add(Me.BunifuCustomLabel11)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(717, 135)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(342, 199)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Guardian Information"
        '
        'txtGuardianCN
        '
        Me.txtGuardianCN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGuardianCN.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtGuardianCN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtGuardianCN.HintForeColor = System.Drawing.Color.Empty
        Me.txtGuardianCN.HintText = ""
        Me.txtGuardianCN.isPassword = False
        Me.txtGuardianCN.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtGuardianCN.LineIdleColor = System.Drawing.Color.Black
        Me.txtGuardianCN.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtGuardianCN.LineThickness = 3
        Me.txtGuardianCN.Location = New System.Drawing.Point(5, 91)
        Me.txtGuardianCN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuardianCN.Name = "txtGuardianCN"
        Me.txtGuardianCN.Size = New System.Drawing.Size(328, 43)
        Me.txtGuardianCN.TabIndex = 27
        Me.txtGuardianCN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(1, 138)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(195, 20)
        Me.BunifuCustomLabel12.TabIndex = 28
        Me.BunifuCustomLabel12.Text = "Guardian Contact Number"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BunifuCustomLabel17)
        Me.GroupBox5.Controls.Add(Me.cbTranscriptRec)
        Me.GroupBox5.Controls.Add(Me.BunifuCustomLabel16)
        Me.GroupBox5.Controls.Add(Me.cbBirthCert)
        Me.GroupBox5.Controls.Add(Me.BunifuCustomLabel15)
        Me.GroupBox5.Controls.Add(Me.cbMedCert)
        Me.GroupBox5.Controls.Add(Me.BunifuCustomLabel14)
        Me.GroupBox5.Controls.Add(Me.cbGoodMoral)
        Me.GroupBox5.Controls.Add(Me.BunifuCustomLabel13)
        Me.GroupBox5.Controls.Add(Me.cbPicture)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(717, 340)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(210, 173)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Requirements"
        '
        'BunifuCustomLabel17
        '
        Me.BunifuCustomLabel17.AutoSize = True
        Me.BunifuCustomLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel17.Location = New System.Drawing.Point(37, 130)
        Me.BunifuCustomLabel17.Name = "BunifuCustomLabel17"
        Me.BunifuCustomLabel17.Size = New System.Drawing.Size(161, 20)
        Me.BunifuCustomLabel17.TabIndex = 33
        Me.BunifuCustomLabel17.Text = "Transcript of Records"
        '
        'cbTranscriptRec
        '
        Me.cbTranscriptRec.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cbTranscriptRec.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cbTranscriptRec.Checked = False
        Me.cbTranscriptRec.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.cbTranscriptRec.ForeColor = System.Drawing.Color.White
        Me.cbTranscriptRec.Location = New System.Drawing.Point(11, 130)
        Me.cbTranscriptRec.Name = "cbTranscriptRec"
        Me.cbTranscriptRec.Size = New System.Drawing.Size(20, 20)
        Me.cbTranscriptRec.TabIndex = 32
        '
        'BunifuCustomLabel16
        '
        Me.BunifuCustomLabel16.AutoSize = True
        Me.BunifuCustomLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel16.Location = New System.Drawing.Point(37, 104)
        Me.BunifuCustomLabel16.Name = "BunifuCustomLabel16"
        Me.BunifuCustomLabel16.Size = New System.Drawing.Size(118, 20)
        Me.BunifuCustomLabel16.TabIndex = 31
        Me.BunifuCustomLabel16.Text = "Birth Certificate"
        '
        'cbBirthCert
        '
        Me.cbBirthCert.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cbBirthCert.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cbBirthCert.Checked = False
        Me.cbBirthCert.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.cbBirthCert.ForeColor = System.Drawing.Color.White
        Me.cbBirthCert.Location = New System.Drawing.Point(11, 104)
        Me.cbBirthCert.Name = "cbBirthCert"
        Me.cbBirthCert.Size = New System.Drawing.Size(20, 20)
        Me.cbBirthCert.TabIndex = 30
        '
        'BunifuCustomLabel15
        '
        Me.BunifuCustomLabel15.AutoSize = True
        Me.BunifuCustomLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel15.Location = New System.Drawing.Point(37, 78)
        Me.BunifuCustomLabel15.Name = "BunifuCustomLabel15"
        Me.BunifuCustomLabel15.Size = New System.Drawing.Size(139, 20)
        Me.BunifuCustomLabel15.TabIndex = 29
        Me.BunifuCustomLabel15.Text = "Medical Certificate"
        '
        'cbMedCert
        '
        Me.cbMedCert.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cbMedCert.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cbMedCert.Checked = False
        Me.cbMedCert.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.cbMedCert.ForeColor = System.Drawing.Color.White
        Me.cbMedCert.Location = New System.Drawing.Point(11, 78)
        Me.cbMedCert.Name = "cbMedCert"
        Me.cbMedCert.Size = New System.Drawing.Size(20, 20)
        Me.cbMedCert.TabIndex = 28
        '
        'BunifuCustomLabel14
        '
        Me.BunifuCustomLabel14.AutoSize = True
        Me.BunifuCustomLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel14.Location = New System.Drawing.Point(37, 52)
        Me.BunifuCustomLabel14.Name = "BunifuCustomLabel14"
        Me.BunifuCustomLabel14.Size = New System.Drawing.Size(92, 20)
        Me.BunifuCustomLabel14.TabIndex = 27
        Me.BunifuCustomLabel14.Text = "Good Moral"
        '
        'cbGoodMoral
        '
        Me.cbGoodMoral.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cbGoodMoral.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cbGoodMoral.Checked = False
        Me.cbGoodMoral.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.cbGoodMoral.ForeColor = System.Drawing.Color.White
        Me.cbGoodMoral.Location = New System.Drawing.Point(11, 52)
        Me.cbGoodMoral.Name = "cbGoodMoral"
        Me.cbGoodMoral.Size = New System.Drawing.Size(20, 20)
        Me.cbGoodMoral.TabIndex = 26
        '
        'BunifuCustomLabel13
        '
        Me.BunifuCustomLabel13.AutoSize = True
        Me.BunifuCustomLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel13.Location = New System.Drawing.Point(37, 26)
        Me.BunifuCustomLabel13.Name = "BunifuCustomLabel13"
        Me.BunifuCustomLabel13.Size = New System.Drawing.Size(87, 20)
        Me.BunifuCustomLabel13.TabIndex = 25
        Me.BunifuCustomLabel13.Text = "2x2 Picture"
        '
        'cbPicture
        '
        Me.cbPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cbPicture.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cbPicture.Checked = False
        Me.cbPicture.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.cbPicture.ForeColor = System.Drawing.Color.White
        Me.cbPicture.Location = New System.Drawing.Point(11, 26)
        Me.cbPicture.Name = "cbPicture"
        Me.cbPicture.Size = New System.Drawing.Size(20, 20)
        Me.cbPicture.TabIndex = 0
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Save"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(945, 465)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(107, 48)
        Me.BunifuFlatButton1.TabIndex = 29
        Me.BunifuFlatButton1.Text = "Save"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1069, 536)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical Certificate"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtApplicantID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtLastName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtFirstName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtMI As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtAddress As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtBarangay As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtCity As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtContact As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtAge As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtBirthdate As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents txtGuardianName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtGuardianCN As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BunifuCustomLabel17 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbTranscriptRec As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCustomLabel16 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbBirthCert As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCustomLabel15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbMedCert As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCustomLabel14 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbGoodMoral As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCustomLabel13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbPicture As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
End Class
