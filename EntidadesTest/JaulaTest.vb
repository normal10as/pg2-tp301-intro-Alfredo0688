Imports Entidades
Module JaulaTest

    Sub main()


        Dim jaula1 As New Jaula
        jaula1.Nombre = "Paco"

        Dim loro1 As New Loro

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

        For Each cotorras As Cotorra In jaula1.getAllCotorra
            Console.Write("Cotorra: ")
            Console.WriteLine(cotorras)
            Console.ReadKey()
        Next

        Console.ReadKey()
    End Sub



End Module
