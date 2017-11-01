Public Class Decision


    Private Sub Decision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Congratulations.Visible = False
        Congratulations2.Visible = False
        Congratulations3.Visible = False
        Congratulations4.Visible = False
        Level2.Visible = False
        level3.Visible = False
        Level4.Visible = False
        Decision2.Visible = False
        decision3.Visible = False
        Decision4.Visible = False
    End Sub

    Private Sub CmdNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNo.Click
        End
        theGame1stLevel.Close()
    End Sub

    Private Sub cmdYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdYes.Click
        Me.Visible = False
        Me.Close()
        theGame1stLevel.Visible = True


    End Sub


End Class