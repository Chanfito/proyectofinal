<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Me.menuOpciones = New System.Windows.Forms.MenuStrip()
        Me.barraAbajo = New System.Windows.Forms.ToolStrip()
        Me.SuspendLayout()
        '
        'menuOpciones
        '
        Me.menuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.menuOpciones.Name = "menuOpciones"
        Me.menuOpciones.Size = New System.Drawing.Size(800, 24)
        Me.menuOpciones.TabIndex = 1
        Me.menuOpciones.Text = "MenuStrip1"
        '
        'barraAbajo
        '
        Me.barraAbajo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barraAbajo.Location = New System.Drawing.Point(0, 425)
        Me.barraAbajo.Name = "barraAbajo"
        Me.barraAbajo.Size = New System.Drawing.Size(800, 25)
        Me.barraAbajo.TabIndex = 2
        Me.barraAbajo.Text = "ToolStrip1"
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.barraAbajo)
        Me.Controls.Add(Me.menuOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuOpciones
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuOpciones As MenuStrip
    Friend WithEvents barraAbajo As ToolStrip
End Class
