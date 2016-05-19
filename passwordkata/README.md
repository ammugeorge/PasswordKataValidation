# Overview

Modify the verification class called `PasswordVerifier`

* Feature #1 - Add the following verifications to a master function called `Verify()`

	* a) password should be larger than 8 chars
	* b) password should not be null
	* c) password should have one uppercase letter at least
	* d) password should have one lowercase letter at least
	* e) password should have one number at least

Each one of these should throw an exception with a different message but always the same exception of your choosing. Construction of `PasswordVerifier` should never throw an exception.

* Feature #2 - Password is OK if at least three of the previous conditions is true
* Feature #3 - Password is never OK if feature #1, story c) is not true.

# Requirements

* Work incrementally - each feature and story within a feature must be a single commit. Refactor the unit tests as the stories for a feature change a feature or new features are added. Do not rewrite or squash commit history. Aim to have this completed within less than 30 minutes.
* Write tests for correct inputs and also invalid inputs.
* Use the `SUT` pattern and assert only one condition per test.
* Use the `Builder` pattern to decouple test creation from actual implementation.
* Use `xUnit` with inline test theories with inline to reduce the amount of test duplication.
* Use `xUnit` as the test runner but write your assertions using `FluentAssertions`
* Use `Ensure` for precondition checks.

# Recommended Reading
* http://xunitpatterns.com/SUT.html
* https://en.wikipedia.org/wiki/SOLID_(object-oriented_design)
* https://github.com/dennisdoomen/FluentAssertions
* http://www.tomdupont.net/2012/04/xunit-theory-data-driven-unit-test.html

# Retro

* Assume each verification takes one second to complete. How would you solve Feature #2 and Feature #3 so tests can run faster whilst preventing password timing attacks?
