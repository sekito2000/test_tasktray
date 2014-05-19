<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
		Me.ContextMenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'NotifyIcon1
		'
		Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
		Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
		Me.NotifyIcon1.Text = "SendMail"
		Me.NotifyIcon1.Visible = True
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.終了ToolStripMenuItem})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(101, 26)
		'
		'終了ToolStripMenuItem
		'
		Me.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem"
		Me.終了ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
		Me.終了ToolStripMenuItem.Text = "終了"
		'
		'Timer1
		'
		Me.Timer1.Interval = 5000
		'
		'Timer2
		'
		Me.Timer2.Interval = 60000
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 262)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
	Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents 終了ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents Timer1 As System.Windows.Forms.Timer
	Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
