Public Class Cotorra
    Inherits Loro

    Sub New()

        MyBase.New

    End Sub

    Public ReadOnly Property EdadHumana As UShort
        Get
            Return Edad * 2
        End Get
    End Property

    Public Overrides Sub Escuchar(frase As String)


    End Sub

End Class
