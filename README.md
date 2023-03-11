# P-man
Complex Pac-Man

# General Information
The game is played in a 23*53 game field including outer walls. Game characters are P, X and Y. Human player is represented by P. Computer controls X and Y. The aim of the game is reaching the highest score.

# Game Characters
P: Human player   
•	Cursor keys: To move the human player (4 directions)   
•	Space: To drop a mine (+) behind the human player

X and Y: Computer controlled enemies   
•	They try to reach the location of the P (4 directions). They are stuck on obstacles.    
•	X: In chasing, priority is x-axis
•	Y: In chasing, priority is y-axis

Numbers: 1, 2, 3
•	These can be collected by the human player. They have some functions for the human player.
o	1: 10 points.
o	2: 30 points and 50 energy.
o	3: 90 points, 200 energy and 1 mine.    

Mine: +
•	Fatal for any game character (P, X, Y) in the same square with the mine.

# Game Playing Information
• P can move one square. Moving 1 square requires 1 energy for the player.
• If the human player has no energy, his/her movement speed is reduced by half.
• If an enemy reaches the square of P, the game is over
•	Enemies cannot see or sense the mines (or the numbers). If an enemy is in the same square with a mine, the mine and the enemy disappear, and the human player gains 300 score points. 

# Changes with time
•	1 number (1, 2, or 3 with the same generation probabilities) is added to the game area (random position) for every 10 time units. 
•	1 enemy (X or Y with equal probability) is added to the game area (random position) for every 150 time units. 
•	1 wall is added or deleted randomly for every time unit.

!!! If you have an question or if you found any error or bugs about game you can contact me from Discord or Linkedin. Thanks Broo.
