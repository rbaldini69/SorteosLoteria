<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class procesamientoDeDatos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnIniciarSorteo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbxExtractos = New System.Windows.Forms.GroupBox()
        Me.lblNumeroSorteo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroSorteo = New System.Windows.Forms.TextBox()
        Me.txtCantidadApValidas = New System.Windows.Forms.TextBox()
        Me.txtCantApAnuladas = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtCantidadApuestas = New System.Windows.Forms.TextBox()
        Me.txtRecaudado = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnArchivo = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ckbProcesado = New System.Windows.Forms.CheckBox()
        Me.gbxExtractos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIniciarSorteo
        '
        Me.btnIniciarSorteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarSorteo.Location = New System.Drawing.Point(583, 90)
        Me.btnIniciarSorteo.Name = "btnIniciarSorteo"
        Me.btnIniciarSorteo.Size = New System.Drawing.Size(132, 65)
        Me.btnIniciarSorteo.TabIndex = 43
        Me.btnIniciarSorteo.Text = "Iniciar Sorteo"
        Me.btnIniciarSorteo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(584, 10)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(132, 65)
        Me.btnGuardar.TabIndex = 42
        Me.btnGuardar.Text = "Sin Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnCancelar.Location = New System.Drawing.Point(3, 155)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 51)
        Me.btnCancelar.TabIndex = 41
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'gbxExtractos
        '
        Me.gbxExtractos.Controls.Add(Me.lblNumeroSorteo)
        Me.gbxExtractos.Controls.Add(Me.Label5)
        Me.gbxExtractos.Controls.Add(Me.Label4)
        Me.gbxExtractos.Controls.Add(Me.Label3)
        Me.gbxExtractos.Controls.Add(Me.Label2)
        Me.gbxExtractos.Controls.Add(Me.Label1)
        Me.gbxExtractos.Controls.Add(Me.txtNumeroSorteo)
        Me.gbxExtractos.Controls.Add(Me.txtCantidadApValidas)
        Me.gbxExtractos.Controls.Add(Me.txtCantApAnuladas)
        Me.gbxExtractos.Controls.Add(Me.TextBox2)
        Me.gbxExtractos.Controls.Add(Me.txtCantidadApuestas)
        Me.gbxExtractos.Controls.Add(Me.txtRecaudado)
        Me.gbxExtractos.Location = New System.Drawing.Point(114, 0)
        Me.gbxExtractos.Name = "gbxExtractos"
        Me.gbxExtractos.Size = New System.Drawing.Size(463, 249)
        Me.gbxExtractos.TabIndex = 40
        Me.gbxExtractos.TabStop = False
        Me.gbxExtractos.Text = "Extracto Archivo"
        '
        'lblNumeroSorteo
        '
        Me.lblNumeroSorteo.AutoSize = True
        Me.lblNumeroSorteo.Location = New System.Drawing.Point(33, 32)
        Me.lblNumeroSorteo.Name = "lblNumeroSorteo"
        Me.lblNumeroSorteo.Size = New System.Drawing.Size(93, 13)
        Me.lblNumeroSorteo.TabIndex = 44
        Me.lblNumeroSorteo.Text = "Numero de Sorteo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Apuestas Validas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Apuestas Anuladas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Total de Apuestas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Cantidad de Apuestas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Total Recaudado"
        '
        'txtNumeroSorteo
        '
        Me.txtNumeroSorteo.Location = New System.Drawing.Point(153, 25)
        Me.txtNumeroSorteo.Name = "txtNumeroSorteo"
        Me.txtNumeroSorteo.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroSorteo.TabIndex = 38
        Me.txtNumeroSorteo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCantidadApValidas
        '
        Me.txtCantidadApValidas.Location = New System.Drawing.Point(154, 213)
        Me.txtCantidadApValidas.Name = "txtCantidadApValidas"
        Me.txtCantidadApValidas.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadApValidas.TabIndex = 37
        Me.txtCantidadApValidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCantApAnuladas
        '
        Me.txtCantApAnuladas.Location = New System.Drawing.Point(154, 175)
        Me.txtCantApAnuladas.Name = "txtCantApAnuladas"
        Me.txtCantApAnuladas.Size = New System.Drawing.Size(100, 20)
        Me.txtCantApAnuladas.TabIndex = 36
        Me.txtCantApAnuladas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(154, 137)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 35
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCantidadApuestas
        '
        Me.txtCantidadApuestas.Location = New System.Drawing.Point(153, 99)
        Me.txtCantidadApuestas.Name = "txtCantidadApuestas"
        Me.txtCantidadApuestas.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadApuestas.TabIndex = 34
        Me.txtCantidadApuestas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRecaudado
        '
        Me.txtRecaudado.Location = New System.Drawing.Point(153, 61)
        Me.txtRecaudado.Name = "txtRecaudado"
        Me.txtRecaudado.Size = New System.Drawing.Size(100, 20)
        Me.txtRecaudado.TabIndex = 33
        Me.txtRecaudado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(3, 83)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(105, 51)
        Me.btnLimpiar.TabIndex = 39
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnArchivo
        '
        Me.btnArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchivo.Location = New System.Drawing.Point(3, 14)
        Me.btnArchivo.Name = "btnArchivo"
        Me.btnArchivo.Size = New System.Drawing.Size(105, 51)
        Me.btnArchivo.TabIndex = 38
        Me.btnArchivo.Text = "Archivo"
        Me.btnArchivo.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(114, 252)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(463, 23)
        Me.ProgressBar1.TabIndex = 44
        '
        'BackgroundWorker1
        '
        '
        'ckbProcesado
        '
        Me.ckbProcesado.AutoSize = True
        Me.ckbProcesado.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ckbProcesado.FlatAppearance.BorderSize = 0
        Me.ckbProcesado.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime
        Me.ckbProcesado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ckbProcesado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbProcesado.Location = New System.Drawing.Point(584, 175)
        Me.ckbProcesado.Name = "ckbProcesado"
        Me.ckbProcesado.Size = New System.Drawing.Size(123, 29)
        Me.ckbProcesado.TabIndex = 45
        Me.ckbProcesado.Text = "Procesado"
        Me.ckbProcesado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ckbProcesado.UseVisualStyleBackColor = True
        Me.ckbProcesado.Visible = False
        '
        'procesamientoDeDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 318)
        Me.Controls.Add(Me.ckbProcesado)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnIniciarSorteo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbxExtractos)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnArchivo)
        Me.Name = "procesamientoDeDatos"
        Me.Text = "procesamientoDeDatos"
        Me.gbxExtractos.ResumeLayout(False)
        Me.gbxExtractos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIniciarSorteo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents gbxExtractos As GroupBox
    Friend WithEvents lblNumeroSorteo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumeroSorteo As TextBox
    Friend WithEvents txtCantidadApValidas As TextBox
    Friend WithEvents txtCantApAnuladas As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtCantidadApuestas As TextBox
    Friend WithEvents txtRecaudado As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnArchivo As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ckbProcesado As CheckBox
End Class
