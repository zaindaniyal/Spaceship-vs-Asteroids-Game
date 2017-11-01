Public Class Decision4

    Private Sub Decision4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Congratulations.Visible = False
        Congratulations3.Visible = False
        Congratulations4.Visible = False
        theGame1stLevel.Visible = False
        level3.Visible = False
        Level2.Visible = False
        Level4.Visible = False
        Decision.Visible = False
        Decision2.Visible = False
        decision3.Visible = False
    End Sub
    Private Sub cmdYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdYes.Click
        Me.Visible = False
        Me.Close()
        Level4.Visible = True
    End Sub

    Private Sub CmdNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNo.Click
        End
        Level4.Close()
    End Sub

End Class