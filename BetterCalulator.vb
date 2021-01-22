'Kendall Callister
'RCET0265
'Spring 2021
'Better Calculator

Option Explicit On
Option Strict On


Module BetterCalulator
    Sub Main()
        Dim firstNumber As Decimal
        Dim secondNumber As Decimal
        Dim userInput As String
        Dim problem As Boolean
        Dim quit As Boolean
        Dim math As Int16

        problem = True

        'Prompts and grabs a user input for the first number.
        Console.WriteLine("First Number = ")
        Do Until problem = False
            Try
                userInput = Console.ReadLine()
                problem = False
                firstNumber = CDec(userInput)
            Catch e As Exception
                Console.WriteLine($"{userInput} is a invaild input")
                Console.WriteLine("First Number = ")
                problem = True
            End Try
        Loop

        problem = True

        'Prompts and grabs a user input for the second number.
        Console.WriteLine("Number Two=")
        Do Until problem = False
            Try
                userInput = Console.ReadLine()
                problem = False
                secondNumber = CDec(userInput)
            Catch e As Exception
                Console.WriteLine($"{userInput} is a invaild input")
                problem = True
            End Try
        Loop

        problem = True

        'Prompts and grabs a user input for the math operator.
        Console.WriteLine("Choose Option")
        Console.WriteLine("1. Add")
        Console.WriteLine("2. Subtract")
        Console.WriteLine("3. Multiply")
        Console.WriteLine("4. Divide")
        Do Until problem = False
            userInput = Console.ReadLine()

            If userInput = "1" Or userInput = "1." Or userInput = "Add" Then
                math = 1
                problem = False
            ElseIf userInput = "2" Or userInput = "2." Or userInput = "Subtract" Then
                math = 2
                problem = False
            ElseIf userInput = "3" Or userInput = "3." Or userInput = "Multiply" Then
                math = 3
                problem = False
            ElseIf userInput = "4" Or userInput = "4." Or userInput = "Divide" Then
                math = 4
                problem = False
            Else
                problem = True
                Console.WriteLine($"{userInput} is a invaild input")
                Console.WriteLine("Choose Option")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")
            End If

        Loop

        'performs math operation and displays result to user.
        If math = 1 Then
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
        ElseIf math = 2 Then
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}")
        ElseIf math = 3 Then
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}")
        ElseIf math = 4 Then
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}")
        End If
        Console.ReadLine()


    End Sub

End Module
