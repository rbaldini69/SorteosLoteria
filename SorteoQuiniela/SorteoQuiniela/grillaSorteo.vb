Imports System
Imports System.Runtime.InteropServices
Public Class grillaSorteo
    Public resolucionCambiada As Boolean = False


    Private Sub grillaSorteo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' escalar1()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Timer1.Stop()

    End Sub

    Private Sub TextBox20s_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox15s_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub lblOrden18_Click(sender As Object, e As EventArgs) Handles lblOrden17.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub pctBolillero4_Click(sender As Object, e As EventArgs) Handles pctBolillero4.Click

    End Sub

    Private Sub PctBolillero0_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub lblOrden6_Click(sender As Object, e As EventArgs) Handles lblOrden6.Click

    End Sub

    Private Sub lblOrden1_Click(sender As Object, e As EventArgs) Handles lblOrden1.Click

    End Sub

    Private Sub lblOrden2_Click(sender As Object, e As EventArgs) Handles lblOrden2.Click

    End Sub

    Private Sub lblOrden3_Click(sender As Object, e As EventArgs) Handles lblOrden3.Click

    End Sub

    Private Sub lblOrden4_Click(sender As Object, e As EventArgs) Handles lblOrden4.Click

    End Sub

    Private Sub lblOrden5_Click(sender As Object, e As EventArgs) Handles lblOrden5.Click

    End Sub

    Private Sub lblOrden7_Click(sender As Object, e As EventArgs) Handles lblOrden7.Click

    End Sub

    Private Sub lblOrden8_Click(sender As Object, e As EventArgs) Handles lblOrden8.Click

    End Sub

    Private Sub lblOrden10_Click(sender As Object, e As EventArgs) Handles lblOrden10.Click

    End Sub

    Private Sub lblOrden9_Click(sender As Object, e As EventArgs) Handles lblOrden9.Click

    End Sub

    Private Sub lblOrden18_Click_1(sender As Object, e As EventArgs) Handles lblOrden18.Click

    End Sub

    Private Sub lblOrden13_Click(sender As Object, e As EventArgs) Handles lblOrden13.Click

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged

    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged

    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged

    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged

    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles TextBox20.TextChanged

    End Sub

    Private Sub lblOrden11_Click(sender As Object, e As EventArgs) Handles lblOrden11.Click

    End Sub

    Private Sub lblLetras_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblLetras_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PctBolillero1_Click(sender As Object, e As EventArgs) Handles PctBolillero1.Click

    End Sub

    Private Sub txtDatosSorteo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.lblFechaHora.Text = DateTime.Now.ToString()
    End Sub

    Private Sub lblOrden20_Click(sender As Object, e As EventArgs) Handles lblOrden20.Click

    End Sub

    Private Sub lblOrden19_Click(sender As Object, e As EventArgs) Handles lblOrden19.Click

    End Sub

    Private Sub lblOrden16_Click(sender As Object, e As EventArgs) Handles lblOrden16.Click

    End Sub

    Private Sub lblOrden12_Click(sender As Object, e As EventArgs) Handles lblOrden12.Click

    End Sub

    Private Sub lblOrden14_Click(sender As Object, e As EventArgs) Handles lblOrden14.Click

    End Sub

    Private Sub lblOrden15_Click(sender As Object, e As EventArgs) Handles lblOrden15.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
    Sub escalar1()
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = desktopSize.Height
        Dim width As Integer = desktopSize.Width
        If height <> 768 And width <> 1366 Then
            Dim f As New System.Drawing.SizeF
            f.Height = ((100 / 768) * Me.Height) / 100
            f.Width = ((100 / 1366) * Me.Width) / 100
            For Each ctrl As Control In Me.Controls
                ctrl.Scale(f)
                Try
                    'controlo el error por si no tiene propiedad font
                    ctrl.Font = New Font(ctrl.Font.OriginalFontName, Math.Round(ctrl.Font.Size * Math.Round(f.Width, 2), 0), ctrl.Font.Style, GraphicsUnit.Point)
                Catch ex As Exception
                End Try
                If (TypeOf (ctrl) Is GroupBox) Then 'si el control es un groupbox escalo sus controles internos
                    For Each ctrlAUX As Control In ctrl.Controls
                        ctrlAUX.Scale(f)
                        Try
                            ctrlAUX.Font = New Font(ctrlAUX.Font.OriginalFontName, ctrlAUX.Font.Size * f.Height, ctrlAUX.Font.Style, GraphicsUnit.Point)
                        Catch ex As Exception
                        End Try
                    Next
                End If
            Next
        End If
        resolucionCambiada = True

    End Sub
End Class