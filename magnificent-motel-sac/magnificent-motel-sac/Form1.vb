Imports System.IO

Public Class Form1
    Private Sub btnDisplayAll_Click(sender As Object, e As EventArgs) Handles btnDisplayAll.Click
        Dim strCustomerName As String
        Dim strSuburb As String
        Dim intNoNights As Integer
        Dim CustomerFile As StreamReader = File.OpenText("CustomerFile.txt")
        lstDisplay.Items.Clear()
        Do While CustomerFile.Peek <> -1
            strCustomerName = CustomerFile.ReadLine()
            strSuburb = CustomerFile.ReadLine()
            intNoNights = CustomerFile.ReadLine()
            lstDisplay.Items.Add("Customer Name: " & strCustomerName)
            lstDisplay.Items.Add("  Suburb: " & strSuburb)
            lstDisplay.Items.Add("  Number of Nights Stayed: " & intNoNights)
        Loop
        CustomerFile.Close()
    End Sub

    Private Sub btnTotalNights_Click(sender As Object, e As EventArgs) Handles btnTotalNights.Click
        Dim strCustomerName As String
        Dim strSuburb As String
        Dim intNoNights As Integer
        Dim intTotalNoNights As Integer
        Dim CustomerFile As StreamReader = File.OpenText("CustomerFile.txt")
        lstDisplay.Items.Clear()
        Do While CustomerFile.Peek <> -1
            strCustomerName = CustomerFile.ReadLine()
            strSuburb = CustomerFile.ReadLine()
            intNoNights = CustomerFile.ReadLine()
            intTotalNoNights = intTotalNoNights + intNoNights
        Loop
        lstDisplay.Items.Add("Total Number of Nights Stayed: " & intTotalNoNights)
        CustomerFile.Close()
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Dim strCustomerName As String = txtName.Text
        Dim strSuburb As String = txtSuburb.Text
        Dim strNoNights As String = txtNoNights.Text
        Dim intNoNights As Integer
        Dim CustomerFile As StreamWriter = File.AppendText("CustomerFile.txt")
        If Integer.TryParse(strNoNights, intNoNights) Then
            CustomerFile.WriteLine(txtName.Text)
            CustomerFile.WriteLine(txtSuburb.Text)
            CustomerFile.WriteLine(txtNoNights.Text)
            txtName.Clear()
            txtSuburb.Clear()
            txtNoNights.Clear()
            MessageBox.Show("The customer name, suburb, and number of nights stayed have been added to the text file.")
        Else
            MessageBox.Show("Please input an integer for the number of nights stayed.")
        End If
        CustomerFile.Close()
    End Sub

    Private Sub btnOver10Nights_Click(sender As Object, e As EventArgs) Handles btnOver10Nights.Click
        Dim strCustomerName As String
        Dim strSuburb As String
        Dim intNoNights As Integer
        Dim CustomerFile As StreamReader = File.OpenText("CustomerFile.txt")
        lstDisplay.Items.Clear()
        Do While CustomerFile.Peek <> -1
            strCustomerName = CustomerFile.ReadLine()
            strSuburb = CustomerFile.ReadLine()
            intNoNights = CustomerFile.ReadLine()
            If intNoNights > 10 Then
                lstDisplay.Items.Add("Customer Name: " & strCustomerName)
                lstDisplay.Items.Add("  Suburb: " & strSuburb)
                lstDisplay.Items.Add("  Number of Nights Stayed: " & intNoNights)
            End If
        Loop
        CustomerFile.Close()
    End Sub
End Class
