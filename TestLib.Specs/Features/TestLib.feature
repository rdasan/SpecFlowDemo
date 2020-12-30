Feature: Testing stuff
  Just testing random stuff using SpecFlow

Scenario: Add two numbers
  Given I chose 12 as first number
  And I chose 15 as second number
  When I call AddNumbers
  Then the result should be 27 on the screen
  
Scenario: Concatenate two strings
  Given First string Hello
  And Second string World
  When StringCat is called
  Then the concatenated string should be Hello World