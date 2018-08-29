Public Class Jaula

    Private _nombre As String
    Private _loro As Loro
    Private _listaCotorras As List(Of Cotorra)

    Sub New()
        _nombre = ""
        _loro = New Loro
        _listaCotorras = New List(Of Cotorra)
    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Loro As Loro
        Get
            Return _loro
        End Get
        Set(value As Loro)
            _loro = value
        End Set
    End Property

    Public Sub addCotorra(cotorra As Cotorra)
        While _listaCotorras.Count <= 3
            _listaCotorras.Add(cotorra)
        End While
    End Sub

    Public Function getAllCotorra() As List(Of Cotorra)
        Return _listaCotorras
    End Function

    Public Overrides Function ToString() As String
        Return "Esta es la jaula de " & Nombre
    End Function

End Class
