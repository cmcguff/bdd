Feature: StaffForm
	In order to do things in the staff screen
	As a typical user
	I want stuff to happen

@mytag
Scenario: Changing the screen caption
	Given The staff form has a caption of "Old Caption"
	When I press the change caption button
	Then the caption should be changed to "New Form Caption"
