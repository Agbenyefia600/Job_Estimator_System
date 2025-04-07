Public Class Form1

    Dim jobDetails(4) As Double
    Dim iTax As Double = 17.5



    Dim firstnum As Double
    Dim secondnum As Double
    Dim op As String
    Dim answer As Double


    Dim Nigerian_Naira As Double = 302.26
    Dim US_Dollar As Double = 1.52
    Dim Kenyan_Shiling As Double = 156.21
    Dim Brazilain_Real As Double = 5.86
    Dim Canadian_Dollar As Double = 2.03
    Dim Indian_Rupee As Double = 101.71
    Dim Philippine_Peso As Double = 71.44
    Dim Indonesian_Rupiah As Double = 20748.75

    Function CuConverter(ByVal money As Double) As Double

        'If cmbCurrency.Text = "Nigeria" Then
        '    Return Math.Round(Nigerian_Naira * money, 2)
        'ElseIf cmbCurrency.Text = "USA" Then
        '    Return Math.Round(US_Dollar * money, 2)
        'ElseIf cmbCurrency.Text = "Nigeria" Then
        '    Return Math.Round(Nigerian_Naira * money, 2)
        'ElseIf cmbCurrency.Text = "Kenyan" Then
        '    Return Math.Round(Kenyan_Shiling * money, 2)
        'ElseIf cmbCurrency.Text = "Brazil" Then
        '    Return Math.Round(Brazilain_Real * money, 2)
        'ElseIf cmbCurrency.Text = "Canada" Then
        '    Return Math.Round(Canadian_Dollar * money, 2)
        'ElseIf cmbCurrency.Text = "India" Then
        '    Return Math.Round(Indian_Rupee * money, 2)
        'ElseIf cmbCurrency.Text = "Indonesia" Then
        '    Return Math.Round(Indonesian_Rupiah * money, 2)
        'ElseIf cmbCurrency.Text = "Philippine" Then
        '    Return Math.Round(Philippine_Peso * money, 2)
        'End If

        Select Case cmbCurrency.Text
            Case "Nigeria"
                Return Math.Round(Nigerian_Naira * money, 2)
            Case "USA"
                Return Math.Round(US_Dollar * money, 2)
            Case "Kenyan"
                Return Math.Round(Kenyan_Shiling * money, 2)
            Case "Brazil"
                Return Math.Round(Brazilain_Real * money, 2)
            Case "Canada"
                Return Math.Round(Canadian_Dollar * money, 2)
            Case "India"
                Return Math.Round(Indian_Rupee * money, 2)
            Case "Indonesia"
                Return Math.Round(Indonesian_Rupiah * money, 2)
            Case "Philippine"
                Return Math.Round(Philippine_Peso * money, 2)
            Case Else
                Return 0
        End Select
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EstimatorDataSet.Job' table. You can move, or remove it, as needed.
        Me.JobTableAdapter.Fill(Me.EstimatorDataSet.Job)
        Login.Show()
        Me.Hide()

        lblDate.Text = Today
        Timer1.Start()


        jobDetails(0) = 20.99   'Labour per hour
        jobDetails(1) = 3.5     'Travel
        jobDetails(2) = 4.5     'copper per meter
        jobDetails(3) = 7.9     'plastic pipes per meter
        jobDetails(4) = 6.5     'chrome per meter

        cmbCurrency.Text = "Choose One..."
        'cmbCurrency.Items.Add("USA")
        'cmbCurrency.Items.Add("Nigeria")
        'cmbCurrency.Items.Add("Kenyan")
        'cmbCurrency.Items.Add("Brazil")
        'cmbCurrency.Items.Add("Canada")
        'cmbCurrency.Items.Add("India")
        'cmbCurrency.Items.Add("Indonesia")
        'cmbCurrency.Items.Add("Philippine")
        cmbCurrency.Items.AddRange({"USA", "Nigeria", "Kenyan", "Brazil", "Canada", "India", "Indonesia", "Philippine"})
        DiscountTextBox.Enabled = False
        TaxTextBox.Enabled = False
        SubTotalTextBox.Enabled = False
        TotalTextBox.Enabled = False
        lblConvert.Enabled = False
        Job_IDTextBox.Enabled = False

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub JobBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles JobBindingNavigatorSaveItem.Click
        Me.Validate()
        JobBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EstimatorDataSet)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TravelLabel_Click(sender As Object, e As EventArgs) Handles TravelLabel.Click

    End Sub

    Private Sub LabourTextBox_TextChanged(sender As Object, e As EventArgs) Handles LabourTextBox.TextChanged

    End Sub

    Private Sub Chrome_PipeLabel_Click(sender As Object, e As EventArgs) Handles Chrome_PipeLabel.Click

    End Sub

    Private Sub TotalLabel_Click(sender As Object, e As EventArgs) Handles TotalLabel.Click

    End Sub

    Private Sub TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalTextBox.TextChanged

    End Sub

    Private Sub SubTotalLabel_Click(sender As Object, e As EventArgs) Handles SubTotalLabel.Click

    End Sub

    Private Sub SubTotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles SubTotalTextBox.TextChanged

    End Sub

    Private Sub TaxLabel_Click(sender As Object, e As EventArgs) Handles TaxLabel.Click

    End Sub

    Private Sub TaxTextBox_TextChanged(sender As Object, e As EventArgs) Handles TaxTextBox.TextChanged

    End Sub

    Private Sub DiscountLabel_Click(sender As Object, e As EventArgs) Handles DiscountLabel.Click

    End Sub

    Private Sub DiscountTextBox_TextChanged(sender As Object, e As EventArgs) Handles DiscountTextBox.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeString

    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click

    End Sub

    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged

    End Sub

    Private Sub Coppies_PipesLabel_Click(sender As Object, e As EventArgs) Handles Coppies_PipesLabel.Click

    End Sub

    Private Sub Plastic_PipeLabel_Click(sender As Object, e As EventArgs) Handles Plastic_PipeLabel.Click

    End Sub

    Private Sub LabourLabel_Click(sender As Object, e As EventArgs) Handles LabourLabel.Click

    End Sub

    Private Sub Chrome_PipeTextBox_TextChanged(sender As Object, e As EventArgs) Handles Chrome_PipeTextBox.TextChanged

    End Sub

    Private Sub JobDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles JobDataGridView.CellContentClick

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Try

            Dim i(4) As Double
            Dim discount As Double

            Job_IDTextBox.Text = Int(32676 * Rnd())        ' Generate Job Number
            Job_IDTextBox.Text = Val(Job_IDTextBox.Text) + 10289  ' Generate Job Number



            i(0) = Coppies_PipesTextBox.Text * jobDetails(2)
            i(1) = Chrome_PipeTextBox.Text * jobDetails(4)
            i(2) = Plastic_PipeTextBox.Text * jobDetails(3)
            i(3) = LabourTextBox.Text * jobDetails(0)
            i(4) = TravelTextBox.Text * jobDetails(1)

            If chkCusDiscount.Checked = False Then

                SubTotalTextBox.Text = i(0) + i(1) + i(2) + i(3) + i(4)
                TaxTextBox.Text = (Val(SubTotalTextBox.Text) * iTax) / 100
                TotalTextBox.Text = Val(TaxTextBox.Text) + Val(SubTotalTextBox.Text)


                DiscountTextBox.Text = FormatCurrency(Val(DiscountTextBox.Text))
                SubTotalTextBox.Text = FormatCurrency(SubTotalTextBox.Text)
                TaxTextBox.Text = FormatCurrency(TaxTextBox.Text)
                TotalTextBox.Text = FormatCurrency(TotalTextBox.Text)

            ElseIf chkCusDiscount.Checked = True Then
                discount = ((i(0) + i(1) + i(2) + i(3) + i(4)) * 10) / 100
                DiscountTextBox.Text = discount

                SubTotalTextBox.Text = i(0) + i(1) + i(2) + i(3) + i(4)
                TaxTextBox.Text = (Val(SubTotalTextBox.Text) * iTax) / 100
                TotalTextBox.Text = Val(TaxTextBox.Text) + Val(SubTotalTextBox.Text)
                TotalTextBox.Text = TotalTextBox.Text - Val(DiscountTextBox.Text)


                DiscountTextBox.Text = FormatCurrency(Val(DiscountTextBox.Text))
                SubTotalTextBox.Text = FormatCurrency(SubTotalTextBox.Text)
                TaxTextBox.Text = FormatCurrency(TaxTextBox.Text)
                TotalTextBox.Text = FormatCurrency(TotalTextBox.Text)
            End If

        Catch ex As Exception
            MessageBox.Show("Please enter valid numeric values in all input fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Job_IDTextBox.Clear()
        FirstnameTextBox.Clear()
        SurnameTextBox.Clear()
        AddressTextBox.Clear()
        PhoneTextBox.Text = ""
        chkCusDiscount.Checked = False
        EmailTextBox.Clear()
        Coppies_PipesTextBox.Clear()
        Chrome_PipeTextBox.Clear()
        Plastic_PipeTextBox.Clear()
        LabourTextBox.Clear()
        TravelTextBox.Clear()
        DiscountTextBox.Clear()
        SubTotalTextBox.Clear()
        TaxTextBox.Clear()
        TotalTextBox.Clear()
    End Sub

    Private Sub JobBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles JobBindingNavigator.RefreshItems

    End Sub

    Private Sub receipt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        TabControl1.SelectedTab = TabPage2
        ReceiptTextBox.Text = ""

        ReceiptTextBox.AppendText(vbTab & vbTab & " Job Estimator Receipt  " & vbNewLine)
        ReceiptTextBox.AppendText(vbTab & vbTab & "************************" & vbNewLine)
        ReceiptTextBox.AppendText(vbTab & "Job ID : " & vbTab & vbTab & vbTab & Job_IDTextBox.Text & vbNewLine)
        ReceiptTextBox.AppendText(vbTab & "Copper pipes : " & vbTab & vbTab & Coppies_PipesTextBox.Text & vbNewLine)
        ReceiptTextBox.AppendText(vbTab & "Chrome pipes : " & vbTab & vbTab & Coppies_PipesTextBox.Text & vbNewLine)
        ReceiptTextBox.AppendText(vbTab & "Plastic pipe : " & vbTab & vbTab & Plastic_PipeTextBox.Text & vbNewLine)
        ReceiptTextBox.AppendText(vbTab & "Labour : " & vbTab & vbTab & vbTab & LabourTextBox.Text & vbNewLine)
        ReceiptTextBox.AppendText(vbTab & "Travel : " & vbTab & vbTab & vbTab & TravelTextBox.Text & vbNewLine)
        ReceiptTextBox.AppendText(vbTab & "Discount : " & vbTab & vbTab & DiscountTextBox.Text & vbNewLine)
        ReceiptTextBox.AppendText(vbTab & "Tax : " & vbTab & vbTab & vbTab & TaxTextBox.Text & vbNewLine)
        ReceiptTextBox.AppendText(vbTab & "Sub Total : " & vbTab & vbTab & SubTotalTextBox.Text & vbNewLine)
        ReceiptTextBox.AppendText(vbTab & "Total: " & vbTab & vbTab & vbTab & TotalTextBox.Text & vbNewLine)

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If InStr(lblDisplay.Text, ".") = 0 Then
            lblDisplay.Text = lblDisplay.Text + "."
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblDisplay.Text = "0"
        lblShowCal.Text = ""
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles btnEqaul.Click
        'secondnum = Val(lblDisplay.Text)
        'If op = "+" Then
        '    answer = firstnum + secondnum
        '    lblDisplay.Text = answer
        '    lblShowCal.Text = ""
        'ElseIf op = "-" Then
        '    answer = firstnum - secondnum
        '    lblDisplay.Text = answer
        '    lblShowCal.Text = ""
        'ElseIf op = "*" Then
        '    answer = firstnum * secondnum
        '    lblDisplay.Text = answer
        '    lblShowCal.Text = ""
        'ElseIf op = "/" Then
        '    answer = firstnum / secondnum
        '    lblDisplay.Text = answer
        '    lblShowCal.Text = ""
        'End If

        Try
            secondnum = Val(lblDisplay.Text)
            Select Case op
                Case "+"
                    answer = firstnum + secondnum
                Case "-"
                    answer = firstnum - secondnum
                Case "*"
                    answer = firstnum * secondnum
                Case "/"
                    If secondnum = 0 Then
                        MessageBox.Show("Division by zero is not allowed.", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    answer = firstnum / secondnum
            End Select
            lblDisplay.Text = answer.ToString()
            lblShowCal.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error calculating result. Please try again.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCurrency.SelectedIndexChanged

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        btnCC.Visible = True
        txtConvert.Text = ""
        lblConvert.Text = ""
        cmbCurrency.Text = "Choose One..."

    End Sub

    Private Sub btnCC_Click(sender As Object, e As EventArgs) Handles btnCC.Click
        btnCC.Visible = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtConvert.Text = ""
        lblConvert.Text = ""
        cmbCurrency.Text = "Choose One..."
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Try

            Dim British_Pounds As Double = CDbl(txtConvert.Text)
            lblConvert.Text = CStr(CuConverter(British_Pounds))

            'If cmbCurrency.Text = "Nigeria" Then
            '    lblConvert.Text = "NGN" & " " & Val(lblConvert.Text)
            'ElseIf cmbCurrency.Text = "USA" Then
            '    lblConvert.Text = "$" & " " & Val(lblConvert.Text)
            'ElseIf cmbCurrency.Text = "Kenyan" Then
            '    lblConvert.Text = "KES" & " " & Val(lblConvert.Text)
            'ElseIf cmbCurrency.Text = "Brazil" Then
            '    lblConvert.Text = "BRL" & " " & Val(lblConvert.Text)
            'ElseIf cmbCurrency.Text = "Canada" Then
            '    lblConvert.Text = "C$" & " " & Val(lblConvert.Text)
            'ElseIf cmbCurrency.Text = "India" Then
            '    lblConvert.Text = "INR" & " " & Val(lblConvert.Text)
            'ElseIf cmbCurrency.Text = "Philippine" Then
            '    lblConvert.Text = "PHP" & " " & Val(lblConvert.Text)
            'ElseIf cmbCurrency.Text = "Indonesia" Then
            '    lblConvert.Text = "IDR" & " " & Val(lblConvert.Text)
            'ElseIf cmbCurrency.Text = "Choose One..." Then
            '    MsgBox("Select a country of your choice", MsgBoxStyle.Information)
            'End If

            Select Case cmbCurrency.Text
                Case "Nigeria"
                    lblConvert.Text = "NGN " & lblConvert.Text
                Case "USA"
                    lblConvert.Text = "$ " & lblConvert.Text
                Case "Kenyan"
                    lblConvert.Text = "KES " & lblConvert.Text
                Case "Brazil"
                    lblConvert.Text = "BRL " & lblConvert.Text
                Case "Canada"
                    lblConvert.Text = "C$ " & lblConvert.Text
                Case "India"
                    lblConvert.Text = "INR " & lblConvert.Text
                Case "Philippine"
                    lblConvert.Text = "PHP " & lblConvert.Text
                Case "Indonesia"
                    lblConvert.Text = "IDR " & lblConvert.Text
                Case "Choose One..."
                    MessageBox.Show("Select a country of your choice", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        Catch ex As Exception
            MessageBox.Show("Please enter a valid amount to convert.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles TabControl1.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button2.Click, Button16.Click, Button14.Click, Button12.Click, Button10.Click
        'Code for button 1 to 9 , 0

        If TypeOf sender Is Button Then
            Dim b As Button = CType(sender, Button) ' Safe casting
            If lblDisplay.Text = "0" Then
                lblDisplay.Text = b.Text
            Else
                lblDisplay.Text &= b.Text ' Use &= for better string concatenation
            End If
        Else
            ' Handle unexpected sender types (optional)
            'MessageBox.Show("Error: Unexpected control triggered this event.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub


    Private Sub Arithmetic_Function(sender As Object, e As EventArgs) Handles TabPage2.Click, Button17.Click, Button15.Click, Button13.Click, Button11.Click
        'Dim ops As Button = sender
        'firstnum = lblDisplay.Text
        'lblShowCal.Text = lblDisplay.Text
        'lblDisplay.Text = ""

        'op = ops.Text
        'lblShowCal.Text = lblShowCal.Text + " " + op

        Try
            Dim ops As Button = CType(sender, Button)
            firstnum = Val(lblDisplay.Text)
            op = ops.Text
            lblShowCal.Text = lblDisplay.Text & " " & op
            lblDisplay.Text = ""
        Catch ex As Exception
            MessageBox.Show("Please enter a valid number before choosing an operation.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lblDisplay.Text.Length > 0 Then
            lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PhoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles PhoneTextBox.TextChanged

    End Sub

    Private Sub Coppies_PipesTextBox_TextChanged(sender As Object, e As EventArgs) Handles Coppies_PipesTextBox.TextChanged
    End Sub

    Private Sub Plastic_PipeTextBox_TextChanged(sender As Object, e As EventArgs) Handles Plastic_PipeTextBox.TextChanged

    End Sub

    Private Sub TravelTextBox_TextChanged(sender As Object, e As EventArgs) Handles TravelTextBox.TextChanged

    End Sub
End Class
