'Joshua Makuch
'RCET0265
'Fall 2023
'Better Calculator
'https://github.com/JoshuaMakuch/BetterCalculator.git

Option Strict On
Option Explicit On
'Option Compare Binary ': This causes the code to look at a letter as both its capital and lowercase for comparison

Imports System
Imports System.Numerics
Imports System.Threading

Module BetterCalculator
    Sub Main(args As String())

        Console.WriteLine("") 'Any empty write lines are for spacing in the console
        Console.WriteLine("Please enter two numbers. Enter {0}Q{0} at any time to quit.", Microsoft.VisualBasic.Chr(34))

        Dim endProgram As Boolean = False

        'Loop until the user decides to quit
        While endProgram = False
            endProgram = CalculatingTime()
        End While

        Console.WriteLine("")
        Console.WriteLine("Have a nice day!")
        Console.WriteLine("Press ENTER to close window.")

    End Sub

    Function CalculatingTime() As Boolean
        Dim num1 As Double 'This ensures that the limit for the number you input isnt going to crash the code
        Dim num2 As Double
        Dim userInput1 As String
        Dim userInput2 As String
        Dim userInputOperator As String
        Dim complete1 As Boolean = False
        Dim complete2 As Boolean = False
        Dim complete3 As Boolean = False

        'This section obtains the first number from the user 
        While complete1 = False
            Console.WriteLine("")
            Console.WriteLine("Choose a first number")
            userInput1 = Console.ReadLine()
            If IsNumeric(userInput1) Then
                Console.WriteLine($"You entered {CDbl(userInput1)}.")
                num1 = CDbl(userInput1)
                complete1 = True
            ElseIf userInput1.ToLower = "q" Then
                Return True
            ElseIf IsNumeric(userInput1) = False Then
                Console.WriteLine($"You entered {userInput1}, please enter a number.")
            End If
        End While

        'This section obtains the second number from the user 
        While complete2 = False
            Console.WriteLine("")
            Console.WriteLine("Choose a second number")
            userInput2 = Console.ReadLine()
            If IsNumeric(userInput2) Then
                Console.WriteLine($"You entered {CDbl(userInput2)}.")
                num2 = CDbl(userInput2)
                complete2 = True
            ElseIf userInput2.ToLower = "q" Then
                Return True
            ElseIf IsNumeric(userInput2) = False Then
                Console.WriteLine($"You entered {userInput2}, please enter a number.")
            End If
        End While

        'This section does the calculation of the two previously obtained numbers
        While complete3 = False
            Console.WriteLine("")
            Console.WriteLine("Choose one of the following options:")
            'Could put  "" & vbNewLine & "" to get rid of all console.writeline,
            'but it makes the lines really long
            Console.WriteLine("1. Add")
            Console.WriteLine("2. Subtract")
            Console.WriteLine("3. Multiply")
            Console.WriteLine("4. Divide")
            userInputOperator = Console.ReadLine()
            If IsNumeric(userInputOperator) Then
                'userInputOperator = CInt(userInputOperator) doesn't work due to option explicit...
                'I could essentially create a new variable, but I didn't, so were here now
                'Also, this determines if the user input a correct option
                Console.WriteLine($"You entered {userInputOperator}.")
                If CInt(userInputOperator) = 1 Then
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}") 'Add
                    complete3 = True
                ElseIf CInt(userInputOperator) = 2 Then
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}") 'Sub
                    complete3 = True
                ElseIf CInt(userInputOperator) = 3 Then
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}") 'Multiply
                    complete3 = True
                ElseIf CInt(userInputOperator) = 4 Then
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}") ' Divide
                    complete3 = True
                ElseIf CInt(userInputOperator) > 4 Or CInt(userInputOperator) < 1 Then
                    Console.WriteLine($"{userInputOperator} is an invalid option, please enter a correct option.")
                End If
            ElseIf userInputOperator.ToLower = "q" Then
                Return True
            ElseIf IsNumeric(userInputOperator) = False Then
                Console.WriteLine($"{userInputOperator} is an invalid option, please enter a correct option.")
            End If

        End While
        Return False
    End Function

End Module
