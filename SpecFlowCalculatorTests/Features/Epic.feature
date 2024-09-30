Feature: Quality Metric Calculator
As a system quality engineer
I want to use a command-line calculator 
To perform quality metric calculations for software quality assurance

    Background: 
        Given the Quality Metric Calculator is running

    Scenario: Calculate Defect Density
        Given I have 10 defects
        And the software size is 1000 lines of code
        When I calculate the defect density
        Then the result should be "0.01"

    Scenario: Track Shipped Source Instructions (SSI)
        Given the total SSI for release 1 is 500
        And I input the SSI for release 2 as 700
        When I calculate the total SSI
        Then the total SSI should be "1200"
        
    Scenario: Calculate Failure Intensity using Musa Model
        Given there have been 5 total failures
        And 100 test cases have been executed
        When I calculate the failure intensity
        Then the result should be a positive number
        
    Scenario: Calculate Expected Failures using Musa Model
        Given there have been 5 total failures
        And 100 test cases have been executed
        When I calculate the expected failures
        Then the result should be "5" or a reasonable approximation