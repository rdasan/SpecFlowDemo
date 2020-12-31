Feature: Rolodex Entity Matcher Scoring
  POC for simple SpecFlow BDD Test
  Rolodex Entity Matching Rules Scoring Engine

#Scenario: Add two numbers
#  Given I chose 12 as first number
#  And I chose 15 as second number
#  When I call AddNumbers
#  Then the result should be 27 on the screen
#  
#Scenario: Concatenate two strings
#  Given First string Hello
#  And Second string World
#  When StringCat is called
#  Then the concatenated string should be Hello World
  
Scenario: FullVerbatim
  Exact match for whole name, except for punctuations
  Given Firm Name "American Bank Corp"
  Then should give a match hit for "American Bank Corp."
  And should not give a match hit for "American Bank Corporation"