?[# Feature: Login to Merchant Sales

## Background:
    Given I am at the Merchant Sales page

## Scenario Outline: Enter Login Credentials
    When I enter <username> and <passwrd> on the login page
    Then the <message> displays

##  Question - select the example(s) of a positive test scenario for <username> <password> and <message>?]
-[ ] myLogin, null, Invalid Passwprd
-[x] myLogin, myPassword, Login Successfull
-[x] null, Password, Invalid Username