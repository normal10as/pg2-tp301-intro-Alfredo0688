Imports Entidades
Module LoroTest

    Sub Main()

        Dim primerAve As New Loro

        primerAve.FechaNacimiento = #12/25/2013#
        primerAve.Nombre = "Paco"
        Console.WriteLine("Nombre del ave: {0}", primerAve.Nombre)
        Console.WriteLine("Fecha de nacimiento: {0}", primerAve.FechaNacimiento)
        Console.WriteLine("Edad del ave: {0}", primerAve.Edad)
        Console.WriteLine("ToString: {0}", primerAve.ToString)
        primerAve.Escuchar("Hola")
        primerAve.Escuchar("Como")
        primerAve.Escuchar("Estais")
        Console.WriteLine(primerAve.Hablar)
        Console.WriteLine(primerAve.Hablar)
        Console.WriteLine(primerAve.Hablar)
        Console.WriteLine(primerAve.Hablar)
        Console.ReadKey()

        Dim segundaAve As New Loro
        Console.WriteLine("Año predeterminado: {0}", segundaAve.FechaNacimiento)
        Console.ReadKey()
    End Sub

End Module
