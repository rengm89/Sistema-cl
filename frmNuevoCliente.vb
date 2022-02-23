Public Class frmNuevoCliente
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If IND < 10 Then
            clientes(IND).codigo = txtCodigo.Text
            clientes(IND).nombre = txtNombre.Text
            clientes(IND).limite = txtLimite.Text
            clientes(IND).deuda = txtDeuda.Text
            IND = IND + 1
            MessageBox.Show("Datos cargados")
        Else
            MessageBox.Show("No se pueden cargar más datos")
        End If

        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtLimite.Text = ""
        txtDeuda.Text = ""
    End Sub

    Private Sub CargaDatos()
        If txtCodigo.Text <> "" And txtNombre.Text <> "" And txtLimite.Text <> "" And txtDeuda.Text <> "" Then
            btnCargar.Enabled = True
        Else
            btnCargar.Enabled = False
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        CargaDatos()
    End Sub

    Private Sub txtDeuda_TextChanged(sender As Object, e As EventArgs) Handles txtDeuda.TextChanged
        CargaDatos()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        CargaDatos()
    End Sub

    Private Sub txtLimite_TextChanged(sender As Object, e As EventArgs) Handles txtLimite.TextChanged
        CargaDatos()
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtNombre.Select()
            e.Handled = True
        Else
            If IsNumeric(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtDeuda.Select()
            e.Handled = True
        End If
    End Sub

    Private Sub txtDeuda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDeuda.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtLimite.Select()
            e.Handled = True
        Else
            If IsNumeric(e.KeyChar) Or e.KeyChar = "." Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtLimite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLimite.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btnCargar.Select()
            e.Handled = True
        End If
    End Sub
End Class