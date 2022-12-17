Imports DevExpress.Xpf.Grid

Namespace CustomGridResourceText

    Public Class CustomGridLocalizer
        Inherits GridControlResXLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As GridControlStringId) As String
            If id = GridControlStringId.GridNewRowText Then Return "Click here to add a new task"
            If id = GridControlStringId.GridGroupPanelText Then Return "Here goes custom text for the group panel"
            Return MyBase.GetLocalizedString(id)
        End Function
    End Class
End Namespace
