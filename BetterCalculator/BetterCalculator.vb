'Joshua Makuch
'RCET0265
'Fall 2023
'Better Calculator
'https://github.com/JoshuaMakuch/BetterCalculator.git

Option Strict On
Option Explicit On

Imports System
Imports System.Net.Security
Imports System.Numerics

Module BetterCalculator
    Sub Main(args As String())

        Console.WriteLine("Please enter two numbers. Enter {0}Q{0} at any time to quit.", Microsoft.VisualBasic.Chr(34))

        Dim endProgram As Boolean = False

        While endProgram = False
            endProgram = CalculatingTime()
        End While

        Console.WriteLine("Have a nice day!")
        Console.WriteLine("Press ENTER to close window.")

    End Sub

    Function CalculatingTime() As Boolean
        Dim num1 As Integer
        Dim num2 As Integer
        Dim userInput1 As String
        Dim userInput2 As String
        Dim complete1 As Boolean = False
        Dim complete2 As Boolean = False

        While complete1 = False
            Console.WriteLine("Choose a first number")
            userInput1 = Console.ReadLine()
            If IsNumeric(userInput1) Then
                Console.WriteLine($"You entered {userInput1}.")
                num1 = CInt(userInput1)
                Console.Write("Integer")
                Console.WriteLine(num1 + 5)
                complete1 = True
            ElseIf userInput1.ToLower = "q" Then
                Return True
            ElseIf IsNumeric(userInput1) = False Then
                Console.WriteLine($"You entered {userInput1}, please enter a whole number.")
            End If
        End While

        While complete2 = False
            Console.WriteLine("Choose a second number")
            userInput2 = Console.ReadLine()
            If IsNumeric(userInput2) Then
                Console.WriteLine($"You entered {userInput2}.")
                num2 = CInt(userInput2)
                Console.Write("Integer")
                Console.WriteLine(num2 + 5)
                complete2 = True
            ElseIf userInput2.ToLower = "q" Then
                Return True
            ElseIf IsNumeric(userInput2) = False Then
                Console.WriteLine($"You entered {userInput2}, please enter a whole number.")
            End If
        End While

        If complete1 And complete2 Then
            Console.WriteLine("Choose one of the following options:")
        End If

        Return False
    End Function

End Module
