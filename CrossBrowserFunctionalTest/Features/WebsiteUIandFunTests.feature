Feature: WebsiteUIandFunTests
	Simple calculator for adding two numbers

Background: 
Given Load Website "http://google.com"
Scenario: UI Testsing 4 browser sessions
	
	And Enter Serach text "Selenium Tests"
	When Click on Search button
	Then Search Reasults displayed