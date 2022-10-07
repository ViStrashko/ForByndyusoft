Feature: TestContacts

A short summary of the feature

@contacts
Scenario: Checking contact information on the Byndyusoft website
	Given Open page Google
	And In the search box type "Byndyusoft"
	And Follow the link of Byndyusoft
	When Click on the yellow Order presentation button
	Then Expected mailbox "sales@byndyusoft.com"
