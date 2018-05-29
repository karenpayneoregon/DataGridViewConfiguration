<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdFreezeCurrentColumn = New System.Windows.Forms.Button()
        Me.cmdExpandColumns = New System.Windows.Forms.Button()
        Me.cmdShowHide = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FrozenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdFreezeCurrentColumn)
        Me.Panel1.Controls.Add(Me.cmdExpandColumns)
        Me.Panel1.Controls.Add(Me.cmdShowHide)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 274)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 78)
        Me.Panel1.TabIndex = 1
        '
        'cmdFreezeCurrentColumn
        '
        Me.cmdFreezeCurrentColumn.Location = New System.Drawing.Point(196, 14)
        Me.cmdFreezeCurrentColumn.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdFreezeCurrentColumn.Name = "cmdFreezeCurrentColumn"
        Me.cmdFreezeCurrentColumn.Size = New System.Drawing.Size(73, 33)
        Me.cmdFreezeCurrentColumn.TabIndex = 2
        Me.cmdFreezeCurrentColumn.Text = "Freeze col"
        Me.cmdFreezeCurrentColumn.UseVisualStyleBackColor = True
        '
        'cmdExpandColumns
        '
        Me.cmdExpandColumns.Location = New System.Drawing.Point(104, 14)
        Me.cmdExpandColumns.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExpandColumns.Name = "cmdExpandColumns"
        Me.cmdExpandColumns.Size = New System.Drawing.Size(73, 33)
        Me.cmdExpandColumns.TabIndex = 1
        Me.cmdExpandColumns.Text = "Expand cols"
        Me.cmdExpandColumns.UseVisualStyleBackColor = True
        '
        'cmdShowHide
        '
        Me.cmdShowHide.Location = New System.Drawing.Point(17, 14)
        Me.cmdShowHide.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdShowHide.Name = "cmdShowHide"
        Me.cmdShowHide.Size = New System.Drawing.Size(73, 33)
        Me.cmdShowHide.TabIndex = 0
        Me.cmdShowHide.Text = "Show/Hide"
        Me.cmdShowHide.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(833, 274)
        Me.DataGridView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FrozenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 26)
        '
        'FrozenToolStripMenuItem
        '
        Me.FrozenToolStripMenuItem.Name = "FrozenToolStripMenuItem"
        Me.FrozenToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.FrozenToolStripMenuItem.Text = "Frozen"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 352)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuring columns in a DataGridView"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmdShowHide As System.Windows.Forms.Button
    Friend WithEvents cmdExpandColumns As System.Windows.Forms.Button
    Friend WithEvents cmdFreezeCurrentColumn As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FrozenToolStripMenuItem As ToolStripMenuItem
End Class
