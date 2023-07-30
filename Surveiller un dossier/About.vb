Public Class About


    'declaration des variables des coordonnées
    'declaration de nexpoint qui est de type point pour recevoir les val de coordonnées
    Dim x, y As Integer
    Dim newpoint As New Point


    Private Sub pnlHaut_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHaut.MouseDown
        ' mise dans l'evenement MouseDown
        ' code nous permettant de remplir les variables x et y de la position actuelle du control
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub pnlHaut_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHaut.MouseMove
        'mise dans l'evenement MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
End Class