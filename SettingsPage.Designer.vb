<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PageWaitValue = New System.Windows.Forms.NumericUpDown()
        Me.PagesToCheck = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FindExepath = New System.Windows.Forms.OpenFileDialog()
        Me.ExePath = New System.Windows.Forms.Button()
        Me.SaveSettings = New System.Windows.Forms.Button()
        CType(Me.PageWaitValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagesToCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "page wait time                     second"
        '
        'PageWaitValue
        '
        Me.PageWaitValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.PageWaitValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PageWaitValue.ForeColor = System.Drawing.Color.Red
        Me.PageWaitValue.Location = New System.Drawing.Point(92, 16)
        Me.PageWaitValue.Name = "PageWaitValue"
        Me.PageWaitValue.Size = New System.Drawing.Size(45, 16)
        Me.PageWaitValue.TabIndex = 100
        Me.PageWaitValue.TabStop = False
        Me.PageWaitValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PagesToCheck
        '
        Me.PagesToCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.PagesToCheck.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PagesToCheck.ForeColor = System.Drawing.Color.Red
        Me.PagesToCheck.Location = New System.Drawing.Point(149, 35)
        Me.PagesToCheck.Name = "PagesToCheck"
        Me.PagesToCheck.Size = New System.Drawing.Size(45, 16)
        Me.PagesToCheck.TabIndex = 100
        Me.PagesToCheck.TabStop = False
        Me.PagesToCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "number of pages to check"
        '
        'FindExepath
        '
        Me.FindExepath.DefaultExt = "exe"
        '
        'ExePath
        '
        Me.ExePath.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ExePath.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ExePath.Location = New System.Drawing.Point(15, 57)
        Me.ExePath.Name = "ExePath"
        Me.ExePath.Size = New System.Drawing.Size(75, 28)
        Me.ExePath.TabIndex = 103
        Me.ExePath.Text = "Exe path"
        Me.ExePath.UseVisualStyleBackColor = False
        '
        'SaveSettings
        '
        Me.SaveSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.SaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveSettings.Location = New System.Drawing.Point(410, 176)
        Me.SaveSettings.Name = "SaveSettings"
        Me.SaveSettings.Size = New System.Drawing.Size(112, 28)
        Me.SaveSettings.TabIndex = 104
        Me.SaveSettings.Text = "Save"
        Me.SaveSettings.UseVisualStyleBackColor = False
        '
        'SettingsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 216)
        Me.Controls.Add(Me.SaveSettings)
        Me.Controls.Add(Me.ExePath)
        Me.Controls.Add(Me.PagesToCheck)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PageWaitValue)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(550, 255)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 255)
        Me.Name = "SettingsPage"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        CType(Me.PageWaitValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagesToCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PageWaitValue As NumericUpDown
    Friend WithEvents PagesToCheck As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents FindExepath As OpenFileDialog
    Friend WithEvents ExePath As Button
    Friend WithEvents SaveSettings As Button
End Class
