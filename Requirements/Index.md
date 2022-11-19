- This application is based on https://ccd-school.de/coding-dojo/application-katas/n-back/ The following notes are a cleaned version of the requirements for the use of implementing the solution.

- The application n-back is based on a psychological test described here http://de.wikipedia.org/wiki/N-back 

---
- (R001) This is [[How the test works technically]]. 

- (R002) There is a [[configuration for a test]] with several attributes that is needed.
  
- (R003) The [[test-dialog]] is the place where the test is performed.
  
- (R004) There is a [[test-is-completed-dialog]] that pops up, when the test is completed.

- (R005) After the test the [[Percentage of Correct Answers]] is presented (in the [[test-is-completed-dialog]]).
  
- (R006) [[The start-dialog]] is the place where you can set all the [[configuration for a test]] and you can start a new test there.
  
- (R007) A test can be aborted any time. When done, the application behaves as normal, the result is presented and the test-protocol, the result is calculated to the then known total of characters that have been presented.
	- In the [[test-dialog]] there should be a way to abort the currently running test.
	- The [[test-is-completed-dialog]] should be presented even when the test is aborted. The  presented results should contain a hint "Test has been aborted after ... stimuli".

- (R008) When the test ends, a [[test-protocol]] is written to the disk containing all details about how the test was performed and what the result was.