Public Class Form1
    Dim milimetro As Double
    Dim centimetro As Double
    Dim decimetro As Double
    Dim decametro As Double
    Dim hectametro As Double
    Dim kilometro As Double
    Dim metro As Integer


    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        'captura de valores 
        metro = txtmtr.Text
        'operaciones
        milimetro = metro / 1000
        centimetro = metro / 100
        decimetro = metro / 10
        decametro = metro * 10
        hectametro = metro * 100
        kilometro = metro * 1000
        'salida
        txtml.Text = milimetro
        txtcm.Text = centimetro
        txtdcm.Text = decimetro
        txtdm.Text = decametro
        txthm.Text = hectametro
        txtkm.Text = kilometro
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click
        'limpiar textos
        txtmtr.Text = ""
        txtml.Text = ""
        txtcm.Text = ""
        txtdcm.Text = ""
        txtdm.Text = ""
        txthm.Text = ""
        txtkm.Text = ""
    End Sub


End Class
