Public Class Loro
    Protected _memoria As Queue(Of String)
    Private _auxiliar As String
    Private _auxiliar2 As String
    Private _fechaNacimiento As Date
    Private _nombre As String

    'constructor
    Sub New()
        Me.Nombre = ""
        Me.FechaNacimiento = Now()
        _memoria = New Queue(Of String)
    End Sub

    Public ReadOnly Property Edad As UShort
        Get
            Return CalcularEdad(FechaNacimiento)
        End Get
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Private Function CalcularEdad(fechanacimiento As Date) As UShort
        Dim anio As UShort
        anio = Date.Now.Year - fechanacimiento.Year
        If Date.Now.Month < fechanacimiento.Month Then
            anio = anio - 1
        ElseIf fechanacimiento.Month = Today.Month Then
            If Today.Day < fechanacimiento.Day Then
                anio = anio - 1
            End If
        End If

        Return anio
    End Function

    Public Overridable Sub Escuchar(frase As String)
        _memoria.Enqueue(frase)
    End Sub

    Public Function Hablar() As String
        If _memoria.Count > 0 Then
            _auxiliar = _memoria.Dequeue
            _auxiliar2 = _auxiliar2 & _auxiliar & " "
        End If
        Return _auxiliar2
    End Function

End Class
