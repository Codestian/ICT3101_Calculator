Feature: Factorial Calculation
In order to use the factorial functionality of the calculator
As a user
I want to calculate the factorial of numbers, including zero

    Scenario: Calculating the factorial of a positive number
        Given I have a calculator
        When I enter 5 into the calculator and press factorial
        Then the factorial result should be 120

    Scenario: Calculating the factorial of zero
        Given I have a calculator
        When I enter 0 into the calculator and press factorial
        Then the factorial result should be 1