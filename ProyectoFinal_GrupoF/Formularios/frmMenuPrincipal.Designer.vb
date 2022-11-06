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
        Me.menuOpciones.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.menuOpciones.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.menuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.menuOpciones.Name = "menuOpciones"
        Me.menuOpciones.Size = New System.Drawing.Size(1200, 34)
        Me.menuOpciones.TabIndex = 1
        Me.menuOpciones.Text = "MenuStrip1"
        '
        'barraAbajo
        '
        Me.barraAbajo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barraAbajo.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.barraAbajo.Location = New System.Drawing.Point(0, 667)
        Me.barraAbajo.Name = "barraAbajo"
        Me.barraAbajo.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.barraAbajo.Size = New System.Drawing.Size(1200, 25)
        Me.barraAbajo.TabIndex = 2
        Me.barraAbajo.Text = "ToolStrip1"
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.ControlBox = False
        Me.Controls.Add(Me.barraAbajo)
        Me.Controls.Add(Me.menuOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuOpciones
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
