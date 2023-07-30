Imports System.IO
Imports System.Text

Public Class frmMain

    'varible globale dela date
    Dim dteGlobal As Date


    'declaration des variables des coordonnées
    'declaration de nexpoint qui est de type point pour recevoir les val de coordonnées
    Dim x, y As Integer
    Dim newpoint As New Point

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDemarrer.Click
        'ici on recolter le chemin d'accès du dossier qu'on souhaite surveiller
        Try
            FileSystemWatcher.Path = txtcheminDossier.Text
            txtcheminDossier.Enabled = False

        Catch ex As Exception
            MsgBox("Erreur soft, verifier la validité de votre dossier ou si ou n'avez pas entrer le chemin d'accès d'un fichier", MsgBoxStyle.Critical, "Alarm soft")
        End Try
    End Sub

    Private Sub FileSystemWatcher1_Created(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher.Created
        'on utiliser la methode invoker, aussi AppendText pour continuer à ecrire dans la textbox. le e dans dans l'evenement contient les info sur le modification observer
        Invoke(New MethodInvoker(Sub() txtRapport.AppendText(vbNewLine & dteGlobal & vbNewLine & "l'element crée:" & vbNewLine & "Nom :" & e.Name & vbNewLine & "Chemin d'acces :" & e.FullPath & vbNewLine)))
    End Sub

    Private Sub FileSystemWatcher1_Deleted(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher.Deleted
        'on utiliser la methode invoker, aussi AppendText pour continuer à ecrire dans la textbox. le e dans dans l'evenement contient les info sur le modification observer
        Invoke(New MethodInvoker(Sub() txtRapport.AppendText(vbNewLine & dteGlobal & vbNewLine & "l'element supprimer:" & vbNewLine & "Nom :" & e.Name & vbNewLine & "Chemin d'acces :" & e.FullPath & vbNewLine)))
    End Sub

    Private Sub FileSystemWatcher1_Renamed(sender As Object, e As RenamedEventArgs) Handles FileSystemWatcher.Renamed
        'on utiliser la methode invoker, aussi AppendText pour continuer à ecrire dans la textbox. le e dans dans l'evenement contient les info sur le modification observer
        Invoke(New MethodInvoker(Sub() txtRapport.AppendText(vbNewLine & dteGlobal & vbNewLine & "l'element renommer:" & vbNewLine & "Nom :" & e.Name & vbNewLine & "Chemin d'acces :" & e.FullPath & vbNewLine)))
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExists.Click
        If IO.Directory.Exists(txtcheminDossier.Text) Then
            MsgBox("Le dossier existe, et est prêt à être surveillance", MsgBoxStyle.Information, "Alarm soft")
        Else
            MsgBox("Erreur dossier, veuiller verifier avant de demarrer la surveillance", MsgBoxStyle.Critical, "Alarm soft")
        End If
    End Sub


    Private Sub pnlHaut_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHaut.MouseDown
        moveForm()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        About.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSauver.Click
        txtcheminDossier.Enabled = True
    End Sub

    Private Sub pnlHaut_Paint(sender As Object, e As PaintEventArgs) Handles pnlHaut.Paint
        moveForm()
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

    Private Sub lblDossier_MouseDown(sender As Object, e As MouseEventArgs) Handles lblDossier.MouseDown
        moveForm()
    End Sub

    Private Sub lblDossier_MouseMove(sender As Object, e As MouseEventArgs) Handles lblDossier.MouseMove
        'mise dans l'evenement MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub lblGarger_MouseMove(sender As Object, e As MouseEventArgs) Handles lblGarger.MouseMove
        'mise dans l'evenement MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub lblGarger_MouseDown(sender As Object, e As MouseEventArgs) Handles lblGarger.MouseDown
        moveForm()
    End Sub

    Private Sub lblOeil_MouseDown(sender As Object, e As MouseEventArgs) Handles lblOeil.MouseDown
        moveForm()
    End Sub

    Private Sub lblOeil_MouseMove(sender As Object, e As MouseEventArgs) Handles lblOeil.MouseMove
        'mise dans l'evenement MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub lblUn_MouseMove(sender As Object, e As MouseEventArgs) Handles lblUn.MouseMove
        'mise dans l'evenement MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub lblUn_MouseDown(sender As Object, e As MouseEventArgs) Handles lblUn.MouseDown
        moveForm()
    End Sub

    Private Sub pnlHaut_DoubleClick(sender As Object, e As EventArgs) Handles pnlHaut.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub SurveillanceInterface_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Rapport()

        'on verifie si le txt est vide en ne considerant pas les espaces vides
        If (txtRapport.Text = String.Empty) Then

        Else
            'on créé un dossierRapport dans le meme dossier ou se trouver l'application
            Dim dossierRapport As String = Application.StartupPath & "/Rapport" 'le nom du dossier
            If Not Directory.Exists(dossierRapport) Then
                Directory.CreateDirectory(dossierRapport)
            End If

            'on crée le fichier qui enregistrera les comptes
            Dim FichierRapport As String = Application.StartupPath & "/Rapport/Rapport se surveillance.txt"

            'creation du séparateur 
            Dim split As String = "(*)" 'on crée un separateur qui va separé le rapport de son heure

            'on crée la variable date pour savoir l'heure de modification
            Dim dte As Date = Date.Now

            'on place le rapport dans la variable NouveauRapport
            Dim NouveauRapport As String = vbNewLine & vbNewLine & vbNewLine & split & dte & " Date et heure du Rapport générer " & split & vbNewLine & txtRapport.Text

            'recolte de la date du jour et l'heure pour que le rapport soient ordonnée
            Dim dteHeure As Date = Date.Now
            Dim dteEnText As String = dteHeure
            'dernier etape on met ces informations dans le fichier Rapport se surveillance.txt
            File.AppendAllText(FichierRapport, NouveauRapport) 'vbnewline pour separer les comptes...
        End If
    End Sub

    Sub moveForm()
        ' mise dans l'evenement MouseDown
        ' code nous permettant de remplir les variables x et y de la position actuelle du control
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        dteGlobal = Date.Now
    End Sub

    Private Sub SurveillanceInterface_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Rapport()

        'on verifie si le txt est vide en ne considerant pas les espaces vides
        If (txtRapport.Text = String.Empty) Then

        Else
            'on créé un dossierRapport dans le meme dossier ou se trouver l'application
            Dim dossierRapport As String = Application.StartupPath & "/Rapport" 'le nom du dossier
            If Not Directory.Exists(dossierRapport) Then
                Directory.CreateDirectory(dossierRapport)
            End If

            'on crée le fichier qui enregistrera les comptes
            Dim FichierRapport As String = Application.StartupPath & "/Rapport/Rapport se surveillance.txt"

            'creation du séparateur 
            Dim split As String = "(*)" 'on crée un separateur qui va separé le rapport de son heure

            'on crée la variable date pour savoir l'heure de modification
            Dim dte As Date = Date.Now

            'on place le rapport dans la variable NouveauRapport
            Dim NouveauRapport As String = vbNewLine & vbNewLine & vbNewLine & split & dte & " Date et heure du Rapport générer " & split & vbNewLine & txtRapport.Text

            'recolte de la date du jour et l'heure pour que le rapport soient ordonnée
            Dim dteHeure As Date = Date.Now
            Dim dteEnText As String = dteHeure
            'dernier etape on met ces informations dans le fichier Rapport se surveillance.txt
            File.AppendAllText(FichierRapport, NouveauRapport) 'vbnewline pour separer les comptes...
        End If
    End Sub

    Private Sub btnColler_Click(sender As Object, e As EventArgs) Handles btnDossier.Click



    End Sub



    'Fonction pour générer un rapport
    Sub Rapport()
        'on verifie si le txt est vide en ne considerant pas les espaces vides
        If (txtRapport.Text = String.Empty) Then
            MsgBox("Erreur, veiller verifier s'il y a des modifications apporter sur votre dossier", MsgBoxStyle.Critical)
        Else
            'on créé un dossierRapport dans le meme dossier ou se trouver l'application
            Dim dossierRapport As String = Application.StartupPath & "/Rapport" 'le nom du dossier
            If Not Directory.Exists(dossierRapport) Then
                Directory.CreateDirectory(dossierRapport)
            End If

            'on crée le fichier qui enregistrera les comptes
            Dim FichierRapport As String = Application.StartupPath & "/Rapport/Rapport de surveillance.txt"

            'creation du séparateur 
            Dim split As String = "(*)" 'on crée un separateur qui va separé le rapport de son heure

            'on crée la variable date pour savoir l'heure de modification
            Dim dte As Date = Date.Now

            'on place le rapport dans la variable NouveauRapport
            Dim NouveauRapport As String = vbNewLine & vbNewLine & vbNewLine & split & dte & " Date et heure du Rapport générer " & split & vbNewLine & txtRapport.Text

            'recolte de la date du jour et l'heure pour que le rapport soient ordonnée
            Dim dteHeure As Date = Date.Now
            Dim dteEnText As String = dteHeure
            'dernier etape on met ces informations dans le fichier Rapport se surveillance.txt
            File.AppendAllText(FichierRapport, NouveauRapport) 'vbnewline pour separer les comptes...
            MsgBox("Votre Rapport à été générer avec succès", MsgBoxStyle.Information)
        End If
    End Sub
End Class
