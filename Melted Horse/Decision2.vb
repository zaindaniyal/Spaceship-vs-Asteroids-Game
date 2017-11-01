Public Class Decision2


    Private Sub Decision2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Congratulations.Visible = False
        Congratulations2.Visible = False
        Congratulations3.Visible = False
        Congratulations4.Visible = False
        theGame1stLevel.Visible = False
        level3.Visible = False
        Level4.Visible = False
        Decision.Visible = False
        decision3.Visible = False
        Decision4.Visible = False
    End Sub


    Private Sub cmdYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdYes.Click
        Me.Visible = False
        Me.Close()
        Level2.Visible = True
    End Sub

    Private Sub CmdNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNo.Click
        End
        Level2.Close()
    End Sub


End Class