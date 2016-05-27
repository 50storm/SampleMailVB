Imports System.Net
Imports System.Net.Mail


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim msg As New MailMessage("igarashi@hnps.co.jp", "igarashi@hnps.co.jp", "テスト", "これはテストメールです。")
        Dim SmtpClientObj As New SmtpClient()
        SmtpClientObj.Host = "smtp.hnps.co.jp"
        SmtpClientObj.Port = 587
        SmtpClientObj.DeliveryMethod = SmtpDeliveryMethod.Network

        Dim NTC As New System.Net.NetworkCredential()

        SmtpClientObj.Credentials = New NetworkCredential("igarashi@hnps.co.jp", "hiGara123")



        'メッセージを送信する
        SmtpClientObj.Send(msg)
        msg.Dispose()
        SmtpClientObj.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub
End Class
