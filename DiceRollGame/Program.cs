

// When the application starts, it shall generate a number from 1 to 6 and then print: 

// Dice rolled. Guess what number it shows in 3 tries.

// The user must select a number. If the number equals the generated number, “You win” is printed to the console. If not, “Wrong number” is printed, and the user has another chance. The user has 3 chances. If they all are unsuccessful, “You lose” is printed to the console, and the program closes after any key is pressed. 

using DiceRollGame;
using DiceRollGame.Game;
using System.Threading.Channels;

var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);



Console.ReadKey();



