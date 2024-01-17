'Alex Wheelock
'RCET 0265
'Spring 2024
'Simple Calculator
'https://github.com/AlexWheelock/Simple-Calculator.git

Option Explicit On
Option Strict On

Module Module1

    Sub Main()

        'Creates Variables for User input
        Dim Number1 As Integer
        Dim Number2 As Integer
        Dim Operation As Integer
        Dim Answer As Integer
        Dim addMult As String

        Console.WriteLine("Please Enter A Number.") 'prompts the user to define Number1 variable
        Number1 = CInt(Console.ReadLine()) 'takes user input

        Console.WriteLine("Please Enter Another Number.") 'prompts the user to define Number2 variable
        Number2 = CInt(Console.ReadLine()) 'takes user input

        Console.WriteLine("Would you like the ADD or MULTIPLY?" & vbNewLine _
                          & "1. ADD" & vbNewLine _
                          & "2. MULTIPLY") 'prompts the user to choose whether or not they want to ADD/MULTIPLY

        Operation = CInt(Console.ReadLine()) 'takes user input

        If Operation = CInt("1") Then
            Answer = Number1 + Number2 '
            addMult = "+"

        ElseIf Operation = CInt("2") Then
            Answer = Number1 * Number2
            addMult = "*"

        End If

        Console.WriteLine(CStr(Number1) & " + " & CStr(Number2) & " = " & CStr(Answer) & vbNewLine _
                          & "The Answer is " & Answer & ".")
        Console.Read()

    End Sub

End Module
