Imports Capa_servicios
Public Class Profesores
    Dim objFacultades As New facultad
    Dim objProfesor As New Profesor
    Dim objValidate As New Validate
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As DataTable = objFacultades.ListarFaculdates()
        cbFacultad.DataSource = dt
        cbFacultad.DisplayMember = dt.Columns(1).ColumnName
        cbFacultad.ValueMember = dt.Columns(0).ColumnName

        Dim dtcate As DataTable = objProfesor.ListarCategoria()
        cbcategoria.DataSource = dtcate
        cbcategoria.DisplayMember = dtcate.Columns(1).ColumnName
        cbcategoria.ValueMember = dtcate.Columns(0).ColumnName

        btnAgregar.Enabled = False
        btnActualizar.Enabled = False
        btnEliminar.Enabled = False
        limpiar()
    End Sub
    Private Sub btnListarProfesore_Click(sender As Object, e As EventArgs) Handles btnListarProfesore.Click
        listarTable()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If String.IsNullOrEmpty(txtcodigo.Text) Then
            MessageBox.Show("Codigo en blanco ")
        ElseIf Not objValidate.ValidarNumero(txtcodigo.Text) Then
            MessageBox.Show("Codigo: " + txtcodigo.Text + " no valida, solo números")
        Else
            Try
                Dim Dt As DataSet = objProfesor.Buscar(txtcodigo.Text)
                If (Dt.Tables(0).Rows.Count > 0) Then

                    txtcodigo.Enabled = False
                    txtCedula.Enabled = True
                    btnActualizar.Enabled = True
                    btnEliminar.Enabled = True
                    btnbuscar.Enabled = False
                    btnAgregar.Enabled = False
                    txtCedula.Text = Dt.Tables(0).Rows(0).Item("cedula")
                    txtnombre.Text = Dt.Tables(0).Rows(0).Item("nombre")
                    txtapellido.Text = Dt.Tables(0).Rows(0).Item("apellido")
                    txtdireccion.Text = Dt.Tables(0).Rows(0).Item("direccion")
                    txtcelular.Text = Dt.Tables(0).Rows(0).Item("celular")
                    txtcorreo.Text = Dt.Tables(0).Rows(0).Item("correo")
                    cbFacultad.SelectedIndex = cbFacultad.FindStringExact(Dt.Tables(0).Rows(0).Item("facultad"))
                    txtsalario.Text = Dt.Tables(0).Rows(0).Item("salario_base")
                    MessageBox.Show("Profesor con codigo: " + txtcodigo.Text + " Nombre: " + txtnombre.Text + " fue encontrado")
                    If Dt.Tables(0).Rows(0).Item("estatus") = 1 Then
                        cbestado.SelectedIndex = 0
                    Else
                        cbestado.SelectedIndex = 1
                    End If
                    cbcategoria.SelectedIndex = cbcategoria.FindStringExact(Dt.Tables(0).Rows(0).Item("categoria"))
                Else
                    btnActualizar.Enabled = False
                    btnEliminar.Enabled = False
                    btnAgregar.Enabled = True
                    txtcodigo.Enabled = False
                    txtCedula.Enabled = True

                    txtCedula.Text = ""
                    txtnombre.Text = ""
                    txtapellido.Text = ""
                    txtdireccion.Text = ""
                    txtcelular.Text = ""
                    txtcorreo.Text = ""
                    cbFacultad.SelectedIndex = -1
                    txtsalario.Text = ""
                    cbcategoria.SelectedIndex = -1

                    MessageBox.Show("Profesor con codigo: " + txtcodigo.Text + " no fue encontrado, puede crearlo")
                End If
                txtnombre.Enabled = True
                txtapellido.Enabled = True
                txtdireccion.Enabled = True
                txtcelular.Enabled = True
                txtcorreo.Enabled = True
                cbFacultad.Enabled = True
                txtsalario.Enabled = True
                cbcategoria.Enabled = True
                cbestado.Enabled = True
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Private Function limpiar()
        txtcodigo.Text = ""
        txtCedula.Text = ""
        txtnombre.Text = ""
        txtapellido.Text = ""
        txtdireccion.Text = ""
        txtcelular.Text = ""
        txtcorreo.Text = ""
        cbFacultad.SelectedIndex = -1
        txtsalario.Text = ""
        cbcategoria.SelectedIndex = -1
        cbestado.SelectedIndex = -1

        txtcodigo.Enabled = True
        txtCedula.Enabled = False
        btnbuscar.Enabled = True
        btnActualizar.Enabled = False
        btnEliminar.Enabled = False

        txtnombre.Enabled = False
        txtapellido.Enabled = False
        txtdireccion.Enabled = False
        txtcelular.Enabled = False
        txtcorreo.Enabled = False
        cbFacultad.Enabled = False
        txtsalario.Enabled = False
        cbcategoria.Enabled = False
        cbestado.Enabled = False
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim estado As Int32 = 0
        If validateValues() Then
            Try
                If (cbestado.SelectedItem = "Activo") Then
                    estado = 1
                End If

                Dim objvalidation As New Validate()

                Dim modeloprofesor As New ModeloProfesor(
                    txtCedula.Text,
                    txtnombre.Text,
                    txtapellido.Text,
                    txtdireccion.Text,
                    txtcelular.Text,
                    txtcorreo.Text,
                    cbFacultad.SelectedItem.Row.ItemArray(0),
                    cbcategoria.SelectedItem.Row.ItemArray(0),
                    txtsalario.Text, txtcodigo.Text, estado)

                If objProfesor.CrearProfesor(modeloprofesor) Then
                    btnAgregar.Enabled = False
                    btnActualizar.Enabled = True
                    btnEliminar.Enabled = True
                    txtCedula.Enabled = False
                    listarTable()
                    MessageBox.Show("Profesor con codigo: " + txtcodigo.Text + " Nombre: " + txtnombre.Text + " fue agregado")
                Else
                    MessageBox.Show("Profesor con codigo: " + txtcodigo.Text + " Nombre: " + txtnombre.Text + " no fue agregado")
                End If
            Catch ex As Exception

            End Try
        End If

    End Sub
    Public Function listarTable()
        Dim objProfesores As New Profesor
        DataGridViewProfesores.DataSource = objProfesores.Listar().Tables(0)
    End Function

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim estado As Int32 = 0
        If validateValues() Then
            Try
                If (cbestado.SelectedItem = "Activo") Then
                    estado = 1
                End If
                Dim modeloprofesor As New ModeloProfesor(
                    txtCedula.Text,
                    txtnombre.Text,
                    txtapellido.Text,
                    txtdireccion.Text,
                    txtcelular.Text,
                    txtcorreo.Text,
                    cbFacultad.SelectedItem.Row.ItemArray(0),
                    cbcategoria.SelectedItem.Row.ItemArray(0),
                    txtsalario.Text, txtcodigo.Text, estado)

                If objProfesor.ActualizarProfeor(modeloprofesor) Then
                    btnAgregar.Enabled = False
                    btnActualizar.Enabled = True
                    btnEliminar.Enabled = True
                    txtCedula.Enabled = False
                    listarTable()
                    MessageBox.Show("Profesor con codigo: " + txtcodigo.Text + " Nombre: " + txtnombre.Text + " fue actualizado")
                Else
                    MessageBox.Show("Profesor con codigo: " + txtcodigo.Text + " Nombre: " + txtnombre.Text + " no fue actualizado")
                End If
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If objProfesor.Delete(txtcodigo.Text) Then

            MessageBox.Show("Profesor con codigo: " + txtcodigo.Text + " Nombre: " + txtnombre.Text + " fue eliminado")
            listarTable()
            limpiar()
        Else

            MessageBox.Show("Profesor con codigo: " + txtcodigo.Text + " Nombre: " + txtnombre.Text + " no fue eliminado")
        End If
    End Sub
    Private Function validateValues()
        Dim result As Boolean = True
        If Not objValidate.ValidarNumero(txtcodigo.Text) Then
            MessageBox.Show("codigo: " + txtcodigo.Text + " no valido, solo números")
            result = False
        ElseIf (Not objValidate.ValidarLetras(txtnombre.Text)) Then
            MessageBox.Show("el nombre: " + txtnombre.Text + " no valido")
            result = False
        ElseIf Not objValidate.Validarcorreo(txtcorreo.Text) Then
            MessageBox.Show("correo: " + txtcorreo.Text + " no es un correo, ejemplo@correo.com")
            result = False
        ElseIf Not objValidate.ValidarLetras(txtapellido.Text) Then
            MessageBox.Show("el apellido: " + txtapellido.Text + " no valido")
            result = False
        ElseIf Not objValidate.ValidarLetras(txtdireccion.Text) Then
            MessageBox.Show("direccion: " + txtdireccion.Text + " no valida")
            result = False

        ElseIf Not objValidate.ValidarNumero(txtCedula.Text) Then
            MessageBox.Show("cedula: " + txtCedula.Text + " no valida, solo números")
            result = False
        ElseIf Not objValidate.ValidarNumero(txtcelular.Text) Then
            MessageBox.Show("celular: " + txtcelular.Text + " no valido, solo números")
            result = False
        ElseIf cbFacultad.SelectedIndex < 0 Then
            MessageBox.Show("debe seleccionar una facultad")
            result = False
        ElseIf cbcategoria.SelectedIndex < 0 Then
            MessageBox.Show("debe seleccionar una categoria")
            result = False
        ElseIf Not objValidate.ValidarNumero(txtsalario.Text) Then
            MessageBox.Show("salario: " + txtsalario.Text + " no valido, solo números")
            result = False
        ElseIf cbestado.SelectedIndex < 0 Then
                MessageBox.Show("debe seleccionar el estatus")
                result = False

            End If
        Return result
    End Function
End Class