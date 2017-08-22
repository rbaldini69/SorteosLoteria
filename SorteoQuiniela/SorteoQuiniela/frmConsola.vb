Imports System.IO
Imports System.ComponentModel
Public Class frmConsola

    Dim posiciones(19) As String
    Dim auxUbicacion As String
    Dim num As Integer = 0
    Dim num2 As Integer = 0
    Dim nombreArchivo As String
    Dim iniciado As Boolean = False
    Dim HoraInicio As Date
    Dim HoraCierre As Date
    Dim distanciax1 As Integer
    Dim distanciay1 As Integer
    Dim distanciax2 As Integer
    Dim distanciay2 As Integer
    Dim distanciax3 As Integer
    Dim distanciay3 As Integer
    Dim distanciax4 As Integer
    Dim distanciay4 As Integer
    Dim terminaciones As String() = {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"}
    Dim sorteosRestantes As Integer
    Dim terminado As Boolean
    Dim ordenLetras As String
    Dim CantRepetidosPoseada As Integer = 0
    Dim arrayTempPoseada() As String
    Dim guardarArchivo As New SaveFileDialog
    Dim repetidos(19, 0) As String




    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        'Dim aux As Integer
        'aux = txtNumSorteado.Text


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim formGrilla As New grillaSorteo
        'formGrilla.MdiParent = Me
        'formGrilla.Show()
        'formGrilla.StartPosition = FormStartPosition.Manual
        Me.txtNumSorteo.Select()
        'grillaSorteo.txtDatosSorteo.Text = "SORTEO N° " & Me.txtNumSorteo.Text & "BUENOS AIRES, " & Me.dtpFechaSorteo.Text
        grillaSorteo.Show()
        'COMENTADO PARA PRUEBAS
        grillaSorteo.Location = New Point(1500, 100)
        grillaSorteo.WindowState = FormWindowState.Maximized


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        soloNumeros(e)
    End Sub
#Region "filtro solo numeros"
    Private Sub soloNumeros(e As KeyPressEventArgs)
        Dim aux As Integer
        aux = Asc(e.KeyChar)
        If aux < 48 Or aux > 57 Then
            e.KeyChar = Chr(0)
        Else
            e.KeyChar = Chr(aux)
        End If
    End Sub
#End Region
#Region "filtro solo letras"
    Private Sub soloLetras(e As KeyPressEventArgs)
        Dim aux As Integer
        aux = Asc(e.KeyChar)
        If aux < 48 Or aux > 57 Then
            e.KeyChar = Chr(aux).ToString().ToUpper()

        Else
            e.KeyChar = Chr(0)
        End If
    End Sub
    Private Function OrdenarLetras(palabra As String) As String
        Dim textoOrdenado As String = ""
        Dim EsVocal As String = "EAIOU"
        Dim grupoVocales() As Char
        Dim grupoConsonantes() As Char
        Dim dimensionConsonantes As Integer = 0
        Dim dimensionVocales As Integer = 0
        For i = 1 To Len(palabra)
            If InStr(EsVocal, (Mid(palabra, i, 1)), CompareMethod.Text) = 0 Then
                dimensionConsonantes += 1
                Array.Resize(grupoConsonantes, dimensionConsonantes)
                grupoConsonantes(dimensionConsonantes - 1) = Mid(palabra, i)
            Else
                dimensionVocales += 1
                Array.Resize(grupoVocales, dimensionVocales)
                grupoVocales(dimensionVocales - 1) = Mid(palabra, i)
            End If
        Next
        If grupoVocales IsNot Nothing Then

            Array.Sort(grupoVocales)
            For i = 0 To grupoVocales.Count() - 1
                textoOrdenado = textoOrdenado & grupoVocales(i)
            Next
        End If
        If grupoConsonantes IsNot Nothing Then
            Array.Sort(grupoConsonantes)
            For i = 0 To grupoConsonantes.Count() - 1
                textoOrdenado = textoOrdenado & grupoConsonantes(i)
            Next

        End If


        Return textoOrdenado
    End Function
#End Region



    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtUnidad_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub txtDecena_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCentena_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtUdeMil_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Ubicacion_TextChanged(sender As Object, e As EventArgs)

    End Sub
#Region "ACEPTAR SORTEO"
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
#End Region
#Region "INICIALIZAR SORTEO"
    Private Sub InicializarSorteo()
        For Each ctl As Control In Me.Controls

            If TypeOf (ctl) Is TextBox Then
                ctl.Text = ""
                Me.txtNumSorteo.Focus()
            End If

        Next

        grillaSorteo.PctBolillero1.Location = New Point(37, 56)
        grillaSorteo.pctBolillero2.Location = New Point(355, 56)
        grillaSorteo.pctBolillero3.Location = New Point(673, 56)
        grillaSorteo.pctBolillero4.Location = New Point(994, 56)
        'grillaSorteo.PctBolillero0.Location = New Point(408, 56)


        grillaSorteo.PctBolillero1.Size = New Size(300, 300)
        grillaSorteo.pctBolillero2.Size = New Size(300, 300)
        grillaSorteo.pctBolillero3.Size = New Size(300, 300)
        grillaSorteo.pctBolillero4.Size = New Size(300, 300)


    End Sub
    Private Sub NuevaExtraccion()
        'If grillaSorteo.resolucionCambiada = True Then
        'grillaSorteo.escalar1()
        'grillaSorteo.resolucionCambiada = False
        'End If
        For Each ctl As Control In Me.gbxNumerosSorteados.Controls

            If TypeOf (ctl) Is TextBox Then
                ctl.Text = ""
                Me.txtUdeMil.Focus()
            End If

        Next
        grillaSorteo.PctBolillero1.Image = My.Resources.fondo_bolilla
        grillaSorteo.pctBolillero2.Image = My.Resources.fondo_bolilla
        grillaSorteo.pctBolillero3.Image = My.Resources.fondo_bolilla
        grillaSorteo.pctBolillero4.Image = My.Resources.fondo_bolilla

        grillaSorteo.PctBolillero1.Location = New Point(34, 206)
        grillaSorteo.pctBolillero2.Location = New Point(347, 206)
        grillaSorteo.pctBolillero3.Location = New Point(651, 206)
        grillaSorteo.pctBolillero4.Location = New Point(954, 206)
        'grillaSorteo.PctBolillero0.Location = New Point(408, 56)


        grillaSorteo.PctBolillero1.Size = New Size(300, 300)
        grillaSorteo.pctBolillero2.Size = New Size(300, 300)
        grillaSorteo.pctBolillero3.Size = New Size(300, 300)
        grillaSorteo.pctBolillero4.Size = New Size(300, 300)
        'grillaSorteo.PctBolillero0.Size = New Size(300, 300)


        For index = 1 To 20
            grillaSorteo.Controls("TextBox" & index).Location = New Point(grillaSorteo.Controls("TextBox" & index).Location.X, grillaSorteo.Controls("TextBox" & index).Location.Y + 220)
            grillaSorteo.Controls("lblOrden" & index).Location = New Point(grillaSorteo.Controls("lblOrden" & index).Location.X, grillaSorteo.Controls("lblorden" & index).Location.Y + 220)
            grillaSorteo.Controls("TextBox" & index).Visible = False
            grillaSorteo.Controls("lblOrden" & index).Visible = False

        Next
        For index = 15 To 0 Step -5
            grillaSorteo.Controls("lblPos" & index).Location = New Point(grillaSorteo.Controls("lblPos" & index).Location.X, grillaSorteo.Controls("lblPos" & index).Location.Y + 220)
            grillaSorteo.Controls("lblRes" & index).Location = New Point(grillaSorteo.Controls("lblRes" & index).Location.X, grillaSorteo.Controls("lblRes" & index).Location.Y + 220)

            grillaSorteo.Controls("lblPos" & index).Visible = False
            grillaSorteo.Controls("lblRes" & index).Visible = False

        Next
        'grillaSorteo.escalar1()

    End Sub
#End Region

    Private Sub txtUnidad_KeyPress(sender As Object, e As KeyPressEventArgs)
        soloNumeros(e)
    End Sub

    Private Sub txtDecena_KeyPress(sender As Object, e As KeyPressEventArgs)
        soloNumeros(e)
    End Sub

    Private Sub txtCentena_KeyPress(sender As Object, e As KeyPressEventArgs)
        soloNumeros(e)
    End Sub

    Private Sub txtUdeMil_KeyPress(sender As Object, e As KeyPressEventArgs)
        soloNumeros(e)
    End Sub

    Private Sub Ubicacion_KeyPress(sender As Object, e As KeyPressEventArgs)
        soloNumeros(e)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblFecha_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblNumSorteo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbxNumerosSorteados.Enter

    End Sub
#Region "boton aceptar"

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'nombreArchivo = "c:/sorteos/SN" & Me.txtNumSorteo.Text & ".txt"

        For Each ctl As Control In Me.gbxNumerosSorteados.Controls

            If TypeOf (ctl) Is TextBox And ctl.Text = "" Then
                MsgBox("Aun quedan elementos del sorteo por cargar " & "'" & ctl.Name & "'", vbOKOnly, "Elementos faltantes")
                ctl.Focus()
                Exit Sub
            End If

        Next
        If nombreArchivo = "" Then
            guardarArchivoNuevo()
        End If
        auxUbicacion = "textbox" & Me.Ubicacion.Text
        If Me.Ubicacion.Text > 0 And Me.Ubicacion.Text <= 20 Then
            If grillaSorteo.Controls(auxUbicacion).Text = "" Then
                grillaSorteo.lblUbicacion.Location = New Point(347, 415)
                grillaSorteo.lblUbicacion.Text = "Ubicacion " & Me.Ubicacion.Text
                grillaSorteo.lblUbicacion.Visible = True

                If MessageBox.Show("Ubicacion " & Ubicacion.Text & ": " & txtNumSorteado.Text & "?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    grillaSorteo.lblUbicacion.Visible = False
                    grillaSorteo.Controls(auxUbicacion).Text = Me.txtNumSorteado.Text
                    Me.distanciax1 = ((grillaSorteo.Controls(auxUbicacion).Location.X + 50 - (grillaSorteo.PctBolillero1.Location.X)) / 30)
                    Me.distanciay1 = ((grillaSorteo.Controls(auxUbicacion).Location.Y + 25 - (grillaSorteo.PctBolillero1.Location.Y)) / 30)
                    Me.distanciax2 = ((grillaSorteo.Controls(auxUbicacion).Location.X + 50 - (grillaSorteo.pctBolillero2.Location.X)) / 30)
                    Me.distanciay2 = ((grillaSorteo.Controls(auxUbicacion).Location.Y + 25 - (grillaSorteo.pctBolillero2.Location.Y)) / 30)
                    Me.distanciax3 = ((grillaSorteo.Controls(auxUbicacion).Location.X + 50 - (grillaSorteo.pctBolillero3.Location.X)) / 30)
                    Me.distanciay3 = ((grillaSorteo.Controls(auxUbicacion).Location.Y + 25 - (grillaSorteo.pctBolillero3.Location.Y)) / 30)
                    Me.distanciax4 = ((grillaSorteo.Controls(auxUbicacion).Location.X + 50 - (grillaSorteo.pctBolillero4.Location.X)) / 30)
                    Me.distanciay4 = ((grillaSorteo.Controls(auxUbicacion).Location.Y + 25 - (grillaSorteo.pctBolillero4.Location.Y)) / 30)

                    Timer1.Enabled = True
                    Timer2.Enabled = True

                    posiciones(CInt(Ubicacion.Text) - 1) = Me.txtNumSorteado.Text
                    ' Timer1.Enabled = True
                    ListBox1.Items.Clear()

                    Using escritor As StreamWriter = New StreamWriter(nombreArchivo, False)
                        escritor.Write("Sorteo N°: " & Me.txtNumSorteo.Text & vbCrLf & "Fecha: " & dtpFechaSorteo.Text &
                                " Hora Inicio: " & HoraInicio & vbCrLf)
                        'RELLENO EL LISTBOX Y SOBRESCRIBO EL ARCHIVO
                        For index = 1 To posiciones.GetUpperBound(0) + 1
                            ListBox1.Items.Add(index & " " & posiciones(index - 1))
                            escritor.WriteLine(index & " " & posiciones(index - 1))
                        Next

                    End Using
                    'NuevaExtraccion()

                End If
            Else
                grillaSorteo.lblUbicacion.Text = "Correccion Ubicacion " & Me.Ubicacion.Text
                If MessageBox.Show("ya existe el sorteo para la ubicacion seleccionada - reemplazar?", "Error. Duplicado", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Me.distanciax1 = ((grillaSorteo.Controls(auxUbicacion).Location.X + 50 - (grillaSorteo.PctBolillero1.Location.X)) / 30)
                    Me.distanciay1 = ((grillaSorteo.Controls(auxUbicacion).Location.Y + 25 - (grillaSorteo.PctBolillero1.Location.Y)) / 30)
                    Me.distanciax2 = ((grillaSorteo.Controls(auxUbicacion).Location.X + 50 - (grillaSorteo.pctBolillero2.Location.X)) / 30)
                    Me.distanciay2 = ((grillaSorteo.Controls(auxUbicacion).Location.Y + 25 - (grillaSorteo.pctBolillero2.Location.Y)) / 30)
                    Me.distanciax3 = ((grillaSorteo.Controls(auxUbicacion).Location.X + 50 - (grillaSorteo.pctBolillero3.Location.X)) / 30)
                    Me.distanciay3 = ((grillaSorteo.Controls(auxUbicacion).Location.Y + 25 - (grillaSorteo.pctBolillero3.Location.Y)) / 30)
                    Me.distanciax4 = ((grillaSorteo.Controls(auxUbicacion).Location.X + 50 - (grillaSorteo.pctBolillero4.Location.X)) / 30)
                    Me.distanciay4 = ((grillaSorteo.Controls(auxUbicacion).Location.Y + 25 - (grillaSorteo.pctBolillero4.Location.Y)) / 30)

                    grillaSorteo.Controls(auxUbicacion).Text = Me.txtNumSorteado.Text
                    Timer1.Enabled = True
                    Timer2.Enabled = True

                    posiciones(CInt(Ubicacion.Text) - 1) = Me.txtNumSorteado.Text
                    ListBox1.Items.Clear()
                    Using escritor As StreamWriter = New StreamWriter(nombreArchivo, False)
                        escritor.Write("Sorteo N°: " & Me.txtNumSorteo.Text & vbCrLf & "Fecha: " & dtpFechaSorteo.Text &
                                " Hora Inicio: " & HoraInicio & vbCrLf)
                        For index = 1 To posiciones.GetUpperBound(0) + 1
                            ListBox1.Items.Add(index & " " & posiciones(index - 1))
                            escritor.WriteLine(index & " " & posiciones(index - 1))

                        Next

                    End Using
                    'NuevaExtraccion()
                Else
                    Exit Sub



                End If

            End If
        Else
            MsgBox("Elija un premio entre 1 y 20", MsgBoxStyle.Critical, "Error!")
            Exit Sub
            '          grillaSorteo.PctBolillero1.Left += grillaSorteo.PctBolillero1.Left + 50
        End If

        terminaciones(CInt(Ubicacion.Text) - 1) = Mid(Me.txtNumSorteado.Text, 3)
        For index = 1 To 20
            grillaSorteo.Controls("TextBox" & index).Visible = True
            grillaSorteo.Controls("lblOrden" & index).Visible = True

            If StrComp(terminaciones(index - 1), "0") = 0 Then
                sorteosRestantes += 1

            End If

        Next
        For index = 15 To 0 Step -5
            grillaSorteo.Controls("lblPos" & index).Visible = True
            grillaSorteo.Controls("lblRes" & index).Visible = True
        Next

        If sorteosRestantes = 0 Then
            terminado = True
            'grillaSorteo.PctBolillero1.Visible = False
            'grillaSorteo.pctBolillero2.Visible = False
            'grillaSorteo.pctBolillero3.Visible = False
            'grillaSorteo.pctBolillero4.Visible = False

            Me.gbxNumerosSorteados.Enabled = False

            For index = 1 To 20

                grillaSorteo.Controls("textbox" & index).Location = New Point(grillaSorteo.Controls("textbox" & index).Location.X - 250, grillaSorteo.Controls("textbox" & index).Location.Y)
                grillaSorteo.Controls("lblOrden" & index).Location = New Point(grillaSorteo.Controls("lblOrden" & index).Location.X - 250, grillaSorteo.Controls("lblOrden" & index).Location.Y)
            Next
            For index = 15 To 0 Step -5
                grillaSorteo.Controls("lblPos" & index).Location = New Point(grillaSorteo.Controls("lblPos" & index).Location.X - 250, grillaSorteo.Controls("lblPos" & index).Location.Y)
                grillaSorteo.Controls("lblRes" & index).Location = New Point(grillaSorteo.Controls("lblRes" & index).Location.X - 250, grillaSorteo.Controls("lblRes" & index).Location.Y)

            Next

            Me.gbxLetras.Visible = True
            Me.txtLetra1.Focus()
        Else

        End If

        sorteosRestantes = 0
    End Sub
#End Region
    Private Sub txtUnidad_TextChanged_1(sender As Object, e As EventArgs) Handles txtUdeMil.TextChanged
        Me.txtCentena.Text = ""
        Me.txtDecena.Text = ""
        Me.txtUnidad.Text = ""
        Me.txtCentena.Focus()
        Me.txtNumSorteado.Text = Me.txtUdeMil.Text
        If iniciado = False Then

            HoraInicio = Now.ToString("HH:mm:ss")
            iniciado = True

        End If

    End Sub

    Private Sub txtUnidad_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtUdeMil.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtDecena_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtCentena.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtCentena_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtDecena.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtUdeMil_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtUnidad.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtDecena_TextChanged_1(sender As Object, e As EventArgs) Handles txtCentena.TextChanged
        Me.txtDecena.Text = ""
        Me.txtUnidad.Text = ""
        Me.txtNumSorteado.Text = Me.txtUdeMil.Text & Me.txtCentena.Text
        Me.txtDecena.Focus()
    End Sub

    Private Sub txtCentena_TextChanged_1(sender As Object, e As EventArgs) Handles txtDecena.TextChanged
        Me.txtUnidad.Text = ""
        Me.txtNumSorteado.Text = Me.txtUdeMil.Text & Me.txtCentena.Text & Me.txtDecena.Text
        Me.txtUnidad.Focus()
    End Sub

    Private Sub txtUdeMil_TextChanged_1(sender As Object, e As EventArgs) Handles txtUnidad.TextChanged
        Me.txtNumSorteado.Text = Me.txtUdeMil.Text & Me.txtCentena.Text & Me.txtDecena.Text & Me.txtUnidad.Text
        Ubicacion.Focus()
    End Sub

    Private Sub txtNumSorteado_TextChanged(sender As Object, e As EventArgs) Handles txtNumSorteado.TextChanged
        Dim imgs() As Image = {My.Resources.Bolilla0, My.Resources.Bolilla1, My.Resources.Bolilla2, My.Resources.Bolilla3, My.Resources.Bolilla4lenta, My.Resources.Bolilla5, My.Resources.Bolilla6, My.Resources.Bolilla7, My.Resources.Bolilla8, My.Resources.Bolilla9}
        Select Case Len(txtNumSorteado.Text)
            Case 1
                grillaSorteo.PctBolillero1.Image = imgs(Me.txtUdeMil.Text)
            Case 2
                grillaSorteo.pctBolillero2.Image = imgs(Me.txtCentena.Text)
            Case 3
                grillaSorteo.pctBolillero3.Image = imgs(Me.txtDecena.Text)
            Case 4
                grillaSorteo.pctBolillero4.Image = imgs(Me.txtUnidad.Text)
        End Select
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If num < 60 Then
            If num Mod 2 = 0 Then
                grillaSorteo.Controls(auxUbicacion).ForeColor = Color.White
            Else
                grillaSorteo.Controls(auxUbicacion).Visible = True
                grillaSorteo.Controls(auxUbicacion).ForeColor = Color.Red
            End If
            num += 1
                grillaSorteo.PctBolillero1.Location = New Point(grillaSorteo.PctBolillero1.Location.X + distanciax1, grillaSorteo.PctBolillero1.Location.Y + distanciay1)
                grillaSorteo.pctBolillero2.Location = New Point(grillaSorteo.pctBolillero2.Location.X + distanciax2, grillaSorteo.pctBolillero2.Location.Y + distanciay2)
                grillaSorteo.pctBolillero3.Location = New Point(grillaSorteo.pctBolillero3.Location.X + distanciax3, grillaSorteo.pctBolillero3.Location.Y + distanciay3)
                grillaSorteo.pctBolillero4.Location = New Point(grillaSorteo.pctBolillero4.Location.X + distanciax4, grillaSorteo.pctBolillero4.Location.Y + distanciay4)
                'grillaSorteo.PctBolillero0.Location = New Point(408, 56)


                grillaSorteo.PctBolillero1.Size = New Size(grillaSorteo.PctBolillero1.Size.Height - 10, grillaSorteo.PctBolillero1.Size.Height - 10)
                grillaSorteo.pctBolillero2.Size = New Size(grillaSorteo.pctBolillero2.Size.Height - 10, grillaSorteo.pctBolillero2.Size.Height - 10)
                grillaSorteo.pctBolillero3.Size = New Size(grillaSorteo.pctBolillero3.Size.Height - 10, grillaSorteo.pctBolillero3.Size.Height - 10)
                grillaSorteo.pctBolillero4.Size = New Size(grillaSorteo.pctBolillero4.Size.Height - 10, grillaSorteo.pctBolillero4.Size.Height - 10)

                'grillaSorteo.PictureBox1.Location = New Point(grillaSorteo.PictureBox1.Location.X + 1, grillaSorteo.PictureBox1.Location.Y)
                'grillaSorteo.PictureBox1.Size = New Size(grillaSorteo.PictureBox1.Width - 20, grillaSorteo.PictureBox1.Size.Height)
            Else

                num = 0
            Timer1.Enabled = False
            grillaSorteo.Controls(auxUbicacion).ForeColor = Color.Red
            '  grillaSorteo.PctBolillero0.Size = New Size(300, 300)
            ' NuevaExtraccion()


            For index = 1 To 20
                grillaSorteo.Controls("TextBox" & index).Location = New Point(grillaSorteo.Controls("TextBox" & index).Location.X, grillaSorteo.Controls("TextBox" & index).Location.Y - 220)
                grillaSorteo.Controls("lblOrden" & index).Location = New Point(grillaSorteo.Controls("lblOrden" & index).Location.X, grillaSorteo.Controls("lblorden" & index).Location.Y - 220)
                'grillaSorteo.Controls("LblOrden" & index).Visible = False
            Next
            For index = 15 To 0 Step -5
                grillaSorteo.Controls("lblPos" & index).Location = New Point(grillaSorteo.Controls("lblPos" & index).Location.X, grillaSorteo.Controls("lblPos" & index).Location.Y - 220)
                grillaSorteo.Controls("lblRes" & index).Location = New Point(grillaSorteo.Controls("lblRes" & index).Location.X, grillaSorteo.Controls("lblRes" & index).Location.Y - 220)

            Next
            If terminado = True Then
                Exit Sub
            Else
                MessageBox.Show("Continuar!", "", MessageBoxButtons.OK)

                NuevaExtraccion()
            End If

        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnArchivo.Click
        Dim ruta As String
        Dim Openf As New OpenFileDialog
        Dim SorteoNumero As String
        Dim FechaInicio As String
        Dim HoraInicio As String
        Dim fiscaliza As String

        Dim linea As String
        Dim arrayDeLineas As New ArrayList()
        ' InicializarSorteo()
        Try
            If Openf.ShowDialog() = DialogResult.OK Then
                ruta = Openf.FileName.ToString()
                ListBox1.Items.Clear()
                gbxNumerosSorteados.Enabled = True
                txtUnidad.Text = ""
                txtDecena.Text = ""
                txtCentena.Text = ""
                txtUdeMil.Text = ""
                Me.Ubicacion.Text = ""


            End If
            Dim lector As StreamReader = New StreamReader(ruta)
            Do
                linea = lector.ReadLine
                arrayDeLineas.Add(linea)
            Loop Until linea Is Nothing
            lector.Close()
            Me.txtNumSorteo.Text = Mid(arrayDeLineas(0), 12)
            ' Me.HoraInicio = Mid(arrayDeLineas(1), 51)
            For index = 2 To 21
                Dim aux As String = "Textbox" & index - 1
                If Len(arrayDeLineas(index)) <= 4 Then

                    grillaSorteo.Controls(aux).Text = ""
                    ListBox1.Items.Add(index - 1 & " " & "0")
                    posiciones(index - 2) = "0"
                    terminaciones(index - 2) = "0"
                ElseIf Len(arrayDeLineas(index)) <= 6 Then
                    grillaSorteo.Controls(aux).Text = Mid(arrayDeLineas(index), 3)
                    ListBox1.Items.Add(index - 1 & " " & Mid(arrayDeLineas(index), 3))
                    posiciones(index - 2) = Mid(arrayDeLineas(index), 3)
                    terminaciones(index - 2) = Mid(arrayDeLineas(index), 5)
                Else
                    grillaSorteo.Controls(aux).Text = Mid(arrayDeLineas(index), 4)
                    ListBox1.Items.Add(index - 1 & " " & Mid(arrayDeLineas(index), 4))
                    posiciones(index - 2) = Mid(arrayDeLineas(index), 4)
                    terminaciones(index - 2) = Mid(arrayDeLineas(index), 6)
                End If
            Next
        Catch excepcion As Exception
            MsgBox("se produjo un error " & excepcion.Message)
        End Try

    End Sub

    Private Sub txtDdeM_TextChanged(sender As Object, e As EventArgs) Handles txtDdeM.TextChanged
        soloNumeros(e)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Dim colorOriginalFondo As Color
        'colorOriginalFondo = grillaSorteo.Controls(auxUbicacion).ForeColor
        'If num2 < 90 Then
        '    If num2 Mod 2 = 0 Then
        '        grillaSorteo.Controls(auxUbicacion).ForeColor = Color.White
        '    Else
        '        'grillaSorteo.Controls(auxUbicacion).Visible = True
        '        grillaSorteo.Controls(auxUbicacion).ForeColor = Color.Red
        '    End If
        '    num2 += 1

        'Else
        '    num2 = 0
        '    Timer2.Enabled = False
        '    'grillaSorteo.Controls(auxUbicacion).ForeColor = Color.White
        '    If terminado = True Then
        '        Exit Sub
        '    Else
        '        MessageBox.Show("Continuar!", "", MessageBoxButtons.OK)

        '        NuevaExtraccion()
        '    End If


        'End If
        'grillaSorteo.Controls(auxUbicacion).ForeColor = colorOriginalFondo
    End Sub

    Private Sub frmConsola_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter

    End Sub

    Private Sub frmConsola_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub txtLetra1_TextChanged(sender As Object, e As EventArgs) Handles txtLetra1.TextChanged
        grillaSorteo.lblTituloLetras.Visible = True
        grillaSorteo.lblLetras.Visible = True
        Me.ordenLetras = Me.txtLetra1.Text
        Me.txtLetra2.Text = ""
        Me.txtLetra3.Text = ""
        Me.txtLetra4.Text = ""
        Me.txtLetra2.Focus()
        Me.txtLetrasOrdenadas.Text = OrdenarLetras(ordenLetras)
        grillaSorteo.lblLetras.Text = txtLetrasOrdenadas.Text
        'grillaSorteo.lblLetras.Location = New Point(515, 515)
        'grillaSorteo.grbLetras.Visible = True
        grillaSorteo.lblLetras.Location = New Point(grillaSorteo.lblLetras.Location.X, grillaSorteo.lblLetras.Location.Y - 150)
        grillaSorteo.lblTituloLetras.Location = New Point(grillaSorteo.lblTituloLetras.Location.X, grillaSorteo.lblTituloLetras.Location.Y - 150)

        grillaSorteo.lblLetras.Visible = True

    End Sub

    Private Sub txtLetra4_TextChanged(sender As Object, e As EventArgs) Handles txtLetra4.TextChanged
        'INGRESO LA ULTIMA LETRA, Y PREPARO LA LISTA POCEADA ELIMINANDO LOS REPETIDOS
        Me.ordenLetras = txtLetra1.Text & txtLetra2.Text & txtLetra3.Text & txtLetra4.Text

        Me.txtLetrasOrdenadas.Text = OrdenarLetras(ordenLetras)
        grillaSorteo.lblLetras.Text = txtLetrasOrdenadas.Text
        Using escritor1 As StreamWriter = New StreamWriter(nombreArchivo, True)
            escritor1.Write("LETRAS" & vbCrLf)
            escritor1.Write(txtLetra1.Text & " - " & txtLetra2.Text & " - " & txtLetra3.Text & " - " & txtLetra4.Text & vbCrLf)
        End Using
        If MessageBox.Show("Continuar??", "Continuar Sorteos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'grillaSorteo.lblLetras.Location = New Point(grillaSorteo.lblLetras.Location.X - 320, grillaSorteo.lblLetras.Location.Y - 50)
            'grillaSorteo.IsMdiContainer = True
            grillaSorteo.lblTituloLetras.Location = New Point(grillaSorteo.lblTituloLetras.Location.X - 250, grillaSorteo.lblTituloLetras.Location.Y - 70)
            grillaSorteo.lblLetras.Location = New Point(grillaSorteo.lblLetras.Location.X - 250, grillaSorteo.lblLetras.Location.Y - 70)

            poceada.Show()
            arrayTempPoseada = terminaciones
            Array.Sort(arrayTempPoseada)
            For i = 0 To arrayTempPoseada.Length - 1
                poceada.grbPoceada.Controls("TextBox" & i + 1).Text = arrayTempPoseada(i)
                Dim actual As String = arrayTempPoseada(i)
                'If StrComp(actual, "R") <> 0 Then

                If Mid(actual, 1) <> "" Then

                    For index = i + 1 To arrayTempPoseada.GetUpperBound(0)
                        If StrComp(actual, arrayTempPoseada(index)) = 0 Then
                            arrayTempPoseada(index) = ""

                            CantRepetidosPoseada += 1
                            repetidos(index, 0) = actual
                        End If

                    Next
                End If
                Array.Sort(arrayTempPoseada)
            Next

            Me.gbxPoceada.Visible = True
            Me.txtDecenaPoceada.Focus()
            For z = 1 To 20
                poceada.grbPoceada.Controls("TextBox" & z).Text = arrayTempPoseada(z - 1)
            Next
            For c = 0 To repetidos.GetUpperBound(0)
                If Not IsNothing(repetidos(c, 0)) Then

                    grillaSorteo.lblRepetidos.Text = grillaSorteo.lblRepetidos.Text & "-" & repetidos(c, 0).ToString()

                End If
            Next
            Me.txtRepetido.Text = grillaSorteo.lblRepetidos.Text
            poceada.Location = New Point(1100, 120) 'posicion en pantalla doble 2180,60
            MsgBox("cant. repetidos " & CantRepetidosPoseada)

            grillaSorteo.lblRepetidos.Visible = True
        Else
            txtLetra1.Text = ""
            txtLetra1.Focus()
        End If

        Me.txtUbicacionPoceada.Text = CantRepetidosPoseada
    End Sub

    Private Sub txtLetra2_TextChanged(sender As Object, e As EventArgs) Handles txtLetra2.TextChanged
        Me.ordenLetras = txtLetra1.Text & txtLetra2.Text
        Me.txtLetra3.Text = ""
        Me.txtLetra4.Text = ""
        Me.txtLetra3.Focus()
        Me.txtLetrasOrdenadas.Text = OrdenarLetras(ordenLetras)
        grillaSorteo.lblLetras.Text = txtLetrasOrdenadas.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub txtLetra1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLetra1.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtLetra2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLetra2.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtLetra3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLetra3.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtLetra4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLetra4.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtLetra3_TextChanged(sender As Object, e As EventArgs) Handles txtLetra3.TextChanged
        Me.ordenLetras = txtLetra1.Text & txtLetra2.Text & txtLetra3.Text
        Me.txtLetra4.Text = ""
        Me.txtLetra4.Focus()
        Me.txtLetrasOrdenadas.Text = OrdenarLetras(ordenLetras)
        grillaSorteo.lblLetras.Text = txtLetrasOrdenadas.Text
    End Sub

    Private Sub BtnPoceada_Click(sender As Object, e As EventArgs) Handles BtnPoceada.Click
        If CantRepetidosPoseada > 0 Then
            If MessageBox.Show("Ubicacion: " & Me.txtUbicacionPoceada.Text & ": " & txtNumSorteadoPoceada.Text, "CONFIRMA!", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                For index = 0 To arrayTempPoseada.GetUpperBound(0)
                    If StrComp(arrayTempPoseada(index), txtNumSorteadoPoceada.Text) = 0 Then
                        MessageBox.Show("ya existe el numero sorteado", "SORTEAR NUEVAMENTE")

                        Me.txtDecenaPoceada.Text = ""
                        Me.txtUnidadPoceada.Text = ""
                        Me.txtDecenaPoceada.Focus()
                        Exit Sub
                    End If

                Next
                arrayTempPoseada(0) = Me.txtNumSorteadoPoceada.Text
                Array.Sort(arrayTempPoseada)
                For c = 1 To 20
                    poceada.grbPoceada.Controls("textbox" & c).Text = arrayTempPoseada(c - 1)
                    poceada.grbPoceada.Controls("TextBox" & c).BackColor = Color.FromArgb(192, 255, 192)
                Next

                ' primerRepetido(repetidos)
                CantRepetidosPoseada -= 1
                For c = 0 To repetidos.GetUpperBound(0)
                    If Not IsNothing(repetidos(c, 0)) Then

                        grillaSorteo.lblRepetidos.Text = repetidos(c, 0).ToString() & " - "

                    End If
                Next
                Me.txtUbicacionPoceada.Text = CantRepetidosPoseada
                txtDecenaPoceada.Text = ""
                txtUnidadPoceada.Text = ""
                Me.txtDecenaPoceada.Focus()
                'GUARDO INFORMACION DE POCEADA
                If CantRepetidosPoseada = 0 Then
                    Using escritor2 As StreamWriter = New StreamWriter(nombreArchivo, True)
                        escritor2.Write("POCEADA" & vbCrLf)
                        For index = 1 To arrayTempPoseada.GetUpperBound(0) + 1

                            escritor2.Write(index & " - " & arrayTempPoseada(index - 1).ToString() & vbCrLf)
                        Next

                    End Using
                    'MsgBox("archivo generado", "se genero archivo txt")
                End If
            End If
        Else
            MessageBox.Show("Sorteo finalizado", "FIN DEL SORTEO ")
        End If
    End Sub

    Private Sub txtLetrasOrdenadas_TextChanged(sender As Object, e As EventArgs) Handles txtLetrasOrdenadas.TextChanged

    End Sub
    Sub desplazamiento(PuntoInicialx As Integer, puntoInicialY As Integer, PuntoFinalX As Integer, PuntoFinalY As Integer)
        Dim distX = PuntoInicialx - PuntoFinalX
        Dim distY = PuntoFinalY - PuntoFinalX
        Dim temporizador As Timer = New Timer


    End Sub
    Function primerRepetido(listado(,) As String)
        Dim primero As String
        For index = 1 To 20
            If Not IsNothing(listado(index - 1, 0)) Then
                primero = listado(index - 1, 0).ToString
                listado(index - 1, 0) = Nothing

                'CantRepetidosPoseada -= 1

                Exit For
            End If
        Next
        Return primero
    End Function

    Private Sub Timer3_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtDecenaPoceada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDecenaPoceada.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtDecenaPoceada_TextChanged(sender As Object, e As EventArgs) Handles txtDecenaPoceada.TextChanged
        Me.txtUnidadPoceada.Focus()
        Me.txtUnidadPoceada.Text = ""
        Me.txtNumSorteadoPoceada.Text = Me.txtDecenaPoceada.Text

    End Sub

    Private Sub txtUnidadPoceada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnidadPoceada.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtUnidadPoceada_TextChanged(sender As Object, e As EventArgs) Handles txtUnidadPoceada.TextChanged

        Me.txtNumSorteadoPoceada.Text = Me.txtNumSorteadoPoceada.Text & Me.txtUnidadPoceada.Text
            Me.BtnPoceada.Enabled = True
            Me.BtnPoceada.Focus()


    End Sub

    Private Sub txtNumSorteadoPoceada_TextChanged(sender As Object, e As EventArgs) Handles txtNumSorteadoPoceada.TextChanged

    End Sub

    Private Sub txtNumSorteo_TextChanged(sender As Object, e As EventArgs) Handles txtNumSorteo.TextChanged
        grillaSorteo.lblDatosSorteo.Text = "S O R T E O  N° " _
               & txtNumSorteo.Text
        grillaSorteo.Timer2.Enabled = True
    End Sub

    Private Sub txtUbicacionPoceada_TextChanged(sender As Object, e As EventArgs) Handles txtUbicacionPoceada.TextChanged

    End Sub

    Private Sub btnProcesarDatos_Click(sender As Object, e As EventArgs) Handles btnProcesarDatos.Click
        guardarArchivoNuevo()
    End Sub
    Sub guardarArchivoNuevo()
        guardarArchivo.Filter = "Archivos de texto | *.txt"
        guardarArchivo.FileName = "Sorteo N°" & Me.txtNumSorteo.Text
        If guardarArchivo.ShowDialog() = DialogResult.OK Then

            'guardarArchivo.FileName = Me.txtNumSorteo.Text & ".txt"

            nombreArchivo = guardarArchivo.FileName

            File.WriteAllText(nombreArchivo, "Archivo generado sin datos")
        End If
    End Sub

    Private Sub txtDecenaPoceada_Enter(sender As Object, e As EventArgs) Handles txtDecenaPoceada.Enter
        Me.txtUnidadPoceada.Text = ""
    End Sub

    Private Sub txtDecenaPoceada_Click(sender As Object, e As EventArgs) Handles txtDecenaPoceada.Click
        txtDecenaPoceada.SelectAll()
    End Sub

    Private Sub txtUnidadPoceada_Enter(sender As Object, e As EventArgs) Handles txtUnidadPoceada.Enter
        Me.txtUnidadPoceada.Text = ""
        Me.txtNumSorteadoPoceada.Text = Me.txtDecenaPoceada.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModalidad.SelectedIndexChanged
        grillaSorteo.lblModalidad.Text = Me.cboModalidad.SelectedItem


    End Sub
End Class

