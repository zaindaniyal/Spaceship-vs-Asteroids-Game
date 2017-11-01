Public Class Plane

    Public energy As Integer

    Public Sub New()
        energy = 567
    End Sub

    Public Sub damage(ByVal destruction As Integer)
        energy = energy - destruction
        If energy < 0 Then energy = 0
    End Sub

    Public Sub rebuild(ByVal heal As Integer)
        energy = energy + heal
        If energy > 567 Then energy = 567
    End Sub

End Class
