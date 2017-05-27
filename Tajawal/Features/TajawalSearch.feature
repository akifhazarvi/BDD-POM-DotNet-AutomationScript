Feature: Search Flight
 As a flyer I want to search available flight between abc and xyz on specific Date When number of people are 2 and class is economy
 So that I can see the results for given date.

@SmokeTest
@Browser:Chrome
Scenario: Flight Search Module
	Given I have naviagted to Tajawal page
	And I have random array of origin as
	| origin |
	|LHE Lahore, Pakistan|
	
	And  I have random array of Destinations as
	| Destination |
	|Dubai, United Arab Emirates|
	
	And  I have random dates
	
	And I have choosed Economy class
	And I have choosed 2 passengers 
	When I tap on submit button
	Then I should see the result for Search parem

