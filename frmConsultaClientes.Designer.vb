<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaClientes
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
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.lblCredito = New System.Windows.Forms.Label()
        Me.lblDeuda = New System.Windows.Forms.Label()
        Me.lblLimite = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.cmbNombre = New System.Windows.Forms.ComboBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.grpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.lblCredito)
        Me.grpDatos.Controls.Add(Me.lblDeuda)
        Me.grpDatos.Controls.Add(Me.lblLimite)
        Me.grpDatos.Controls.Add(Me.lblD)
        Me.grpDatos.Location = New System.Drawing.Point(12, 107)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(229, 127)
        Me.grpDatos.TabIndex = 7
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos del cliente"
        '
        'lblCredito
        '
        Me.lblCredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCredito.Location = New System.Drawing.Point(110, 84)
        Me.lblCredito.Name = "lblCredito"
        Me.lblCredito.Size = New System.Drawing.Size(100, 23)
        Me.lblCredito.TabIndex = 3
        Me.lblCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDeuda
        '
        Me.lblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeuda.Location = New System.Drawing.Point(108, 43)
        Me.lblDeuda.Name = "lblDeuda"
        Me.lblDeuda.Size = New System.Drawing.Size(100, 23)
        Me.lblDeuda.TabIndex = 2
        Me.lblDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLimite
        '
        Me.lblLimite.AutoSize = True
        Me.lblLimite.Location = New System.Drawing.Point(6, 89)
        Me.lblLimite.Name = "lblLimite"
        Me.lblLimite.Size = New System.Drawing.Size(87, 13)
        Me.lblLimite.TabIndex = 1
        Me.lblLimite.Text = "Limite de crédito:"
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Location = New System.Drawing.Point(6, 43)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(42, 13)
        Me.lblD.TabIndex = 0
        Me.lblD.Text = "Deuda:"
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(166, 63)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 6
        Me.btnMostrar.Text = "Mostar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'cmbNombre
        '
        Me.cmbNombre.FormattingEnabled = True
        Me.cmbNombre.Location = New System.Drawing.Point(120, 19)
        Me.cmbNombre.Name = "cmbNombre"
        Me.cmbNombre.Size = New System.Drawing.Size(121, 21)
        Me.cmbNombre.TabIndex = 5
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(16, 22)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(98, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre del cliente:"
        '
        'frmConsultaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(257, 249)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.cmbNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "frmConsultaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Clientes"
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents lblCredito As Label
    Friend WithEvents lblDeuda As Label
    Friend WithEvents lblLimite As Label
    Friend WithEvents lblD As Label
    Friend WithEvents btnMostrar As Button
    Friend WithEvents cmbNombre As ComboBox
    Friend WithEvents lblNombre As Label
End Class
