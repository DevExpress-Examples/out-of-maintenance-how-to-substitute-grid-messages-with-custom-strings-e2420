Imports System.Windows
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Grid

Namespace CustomGridResourceText

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            GridControlResXLocalizer.Active = New CustomGridLocalizer()
            Me.InitializeComponent()
            Dim data As ObservableCollection(Of Task) = New ObservableCollection(Of Task)()
            Me.gridControl1.ItemsSource = data
        End Sub
    End Class

    Public Class Task

        Private _DueDate As Date = Date.Now

        Public Property DueDate As Date
            Get
                Return _DueDate
            End Get

            Set(ByVal value As Date)
                _DueDate = value
            End Set
        End Property

        Public Property Subject As String
    End Class
End Namespace
