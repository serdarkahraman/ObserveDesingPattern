# ObserveDesingPattern
The Observer design pattern is a behavioral design pattern that allows other objects to observe and respond when the state of an object changes.

# Example 
- In this example the Player class implements the IPlayer interface.
- Observer class Referee implements the IReferee interface.
- The player includes methods for registering, removing and updating watchers.
- The players movement is calculated and the direction, angle and force values are updated. These values are taken by the referee and printed on the screen.
