<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsola
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsola))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbxDatosSorteo = New System.Windows.Forms.GroupBox()
        Me.btnArchivo = New System.Windows.Forms.Button()
        Me.dtpFechaSorteo = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblFiscaliza = New System.Windows.Forms.Label()
        Me.lblNumSorteo = New System.Windows.Forms.Label()
        Me.txtNumSorteo = New System.Windows.Forms.TextBox()
        Me.gbxNumerosSorteados = New System.Windows.Forms.GroupBox()
        Me.lblDM = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.lblNumSorteado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.txtUdeMil = New System.Windows.Forms.TextBox()
        Me.txtCentena = New System.Windows.Forms.TextBox()
        Me.txtDecena = New System.Windows.Forms.TextBox()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.Ubicacion = New System.Windows.Forms.TextBox()
        Me.txtNumSorteado = New System.Windows.Forms.TextBox()
        Me.txtDdeM = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.gbxLetras = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLetrasOrdenadas = New System.Windows.Forms.TextBox()
        Me.txtLetra4 = New System.Windows.Forms.TextBox()
        Me.txtLetra3 = New System.Windows.Forms.TextBox()
        Me.txtLetra2 = New System.Windows.Forms.TextBox()
        Me.txtLetra1 = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.gbxPoceada = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRepetido = New System.Windows.Forms.TextBox()
        Me.BtnPoceada = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDecenaPoceada = New System.Windows.Forms.TextBox()
        Me.txtUnidadPoceada = New System.Windows.Forms.TextBox()
        Me.txtUbicacionPoceada = New System.Windows.Forms.TextBox()
        Me.txtNumSorteadoPoceada = New System.Windows.Forms.TextBox()
        Me.btnProcesarDatos = New System.Windows.Forms.Button()
        Me.gbxDatosSorteo.SuspendLayout()
        Me.gbxNumerosSorteados.SuspendLayout()
        Me.gbxLetras.SuspendLayout()
        Me.gbxPoceada.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 25
        '
        'gbxDatosSorteo
        '
        Me.gbxDatosSorteo.Controls.Add(Me.btnArchivo)
        Me.gbxDatosSorteo.Controls.Add(Me.dtpFechaSorteo)
        Me.gbxDatosSorteo.Controls.Add(Me.lblFecha)
        Me.gbxDatosSorteo.Controls.Add(Me.TextBox2)
        Me.gbxDatosSorteo.Controls.Add(Me.lblFiscaliza)
        Me.gbxDatosSorteo.Controls.Add(Me.lblNumSorteo)
        Me.gbxDatosSorteo.Controls.Add(Me.txtNumSorteo)
        Me.gbxDatosSorteo.Location = New System.Drawing.Point(54, 44)
        Me.gbxDatosSorteo.Name = "gbxDatosSorteo"
        Me.gbxDatosSorteo.Size = New System.Drawing.Size(363, 99)
        Me.gbxDatosSorteo.TabIndex = 22
        Me.gbxDatosSorteo.TabStop = False
        Me.gbxDatosSorteo.Text = "Datos del Sorteo"
        '
        'btnArchivo
        '
        Me.btnArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchivo.Location = New System.Drawing.Point(108, 16)
        Me.btnArchivo.Name = "btnArchivo"
        Me.btnArchivo.Size = New System.Drawing.Size(27, 22)
        Me.btnArchivo.TabIndex = 28
        Me.btnArchivo.Text = "..."
        Me.btnArchivo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnArchivo.UseVisualStyleBackColor = True
        '
        'dtpFechaSorteo
        '
        Me.dtpFechaSorteo.Location = New System.Drawing.Point(146, 17)
        Me.dtpFechaSorteo.Name = "dtpFechaSorteo"
        Me.dtpFechaSorteo.Size = New System.Drawing.Size(211, 20)
        Me.dtpFechaSorteo.TabIndex = 27
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(209, 40)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 26
        Me.lblFecha.Text = "Fecha"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(7, 60)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(350, 20)
        Me.TextBox2.TabIndex = 25
        '
        'lblFiscaliza
        '
        Me.lblFiscaliza.AutoSize = True
        Me.lblFiscaliza.Location = New System.Drawing.Point(150, 83)
        Me.lblFiscaliza.Name = "lblFiscaliza"
        Me.lblFiscaliza.Size = New System.Drawing.Size(47, 13)
        Me.lblFiscaliza.TabIndex = 24
        Me.lblFiscaliza.Text = "Fiscaliza"
        '
        'lblNumSorteo
        '
        Me.lblNumSorteo.AutoSize = True
        Me.lblNumSorteo.Location = New System.Drawing.Point(28, 40)
        Me.lblNumSorteo.Name = "lblNumSorteo"
        Me.lblNumSorteo.Size = New System.Drawing.Size(78, 13)
        Me.lblNumSorteo.TabIndex = 23
        Me.lblNumSorteo.Text = "Sorteo Número"
        '
        'txtNumSorteo
        '
        Me.txtNumSorteo.Location = New System.Drawing.Point(7, 17)
        Me.txtNumSorteo.Name = "txtNumSorteo"
        Me.txtNumSorteo.Size = New System.Drawing.Size(99, 20)
        Me.txtNumSorteo.TabIndex = 22
        '
        'gbxNumerosSorteados
        '
        Me.gbxNumerosSorteados.Controls.Add(Me.lblDM)
        Me.gbxNumerosSorteados.Controls.Add(Me.btnAceptar)
        Me.gbxNumerosSorteados.Controls.Add(Me.lblUbicacion)
        Me.gbxNumerosSorteados.Controls.Add(Me.lblNumSorteado)
        Me.gbxNumerosSorteados.Controls.Add(Me.Label3)
        Me.gbxNumerosSorteados.Controls.Add(Me.Label2)
        Me.gbxNumerosSorteados.Controls.Add(Me.Label1)
        Me.gbxNumerosSorteados.Controls.Add(Me.lblUnidad)
        Me.gbxNumerosSorteados.Controls.Add(Me.txtUdeMil)
        Me.gbxNumerosSorteados.Controls.Add(Me.txtCentena)
        Me.gbxNumerosSorteados.Controls.Add(Me.txtDecena)
        Me.gbxNumerosSorteados.Controls.Add(Me.txtUnidad)
        Me.gbxNumerosSorteados.Controls.Add(Me.Ubicacion)
        Me.gbxNumerosSorteados.Controls.Add(Me.txtNumSorteado)
        Me.gbxNumerosSorteados.Location = New System.Drawing.Point(54, 165)
        Me.gbxNumerosSorteados.Name = "gbxNumerosSorteados"
        Me.gbxNumerosSorteados.Size = New System.Drawing.Size(363, 136)
        Me.gbxNumerosSorteados.TabIndex = 23
        Me.gbxNumerosSorteados.TabStop = False
        Me.gbxNumerosSorteados.Text = "Números Sorteados"
        '
        'lblDM
        '
        Me.lblDM.AutoSize = True
        Me.lblDM.Enabled = False
        Me.lblDM.Location = New System.Drawing.Point(24, 52)
        Me.lblDM.Name = "lblDM"
        Me.lblDM.Size = New System.Drawing.Size(24, 13)
        Me.lblDM.TabIndex = 28
        Me.lblDM.Text = "DM"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(268, 75)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 26
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Location = New System.Drawing.Point(134, 100)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(55, 13)
        Me.lblUbicacion.TabIndex = 25
        Me.lblUbicacion.Text = "Ubicacion"
        '
        'lblNumSorteado
        '
        Me.lblNumSorteado.AutoSize = True
        Me.lblNumSorteado.Location = New System.Drawing.Point(16, 101)
        Me.lblNumSorteado.Name = "lblNumSorteado"
        Me.lblNumSorteado.Size = New System.Drawing.Size(90, 13)
        Me.lblNumSorteado.TabIndex = 24
        Me.lblNumSorteado.Text = "Numero Sorteado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "C"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "D"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "U"
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Location = New System.Drawing.Point(91, 52)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(24, 13)
        Me.lblUnidad.TabIndex = 7
        Me.lblUnidad.Text = "UM"
        '
        'txtUdeMil
        '
        Me.txtUdeMil.Location = New System.Drawing.Point(90, 29)
        Me.txtUdeMil.Name = "txtUdeMil"
        Me.txtUdeMil.Size = New System.Drawing.Size(27, 20)
        Me.txtUdeMil.TabIndex = 3
        '
        'txtCentena
        '
        Me.txtCentena.Location = New System.Drawing.Point(136, 29)
        Me.txtCentena.Name = "txtCentena"
        Me.txtCentena.Size = New System.Drawing.Size(27, 20)
        Me.txtCentena.TabIndex = 2
        '
        'txtDecena
        '
        Me.txtDecena.Location = New System.Drawing.Point(183, 29)
        Me.txtDecena.Name = "txtDecena"
        Me.txtDecena.Size = New System.Drawing.Size(27, 20)
        Me.txtDecena.TabIndex = 1
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(228, 29)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(27, 20)
        Me.txtUnidad.TabIndex = 0
        '
        'Ubicacion
        '
        Me.Ubicacion.Location = New System.Drawing.Point(137, 77)
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.Size = New System.Drawing.Size(50, 20)
        Me.Ubicacion.TabIndex = 15
        '
        'txtNumSorteado
        '
        Me.txtNumSorteado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumSorteado.Enabled = False
        Me.txtNumSorteado.Location = New System.Drawing.Point(6, 78)
        Me.txtNumSorteado.Name = "txtNumSorteado"
        Me.txtNumSorteado.Size = New System.Drawing.Size(112, 20)
        Me.txtNumSorteado.TabIndex = 8
        Me.txtNumSorteado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDdeM
        '
        Me.txtDdeM.Enabled = False
        Me.txtDdeM.Location = New System.Drawing.Point(12, 194)
        Me.txtDdeM.Name = "txtDdeM"
        Me.txtDdeM.Size = New System.Drawing.Size(27, 20)
        Me.txtDdeM.TabIndex = 27
        '
        'ListBox1
        '
        Me.ListBox1.CausesValidation = False
        Me.ListBox1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 23
        Me.ListBox1.Location = New System.Drawing.Point(423, 44)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(201, 257)
        Me.ListBox1.TabIndex = 27
        '
        'gbxLetras
        '
        Me.gbxLetras.Controls.Add(Me.Label4)
        Me.gbxLetras.Controls.Add(Me.txtLetrasOrdenadas)
        Me.gbxLetras.Controls.Add(Me.txtLetra4)
        Me.gbxLetras.Controls.Add(Me.txtLetra3)
        Me.gbxLetras.Controls.Add(Me.txtLetra2)
        Me.gbxLetras.Controls.Add(Me.txtLetra1)
        Me.gbxLetras.Location = New System.Drawing.Point(56, 307)
        Me.gbxLetras.Name = "gbxLetras"
        Me.gbxLetras.Size = New System.Drawing.Size(568, 55)
        Me.gbxLetras.TabIndex = 29
        Me.gbxLetras.TabStop = False
        Me.gbxLetras.Text = "Letras"
        Me.gbxLetras.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Letras Ordenadas"
        '
        'txtLetrasOrdenadas
        '
        Me.txtLetrasOrdenadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLetrasOrdenadas.Location = New System.Drawing.Point(462, 14)
        Me.txtLetrasOrdenadas.Name = "txtLetrasOrdenadas"
        Me.txtLetrasOrdenadas.Size = New System.Drawing.Size(100, 26)
        Me.txtLetrasOrdenadas.TabIndex = 38
        '
        'txtLetra4
        '
        Me.txtLetra4.Location = New System.Drawing.Point(273, 19)
        Me.txtLetra4.Name = "txtLetra4"
        Me.txtLetra4.Size = New System.Drawing.Size(24, 20)
        Me.txtLetra4.TabIndex = 34
        '
        'txtLetra3
        '
        Me.txtLetra3.Location = New System.Drawing.Point(200, 19)
        Me.txtLetra3.Name = "txtLetra3"
        Me.txtLetra3.Size = New System.Drawing.Size(24, 20)
        Me.txtLetra3.TabIndex = 35
        '
        'txtLetra2
        '
        Me.txtLetra2.Location = New System.Drawing.Point(120, 19)
        Me.txtLetra2.Name = "txtLetra2"
        Me.txtLetra2.Size = New System.Drawing.Size(24, 20)
        Me.txtLetra2.TabIndex = 36
        '
        'txtLetra1
        '
        Me.txtLetra1.Location = New System.Drawing.Point(46, 19)
        Me.txtLetra1.Name = "txtLetra1"
        Me.txtLetra1.Size = New System.Drawing.Size(24, 20)
        Me.txtLetra1.TabIndex = 37
        '
        'Timer2
        '
        '
        'gbxPoceada
        '
        Me.gbxPoceada.Controls.Add(Me.Label5)
        Me.gbxPoceada.Controls.Add(Me.txtRepetido)
        Me.gbxPoceada.Controls.Add(Me.BtnPoceada)
        Me.gbxPoceada.Controls.Add(Me.Label6)
        Me.gbxPoceada.Controls.Add(Me.Label7)
        Me.gbxPoceada.Controls.Add(Me.Label9)
        Me.gbxPoceada.Controls.Add(Me.Label10)
        Me.gbxPoceada.Controls.Add(Me.txtDecenaPoceada)
        Me.gbxPoceada.Controls.Add(Me.txtUnidadPoceada)
        Me.gbxPoceada.Controls.Add(Me.txtUbicacionPoceada)
        Me.gbxPoceada.Controls.Add(Me.txtNumSorteadoPoceada)
        Me.gbxPoceada.Location = New System.Drawing.Point(639, 44)
        Me.gbxPoceada.Name = "gbxPoceada"
        Me.gbxPoceada.Size = New System.Drawing.Size(207, 170)
        Me.gbxPoceada.TabIndex = 31
        Me.gbxPoceada.TabStop = False
        Me.gbxPoceada.Text = "Quiniela Poceada"
        Me.gbxPoceada.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Nuevo"
        '
        'txtRepetido
        '
        Me.txtRepetido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRepetido.Enabled = False
        Me.txtRepetido.Location = New System.Drawing.Point(32, 76)
        Me.txtRepetido.Name = "txtRepetido"
        Me.txtRepetido.Size = New System.Drawing.Size(56, 20)
        Me.txtRepetido.TabIndex = 27
        Me.txtRepetido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnPoceada
        '
        Me.BtnPoceada.Enabled = False
        Me.BtnPoceada.Location = New System.Drawing.Point(114, 29)
        Me.BtnPoceada.Name = "BtnPoceada"
        Me.BtnPoceada.Size = New System.Drawing.Size(75, 23)
        Me.BtnPoceada.TabIndex = 26
        Me.BtnPoceada.Text = "Aceptar"
        Me.BtnPoceada.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Repetidos"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Anterior"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "D"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(84, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "U"
        '
        'txtDecenaPoceada
        '
        Me.txtDecenaPoceada.Location = New System.Drawing.Point(32, 29)
        Me.txtDecenaPoceada.Name = "txtDecenaPoceada"
        Me.txtDecenaPoceada.Size = New System.Drawing.Size(27, 20)
        Me.txtDecenaPoceada.TabIndex = 1
        '
        'txtUnidadPoceada
        '
        Me.txtUnidadPoceada.Location = New System.Drawing.Point(77, 29)
        Me.txtUnidadPoceada.Name = "txtUnidadPoceada"
        Me.txtUnidadPoceada.Size = New System.Drawing.Size(27, 20)
        Me.txtUnidadPoceada.TabIndex = 0
        '
        'txtUbicacionPoceada
        '
        Me.txtUbicacionPoceada.Location = New System.Drawing.Point(87, 121)
        Me.txtUbicacionPoceada.Name = "txtUbicacionPoceada"
        Me.txtUbicacionPoceada.Size = New System.Drawing.Size(47, 20)
        Me.txtUbicacionPoceada.TabIndex = 15
        Me.txtUbicacionPoceada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumSorteadoPoceada
        '
        Me.txtNumSorteadoPoceada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumSorteadoPoceada.Enabled = False
        Me.txtNumSorteadoPoceada.Location = New System.Drawing.Point(129, 76)
        Me.txtNumSorteadoPoceada.Name = "txtNumSorteadoPoceada"
        Me.txtNumSorteadoPoceada.Size = New System.Drawing.Size(56, 20)
        Me.txtNumSorteadoPoceada.TabIndex = 8
        Me.txtNumSorteadoPoceada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnProcesarDatos
        '
        Me.btnProcesarDatos.Location = New System.Drawing.Point(54, 12)
        Me.btnProcesarDatos.Name = "btnProcesarDatos"
        Me.btnProcesarDatos.Size = New System.Drawing.Size(118, 23)
        Me.btnProcesarDatos.TabIndex = 32
        Me.btnProcesarDatos.Text = "Guardar Como"
        Me.btnProcesarDatos.UseVisualStyleBackColor = True
        '
        'frmConsola
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 426)
        Me.Controls.Add(Me.btnProcesarDatos)
        Me.Controls.Add(Me.gbxPoceada)
        Me.Controls.Add(Me.gbxLetras)
        Me.Controls.Add(Me.txtDdeM)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.gbxNumerosSorteados)
        Me.Controls.Add(Me.gbxDatosSorteo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsola"
        Me.Text = "Consola"
        Me.gbxDatosSorteo.ResumeLayout(False)
        Me.gbxDatosSorteo.PerformLayout()
        Me.gbxNumerosSorteados.ResumeLayout(False)
        Me.gbxNumerosSorteados.PerformLayout()
        Me.gbxLetras.ResumeLayout(False)
        Me.gbxLetras.PerformLayout()
        Me.gbxPoceada.ResumeLayout(False)
        Me.gbxPoceada.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents gbxDatosSorteo As GroupBox
    Friend WithEvents dtpFechaSorteo As DateTimePicker
    Friend WithEvents lblFecha As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblFiscaliza As Label
    Friend WithEvents lblNumSorteo As Label
    Friend WithEvents txtNumSorteo As TextBox
    Friend WithEvents gbxNumerosSorteados As GroupBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents lblNumSorteado As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUnidad As Label
    Friend WithEvents txtUdeMil As TextBox
    Friend WithEvents txtCentena As TextBox
    Friend WithEvents txtDecena As TextBox
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents Ubicacion As TextBox
    Friend WithEvents txtNumSorteado As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnArchivo As Button
    Friend WithEvents lblDM As Label
    Friend WithEvents txtDdeM As TextBox
    Friend WithEvents gbxLetras As GroupBox
    Friend WithEvents txtLetra4 As TextBox
    Friend WithEvents txtLetra3 As TextBox
    Friend WithEvents txtLetra2 As TextBox
    Friend WithEvents txtLetra1 As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLetrasOrdenadas As TextBox
    Friend WithEvents gbxPoceada As GroupBox
    Friend WithEvents BtnPoceada As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDecenaPoceada As TextBox
    Friend WithEvents txtUnidadPoceada As TextBox
    Friend WithEvents txtUbicacionPoceada As TextBox
    Friend WithEvents txtNumSorteadoPoceada As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRepetido As TextBox
    Friend WithEvents btnProcesarDatos As Button
End Class
