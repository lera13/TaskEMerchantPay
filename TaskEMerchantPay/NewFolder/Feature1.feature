Feature: Transaction

A short summary of the feature

@tag1
Scenario: Simple POST with check body
	When I send POST request
	Then the system should return 200
	And I will check transaction status