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
        Label1 = New Label()
        btnDisplayAll = New Button()
        btnTotalNights = New Button()
        btnAddCustomer = New Button()
        btnOver10Nights = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtName = New TextBox()
        txtSuburb = New TextBox()
        txtNoNights = New TextBox()
        Label5 = New Label()
        lstDisplay = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Navy
        Label1.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Aqua
        Label1.Location = New Point(150, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(275, 26)
        Label1.TabIndex = 0
        Label1.Text = "Mr Mac's Magnificent Motel"
        ' 
        ' btnDisplayAll
        ' 
        btnDisplayAll.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnDisplayAll.ForeColor = SystemColors.ControlText
        btnDisplayAll.Location = New Point(75, 50)
        btnDisplayAll.Name = "btnDisplayAll"
        btnDisplayAll.Size = New Size(200, 35)
        btnDisplayAll.TabIndex = 1
        btnDisplayAll.Text = "Display All"
        btnDisplayAll.UseVisualStyleBackColor = True
        ' 
        ' btnTotalNights
        ' 
        btnTotalNights.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnTotalNights.ForeColor = SystemColors.ControlText
        btnTotalNights.Location = New Point(300, 50)
        btnTotalNights.Name = "btnTotalNights"
        btnTotalNights.Size = New Size(200, 35)
        btnTotalNights.TabIndex = 2
        btnTotalNights.Text = "Total Nights"
        btnTotalNights.UseVisualStyleBackColor = True
        ' 
        ' btnAddCustomer
        ' 
        btnAddCustomer.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddCustomer.ForeColor = SystemColors.ControlText
        btnAddCustomer.Location = New Point(75, 100)
        btnAddCustomer.Name = "btnAddCustomer"
        btnAddCustomer.Size = New Size(200, 35)
        btnAddCustomer.TabIndex = 3
        btnAddCustomer.Text = "Add Customer"
        btnAddCustomer.UseVisualStyleBackColor = True
        ' 
        ' btnOver10Nights
        ' 
        btnOver10Nights.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnOver10Nights.ForeColor = SystemColors.ControlText
        btnOver10Nights.Location = New Point(300, 100)
        btnOver10Nights.Name = "btnOver10Nights"
        btnOver10Nights.Size = New Size(200, 35)
        btnOver10Nights.TabIndex = 4
        btnOver10Nights.Text = "More than 10 Nights"
        btnOver10Nights.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(50, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 24)
        Label2.TabIndex = 5
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(50, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 24)
        Label3.TabIndex = 6
        Label3.Text = "Suburb"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(50, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(157, 24)
        Label4.TabIndex = 7
        Label4.Text = "Number of Nights"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtName.Location = New Point(125, 150)
        txtName.Name = "txtName"
        txtName.Size = New Size(375, 29)
        txtName.TabIndex = 8
        ' 
        ' txtSuburb
        ' 
        txtSuburb.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtSuburb.Location = New Point(125, 190)
        txtSuburb.Name = "txtSuburb"
        txtSuburb.Size = New Size(375, 29)
        txtSuburb.TabIndex = 9
        ' 
        ' txtNoNights
        ' 
        txtNoNights.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtNoNights.Location = New Point(215, 227)
        txtNoNights.Name = "txtNoNights"
        txtNoNights.Size = New Size(285, 29)
        txtNoNights.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Aqua
        Label5.Location = New Point(50, 275)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 26)
        Label5.TabIndex = 11
        Label5.Text = "Display"
        ' 
        ' lstDisplay
        ' 
        lstDisplay.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lstDisplay.FormattingEnabled = True
        lstDisplay.ItemHeight = 20
        lstDisplay.Location = New Point(50, 315)
        lstDisplay.Name = "lstDisplay"
        lstDisplay.Size = New Size(450, 224)
        lstDisplay.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(584, 561)
        Controls.Add(lstDisplay)
        Controls.Add(Label5)
        Controls.Add(txtNoNights)
        Controls.Add(txtSuburb)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnOver10Nights)
        Controls.Add(btnAddCustomer)
        Controls.Add(btnTotalNights)
        Controls.Add(btnDisplayAll)
        Controls.Add(Label1)
        ForeColor = SystemColors.Control
        Name = "Form1"
        Text = "Mr Mac's Magnificent Motel"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDisplayAll As Button
    Friend WithEvents btnTotalNights As Button
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnOver10Nights As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSuburb As TextBox
    Friend WithEvents txtNoNights As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lstDisplay As ListBox
End Class
