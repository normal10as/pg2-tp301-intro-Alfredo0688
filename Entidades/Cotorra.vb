Public Class Cotorra
    Inherits Loro

    Private _campo As Boolean = True

    Sub New()

        MyBase.New

    End Sub

    Public ReadOnly Property EdadHumana As UShort
        Get
            Return Edad * 2
        End Get
    End Property

    Public Overrides Sub Escuchar(frase As String)
        If _campo = True Then
            _memoria.Enqueue(frase)
        End If
        _campo = Not _campo
    End Sub

End Class
