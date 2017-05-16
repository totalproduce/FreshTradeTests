Feature: FreshTradeClose
	In order to test the test environment
	I will open FreshTrade app
	And close it right after

@smoketests
Scenario: Close FreshTrade app
Given I select TPUKFRIDAY
When I close FreshTrade from the menu
Then FreshTrade should be closed