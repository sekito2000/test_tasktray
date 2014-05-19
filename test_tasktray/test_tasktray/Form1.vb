Imports System.Security.Permissions

Public Class Form1

	'【フォームを表示しないようにする方法】
	'フォームのCreateParamsプロパティをオーバーライドする
	Protected Overrides ReadOnly Property CreateParams() As CreateParams
		<SecurityPermission(SecurityAction.Demand, _
		 Flags:=SecurityPermissionFlag.UnmanagedCode)> _
		Get
			Const WS_EX_TOOLWINDOW As Int32 = &H80
			Const WS_POPUP As Int32 = &H80000000
			Const WS_VISIBLE As Int32 = &H10000000
			Const WS_SYSMENU As Int32 = &H80000
			Const WS_MAXIMIZEBOX As Int32 = &H10000

			Dim cp As System.Windows.Forms.CreateParams
			cp = MyBase.CreateParams
			cp.ExStyle = WS_EX_TOOLWINDOW
			cp.Style = WS_POPUP Or WS_VISIBLE Or _
			 WS_SYSMENU Or WS_MAXIMIZEBOX
			cp.Height = 0
			cp.Width = 0
			Return cp
		End Get
	End Property


	Private Sub 終了ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 終了ToolStripMenuItem.Click
		NotifyIcon1.Visible = False		'アイコンをトレイから取り除く
		Timer1.Enabled = False			'[ｵﾌ]メール送信ﾁｪｯｸﾀｲﾏー
		Timer2.Enabled = False			'[ｵﾌ]重複送防止用ﾀｲﾏー
		Application.Exit()				'[終了]ｱﾌﾟﾘ
	End Sub

	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		'MessageBox.Show("aaa")
		Timer1.Enabled = True			'[ｵﾝ]メール送信ﾁｪｯｸﾀｲﾏー
		Timer2.Enabled = False			'[ｵﾌ]重複送防止用ﾀｲﾏー
	End Sub

	'[ﾀｲﾏｰ]メール送信ﾁｪｯｸ≪ｲﾝﾀｰﾊﾞﾙ：５秒≫
	Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
		Dim stHHmm As String
		stHHmm = Format(Now, "HH:mm")
		'[一致]メール送信時間
		If stHHmm = "22:12" Then
			Timer1.Enabled = False	'[ｵﾌ]メール送信ﾁｪｯｸﾀｲﾏー
			Timer2.Enabled = True	'[ｵﾝ]重複送防止用ﾀｲﾏー

			'[メール送信]
			MessageBox.Show("22:12です≪メール送信します≫")
		End If
	End Sub

	'[ﾀｲﾏｰ]重複送防止用≪ｲﾝﾀｰﾊﾞﾙ：１分≫
	Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
		Timer2.Enabled = False	'[ｵﾌ]重複送防止用ﾀｲﾏー
		Timer1.Enabled = True	'[ｵﾝ]メール送信ﾁｪｯｸﾀｲﾏー
	End Sub
End Class
