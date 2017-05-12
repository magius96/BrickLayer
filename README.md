# Brick Layer - ReadMe

The Brick Layer project is designed to showcase the Truth-View-Input game design concept.

Truth, View, Input (TVI) is a programming concept designed specifically for game development, much the same as Model, View, Controller (MVC) was a coding concept designed for web development.  In truth, MVC and TVI are very similar, however, there are some marked differences between them.  I'll leave comparing the two up to you, but let's first make sure you understand what TVI is.

## Truth

The first concept to discuss is the Truth.  We're not talking about truth and lies here, it is not that kind of truth.  Essentially the Truth part of TVI is your game, without any input, graphics, or audio code.  It is the player's coordinate, the position and health of all the enemies, the list of items being carried by the player.  In short, the Truth is a complete representation of the games current state, and contains all the code necessary for running the game.

## View

The second concept to discuss is the View.  When you play a video game, the graphics you see and the sounds you hear are part of the view.  When you open a menu, the graphical representation of that menu is part of the view.  Quite literally, the view is how the player sees the game.

## Input

The last concept to discuss is the Input.  As the name suggests, this handles all the player's input.  For multiplayer games, this may also handle all inputs from remote systems.  When you see a button on the screen, the visual display of that button is in the View, but when you click on that button, the Input handles that click.

## Bringing it Together

The struggle here is separating the three concerns and having them work together as though they were all built as a single unit.  The key to doing this is how the Truth is designed and implemented. The code in the Truth should never interact directly with any IO.  It should provide methods and events that allow the other two pieces of TVI to interact with it.

The Truth, should now everything there is to know about your game.  Wanna know what position a player is at, its in the truth.  Need to know how many potions the player has left?  That's in the truth.  Need to know what the distance between two players is?  You should be able to get that from the truth as well.

On the inverse, the View and Input classes should not know anything about your game.  When the input needs to draw a player on the screen, it has to get the position from the Truth.

## Why Use Truth-View-Input?

There are three main reasons to organize your code according to TVI.  

The seperation in TVI makes it easy to swap out control schemes for a different platform.  In the Brick Layer project, you can see that the game has been designed to run on both Windows and XBox One. We make use of compiler defines to block out parts of the code that are not related to the current build type.  Because of this, you can stop the brick on a PC using space, and the A button on XBox One.

Second, it makes it easy to change how the game is viewed.  There are two main reasons you would want to do this.  Let's say you wanted to change your game from being drawn completely in 2D, to being 2D using 3D models.  By merely changing out the view you can make that happen.  The second, and most used reason is for mutliple platform feedback.  In Brick Layer, we have a different view for the Title and Game screen, that allows us to set what instructions you see based on the what system it was built for.

Finally, because you have seperated graphics, audio, and inputs from your game code, the entirety of your game code should be fully unit testable.  This means that you should be able to write unit tests on every method and function in the Truth class to ensure they work completely as desired.