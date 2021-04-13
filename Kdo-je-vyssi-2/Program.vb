Imports System

Module Program
    Sub Main()
        Console.WriteLine("Martin a Pavel se hádají, kdo z nich je vyšší.")
        Console.Write("Napiš Martinovu výšku v cm: ")
        Dim VyskaMartin = Console.ReadLine()
        Console.Write("Napiš Pavlovu výšku v cm: ")
        Dim VyskaPavel = Console.ReadLine()

        If VyskaMartin = VyskaPavel Then
            Console.WriteLine("Kluci jsou na chlup stejnì vysocí. Šli to zapít." & vbCrLf)
        ElseIf VyskaMartin > VyskaPavel Then
            Console.WriteLine("Martin se dívá na Pavla shora. Jeho výška je pøece: " & VyskaMartin & vbCrLf)
        Else
            Console.WriteLine("Pavel se dívá na Martina shora. Jeho výška je pøece: " & VyskaPavel & vbCrLf)
        End If

        Main()

    End Sub
End Module
