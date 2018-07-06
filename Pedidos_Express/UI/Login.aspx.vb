Imports BL

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub registrarseBTN_Click(sender As Object, e As EventArgs) Handles registrarseBTN.Click

        Dim manager As New BLManager()
        Dim userRole = manager.checkLogin(usernameTB.Text, passTB.Text)


    End Sub


End Class