<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosProgramador
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
        Me.grpDatosProgramador = New System.Windows.Forms.GroupBox()
        Me.lblDev = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblDesarrollador = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.grpDatosProgramador.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatosProgramador
        '
        Me.grpDatosProgramador.Controls.Add(Me.lblDev)
        Me.grpDatosProgramador.Controls.Add(Me.lblFecha)
        Me.grpDatosProgramador.Controls.Add(Me.lblDesarrollador)
        Me.grpDatosProgramador.Controls.Add(Me.lblVersion)
        Me.grpDatosProgramador.Location = New System.Drawing.Point(12, 12)
        Me.grpDatosProgramador.Name = "grpDatosProgramador"
        Me.grpDatosProgramador.Size = New System.Drawing.Size(247, 160)
        Me.grpDatosProgramador.TabIndex = 1
        Me.grpDatosProgramador.TabStop = False
        Me.grpDatosProgramador.Text = "Desarrollador"
        '
        'lblDev
        '
        Me.lblDev.AutoSize = True
        Me.lblDev.Location = New System.Drawing.Point(100, 81)
        Me.lblDev.Name = "lblDev"
        Me.lblDev.Size = New System.Drawing.Size(78, 13)
        Me.lblDev.TabIndex = 3
        Me.lblDev.Text = "Renzo Giraudo"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(19, 124)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(131, 13)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Córdoba, Argentina - 2021"
        '
        'lblDesarrollador
        '
        Me.lblDesarrollador.AutoSize = True
        Me.lblDesarrollador.Location = New System.Drawing.Point(19, 81)
        Me.lblDesarrollador.Name = "lblDesarrollador"
        Me.lblDesarrollador.Size = New System.Drawing.Size(75, 13)
        Me.lblDesarrollador.TabIndex = 1
        Me.lblDesarrollador.Text = "Desarrollador :"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(19, 39)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(60, 13)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "Versión 1.0"
        '
        'frmDatosProgramador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(267, 182)
        Me.Controls.Add(Me.grpDatosProgramador)
        Me.Name = "frmDatosProgramador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del Programador"
        Me.grpDatosProgramador.ResumeLayout(False)
        Me.grpDatosProgramador.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpDatosProgramador As GroupBox
    Friend WithEvents lblDev As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblDesarrollador As Label
    Friend WithEvents lblVersion As Label
End Class
