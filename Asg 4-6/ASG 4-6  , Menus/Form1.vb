'Rykken Nelson 
'RCET
'Asg 4-6

Option Explicit On

Public Class Form1
    Dim casePosition As Integer
    Dim description As String
    Dim unit As String
    Dim rate As String
    Dim subTotal As String
    Dim response As String
    Dim Data As Boolean
    Dim invoiceKeeper As String
    Dim InvoiceList As New List(Of String)


    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Data = True
        DataCheck()

    End Sub
    'Checks to see if all data is filled in so that the transaction can be continued 
    Private Sub DataCheck()
        Static customer As Integer

        If Data = True Then

            If CStr(NameTextBox.Text) = "" Then
                MessageBox.Show("Type Your name in the name textBox")
                NameTextBox.Focus()
                Data = False
            End If
            If CStr(AddressTextBox.Text) = "" Then
                MessageBox.Show("Type in your Address in the Address textBox")
                AddressTextBox.Focus()
                Data = False
            End If
            If CStr(CityTextBox.Text) = "" Then
                MessageBox.Show("Type in the city you live in, in the City textBox")
                CityTextBox.Focus()
                Data = False
            End If
            If CStr(StateTextBox.Text) = "" Then
                MessageBox.Show("Type in the State of your address in the state textBox")
                StateTextBox.Focus()
                Data = False
            End If
            If Len(ZipTextBox.Text) <> 5 Then
                MessageBox.Show("Type in your zipcode in the zipCode textBox")
                ZipTextBox.Focus()
                Data = False
            End If
            If CStr(BeginOdoTextBox.Text) = "" Then
                MessageBox.Show("Type in the correct odometer data in the Begin Odometer Reading textBox")
                BeginOdoTextBox.Focus()
                Data = False
            End If
            If CStr(EndOdoTextBox.Text) = "" Then
                MessageBox.Show("Type in the Correct End Odometer Data in the reading textBox")
                EndOdoTextBox.Focus()
                Data = False
            End If
            If CStr(DaysTextBox.Text) = "" Then
                MessageBox.Show("Type in the correct amount of days you will rent this car")
                DaysTextBox.Focus()
                Data = False
            End If
            Try
                If CInt(BeginOdoTextBox.Text) > CInt(EndOdoTextBox.Text) Then
                    MessageBox.Show("the End Odometer reading must be more than the start odometer ")
                    Data = False
                End If
            Catch ex As Exception
                MessageBox.Show("Odometer must be in a numeric type")
                Data = False

            End Try
        End If
        'Calls to Summary if all data is filled in and data = true
        If Data = True Then

            customer += 1
            Summary(customer)

        End If

    End Sub

    Sub Summary(ByVal CustomerRecieve As Integer)
        'This will control which case will be selected in the printInvoice
        Dim i As Integer
        For i = 1 To 6

            casePosition += 1
            If casePosition = 1 Then
                response = "*******************************************************************************" &
               vbNewLine & "*          INVOICE SUMMARY                                                    *" & vbNewLine &
                           "*******************************************************************************"
            End If
            If casePosition = 2 Then
                description = NameTextBox.Text & vbNewLine
                unit = CStr(AddressTextBox.Text & CityTextBox.Text.PadLeft(5) & StateTextBox.Text.PadLeft(5) & vbNewLine)
                rate = ZipTextBox.Text
                response = CStr(description & unit & rate)
            End If
            If casePosition = 3 Then
                description = "Description"
                unit = "Unit"
                rate = "Rate"
                subTotal = "SubTotal"
                response = CStr(description.PadRight(20) & unit.PadRight(20) & rate.PadRight(20) & subTotal.PadRight(20))
            End If
            If casePosition = 4 Then
                description = "Description"
                unit = "Unit"
                rate = "Rate"
                subTotal = "SubTotal"
                response = CStr(description.PadRight(20) & unit.PadRight(20) & rate.PadRight(20) & subTotal.PadRight(20))
            End If
            If casePosition = 5 Then
                description = "Description"
                unit = "Unit"
                rate = "Rate"
                subTotal = "SubTotal"
                                response = CStr(description.PadRight(20) & unit.PadRight(20) & rate.PadRight(20) & subTotal.PadRight(20))
            End If

            If casePosition = 6 Then
                'This is going to start a list for the ComboBox

                Console.WriteLine(CustomerRecieve & invoiceKeeper)
                ComboList(invoiceKeeper, CustomerRecieve)
                'DataList(customer, CStr(invoiceKeeper))
                'clears invoice keeper data for the next customer 
            End If
           
                invoiceKeeper += CStr(response & vbNewLine)
        Next
  End Sub


    Sub ComboList(ByRef invoiceRecieve As String, ByVal customerReciever As Integer)
        'This Contains the List information for each Customer 
        ComboBox1.Items.Add("Customer" & customerReciever)
        InvoiceList.Add(invoiceRecieve)
        Console.WriteLine(invoiceRecieve)
    End Sub


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
        DistanceTextBox.Text = ""
        MileageTextBox.Text = ""
        DayChargeTextBox.Text = ""
        DiscountTextBox.Text = ""
        TotalTextBox.Text = ""
        MilesRadioButton.Refresh()
        KilometersRadioButton.Refresh()
        AAACheckBox.Refresh()
        SeniorCheckBox.Refresh()
        NameTextBox.Show()
        AddressTextBox.Show()
        CityTextBox.Show()
        StateTextBox.Show()
        ZipTextBox.Show()
        DistanceTextBox.Show()
        MileageTextBox.Show()
        DayChargeTextBox.Show()
        DiscountTextBox.Show()
        TotalTextBox.Show()
        MilesRadioButton.Show()
        KilometersRadioButton.Show()
        AAACheckBox.Show()
        SeniorCheckBox.Show()
        GroupBox4.Show()
        ComboBox1.Hide()
        InvoiceListBox.Hide()
    End Sub


    Private Sub InvoiceView_Click(sender As Object, e As EventArgs) Handles InvoiceView.Click
        NameTextBox.Hide()
        AddressTextBox.Hide()
        CityTextBox.Hide()
        StateTextBox.Hide()
        ZipTextBox.Hide()
        DistanceTextBox.Hide()
        MileageTextBox.Hide()
        DayChargeTextBox.Hide()
        DiscountTextBox.Hide()
        TotalTextBox.Hide()
        MilesRadioButton.Hide()
        KilometersRadioButton.Hide()
        AAACheckBox.Hide()
        SeniorCheckBox.Hide()

        ComboBox1.Show()
        InvoiceListBox.Show()
    End Sub

    Private Sub ComboBox1_click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        Try
            Dim listNum As Integer
            Console.WriteLine(listNum)
            InvoiceListBox.Items.Clear()
            listNum = ComboBox1.SelectedIndex() + 1
            InvoiceListBox.Items.Add(InvoiceList(listNum))
            Console.WriteLine(InvoiceList(listNum))
            '  Dim comboNumber As Integer
            '  comboNumber = ComboBox1.SelectedItem As Integer
        Catch ex As Exception
            MessageBox.Show("Dont Spam Click")
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


'Private Sub ComboBox1_SelectedIndex(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
'    'Selected index on combo box will show the invoice on the list box
'    NameTextBox.Hide()
'    AddressTextBox.Hide()
'    CityTextBox.Hide()
'    StateTextBox.Hide()
'    ZipTextBox.Hide()
'    DistanceTextBox.Hide()
'    MileageTextBox.Hide()
'    DayChargeTextBox.Hide()
'    DiscountTextBox.Hide()
'    TotalTextBox.Hide()
'    MilesRadioButton.Hide()
'    KilometersRadioButton.Hide()
'    AAACheckBox.Hide()
'    SeniorCheckBox.Hide()
'    GroupBox4.Hide()
'    ComboBox1.Show()
'    InvoiceListBox.BringToFront()

'    Dim listNum As Integer
'    listNum = ComboBox1.SelectedIndex()
'    InvoiceListBox.Items.Add(InvoiceList(listNum))
'    Console.WriteLine(listNum)
'    '  Dim comboNumber As Integer
'    '  comboNumber = ComboBox1.SelectedItem As Integer
'End Sub