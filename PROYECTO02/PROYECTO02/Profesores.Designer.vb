<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profesores
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
        Me.DataGridViewProfesores = New System.Windows.Forms.DataGridView()
        Me.btnListarProfesore = New System.Windows.Forms.Button()
        Me.txtsalario = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cbestado = New System.Windows.Forms.ComboBox()
        Me.cbcategoria = New System.Windows.Forms.ComboBox()
        Me.cbFacultad = New System.Windows.Forms.ComboBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.txtcelular = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewProfesores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewProfesores
        '
        Me.DataGridViewProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProfesores.Location = New System.Drawing.Point(52, 102)
        Me.DataGridViewProfesores.Name = "DataGridViewProfesores"
        Me.DataGridViewProfesores.RowHeadersWidth = 51
        Me.DataGridViewProfesores.RowTemplate.Height = 29
        Me.DataGridViewProfesores.Size = New System.Drawing.Size(688, 569)
        Me.DataGridViewProfesores.TabIndex = 0
        '
        'btnListarProfesore
        '
        Me.btnListarProfesore.Location = New System.Drawing.Point(52, 45)
        Me.btnListarProfesore.Name = "btnListarProfesore"
        Me.btnListarProfesore.Size = New System.Drawing.Size(195, 32)
        Me.btnListarProfesore.TabIndex = 1
        Me.btnListarProfesore.Text = "Listar"
        Me.btnListarProfesore.UseVisualStyleBackColor = True
        '
        'txtsalario
        '
        Me.txtsalario.Location = New System.Drawing.Point(865, 454)
        Me.txtsalario.Name = "txtsalario"
        Me.txtsalario.Size = New System.Drawing.Size(267, 27)
        Me.txtsalario.TabIndex = 57
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(891, 614)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(165, 57)
        Me.btnLimpiar.TabIndex = 56
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'cbestado
        '
        Me.cbestado.FormattingEnabled = True
        Me.cbestado.Items.AddRange(New Object() {"Activo", "InActivo"})
        Me.cbestado.Location = New System.Drawing.Point(865, 491)
        Me.cbestado.Name = "cbestado"
        Me.cbestado.Size = New System.Drawing.Size(267, 28)
        Me.cbestado.TabIndex = 55
        '
        'cbcategoria
        '
        Me.cbcategoria.FormattingEnabled = True
        Me.cbcategoria.Items.AddRange(New Object() {"01", "88"})
        Me.cbcategoria.Location = New System.Drawing.Point(865, 411)
        Me.cbcategoria.Name = "cbcategoria"
        Me.cbcategoria.Size = New System.Drawing.Size(267, 28)
        Me.cbcategoria.TabIndex = 53
        '
        'cbFacultad
        '
        Me.cbFacultad.FormattingEnabled = True
        Me.cbFacultad.Location = New System.Drawing.Point(865, 367)
        Me.cbFacultad.Name = "cbFacultad"
        Me.cbFacultad.Size = New System.Drawing.Size(267, 28)
        Me.cbFacultad.TabIndex = 52
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(865, 328)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(267, 27)
        Me.txtcorreo.TabIndex = 51
        '
        'txtcelular
        '
        Me.txtcelular.Location = New System.Drawing.Point(865, 291)
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.Size = New System.Drawing.Size(267, 27)
        Me.txtcelular.TabIndex = 50
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(865, 254)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(267, 27)
        Me.txtdireccion.TabIndex = 49
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(865, 210)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(267, 27)
        Me.txtapellido.TabIndex = 48
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(865, 175)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(267, 27)
        Me.txtnombre.TabIndex = 47
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(864, 139)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(267, 27)
        Me.txtCedula.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(794, 499)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 20)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Estado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(794, 461)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Salario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(791, 419)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 20)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Categoria"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(794, 375)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Facultad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(794, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Correo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(794, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Celular"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(794, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(794, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Cedula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(794, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Apellido"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(1038, 555)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 29)
        Me.btnEliminar.TabIndex = 35
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(925, 555)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(94, 29)
        Me.btnActualizar.TabIndex = 34
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(814, 555)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(94, 29)
        Me.btnAgregar.TabIndex = 33
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(940, 45)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(105, 35)
        Me.btnbuscar.TabIndex = 32
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(794, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Nombre"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(864, 102)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(268, 27)
        Me.txtcodigo.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(794, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 20)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Codigo"
        '
        'Profesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 774)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.txtsalario)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.cbestado)
        Me.Controls.Add(Me.cbcategoria)
        Me.Controls.Add(Me.cbFacultad)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.txtcelular)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.Label11)
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
        Me.Controls.Add(Me.btnListarProfesore)
        Me.Controls.Add(Me.DataGridViewProfesores)
        Me.Name = "Profesores"
        Me.Text = "Profesores"
        CType(Me.DataGridViewProfesores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewProfesores As DataGridView
    Friend WithEvents btnListarProfesore As Button
    Friend WithEvents txtsalario As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents cbestado As ComboBox
    Friend WithEvents cbcategoria As ComboBox
    Friend WithEvents cbFacultad As ComboBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txtcelular As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label10 As Label
End Class
