<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoCliente
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
        Me.grpCargaCliente = New System.Windows.Forms.GroupBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDeuda = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblLimite = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDeuda = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.grpCargaCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCargaCliente
        '
        Me.grpCargaCliente.Controls.Add(Me.btnCargar)
        Me.grpCargaCliente.Controls.Add(Me.txtLimite)
        Me.grpCargaCliente.Controls.Add(Me.txtNombre)
        Me.grpCargaCliente.Controls.Add(Me.txtDeuda)
        Me.grpCargaCliente.Controls.Add(Me.txtCodigo)
        Me.grpCargaCliente.Controls.Add(Me.lblLimite)
        Me.grpCargaCliente.Controls.Add(Me.lblNombre)
        Me.grpCargaCliente.Controls.Add(Me.lblDeuda)
        Me.grpCargaCliente.Controls.Add(Me.lblCodigo)
        Me.grpCargaCliente.Location = New System.Drawing.Point(12, 16)
        Me.grpCargaCliente.Name = "grpCargaCliente"
        Me.grpCargaCliente.Size = New System.Drawing.Size(506, 168)
        Me.grpCargaCliente.TabIndex = 1
        Me.grpCargaCliente.TabStop = False
        Me.grpCargaCliente.Text = "Cargar Cliente"
        '
        'btnCargar
        '
        Me.btnCargar.Enabled = False
        Me.btnCargar.Location = New System.Drawing.Point(365, 139)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 5
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'txtLimite
        '
        Me.txtLimite.Location = New System.Drawing.Point(340, 94)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(100, 20)
        Me.txtLimite.TabIndex = 4
        Me.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(340, 35)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDeuda
        '
        Me.txtDeuda.Location = New System.Drawing.Point(98, 94)
        Me.txtDeuda.Name = "txtDeuda"
        Me.txtDeuda.Size = New System.Drawing.Size(100, 20)
        Me.txtDeuda.TabIndex = 3
        Me.txtDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(98, 36)
        Me.txtCodigo.MaxLength = 8
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLimite
        '
        Me.lblLimite.AutoSize = True
        Me.lblLimite.Location = New System.Drawing.Point(239, 97)
        Me.lblLimite.Name = "lblLimite"
        Me.lblLimite.Size = New System.Drawing.Size(89, 13)
        Me.lblLimite.TabIndex = 3
        Me.lblLimite.Text = "Límite de crédito:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(239, 38)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(95, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre y Apellido:"
        '
        'lblDeuda
        '
        Me.lblDeuda.AutoSize = True
        Me.lblDeuda.Location = New System.Drawing.Point(28, 97)
        Me.lblDeuda.Name = "lblDeuda"
        Me.lblDeuda.Size = New System.Drawing.Size(42, 13)
        Me.lblDeuda.TabIndex = 1
        Me.lblDeuda.Text = "Deuda:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(28, 39)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'frmNuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(526, 196)
        Me.Controls.Add(Me.grpCargaCliente)
        Me.Name = "frmNuevoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Cliente"
        Me.grpCargaCliente.ResumeLayout(False)
        Me.grpCargaCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCargaCliente As GroupBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents txtLimite As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDeuda As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblLimite As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDeuda As Label
    Friend WithEvents lblCodigo As Label
End Class
