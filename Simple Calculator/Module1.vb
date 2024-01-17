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
        Dim funct As String

        Console.WriteLine("Please Enter Two Numbers. Enter " & "Q " & "at any time to quit") 'prompts the user to define Number1 variable



        Number1 = CInt(Console.ReadLine()) 'takes user input

        'If Number1 = ("Q") Then

        'ElseIf Number1 <> Int32 Then

        'Else

        'End If

        Console.WriteLine("Please Enter Another Number.") 'prompts the user to define Number2 variable
        Number2 = CInt(Console.ReadLine()) 'takes user input

        Console.WriteLine("Choose one of the following options:" & vbNewLine _
                          & "1. Add" & vbNewLine _
                          & "2. Subtract" & vbNewLine _
                          & "3. Multiply" & vbNewLine _
                          & "4. Divide")

        Operation = CInt(Console.ReadLine()) 'takes user input

        If Operation = CInt("1") Then
            Answer = Number1 + Number2 '
            funct = "+"

        ElseIf Operation = CInt("2") Then
            Answer = Number1 - Number2
            funct = "-"

        ElseIf Operation = CInt("3") Then
            Answer = Number1 * Number2
            funct = "*"

        ElseIf Operation = CInt("4") Then
            Answer = Number1 \ Number2
            funct = "/"

        End If

        Console.WriteLine(CStr(Number1) & " + " & CStr(Number2) & " = " & CStr(Answer) & vbNewLine _
                          & "The Answer is " & Answer & ".")
        Console.Read()

    End Sub

End Module
