Imports System.ComponentModel

Public Class Form_Automat
    Dim taeller As Integer


    Private Sub Form_Automat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        taeller += 1
        Me.Text = taeller
        Select Case taeller
            Case 1
                Lbl_Vo.BackColor = Color.Red
                Lbl_Bp.BackColor = Color.Red
            Case 4
                Lbl_Bp.BackColor = Color.Green
            Case 6

                If drik = "kaffe" Then
                    Lbl_Kd.BackColor = Color.Red
                Else
                    Lbl_Td.BackColor = Color.Red
                End If



            Case 12
                If drik = "kaffe" Then
                    Lbl_Kd.BackColor = Color.Green
                Else
                    Lbl_Td.BackColor = Color.Green
                End If
                Lbl_Td.Refresh()
                Lbl_Kd.Refresh()

                If sukker > 0 Then
                    For i = 1 To sukker
                        Lbl_S.BackColor = Color.Red
                        Lbl_S.Refresh()
                        Threading.Thread.Sleep(500)
                        Lbl_S.BackColor = Color.Green
                        Lbl_S.Refresh()
                        Threading.Thread.Sleep(500)

                    Next
                End If
                If mælk > 0 Then
                    For i = 1 To mælk
                        Lbl_M.BackColor = Color.Red
                        Lbl_M.Refresh()
                        Threading.Thread.Sleep(500)
                        Lbl_M.BackColor = Color.Green
                        Lbl_M.Refresh()
                        Threading.Thread.Sleep(500)

                    Next
                End If
                Lbl_Vo.BackColor = Color.Green
                Lbl_Vd.BackColor = Color.Red

            Case 20
                Lbl_Vd.BackColor = Color.Green
            Case 30
                Lbl_Display.Text = "Klar!"
                Lbl_Færdig.BackColor = Color.Green
            Case 45

                taeller = 0
                Timer1.Stop()
                MsgBox("TAG NU DIN BESTILLING!!!!")
                Form1.Show()


        End Select
    End Sub

    Private Sub Form_Automat_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Show()

    End Sub
End Class