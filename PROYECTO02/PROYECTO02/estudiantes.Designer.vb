<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class estudiantes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridViewEstudiantes = New System.Windows.Forms.DataGridView()
        Me.btnlistarE = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtcelular = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.cbFacultad = New System.Windows.Forms.ComboBox()
        Me.cbcarreras = New System.Windows.Forms.ComboBox()
        Me.cbsexo = New System.Windows.Forms.ComboBox()
        Me.cbestado = New System.Windows.Forms.ComboBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtindice = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewEstudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewEstudiantes
        '
        Me.DataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEstudiantes.Location = New System.Drawing.Point(50, 69)
        Me.DataGridViewEstudiantes.Name = "DataGridViewEstudiantes"
        Me.DataGridViewEstudiantes.RowHeadersWidth = 51
        Me.DataGridViewEstudiantes.RowTemplate.Height = 29
        Me.DataGridViewEstudiantes.Size = New System.Drawing.Size(740, 614)
        Me.DataGridViewEstudiantes.TabIndex = 0
        '
        'btnlistarE
        '
        Me.btnlistarE.Location = New System.Drawing.Point(50, 12)
        Me.btnlistarE.Name = "btnlistarE"
        Me.btnlistarE.Size = New System.Drawing.Size(173, 35)
        Me.btnlistarE.TabIndex = 1
        Me.btnlistarE.Text = "Listar Estudiantes"
        Me.btnlistarE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(853, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(999, 12)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(105, 35)
        Me.btnbuscar.TabIndex = 3
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(873, 522)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(94, 29)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(984, 522)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(94, 29)
        Me.btnActualizar.TabIndex = 5
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(1097, 522)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 29)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(853, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(853, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cedula"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(853, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(853, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Celular"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(853, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Correo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(853, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Facultad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(853, 337)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Carrera"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(853, 376)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Indice"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(853, 420)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Sexo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(853, 466)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 20)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Estado"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(924, 69)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(267, 27)
        Me.txtCedula.TabIndex = 17
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(924, 106)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(267, 27)
        Me.txtnombre.TabIndex = 18
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(924, 142)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(267, 27)
        Me.txtapellido.TabIndex = 19
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(924, 177)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(267, 27)
        Me.txtdireccion.TabIndex = 20
        '
        'txtcelular
        '
        Me.txtcelular.Location = New System.Drawing.Point(924, 214)
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.Size = New System.Drawing.Size(267, 27)
        Me.txtcelular.TabIndex = 21
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(924, 254)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(267, 27)
        Me.txtcorreo.TabIndex = 23
        '
        'cbFacultad
        '
        Me.cbFacultad.FormattingEnabled = True
        Me.cbFacultad.Location = New System.Drawing.Point(924, 290)
        Me.cbFacultad.Name = "cbFacultad"
        Me.cbFacultad.Size = New System.Drawing.Size(267, 28)
        Me.cbFacultad.TabIndex = 24
        '
        'cbcarreras
        '
        Me.cbcarreras.FormattingEnabled = True
        Me.cbcarreras.Location = New System.Drawing.Point(924, 329)
        Me.cbcarreras.Name = "cbcarreras"
        Me.cbcarreras.Size = New System.Drawing.Size(267, 28)
        Me.cbcarreras.TabIndex = 25
        '
        'cbsexo
        '
        Me.cbsexo.FormattingEnabled = True
        Me.cbsexo.Items.AddRange(New Object() {"F", "M"})
        Me.cbsexo.Location = New System.Drawing.Point(924, 412)
        Me.cbsexo.Name = "cbsexo"
        Me.cbsexo.Size = New System.Drawing.Size(267, 28)
        Me.cbsexo.TabIndex = 27
        '
        'cbestado
        '
        Me.cbestado.FormattingEnabled = True
        Me.cbestado.Items.AddRange(New Object() {"Activo", "InActivo"})
        Me.cbestado.Location = New System.Drawing.Point(924, 458)
        Me.cbestado.Name = "cbestado"
        Me.cbestado.Size = New System.Drawing.Size(267, 28)
        Me.cbestado.TabIndex = 28
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(950, 581)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(165, 57)
        Me.btnLimpiar.TabIndex = 29
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtindice
        '
        Me.txtindice.Location = New System.Drawing.Point(924, 376)
        Me.txtindice.Name = "txtindice"
        Me.txtindice.Size = New System.Drawing.Size(267, 27)
        Me.txtindice.TabIndex = 30
        '
        'estudiantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 723)
        Me.Controls.Add(Me.txtindice)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.cbestado)
        Me.Controls.Add(Me.cbsexo)
        Me.Controls.Add(Me.cbcarreras)
        Me.Controls.Add(Me.cbFacultad)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.txtcelular)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnlistarE)
        Me.Controls.Add(Me.DataGridViewEstudiantes)
        Me.Name = "estudiantes"
        Me.Text = "estudiantes"
        CType(Me.DataGridViewEstudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewEstudiantes As DataGridView
    Friend WithEvents btnlistarE As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtcelular As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents cbFacultad As ComboBox
    Friend WithEvents cbcarreras As ComboBox
    Friend WithEvents cbsexo As ComboBox
    Friend WithEvents cbestado As ComboBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtindice As TextBox
End Class
