Public Class Level2

    'these are all the global variables i've used....
    Dim speed As Integer = 10
    Dim isMovingLeft As Boolean = False
    Dim isMovingRight As Boolean = False
    Dim isMovingUp As Boolean = False
    Dim isMovingDown As Boolean = False
    'Dim isPowerUp As Boolean = False
    'Dim isPowerDown As Boolean = False
    Dim sr71 As New Plane
    Dim isBouncingUp As Boolean = True
    Dim isBouncingLeft As Boolean = True
    Dim asteroidSpeed As Integer = 20
    Dim isUp As Boolean = False
    Dim isLeft As Boolean = False
    Dim isGoneMentalup As Boolean = False
    Dim isGoneMentalLeft As Boolean = False
    Dim isGoneCrazyUp As Boolean = True
    Dim isGoneCrazyLeft As Boolean = True





    'this bottom sub runs when the foams loads..
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sr71 = New Plane
        pctCloseSelected.Visible = False
        'Plane.Image = imgPlane.Images(1)
        pctDiomondFinal.Visible = False
        Congratulations.Visible = False
        Congratulations2.Visible = False
        Congratulations3.Visible = False
        Congratulations4.Visible = False
        theGame1stLevel.Visible = False
        level3.Visible = False
        Level4.Visible = False
        Decision.Visible = False
        Decision2.Visible = False
        decision3.Visible = False
        Decision4.Visible = False
    End Sub

    'this buttom sub makes sure that the plane moves in the right direction when a key is pressed
    Private Sub tmrPlane_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlane.Tick
        If isMovingLeft = True Then pctPlane.Left = pctPlane.Left - speed
        If isMovingRight = True Then pctPlane.Left = pctPlane.Left + speed
        If isMovingUp = True Then pctPlane.Top = pctPlane.Top - speed
        If isMovingDown = True Then pctPlane.Top = pctPlane.Top + speed


        pctGreenEnergy.Width = sr71.energy



        'this level is slightly made harder by increasing the damage done to the plane by the asteroids
        If pctPlane.Bounds.IntersectsWith(pctAsteroid.Bounds) Then
            sr71.damage(25)

        End If


        If pctPlane.Bounds.IntersectsWith(pctAsteroidSlow.Bounds) Then
            sr71.damage(20)
        End If

        If pctPlane.Bounds.IntersectsWith(pctAsteroid2.Bounds) Then
            sr71.damage(25)
        End If

        If pctPlane.Bounds.IntersectsWith(pctAsteroid3.Bounds) Then
            sr71.damage(35)
        End If



        'notice tht this time i've used a different decision window....(not effeicient)
        If pctGreenEnergy.Width <= 0 Then
            Decision2.Visible = True
            pctPlane.Left = 10
            pctPlane.Top = 264
            pctGreenEnergy.Width = 567
            sr71.energy = 567
            isMovingDown = False
            isMovingLeft = False
            isMovingRight = False
            isMovingUp = False
            pctDiomond.Visible = True
            pctDiomondFinal.Visible = False
        End If


        If sr71.energy <= 0 Then
            Decision2.Visible = True
            pctPlane.Left = 10
            pctPlane.Top = 264
            pctGreenEnergy.Width = 567
            sr71.energy = 567
            pctDiomond.Visible = True
            pctDiomondFinal.Visible = False
            isMovingDown = False
            isMovingLeft = False
            isMovingRight = False
            isMovingUp = False
        End If


        If pctPlane.Bounds.IntersectsWith(pctXtraTopBoundry.Bounds) Then
            pctPlane.Top = pctPlane.Top + speed
        End If

        If pctPlane.Bounds.IntersectsWith(pctLeftPlaneBoundry.Bounds) Then
            pctPlane.Left = pctPlane.Left + speed
        End If

        If pctPlane.Bounds.IntersectsWith(pctRightPlaneBoundry.Bounds) Then
            pctPlane.Left = pctPlane.Left - speed
        End If


        If pctPlane.Bounds.IntersectsWith(pctDiomond.Bounds) Then
            pctDiomondFinal.Visible = True
            pctDiomond.Visible = False
        End If


        If pctDiomondFinal.Visible = True And pctPlane.Bounds.IntersectsWith(pctDiomondFinal.Bounds) Then
            Me.Visible = False
            Congratulations2.Visible = True
            pctGreenEnergy.Width = 567
            sr71.energy = 567
            pctPlane.Left = 9
            pctPlane.Top = 274
        End If


        'notice 2 more picture boxes have been introduced to not alllow the plane to go the easy way.
        If pctPlane.Bounds.IntersectsWith(pctPlaneBottomBoundryLeft.Bounds) Then
            pctPlane.Left = pctPlane.Left - speed
        End If

        If pctPlane.Bounds.IntersectsWith(pctPlaneBottomBoundryRight.Bounds) Then
            pctPlane.Left = pctPlane.Left + speed
        End If


        'If isPowerUp = True Then
        'sr71.rebuild(20)
        'End If
        '
        'If isPowerDown = True Then
        'sr71.damage(13)
        'End If
        '
        '
        'If pctPlane.Bounds.IntersectsWith(pctPowerUp.Bounds) Then
        'isPowerUp = True
        'pctPowerUp.Visible = False
        'End If
        '
        'If pctPlane.Bounds.IntersectsWith(pctPowerDown.Bounds) Then
        'isPowerDown = True
        'pctPowerDown.Visible = False
        '
        'End If


        'this level is slightly made harder by increasing the damage done to the plane by the asteroids
        If pctPlane.Bounds.IntersectsWith(pctAsteroid4.Bounds) Then
            sr71.damage(45)
        End If


    End Sub

    'this buttom sub makes the plane move when the key is pressed.
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Left Then
            isMovingLeft = True
            pctPlane.Image = imgPlane.Images(0)
        End If

        If e.KeyValue = Keys.Right Then
            isMovingRight = True
            pctPlane.Image = imgPlane.Images(1)
        End If

        If e.KeyValue = Keys.Up Then
            isMovingUp = True
            pctPlane.Image = imgPlaneVertical.Images(1)
        End If

        If e.KeyValue = Keys.Down Then
            isMovingDown = True
            pctPlane.Image = imgPlaneVertical.Images(0)
        End If


        If e.KeyValue = Keys.P Then
            pctPlane.Left = 10
            pctPlane.Top = 266
        End If





    End Sub

    'this buttom sub makes the plane stop or change direction when a key is released.
    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue = Keys.Left Then isMovingLeft = False
        If e.KeyValue = Keys.Right Then isMovingRight = False
        If e.KeyValue = Keys.Up Then isMovingUp = False
        If e.KeyValue = Keys.Down Then isMovingDown = False

    End Sub


    'the next 4 subs are basically to exit from the game....
    Private Sub pctCloseSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctCloseSelected.Click
        End
    End Sub


    Private Sub Form1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        pctCloseSelected.Visible = False
        pctClose.Visible = True
    End Sub
    'this ^^ sub displays the exit icon for exiting from the game when you hover over the exit picturebox.


    Private Sub pctClose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pctClose.MouseHover
        pctClose.Visible = False
        pctCloseSelected.Visible = True
    End Sub
    'this ^^ sub displays the selected exit picturebox.


    Private Sub pctClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctClose.Click
        End
    End Sub



    'this buttom sub makes 4 asteroids go round & round the screen
    Private Sub tmrAstroiod_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAsteroid.Tick

        'Dim isBouncingUp As Boolean = False
        'Dim isBouncingLeft As Boolean = False
        'the few lines of code is for asteroid.
        If isBouncingLeft = True Then
            pctAsteroid.Left = pctAsteroid.Left - asteroidSpeed
            If pctAsteroid.Left <= 0 Then isBouncingLeft = False
        Else
            pctAsteroid.Left = pctAsteroid.Left + asteroidSpeed
            If pctAsteroid.Left >= (Me.Width - pctAsteroid.Width) Then isBouncingLeft = True
        End If

        If isBouncingUp = True Then
            pctAsteroid.Top = pctAsteroid.Top - asteroidSpeed
            If pctAsteroid.Top <= 0 Then isBouncingUp = False
        Else
            pctAsteroid.Top = pctAsteroid.Top + asteroidSpeed
            If pctAsteroid.Top >= (Me.Height - pctAsteroid.Height) Then isBouncingUp = True
        End If

        If pctAsteroid.Bounds.IntersectsWith(pctXtraLeftBoundry.Bounds) Then
            isBouncingLeft = False
        End If

        If pctAsteroid.Bounds.IntersectsWith(pctXtraTopBoundry.Bounds) Then
            isBouncingUp = False
        End If

        If pctAsteroid.Bounds.IntersectsWith(pctXtraRightBoundry.Bounds) Then
            isBouncingLeft = True
        End If

        If pctAsteroid.Bounds.IntersectsWith(pctXtraBottomBoundry.Bounds) Then
            isBouncingUp = True
        End If





        'the next set of code is for asteroid 2

        If isGoneMentalLeft = True Then
            pctAsteroid2.Left = pctAsteroid2.Left - asteroidSpeed
            If pctAsteroid2.Left <= 0 Then isGoneMentalLeft = False
        Else
            pctAsteroid2.Left = pctAsteroid2.Left + asteroidSpeed
            If pctAsteroid2.Left >= (Me.Width - pctAsteroid2.Width) Then isGoneMentalLeft = True
        End If

        If isGoneMentalup = True Then
            pctAsteroid2.Top = pctAsteroid2.Top - asteroidSpeed
            If pctAsteroid2.Top <= 0 Then isGoneMentalup = False
        Else
            pctAsteroid2.Top = pctAsteroid2.Top + asteroidSpeed
            If pctAsteroid2.Top >= (Me.Height - pctAsteroid2.Height) Then isGoneMentalup = True
        End If

        If pctAsteroid2.Bounds.IntersectsWith(pctXtraLeftBoundry.Bounds) Then
            isGoneMentalLeft = False
        End If

        If pctAsteroid2.Bounds.IntersectsWith(pctXtraTopBoundry.Bounds) Then
            isGoneMentalup = False
        End If

        If pctAsteroid2.Bounds.IntersectsWith(pctXtraRightBoundry.Bounds) Then
            isGoneMentalLeft = True
        End If


        If pctAsteroid2.Bounds.IntersectsWith(pctXtraBottomBoundry.Bounds) Then
            isGoneMentalup = True
        End If

        'the next set of code is for asteroid 3

        Dim asteroid3speed As Integer = 50

        If isGoneCrazyUp = True Then
            pctAsteroid3.Top = pctAsteroid3.Top - asteroid3speed
        End If

        If isGoneCrazyUp = False Then
            pctAsteroid3.Top = pctAsteroid3.Top + asteroid3speed

        End If




        If pctAsteroid3.Bounds.IntersectsWith(pctXtraTopBoundry.Bounds) Then
            isGoneCrazyUp = False
        End If


        If pctAsteroid3.Bounds.IntersectsWith(pctXtraBottomBoundry.Bounds) Then
            isGoneCrazyUp = True
        End If


        'the set of lines are dedicated to asteroid 4... which seems to be the most violent
        'notice this asteroid only goes right and left...
        If isGoneCrazyLeft = True Then
            pctAsteroid4.Left = pctAsteroid4.Left - asteroid3speed
        End If


        If isGoneCrazyLeft = False Then
            pctAsteroid4.Left = pctAsteroid4.Left + asteroid3speed
        End If

        If pctAsteroid4.Bounds.IntersectsWith(pctXtraRightBoundry.Bounds) Then
            isGoneCrazyLeft = True
        End If


        If pctAsteroid4.Bounds.IntersectsWith(pctXtraLeftBoundry.Bounds) Then
            isGoneCrazyLeft = False
        End If

    End Sub


    'this botttom sub is for the slow asteroid.
    Private Sub tmrAsteroidSlow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAsteroidSlow.Tick

        'Dim isUp As Boolean = False
        'Dim isLeft As Boolean = False
        'the next few lines of code for the only slow asteroid.
        If isLeft = True Then
            pctAsteroidSlow.Left = pctAsteroidSlow.Left - asteroidSpeed
            If pctAsteroidSlow.Left <= 0 Then isLeft = False
        Else
            pctAsteroidSlow.Left = pctAsteroidSlow.Left + asteroidSpeed
            If pctAsteroidSlow.Left >= (Me.Width - pctAsteroidSlow.Width) Then isLeft = True
        End If

        If isUp = True Then
            pctAsteroidSlow.Top = pctAsteroidSlow.Top - asteroidSpeed
            If pctAsteroidSlow.Top <= 0 Then isUp = False
        Else
            pctAsteroidSlow.Top = pctAsteroidSlow.Top + asteroidSpeed
            If pctAsteroidSlow.Top >= (Me.Height - pctAsteroidSlow.Height) Then isUp = True
        End If

        If pctAsteroidSlow.Bounds.IntersectsWith(pctXtraLeftBoundry.Bounds) Then
            isLeft = False
        End If

        If pctAsteroidSlow.Bounds.IntersectsWith(pctXtraTopBoundry.Bounds) Then
            isUp = False
        End If

        If pctAsteroidSlow.Bounds.IntersectsWith(pctXtraRightBoundry.Bounds) Then
            isLeft = True
        End If

        If pctAsteroidSlow.Bounds.IntersectsWith(pctXtraBottomBoundry.Bounds) Then
            isUp = True
        End If

    End Sub

End Class




