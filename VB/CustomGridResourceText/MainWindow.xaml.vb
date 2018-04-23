Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Grid

Namespace CustomGridResourceText
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			GridControlResXLocalizer.Active = New CustomGridLocalizer()

			InitializeComponent()

			Dim data As New ObservableCollection(Of Task)()
			gridControl1.DataSource = data
		End Sub
	End Class

	Public Class Task
		Private _DueDate As DateTime = DateTime.Now
		Public Property DueDate() As DateTime
			Get
				Return _DueDate
			End Get
			Set(ByVal value As DateTime)
				_DueDate = value
			End Set
		End Property
		Private privateSubject As String
		Public Property Subject() As String
			Get
				Return privateSubject
			End Get
			Set(ByVal value As String)
				privateSubject = value
			End Set
		End Property
	End Class
End Namespace