Public Class decision3


    Private Sub decision3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Congratulations.Visible = False
        Congratulations3.Visible = False
        Congratulations4.Visible = False
        theGame1stLevel.Visible = False
        Level2.Visible = False
        Level4.Visible = False
        Decision.Visible = False
        Decision2.Visible = False
        Decision4.Visible = False
    End Sub
    Private Sub CmdNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNo.Click
        End
        level3.Close()
    End Sub

    Private Sub cmdYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdYes.Click
        Me.Visible = False
        Me.Close()
        level3.Visible = True
    End Sub

End Class