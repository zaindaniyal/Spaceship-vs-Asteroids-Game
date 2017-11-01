Public Class Congratulations3


    Private Sub Congratulations3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Congratulations.Visible = False
        Congratulations4.Visible = False
        theGame1stLevel.Visible = False
        level3.Visible = False
        Level2.Visible = False
        Level4.Visible = False
        Decision.Visible = False
        Decision2.Visible = False
        decision3.Visible = False
        Decision4.Visible = False
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Me.Visible = False
        Me.Close()
        Level4.Visible = True
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        End
        level3.Close()
    End Sub

End Class