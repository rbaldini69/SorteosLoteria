Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.Text
Imports System.ComponentModel
Imports SorteoQuiniela

Public Class procesamientoDeDatos
    Dim ruta As String
    Dim cantRegistros As Integer = 0
    Dim cantidadDeApuestas As Integer = 0
    Dim apuestasAnuladas As Integer
    Dim apuestasValidas As Integer
    Dim cantRegistros2 As Integer = 0
    'posicion
    Dim version As String                                       '1 a 2 
    Dim CodJuego As String                                       '3 a 4
    Dim NumeroDeSorteo As String                                       '5 a 9
    Dim CantidadDeSorteosJugados As String                                       '10a 11
    Dim proveedor As String                                       '12a 12
    Dim provincia As String                                       '13a 14
    Dim agencia As String                                       '15a 19
    Dim digitoVerificador As String                                       '20a 20
    Dim NumeroDeTerminal As String                                       '21a 28
    Dim FechaDeVenta As String                                       '29a36
    Dim HoraDeVenta As String                                       '37a 42
    Dim FechaCancelacion As String                                       '43a 50
    Dim HoraCancelacion As String                                       '52a 56
    Dim cantidadDePartes As String                                       '57a 58
    Dim numeroDeTicket As String                                       '59a 68
    Dim OrdinalDeApuesta As String                                       '69a 70
    Dim valorDeApuesta As String                                       '71a 80
    Dim tipoDeDocumento As String                                       '82a 89
    Dim reservado As String                                       '90a 90
    Dim valorTotalApuestas As Long = 0
    Dim cadena As String

    Private Sub txtArchivo_Click(sender As Object, e As EventArgs) Handles btnArchivo.Click
        buscarNuevosArchivos()
        Dim Openf As New OpenFileDialog
        Dim registros As New ArrayList()
        'Dim vendido As String
        If Openf.ShowDialog() = DialogResult.OK Then
            ruta = Openf.FileName.ToString()



            'Call Button1_Click_2(e, sender)
            For Each Ctrl As Control In Me.gbxExtractos.Controls
                If TypeOf (Ctrl) Is TextBox Then
                    CType(Ctrl, TextBox).Clear()
                End If
            Next
            Dim lector As StreamReader = New StreamReader(ruta)

            Dim linea0 As String

            Do
                linea0 = lector.ReadLine()
                If NumeroDeSorteo = "" Then
                    NumeroDeSorteo = Mid(linea0, 5, 5)
                End If
                cantRegistros += 1


            Loop Until linea0 Is Nothing

            ProgressBar1.Value = 0

            '    
            'MsgBox("fin de lectura de archivo, cant. de registros: " & cantRegistros)
            lector.Close()
            BackgroundWorker1.RunWorkerAsync()
            BackgroundWorker1.WorkerReportsProgress = True
            BackgroundWorker1.WorkerSupportsCancellation = True


        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

    End Sub

    Private Sub procesamientoDeDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
    Sub buscarNuevosArchivos()
        ' btnGuardar.Enabled = True
        btnGuardar.Text = "Sin Guardar"
        btnGuardar.Enabled = False
        btnGuardar.ForeColor = Color.Black
        btnGuardar.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Archivos de texto (*.txt)| *.txt"
        sfd.FileName = "Resumen de Extracto Sorteo N° " & Me.txtNumeroSorteo.Text
        If sfd.ShowDialog() = DialogResult.OK Then

            File.WriteAllText(sfd.FileName, cadena.ToString())

            MsgBox("Archivo guardado ")
            Me.btnGuardar.Text = "Guardado"
            Me.btnGuardar.ForeColor = Color.LimeGreen
            Me.btnGuardar.TextAlign = ContentAlignment.MiddleCenter
            Me.btnIniciarSorteo.Enabled = True
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Dim sb As New StringBuilder

        If Not e.Error Is Nothing Then

            REM MUESTRO EL ERROR
            MessageBox.Show(e.Error.Message)

        ElseIf e.Cancelled Then

            REM SE CANCELO LA OPERACION??
            MessageBox.Show("La Operacion de Lectura de archivo ha sido cancelada", "Operacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            REM LA OPERACION FINALIZO CORRECTAMENTE
            Me.txtNumeroSorteo.Text = NumeroDeSorteo
            Me.txtRecaudado.Text = Format(CDec(valorTotalApuestas), "C")
            Me.txtCantidadApuestas.Text = Format(cantRegistros2, "G")
            Me.txtCantApAnuladas.Text = apuestasAnuladas
            Me.txtCantidadApValidas.Text = cantRegistros2 - apuestasAnuladas

            MessageBox.Show("Archivo leido correctamente!", "Lectura Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            sb.Append("Número de Sorteo :")
            sb.AppendLine(txtNumeroSorteo.Text)
            sb.AppendLine("cantidad de apuestas: " & txtCantidadApuestas.Text)
            sb.AppendLine("apuestas anuladas: " & txtCantApAnuladas.Text)
            sb.AppendLine("Apuestas Válidas: " & txtCantidadApValidas.Text)
            sb.AppendLine("Total recaudado: " & txtRecaudado.Text)
            cadena = sb.ToString()
            btnGuardar.Enabled = True
            btnGuardar.ForeColor = Color.Red
            'ckbProcesado.Enabled = True
            ckbProcesado.Checked = True





        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        BackgroundWorker1.CancelAsync()
        BackgroundWorker1.Dispose()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim lector2 As StreamReader = New StreamReader(ruta)
        Dim linea As String
        Dim auxvalor As Long
        Do
            linea = lector2.ReadLine()


            cantRegistros2 += 1
            If StrComp(Mid(linea, 43, 1), " ") <> 0 Then
                apuestasAnuladas += 1

            Else
                Me.valorDeApuesta = Mid(linea, 71, 8)
                apuestasValidas += 1

                Long.TryParse(valorDeApuesta, auxvalor)
                valorTotalApuestas = valorTotalApuestas + auxvalor
            End If

            REM HAY PENDIENTE UNA CANCELACION???
            If BackgroundWorker1.CancellationPending Then
                e.Cancel = True
                Exit Sub
            End If
            BackgroundWorker1.ReportProgress(CType((100 * cantRegistros2 / cantRegistros), Long))
        Loop Until linea Is Nothing
        '  pgb1.Maximum = cantRegistros2

        lector2.Close()

    End Sub

    Private Sub btnIniciarSorteo_Click(sender As Object, e As EventArgs) Handles btnIniciarSorteo.Click
        Dim frmSorteoNuevo As New frmConsola

        If Me.ckbProcesado.Checked = True Then
            frmSorteoNuevo.txtNumSorteo.Text = Me.txtNumeroSorteo.Text
        Else
            frmSorteoNuevo.txtNumSorteo.Text = InputBox("Archivos no procesados, Ingrese numero de sorteo", "COMENZAR SORTEO SIN PROCESAMIENTO ")
        End If
        'Me.Close()
        frmSorteoNuevo.Show()





    End Sub

    Private Sub ckbProcesado_CheckedChanged(sender As Object, e As EventArgs) Handles ckbProcesado.CheckedChanged

    End Sub
End Class