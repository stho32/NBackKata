## Visuals / UX

- The test-dialog has a big display for a character.
  
- There are two buttons on the screen that should be accessable through hotkeys to simplify the usage for the [[subject]]:
	- F) The presented character is a repetition.
	- J) The presented character is not a repitition. 
	  [[Why have those hotkeys been chosen]]

- The buttons "lock in". This means that as long as the duration for the stimulus is still going on the [[subject]] can change his/her mind.
  
## Action!

- See also: [[How the test works technically]]
  
- The [[Stream of Stimuli]] is presented to the user one character at a time:
  
	1. The next character is displayed. The button state is cleared.
	  
	2. There is an internal timer counting down the [[Stimulus duration]]. During this time the [[subject]] is free to change the button state freely.
	  
	3. When the time for the stimulus is up the decision of the [[subject]] is saved and either the next character is displayed (goto 1) or the [[test-is-completed-dialog|test is completed]].

