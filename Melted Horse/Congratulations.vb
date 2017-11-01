Public Class Congratulations


    Private Sub Congratulations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Congratulations2.Visible = False
        Congratulations3.Visible = False
        Congratulations4.Visible = False
        Level2.Visible = False
        level3.Visible = False
        Level4.Visible = False
        Decision.Visible = False
        Decision2.Visible = False
        decision3.Visible = False
        Decision4.Visible = False
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        End

        theGame1stLevel.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Me.Visible = False
        Level2.Visible = True
    End Sub


End Class