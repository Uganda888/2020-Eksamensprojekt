Imports System.ComponentModel

Public Class Form1



    Private Sub But_Mælk_Click(sender As Object, e As EventArgs) Handles But_Mælk.Click
        If mælk < 3 Then
            mælk += 1
        Else
            mælk = 0
        End If
        Label1.Text = mælk
    End Sub

    Private Sub But_Kaffe_Click(sender As Object, e As EventArgs) Handles But_Kaffe.Click
        drik = "kaffe"
        ValgTekst()
        But_Kaffe.Enabled = False
        But_Te.Enabled = True
    End Sub

    Private Sub But_Te_Click(sender As Object, e As EventArgs) Handles But_Te.Click
        drik = "te"
        ValgTekst()
        But_Kaffe.Enabled = True
        But_Te.Enabled = False
    End Sub

    Private Sub But_Bekræft_Click(sender As Object, e As EventArgs) Handles But_Bekræft.Click
        If drik <> Nothing Then
            Form_Automat.Show()
            Me.Hide()
        Else
            MsgBox("Hov! Du har ikke valgt kaffe/te")
        End If

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Form_Automat.Hide()
    End Sub

    Private Sub But_Sukker_Click(sender As Object, e As EventArgs) Handles But_Sukker.Click
        If sukker < 3 Then
            sukker += 1
        Else
            sukker = 0
        End If
        Label2.Text = sukker
    End Sub

    Private Sub ValgTekst()
        Label3.Text = "Du har bestilt " & drik
    End Sub

    Private Sub But_Annuller_Click(sender As Object, e As EventArgs) Handles But_Annuller.Click
        Controls.Clear()
        InitializeComponent()
        sukker = 0
        mælk = 0
    End Sub



    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form_Automat.Enabled = False

    End Sub


End Class
