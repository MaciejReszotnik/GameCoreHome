Feature: Player character
	In order to play the game
	As a human player
	I want character attributes to be correctly represented

@mytag
Scenario: Taking no damage when hit does not affect health
	Given I am a new player
	When I take 0 damage
	Then My health should be 100
