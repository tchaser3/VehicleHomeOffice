'Title:         Close Program
'Date:          6-22-15
'Author:        Terry Holmes

'Descritpion:   This form will close the program

Option Strict On

Public Class CloseProgram

    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click

        'This sets the global variable
        LastTransaction.Show()
        Logon.Close()
        Me.Close()

    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click

        'This sets the global variable
        Me.Close()

    End Sub

End Class