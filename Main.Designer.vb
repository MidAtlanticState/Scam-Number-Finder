<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.dorks = New System.Windows.Forms.TextBox()
        Me.WhatIsAdork = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Start = New System.Windows.Forms.Button()
        Me.NumbersandLinks = New System.Windows.Forms.RichTextBox()
        Me.DorkTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'dorks
        '
        Me.dorks.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.dorks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dorks.ContextMenuStrip = Me.WhatIsAdork
        Me.dorks.Dock = System.Windows.Forms.DockStyle.Top
        Me.dorks.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.dorks.ForeColor = System.Drawing.Color.Red
        Me.dorks.Location = New System.Drawing.Point(0, 0)
        Me.dorks.Name = "dorks"
        Me.dorks.Size = New System.Drawing.Size(354, 17)
        Me.dorks.TabIndex = 101
        Me.dorks.Text = resources.GetString("dorks.Text")
        Me.dorks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DorkTip.SetToolTip(Me.dorks, "Just Google it or right click")
        '
        'WhatIsAdork
        '
        Me.WhatIsAdork.Name = "WhatIsAdork"
        Me.WhatIsAdork.Size = New System.Drawing.Size(61, 4)
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Start.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Start.FlatAppearance.BorderSize = 0
        Me.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.ForeColor = System.Drawing.Color.Red
        Me.Start.Location = New System.Drawing.Point(0, 321)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(354, 60)
        Me.Start.TabIndex = 100
        Me.Start.Text = "Find Me Phone Numbers"
        Me.Start.UseVisualStyleBackColor = False
        '
        'NumbersandLinks
        '
        Me.NumbersandLinks.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.NumbersandLinks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumbersandLinks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumbersandLinks.ForeColor = System.Drawing.Color.Red
        Me.NumbersandLinks.Location = New System.Drawing.Point(0, 17)
        Me.NumbersandLinks.Name = "NumbersandLinks"
        Me.NumbersandLinks.Size = New System.Drawing.Size(354, 304)
        Me.NumbersandLinks.TabIndex = 102
        Me.NumbersandLinks.TabStop = False
        Me.NumbersandLinks.Text = ""
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 381)
        Me.Controls.Add(Me.NumbersandLinks)
        Me.Controls.Add(Me.dorks)
        Me.Controls.Add(Me.Start)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(370, 420)
        Me.Name = "Main"
        Me.Text = "Scam Number Finder"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dorks As TextBox
    Friend WithEvents WhatIsAdork As ContextMenuStrip
    Friend WithEvents DorkTip As ToolTip
    Friend WithEvents Start As Button
    Friend WithEvents NumbersandLinks As RichTextBox
End Class
