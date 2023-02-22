# ObserveDesingPattern
The Observer design pattern is a behavioral design pattern that allows other objects to observe and respond when the state of an object changes.

1: In this example the Player class implements the IPlayer interface.
2: Observer class Referee implements the IReferee interface.
3: The player includes methods for registering, removing and updating watchers.
4: The players movement is calculated and the direction, angle and force values are updated. These values are taken by the referee and printed on the screen.
