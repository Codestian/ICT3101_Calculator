Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

    Scenario: Calculate current failure intensity
        Given the initial failure intensity is 1.0
        And the decay rate is 0.1
        And the execution time is 5.0
        When I calculate the current failure intensity
        Then the result should be approximately 0.6065

    Scenario: Calculate expected failures
        Given the initial failure intensity is 1.0
        And the decay rate is 0.1
        And the execution time is 5.0
        When I calculate the average number of expected failures
        Then the result should be approximately 0.3935