# PacMan-Challenge

## Objective
In a C# console app print out the total points and lives back to the user following the rules below and using data from CSV file.
Pacman starts out with 3 lives and 5000 points.

## Rules
1. If a Ghost eats Pac-Man a life is lost 
2. If all lives are lost, the game ends
3. If Pac-Man eats a pellet he can eat ghosts
4. First Ghost is 200 points, second ghost is 400 points, third ghost is 800 points, fourth is 1600 points 
5. Ghosts are not eaten in continous sequence
6. When Pac-Man reached 10000 he get a life 
7. Fruit: 
- Cherry: 100 points  
- Strawberry: 300 points  
- Orange: 500 points  
- Apple: 700 points  
- Melon: 1000 points  
- Galaxian: 2000 points  
- Bell: 3000 points  
- Key: 5000 points

## Approach
1. Create an Object Class that defines all game objects.  Make two dictionaries defining how many points and 
object is worth and how many lives an object can take away.
2. Services class has methods that read the CSV file, and another method that processes each word in the file 
and determines whether their are lives or points associated to it and will either add points or subtract lives 
by calling other methods.
3. Pacman class defines starting points and lives.  Pacman class has methods for GetPoints, GetLives, AddPoints, 
SubtractLives, AddLives.
4. Game Controller class has a start method that reads CSV file and processes what to do with each index and 
prints data back to user
