'Alex Wheelock
'RCET 0265
'Spring 2024
'Simple Calculator
'https://github.com/AlexWheelock/Simple-Calculator.git

Option Explicit On
Option Strict On

Module Module1
    Private Const V As Integer = 2
    Private Const V1 As Integer = 1

    Sub Main()

        'Creates Variables for User input
        Dim Number1 As Integer
        Dim Number2 As Integer
        Dim Operation As Integer
        Dim Answer As Integer

        Console.WriteLine("Please Enter A Number.") 'prompts the user to define Number1 variable
        Number1 = CInt(Console.ReadLine()) 'takes user input

        Console.WriteLine("Please Enter Another Number.") 'prompts the user to define Number2 variable
        Number2 = CInt(Console.ReadLine()) 'takes user input

        Console.WriteLine("Would you like the SUM or PRODUCT of these two numbers?" & vbNewLine _
                          & "1. SUM" & vbNewLine _
                          & "2. PRODUCT")

        Operation = CInt(Console.ReadLine())

        If Operation <> V1 Then Else Console.WriteLine(Answer = Number1 + Number2)

        If Operation = V Then Console.WriteLine(Answer = Number1 * Number2)

        Console.Read()

    End Sub

End Module
