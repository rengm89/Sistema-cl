Public Class frmConsultaClientes
    Private Sub frmConsultaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        While i < IND
            cmbNombre.Items.Add(clientes(i).nombre)
            i = i + 1
        End While
        cmbNombre.SelectedIndex = 0
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim i As Integer = cmbNombre.SelectedIndex
        lblDeuda.Text = clientes(i).deuda
        lblCredito.Text = clientes(i).limite
    End Sub
End Class