Feature: Search Result
	Filter the result on basis of Emirates carrier and select the specfic flight details.

@Browser:Chrome
Scenario: Flight Search Result
Given Filter results to Emirates carrier 
Then Assert listing results are only the selected carrier 
