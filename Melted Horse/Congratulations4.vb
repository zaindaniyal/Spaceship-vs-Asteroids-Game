Public Class Congratulations4

    Private Sub Congratulations4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Congratulations.Visible = False
        Congratulations2.Visible = False
        Congratulations3.Visible = False
        theGame1stLevel.Visible = False
        Level2.Visible = False
        level3.Visible = False
        Level4.Visible = False
        Decision.Visible = False
        Decision2.Visible = False
        decision3.Visible = False
        Decision4.Visible = False
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        End
        Level4.Close()
    End Sub

End Class