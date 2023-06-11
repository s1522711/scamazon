Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Then
            TextBox2.Text = TextBox2.Text + TextBox1.Text
        ElseIf TextBox1.Text IsNot "" Then
            TextBox2.Text = TextBox2.Text + vbNewLine + TextBox1.Text
        End If
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProgressBar1.Value = 0
        Timer1.Start()
        TextBox3.Text = "Your Order:" + vbNewLine + TextBox2.Text
        TextBox2.Text = ""
        TextBox3.Visible = True
        ProgressBar1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Button2.Enabled = False
        TextBox1.Visible = False
        Button1.Visible = False
        TextBox2.Visible = False
        Label1.Visible = False
        Label3.Text = "Connecting To Scamazon!"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.PerformStep()
            If ProgressBar1.Value = 20 Then
                Label3.Text = "Connecting To Payment Proccesor!"
            End If
            If ProgressBar1.Value = 50 Then
                Label3.Text = "Paying For The Order!"
            End If
            If ProgressBar1.Value = 80 Then
                Label3.Text = "Draining Your Bank Account!"
            End If
            If ProgressBar1.Value = 90 Then
                Label3.Text = "Sending Your Order!"
            End If
        Else
            Timer1.Stop()
            Label3.Text = "Order Delivered!"
            Button3.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Stop()
        Button2.Enabled = True
        TextBox3.Visible = False
        ProgressBar1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        TextBox1.Visible = True
        Button1.Visible = True
        TextBox2.Visible = True
        Label1.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button2.Enabled = True
        TextBox3.Visible = False
        ProgressBar1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        TextBox1.Visible = True
        Button1.Visible = True
        TextBox2.Visible = True
        Label1.Visible = True
        Button3.Visible = False
    End Sub
End Class
