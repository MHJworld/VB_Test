'ctrl + k + c : 주석처리, ctrl + k + U : 주석처리 취소

'Module Module1

'    Sub Main()
'        Console.Write("What is your name? " + vbCrLf)
'        Dim name = Console.ReadLine()
'        Dim currentDate = DateTime.Now
'        Console.WriteLine($"{vbCrLf}Hello, {name}, on {currentDate:d} at {currentDate:t}!")
'        Console.Write(vbCrLf + "Press any key to exit... ")
'        Console.ReadKey(True)
'        Console.Write(vbCrLf + "The END !!" + vbCrLf)
'    End Sub

'End Module

'Module Module1

'    Public num1 As Integer
'    Public num2 As Integer
'    Public answer As Integer
'    Sub Main()
'        Console.WriteLine("Type a number and press Enter")
'        num1 = Console.ReadLine()
'        Console.WriteLine("Type another number to add to it and press Enter")
'        num2 = Console.ReadLine()
'        answer = num1 + num2
'        Console.WriteLine("The answer is " & answer)
'        Console.ReadLine()
'        Console.Write("Byebye")
'    End Sub

'End Module

Module Module1
    Public num As Integer
    Public ch As String

    Sub Main()
        Console.WriteLine("Input Something!!")
        'MsgBox("Hello World!")
        Dim input = Console.ReadLine()
        For i As Integer = 1 To input Step 2
            Console.WriteLine(i)
        Next

    End Sub

End Module