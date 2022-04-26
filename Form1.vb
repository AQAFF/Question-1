Public Class Form1
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim strAmount As Double = CDbl(txtLoan.Text)
        Dim strYears As Integer = (cbYear.SelectedItem)
        Dim strsRate As Integer = (cbStart.SelectedItem)
        Dim strErate As Integer = (cbEnd.SelectedItem)
        Dim strStepR As Double = CDbl(txtRate.Text)
        Dim result As Decimal
        Dim rate As Double
        Dim arrange As String = "{0}                  {1}"
        Dim month As Integer = strYears * 12

        strAmount = Double.Parse(txtLoan.Text.ToString())
        strYears = Double.Parse(cbYear.GetItemText(cbYear.SelectedItem))
        strsRate = Double.Parse(cbStart.GetItemText(cbStart.SelectedItem))
        strErate = Double.Parse(cbEnd.GetItemText(cbEnd.SelectedItem))
        strStepR = Double.Parse(txtRate.Text.ToString())

        For rate = strsRate To strErate Step strStepR
            'Interest rate = (rate / 12) / 100
            result = -Pmt((rate / 12) / 100, month, strAmount)
            lbResult.Items.Add(String.Format(arrange, FormatPercent(rate.ToString / 100), FormatCurrency(result.ToString, 2)))
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strName As String
        lbName.Text = "Name: AMIR FIDAUS BIN FAUZI (10DDT20F1003)"
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtLoan.Text = ""
        txtRate.Text = ""
        cbEnd.ResetText()
        cbStart.ResetText()
        cbYear.ResetText()
        lbResult.Items.Clear()
    End Sub

    Private Sub btnCar_Click(sender As Object, e As EventArgs) Handles btnCar.Click
        MsgBox("
         Perodua Ativa
         5-Seater SUV
         From RM61,500

         Proton X50
         SUV
         From RM79,200

         Honda HR-V 
         Compact crossover SUV
         From RM104,000

         Nissan X-Trail
         Compact crossover SUV
         From RM128,630", MsgBoxStyle.OkCancel, "Car List")
    End Sub


End Class
