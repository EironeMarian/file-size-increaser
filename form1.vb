Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Dosya_Şişirici.My.Resources
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Dosya_Şişirici
	' Token: 0x0200000A RID: 10
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x0600002F RID: 47 RVA: 0x0000C4BC File Offset: 0x0000A8BC
		Public Sub New()
			Form1.__ENCAddToList(Me)
			Me.geniş = True
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000030 RID: 48 RVA: 0x0000C4DC File Offset: 0x0000A8DC
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Form1.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = Form1.__ENCList.Count = Form1.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Form1.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Form1.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								Form1.__ENCList(num) = Form1.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Form1.__ENCList.RemoveRange(num, Form1.__ENCList.Count - num)
					Form1.__ENCList.Capacity = Form1.__ENCList.Count
				End If
				Form1.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x06000033 RID: 51 RVA: 0x0000D240 File Offset: 0x0000B640
		' (set) Token: 0x06000034 RID: 52 RVA: 0x0000D258 File Offset: 0x0000B658
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button1_Click
				Dim flag As Boolean = Me._Button1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button1.Click, value2
				End If
				Me._Button1 = value
				flag = (Me._Button1 IsNot Nothing)
				If flag Then
					AddHandler Me._Button1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700000C RID: 12
		' (get) Token: 0x06000035 RID: 53 RVA: 0x0000D2B8 File Offset: 0x0000B6B8
		' (set) Token: 0x06000036 RID: 54 RVA: 0x0000D2D0 File Offset: 0x0000B6D0
		Friend Overridable Property OpenFileDialog1 As OpenFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenFileDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OpenFileDialog)
				Dim value2 As CancelEventHandler = AddressOf Me.OpenFileDialog1_FileOk
				Dim flag As Boolean = Me._OpenFileDialog1 IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenFileDialog1.FileOk, value2
				End If
				Me._OpenFileDialog1 = value
				flag = (Me._OpenFileDialog1 IsNot Nothing)
				If flag Then
					AddHandler Me._OpenFileDialog1.FileOk, value2
				End If
			End Set
		End Property

		' Token: 0x1700000D RID: 13
		' (get) Token: 0x06000037 RID: 55 RVA: 0x0000D330 File Offset: 0x0000B730
		' (set) Token: 0x06000038 RID: 56 RVA: 0x0000D348 File Offset: 0x0000B748
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox1 = value
			End Set
		End Property

		' Token: 0x1700000E RID: 14
		' (get) Token: 0x06000039 RID: 57 RVA: 0x0000D354 File Offset: 0x0000B754
		' (set) Token: 0x0600003A RID: 58 RVA: 0x0000D36C File Offset: 0x0000B76C
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button2_Click
				Dim flag As Boolean = Me._Button2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button2.Click, value2
				End If
				Me._Button2 = value
				flag = (Me._Button2 IsNot Nothing)
				If flag Then
					AddHandler Me._Button2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x0600003B RID: 59 RVA: 0x0000D3CC File Offset: 0x0000B7CC
		' (set) Token: 0x0600003C RID: 60 RVA: 0x0000D3E4 File Offset: 0x0000B7E4
		Friend Overridable Property Label1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		' Token: 0x17000010 RID: 16
		' (get) Token: 0x0600003D RID: 61 RVA: 0x0000D3F0 File Offset: 0x0000B7F0
		' (set) Token: 0x0600003E RID: 62 RVA: 0x0000D408 File Offset: 0x0000B808
		Friend Overridable Property Label2 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x0600003F RID: 63 RVA: 0x0000D414 File Offset: 0x0000B814
		' (set) Token: 0x06000040 RID: 64 RVA: 0x0000D42C File Offset: 0x0000B82C
		Friend Overridable Property NumericUpDown1 As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._NumericUpDown1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._NumericUpDown1 = value
			End Set
		End Property

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x06000041 RID: 65 RVA: 0x0000D438 File Offset: 0x0000B838
		' (set) Token: 0x06000042 RID: 66 RVA: 0x0000D450 File Offset: 0x0000B850
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = AddressOf Me.PictureBox1_Click
				Dim flag As Boolean = Me._PictureBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox1.Click, value2
				End If
				Me._PictureBox1 = value
				flag = (Me._PictureBox1 IsNot Nothing)
				If flag Then
					AddHandler Me._PictureBox1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x06000043 RID: 67 RVA: 0x0000D4B0 File Offset: 0x0000B8B0
		' (set) Token: 0x06000044 RID: 68 RVA: 0x0000D4C8 File Offset: 0x0000B8C8
		Friend Overridable Property Label3 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x06000045 RID: 69 RVA: 0x0000D4D4 File Offset: 0x0000B8D4
		' (set) Token: 0x06000046 RID: 70 RVA: 0x0000D4EC File Offset: 0x0000B8EC
		Friend Overridable Property Timer1 As System.Windows.Forms.Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Me._Timer1 = value
			End Set
		End Property

		' Token: 0x17000015 RID: 21
		' (get) Token: 0x06000047 RID: 71 RVA: 0x0000D4F8 File Offset: 0x0000B8F8
		' (set) Token: 0x06000048 RID: 72 RVA: 0x0000D510 File Offset: 0x0000B910
		Friend Overridable Property GroupBox2 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox2 = value
			End Set
		End Property

		' Token: 0x17000016 RID: 22
		' (get) Token: 0x06000049 RID: 73 RVA: 0x0000D51C File Offset: 0x0000B91C
		' (set) Token: 0x0600004A RID: 74 RVA: 0x0000D534 File Offset: 0x0000B934
		Friend Overridable Property Label4 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		' Token: 0x17000017 RID: 23
		' (get) Token: 0x0600004B RID: 75 RVA: 0x0000D540 File Offset: 0x0000B940
		' (set) Token: 0x0600004C RID: 76 RVA: 0x0000D558 File Offset: 0x0000B958
		Friend Overridable Property PictureBox2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = AddressOf Me.PictureBox2_Click
				Dim flag As Boolean = Me._PictureBox2 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox2.Click, value2
				End If
				Me._PictureBox2 = value
				flag = (Me._PictureBox2 IsNot Nothing)
				If flag Then
					AddHandler Me._PictureBox2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000018 RID: 24
		' (get) Token: 0x0600004D RID: 77 RVA: 0x0000D5B8 File Offset: 0x0000B9B8
		' (set) Token: 0x0600004E RID: 78 RVA: 0x0000D5D0 File Offset: 0x0000B9D0
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = AddressOf Me.PictureBox3_Click
				Dim flag As Boolean = Me._PictureBox3 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox3.Click, value2
				End If
				Me._PictureBox3 = value
				flag = (Me._PictureBox3 IsNot Nothing)
				If flag Then
					AddHandler Me._PictureBox3.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000019 RID: 25
		' (get) Token: 0x0600004F RID: 79 RVA: 0x0000D630 File Offset: 0x0000BA30
		' (set) Token: 0x06000050 RID: 80 RVA: 0x0000D648 File Offset: 0x0000BA48
		Friend Overridable Property PictureBox4 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = AddressOf Me.PictureBox4_Click
				Dim flag As Boolean = Me._PictureBox4 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox4.Click, value2
				End If
				Me._PictureBox4 = value
				flag = (Me._PictureBox4 IsNot Nothing)
				If flag Then
					AddHandler Me._PictureBox4.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700001A RID: 26
		' (get) Token: 0x06000051 RID: 81 RVA: 0x0000D6A8 File Offset: 0x0000BAA8
		' (set) Token: 0x06000052 RID: 82 RVA: 0x0000D6C0 File Offset: 0x0000BAC0
		Friend Overridable Property GroupBox1 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox1 = value
			End Set
		End Property

		' Token: 0x1700001B RID: 27
		' (get) Token: 0x06000053 RID: 83 RVA: 0x0000D6CC File Offset: 0x0000BACC
		' (set) Token: 0x06000054 RID: 84 RVA: 0x0000D6E4 File Offset: 0x0000BAE4
		Friend Overridable Property Label5 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label5 = value
			End Set
		End Property

		' Token: 0x06000055 RID: 85 RVA: 0x0000D6F0 File Offset: 0x0000BAF0
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.OpenFileDialog1.Filter = "Tüm Dosyalar(*.*)|*.*"
			Me.OpenFileDialog1.FileName = ""
			Me.OpenFileDialog1.ShowDialog()
		End Sub

		' Token: 0x06000056 RID: 86 RVA: 0x0000D724 File Offset: 0x0000BB24
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "", False) = 0
			If flag Then
				Interaction.MsgBox("Lütfen Şişirmek İstediğiniz Bir Dosya Seçiniz!", MsgBoxStyle.Exclamation, "Hata!")
			Else
				flag = (Decimal.Compare(Me.NumericUpDown1.Value, 0D) = 0)
				If flag Then
					Interaction.MsgBox("Lütfen Dosyayı Kaç Mb Şişirmek İstediğinizi Yazınız!", MsgBoxStyle.Exclamation, "Hata!")
				Else
					Try
						Dim fileStream As FileStream = File.OpenWrite(Me.TextBox1.Text)
						Dim num As Long = fileStream.Seek(0L, SeekOrigin.[End])
						Dim num2 As Integer = Convert.ToInt32(Me.NumericUpDown1.Value)
						Dim d As Decimal = New Decimal(CLng((num2 * 1048576)) + fileStream.Length)
						While Decimal.Compare(New Decimal(num), d) < 0
							num += 1L
							fileStream.WriteByte(0)
						End While
						fileStream.Close()
						Interaction.MsgBox("Dosya Başarıyla Şişirildi!", MsgBoxStyle.Information, "Başarılı!")
					Catch ex As Exception
						Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Hata!")
					End Try
				End If
			End If
		End Sub

		' Token: 0x06000057 RID: 87 RVA: 0x0000D85C File Offset: 0x0000BC5C
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
			Process.Start("http://coderzy.blogspot.com/")
		End Sub

		' Token: 0x06000058 RID: 88 RVA: 0x0000D86C File Offset: 0x0000BC6C
		Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
			Process.Start("https://twitter.com/CoderZY")
		End Sub

		' Token: 0x06000059 RID: 89 RVA: 0x0000D87C File Offset: 0x0000BC7C
		Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
			Process.Start("https://plus.google.com/u/0/108018280406843929957")
		End Sub

		' Token: 0x0600005A RID: 90 RVA: 0x0000D88C File Offset: 0x0000BC8C
		Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
			Process.Start("https://www.facebook.com/pages/Coderzy/469948773043640")
		End Sub

		' Token: 0x0600005B RID: 91 RVA: 0x0000D89C File Offset: 0x0000BC9C
		Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs)
			Me.TextBox1.Text = String.Empty
			Me.TextBox1.Text = Me.OpenFileDialog1.FileName
		End Sub

		' Token: 0x0400000D RID: 13
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400000F RID: 15
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000010 RID: 16
		<AccessedThroughProperty("OpenFileDialog1")>
		Private _OpenFileDialog1 As OpenFileDialog

		' Token: 0x04000011 RID: 17
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000012 RID: 18
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000013 RID: 19
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000014 RID: 20
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000015 RID: 21
		<AccessedThroughProperty("NumericUpDown1")>
		Private _NumericUpDown1 As NumericUpDown

		' Token: 0x04000016 RID: 22
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000017 RID: 23
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000018 RID: 24
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As System.Windows.Forms.Timer

		' Token: 0x04000019 RID: 25
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x0400001A RID: 26
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x0400001B RID: 27
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x0400001C RID: 28
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x0400001D RID: 29
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x0400001E RID: 30
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x0400001F RID: 31
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x04000020 RID: 32
		Private geniş As Boolean
	End Class
End Namespace
