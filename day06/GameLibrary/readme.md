 **Game Controller Library**

This library provides a simple game controller class that manages the state of a game and allows players to join and start the game.

**Game Status**

The game controller class has a `GameStatus` enum that represents the current state of the game. The possible states are:

* `NotInitialized`: The game has not been initialized yet.
* `Ready`: The game is ready to start.
* `Playing`: The game is in progress.

**Adding a Player**

To add a player to the game, call the `AddPlayer` method. This method takes an `IPlayer` object as an argument. The `IPlayer` interface defines the properties that a player object must have:

* `ID`: The unique identifier of the player.
* `Name`: The name of the player.

The `AddPlayer` method returns `true` if the player was added successfully, and `false` otherwise. The player can only be added if the game is in the `NotInitialized` state.

**Checking the Game Status**

To check the current status of the game, call the `CheckGame` method. This method returns the current value of the `GameStatus` enum.

**Starting the Game**

To start the game, call the `StartGame` method. This method returns `true` if the game was started successfully, and `false` otherwise. The game can only be started if it is in the `Ready` state.

**Code Snippets**

Here are some code snippets that show how to use the game controller class:

```csharp
// Create a game controller object.
GameController gameController = new GameController();

// Add a player to the game.
IPlayer player1 = new Player { ID = 1, Name = "Player 1" };
gameController.AddPlayer(player1);

// Check the game status.
GameStatus gameStatus = gameController.CheckGame();

// Start the game.
gameController.StartGame();
```
