Imports System

Module Program
    Sub Main()
        Console.WriteLine("Martin a Pavel se h�daj�, kdo z nich je vy���.")
        Console.Write("Napi� Martinovu v��ku v cm: ")
        Dim VyskaMartin = Console.ReadLine()
        Console.Write("Napi� Pavlovu v��ku v cm: ")
        Dim VyskaPavel = Console.ReadLine()

        If VyskaMartin = VyskaPavel Then
            Console.WriteLine("Kluci jsou na chlup stejn� vysoc�. �li to zap�t." & vbCrLf)
        ElseIf VyskaMartin > VyskaPavel Then
            Console.WriteLine("Martin se d�v� na Pavla shora. Jeho v��ka je p�ece: " & VyskaMartin & vbCrLf)
        Else
            Console.WriteLine("Pavel se d�v� na Martina shora. Jeho v��ka je p�ece: " & VyskaPavel & vbCrLf)
        End If

        Main()

    End Sub
End Module
