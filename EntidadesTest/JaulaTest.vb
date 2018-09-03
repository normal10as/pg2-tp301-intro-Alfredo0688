Imports Entidades
Module JaulaTest

    Sub main()


        Dim jaula1 As New Jaula
        jaula1.Nombre = "Santuario"

        Dim loro1 As New Loro
        loro1.Nombre = "Pepe"

        Dim cotorra1 As New Cotorra
        cotorra1.Nombre = "Laura"

        Dim cotorra2 As New Cotorra
        cotorra2.Nombre = "Flor"

        Dim cotorra3 As New Cotorra
        cotorra3.Nombre = "Pepa"

        Dim cotorra4 As New Cotorra
        cotorra3.Nombre = "Paquita"


        jaula1.Loro = loro1

        jaula1.addCotorra(cotorra1)
        jaula1.addCotorra(cotorra2)
        jaula1.addCotorra(cotorra3)

        Console.WriteLine("ToString: {0}", jaula1.ToString)
        Console.WriteLine("Loro en la jaula: {0}", jaula1.Loro)
        Console.WriteLine("Cotorras en la jaula: ")
        For Each cotorras As Cotorra In jaula1.getAllCotorra
            Console.Write("Cotorra: ")
            Console.WriteLine(cotorras)
            Console.ReadKey()
        Next

        Console.ReadKey()
    End Sub



End Module
