﻿Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DepositButton.Click

        Label3.Text = "Amount Deposited Successfully"
        AmountToDepositTextBox.Clear()
        AmountToDepositTextBox.Enabled = False

    End Sub

    Private Sub AmountToDepositTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AmountToDepositTextBox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
            Label3.Text = "Amount Deposited Successfully"
            AmountToDepositTextBox.Clear()
            AmountToDepositTextBox.Enabled = False
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
