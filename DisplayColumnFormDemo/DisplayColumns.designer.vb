<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayColumns
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmdDown = New System.Windows.Forms.Button()
        Me.cmdUp = New System.Windows.Forms.Button()
        Me.cmdSetAllVisible = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdSetAllVisible)
        Me.Panel1.Controls.Add(Me.cmdApply)
        Me.Panel1.Controls.Add(Me.cmdClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 235)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 53)
        Me.Panel1.TabIndex = 1
        '
        'cmdApply
        '
        Me.cmdApply.Location = New System.Drawing.Point(12, 18)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(75, 23)
        Me.cmdApply.TabIndex = 0
        Me.cmdApply.Text = "Apply"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Location = New System.Drawing.Point(499, 18)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(453, 235)
        Me.DataGridView1.TabIndex = 0
        '
        'cmdDown
        '
        Me.cmdDown.Image = Global.DisplayColumnFormDemo.My.Resources.Resources.DnArrow
        Me.cmdDown.Location = New System.Drawing.Point(482, 85)
        Me.cmdDown.Name = "cmdDown"
        Me.cmdDown.Size = New System.Drawing.Size(75, 48)
        Me.cmdDown.TabIndex = 3
        Me.cmdDown.UseVisualStyleBackColor = True
        '
        'cmdUp
        '
        Me.cmdUp.Image = Global.DisplayColumnFormDemo.My.Resources.Resources.UpArrow
        Me.cmdUp.Location = New System.Drawing.Point(482, 22)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(75, 48)
        Me.cmdUp.TabIndex = 2
        Me.cmdUp.UseVisualStyleBackColor = True
        '
        'cmdSetAllVisible
        '
        Me.cmdSetAllVisible.Location = New System.Drawing.Point(93, 18)
        Me.cmdSetAllVisible.Name = "cmdSetAllVisible"
        Me.cmdSetAllVisible.Size = New System.Drawing.Size(75, 23)
        Me.cmdSetAllVisible.TabIndex = 2
        Me.cmdSetAllVisible.Text = "All Visible"
        Me.cmdSetAllVisible.UseVisualStyleBackColor = True
        '
        'frmDisplayColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 288)
        Me.Controls.Add(Me.cmdDown)
        Me.Controls.Add(Me.cmdUp)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDisplayColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Display Columns"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents cmdApply As System.Windows.Forms.Button
   Friend WithEvents cmdClose As System.Windows.Forms.Button
   Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmdUp As Button
    Friend WithEvents cmdDown As Button
    Friend WithEvents cmdSetAllVisible As Button
End Class
