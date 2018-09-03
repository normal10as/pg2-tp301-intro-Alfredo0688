Imports Entidades
Module CotorraTest
    Sub main()

        Dim firstcotorra As New Cotorra

        firstcotorra.FechaNacimiento = #2/18/2008#
        firstcotorra.Nombre = "Paquita"

        firstcotorra.Escuchar("Holaa")
        firstcotorra.Escuchar("Paco")
        firstcotorra.Escuchar("Cookie")
        firstcotorra.Escuchar("Good")

        Console.WriteLine(firstcotorra.Hablar)
        Console.WriteLine(firstcotorra.Hablar)
        Console.WriteLine(firstcotorra.Hablar)
        Console.WriteLine(firstcotorra.Hablar)
        Console.WriteLine("Fecha de nacimiento de la cotorra {0}", firstcotorra.FechaNacimiento)
        Console.WriteLine("Edad humana: {0} Edad:{1}", firstcotorra.EdadHumana, firstcotorra.Edad)
        Console.ReadKey()


    End Sub
End Module
