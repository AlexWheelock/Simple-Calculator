'Alex Wheelock
'RCET 0265
'Spring 2024
'Better Calculator
'https://github.com/AlexWheelock/Simple-Calculator.git

Option Explicit On
Option Strict Off

Module BetterCalculator

    Sub Main()

        'Creates Variables for User input
        Dim Number1 As String
        Dim Number2 As String
        Dim Operation As String
        Dim Answer As String
        Dim funct As String

        Do

            Console.WriteLine("Please Enter Two Numbers. Enter " & Chr(34) & "Q" & Chr(34) & " at any time to quit")

            'Do

            Number1 = Console.ReadLine() 'takes user input

            If Number1 = "q" Then
                Console.WriteLine("Have a nice day" & vbNewLine _
                                  & "Press enter to close this window")
                Console.Read()
                Exit Sub


            ElseIf Number1 <> "-2147483648 - 2147483648" Then
                Console.WriteLine("You entered " & Chr(34) & CStr(Number1) & Chr(34))

            Else
                Console.WriteLine("You entered" & Chr(34) & CStr(Number1) & Chr(34) & ", please enter a whole number")

            End If

            'Loop Until Number1 = -2147483648 - 2147483648

            'Do

            Console.WriteLine("Please Enter Another Number.") 'prompts the user to define Number2 variable
            Number2 = Console.ReadLine() 'takes user input

            If Number2 = "q" Then
                Console.WriteLine("Have a nice day" & vbNewLine _
                                      & "Press enter to close this window")
                Console.Read()
                Exit Sub

            ElseIf Number2 <> -2147483648 - 2147483648 Then
                Console.WriteLine("You entered " & Chr(34) & CStr(Number2) & Chr(34))

            Else
                Console.WriteLine("You entered" & Chr(34) & CStr(Number2) & Chr(34) & ", please enter a whole number")

            End If

            'Loop Until Number2 = -2147483648 - 2147483648

            Console.WriteLine("Choose one of the following options:" & vbNewLine _
                              & "1. Add" & vbNewLine _
                              & "2. Subtract" & vbNewLine _
                              & "3. Multiply" & vbNewLine _
                              & "4. Divide")

            'Do

            Operation = Console.ReadLine() 'takes user input

                If Operation = "q" Then
                    Console.WriteLine("Have a nice day" & vbNewLine _
                                      & "Press enter to close this window")
                    Console.Read()
                    Exit Sub
                End If

            If Operation = "1" Then
                    Answer = CInt(Number1) + CInt(Number2)
                    funct = "+"

                ElseIf Operation = "2" Then
                    Answer = CInt(Number1) - CInt(Number2)
                    funct = "-"

                ElseIf Operation = "3" Then
                    Answer = CInt(Number1) * CInt(Number2)
                    funct = "*"

                ElseIf Operation = "4" Then
                    Answer = CInt(Number1) \ CInt(Number2)
                    funct = "/"

            Else Console.WriteLine("You Entered " & Chr(34) & CStr(Operation) & Chr(34) & ", please enter a valid input.")

            End If

            'Loop Until Operation = "1-4"

            Console.WriteLine((Number1) & " + " & CStr(Number2) & " = " & CStr(Answer) & vbNewLine _
                              & "The Answer is " & Answer & ".")
        Loop

    End Sub

End Module
