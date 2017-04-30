# BowlingGame

Technical Challenge - Bowling game 

In this challenge we want you to implement a web application that calculates the score during a game of ten-pin bowling. 

Requirements: 

* Allows a user to start a game and enter the result of each round. You can for example use two input elements of type text, one for each roll. 
* Each round with two rolls should be send to server for score calculation. For this assignment, you can let the browser keep track of all rounds so far. 
* When a resulting score is returned it should be displayed somewhere on the current page along with the result for each round played. 
* Shows final results view when all ten rounds have been played. Option to play again. 

Technical aspects: 

* Use technologies you feel are appropriate, but it should include: 
- ASP.NET Web API backend calculating each round and returning score. 
- AngularJS frontend 
- Feel free to use any Nuget package, NPM modules, gulp or other tools 
* Deliver your solution by creating a repository in Github and send us the link. If it is easy for us to run we will be happy. 

An example scenario: 
Player starts a new game by visiting the web site: The current score is 0. 

Player rolls a 3 and a 4: 
The user enters 3 and 4 and submits the score. 
The web browser displays the current score 7. 

Player rolls a 4 and 5: 
The user enters 4 and 5 and submits the score. 
The web browser displays the current score 16. 

etc. 

The Rules of Bowling: 

* A game consists of ten frames. Frame 1-9 are composed of two rolls. Frame 10 can be composed of up to three rolls depending on if the first rolls in the frame is a strike or a spare. 

* Each frame can have one of three marks: 
- Strike: all 10 pins were knocked down with the first roll. 
- Spare: all 10 pins were knocked down using two rolls. 
- Open: some pins were left standing after the frame was completed. 

* When calculating the total score, the sum of the score for each frame is used. 
- For an open frame the score is the total number of pins knocked down. 
- For a strike, the score is 10 + the sum of the two rolls in the following frame. 
- For a spare, the score is 10 + the number of pins knocked down in the first roll of the following frame. 

The tenth frame may be composed of up to three rolls: the bonus roll(s) following a strike or spare in the tenth (sometimes referred to as the eleventh and twelfth frames) are fill ball(s) used only to calculate the score of the mark rolled in the tenth. 
