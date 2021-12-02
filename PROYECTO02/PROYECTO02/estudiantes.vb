Imports Capa_servicios
Public Class estudiantes
    Dim objFacultades As New facultad
    Dim objEstudiante As New Estudiante
    Dim objValidate As New Validate
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As DataTable = objFacultades.ListarFaculdates()
        Try
            cbFacultad.DataSource = dt
            cbFacultad.DisplayMember = dt.Columns(1).ColumnName
            cbFacultad.ValueMember = dt.Columns(0).ColumnName
            btnAgregar.Enabled = False
            btnActualizar.Enabled = False
            btnEliminar.Enabled = False
        Catch ex As Exception

        End Try

        limpiar()
    End Sub
    Private Sub btnlistarE_Click(sender As Object, e As EventArgs) Handles btnlistarE.Click
        listarTable()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If String.IsNullOrEmpty(txtCedula.Text) Then
            MessageBox.Show("cedula en blanco ")
        ElseIf Not objValidate.ValidarNumero(txtCedula.Text) Then
            MessageBox.Show("cedula: " + txtCedula.Text + " no valida, solo números")
        Else
            Dim Dt As DataSet = objEstudiante.Buscar(txtCedula.Text)
            If (Dt.Tables(0).Rows.Count > 0) Then

                txtCedula.Enabled = False
                btnActualizar.Enabled = True
                btnEliminar.Enabled = True
                btnbuscar.Enabled = False
                btnAgregar.Enabled = False
                txtnombre.Text = Dt.Tables(0).Rows(0).Item("nombre")
                txtapellido.Text = Dt.Tables(0).Rows(0).Item("apellido")
                txtdireccion.Text = Dt.Tables(0).Rows(0).Item("direccion")
                txtcelular.Text = Dt.Tables(0).Rows(0).Item("celular")
                txtcorreo.Text = Dt.Tables(0).Rows(0).Item("correo")
                cbFacultad.SelectedIndex = cbFacultad.FindStringExact(Dt.Tables(0).Rows(0).Item("facultad"))
                txtindice.Text = Dt.Tables(0).Rows(0).Item("indice_academico")
                MessageBox.Show("Estudiante con cedula: " + txtCedula.Text + " Nombre: " + txtnombre.Text + " fue encontrado")
                If Dt.Tables(0).Rows(0).Item("estatus") = 1 Then
                    cbestado.SelectedIndex = 0
                Else
                    cbestado.SelectedIndex = 1
                End If


                cbsexo.SelectedIndex = cbsexo.FindStringExact(Dt.Tables(0).Rows(0).Item("sexo"))
                Dim dtcb As DataTable = objFacultades.BuscarCarreras(Dt.Tables(0).Rows(0).Item("cod_facultad"))
                cbcarreras.DataSource = dtcb
                cbcarreras.DisplayMember = dtcb.Columns(1).ColumnName
                cbcarreras.ValueMember = dtcb.Columns(0).ColumnName
                cbcarreras.SelectedIndex = cbcarreras.FindStringExact(Dt.Tables(0).Rows(0).Item("carrera"))
            Else
                btnActualizar.Enabled = False
                btnEliminar.Enabled = False
                btnAgregar.Enabled = True
                txtCedula.Enabled = False

                txtnombre.Text = ""
                txtapellido.Text = ""
                txtdireccion.Text = ""
                txtcelular.Text = ""
                txtcorreo.Text = ""
                cbFacultad.SelectedIndex = -1
                txtindice.Text = ""
                cbsexo.SelectedIndex = -1
                cbcarreras.DataSource = {}

                MessageBox.Show("Estudiante con cedula: " + txtCedula.Text + " no fue encontrado, puede crearlo")
            End If
            txtnombre.Enabled = True
            txtapellido.Enabled = True
            txtdireccion.Enabled = True
            txtcelular.Enabled = True
            txtcorreo.Enabled = True
            cbFacultad.Enabled = True
            txtindice.Enabled = True
            cbsexo.Enabled = True
            cbcarreras.Enabled = True
            cbestado.Enabled = True
        End If






    End Sub

    Private Sub cbFacultad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFacultad.SelectedIndexChanged

        Dim faculdad = CType(sender, ComboBox)
        If (faculdad.SelectedIndex >= 0) Then
            Try
                Dim dtcb As DataTable = objFacultades.BuscarCarreras(faculdad.SelectedItem.Row.ItemArray(0))
                cbcarreras.DataSource = dtcb
                cbcarreras.DisplayMember = dtcb.Columns(1).ColumnName
                cbcarreras.ValueMember = dtcb.Columns(0).ColumnName
                cbcarreras.SelectedIndex = -1
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim estado As Int32 = 0
        If (cbestado.SelectedItem = "Activo") Then
            estado = 1
        End If

        If (validateValues()) Then
            Try
                Dim modeloEstudiante As New modeloEstudiante(txtCedula.Text, txtnombre.Text, txtapellido.Text, txtdireccion.Text,
           txtcelular.Text, txtcorreo.Text, cbFacultad.SelectedItem.Row.ItemArray(0), cbcarreras.SelectedItem.Row.ItemArray(0),
           txtindice.Text, cbsexo.SelectedItem, estado)

                If objEstudiante.crearEstudiante(modeloEstudiante) Then
                    btnAgregar.Enabled = False
                    btnActualizar.Enabled = True
                    btnEliminar.Enabled = True
                    txtCedula.Enabled = False
                    listarTable()
                    MessageBox.Show("Estudiante con cedula: " + txtCedula.Text + " Nombre: " + txtnombre.Text + " fue agregado")
                Else
                    MessageBox.Show("Estudiante con cedula: " + txtCedula.Text + " Nombre: " + txtnombre.Text + " no fue agregado")
                End If
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim estado As Int32 = 0
        If (cbestado.SelectedItem = "Activo") Then
            estado = 1
        End If

        If (validateValues()) Then
            Try
                Dim modeloEstudiante As New modeloEstudiante(txtCedula.Text, txtnombre.Text, txtapellido.Text, txtdireccion.Text,
                txtcelular.Text, txtcorreo.Text, cbFacultad.SelectedItem.Row.ItemArray(0), cbcarreras.SelectedItem.Row.ItemArray(0),
                txtindice.Text, cbsexo.SelectedItem, estado)

                If objEstudiante.actualizarEstudiante(modeloEstudiante) Then
                    listarTable()
                    MessageBox.Show("Estudiante con cedula: " + txtCedula.Text + " Nombre: " + txtnombre.Text + " fue actualizado")
                Else
                    MessageBox.Show("Estudiante con cedula: " + txtCedula.Text + " Nombre: " + txtnombre.Text + " no fue actualizado")
                End If
            Catch ex As Exception
                MessageBox.Show("Error")
            End Try

        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrEmpty(txtCedula.Text) Then
            MessageBox.Show("cedula en blanco ")
        ElseIf Not objValidate.ValidarNumero(txtCedula.Text) Then
            MessageBox.Show("cedula: " + txtCedula.Text + " no valida, solo números")
        Else
            Try
                If objEstudiante.Delete(txtCedula.Text) Then

                    MessageBox.Show("Estudiante con cedula: " + txtCedula.Text + " Nombre: " + txtnombre.Text + " fue eliminado")
                    listarTable()
                    limpiar()
                Else

                    MessageBox.Show("Estudiante con cedula: " + txtCedula.Text + " Nombre: " + txtnombre.Text + " no fue eliminado")
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Private Function limpiar()
        txtCedula.Text = ""
        txtnombre.Text = ""
        txtapellido.Text = ""
        txtdireccion.Text = ""
        txtcelular.Text = ""
        txtcorreo.Text = ""
        cbFacultad.SelectedIndex = -1
        txtindice.Text = ""
        cbsexo.SelectedIndex = -1
        cbcarreras.DataSource = {}
        cbestado.SelectedIndex = -1
        txtCedula.Enabled = True
        btnbuscar.Enabled = True
        btnActualizar.Enabled = False
        btnEliminar.Enabled = False

        txtnombre.Enabled = False
        txtapellido.Enabled = False
        txtdireccion.Enabled = False
        txtcelular.Enabled = False
        txtcorreo.Enabled = False
        cbFacultad.Enabled = False
        txtindice.Enabled = False
        cbsexo.Enabled = False
        cbcarreras.Enabled = False
        cbestado.Enabled = False
    End Function
    Private Function listarTable()
        DataGridViewEstudiantes.DataSource = objEstudiante.Listar().Tables(0)
    End Function

    Private Function validateValues()
        Dim result As Boolean = True
        If Not objValidate.ValidarNumero(txtCedula.Text) Then
            MessageBox.Show("cedula: " + txtCedula.Text + " no valida, solo números")
            result = False
        ElseIf (Not objValidate.ValidarLetras(txtnombre.Text)) Then
            MessageBox.Show("el nombre: " + txtnombre.Text + " no valido")
            result = False

        ElseIf Not objValidate.ValidarLetras(txtapellido.Text) Then
            MessageBox.Show("el apellido: " + txtapellido.Text + " no valido")
            result = False
        ElseIf Not objValidate.ValidarLetras(txtdireccion.Text) Then
            MessageBox.Show("direccion: " + txtdireccion.Text + " no valida")
            result = False

        ElseIf Not objValidate.ValidarNumero(txtcelular.Text) Then
            MessageBox.Show("celular: " + txtcelular.Text + " no valido, solo números")
            result = False
        ElseIf Not objValidate.Validarcorreo(txtcorreo.Text) Then
            MessageBox.Show("correo: " + txtcorreo.Text + " no es un correo, ejemplo@correo.com")
            result = False
        ElseIf cbFacultad.SelectedIndex < 0 Then
            MessageBox.Show("debe seleccionar una facultad")
            result = False
        ElseIf cbcarreras.SelectedIndex < 0 Then
            MessageBox.Show("debe seleccionar una carrera")
            result = False
        ElseIf Not objValidate.ValidarNumero(txtindice.Text) Then
            MessageBox.Show("indice: " + txtindice.Text + " no valido, solo números")
            result = False
        ElseIf objValidate.ValidarNumero(txtindice.Text) Then
            If Not String.IsNullOrEmpty(txtindice.Text) Then
                If txtindice.Text > 0 And txtindice.Text <= 3 Then


                Else
                    MessageBox.Show("indice: " + txtindice.Text + " no valido, valor entre 0 y 3")
                    result = False
                End If
            Else
                MessageBox.Show("indice: " + txtindice.Text + " no valido, valor entre 0 y 3")
                result = False
            End If

        End If
        If (result) Then
            If cbsexo.SelectedIndex < 0 Then
                MessageBox.Show("debe seleccionar el sexo")
                result = False
            ElseIf cbestado.SelectedIndex < 0 Then
                MessageBox.Show("debe seleccionar el estatus")
                result = False
            End If
        End If

        Return result
    End Function
End Class