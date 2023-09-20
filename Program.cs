// code to write a simple dice game

Console.WriteLine("===Simple Dice Game=== \nType 'Start' or 'S' to begin ");
string  startGame = Console.ReadLine()!;

const int doublePoint = 2;
const int triplePoint = 6;
int totalPoint = 0;

if (!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))
{
    Console.WriteLine("Type 'Start' or 'S'to start the game properly");
    return;
}

Random rand = new();
int diceOne = rand.Next(1, 7);
int diceTwo = rand.Next(1, 7);
int diceThree = rand.Next(1, 7);
int originalScore = diceOne + diceTwo + diceThree;

Console.WriteLine($"Dice One: {diceOne}\nDice Two: {diceTwo}\nDiceThree: {diceThree}");

// Check if all dice have the same output
if (diceOne == diceTwo && diceTwo == diceThree)
{
    Console.WriteLine("You score a triple point");
    totalPoint = originalScore + triplePoint;
    Console.WriteLine($"total point: {totalPoint}");
}

// Check if any two dice out of the three dice have the same output
else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
{
    Console.WriteLine("You score a double point");
    totalPoint = originalScore + doublePoint;
    Console.WriteLine($"total point: {totalPoint}");
}

else 
{
    totalPoint += originalScore;
    Console.WriteLine($"total point: {totalPoint}");
}


// assign gift to certain totalpoints
if(totalPoint >=22 && totalPoint <=24)
{
    Console.WriteLine("You won all the available gifts ");
}

int luckyNumber = 21;
if (totalPoint == luckyNumber)
{
    Console.WriteLine("You got a lucky number, You won a Samsung Galaxy A24");
}

if (totalPoint >= 18 && totalPoint <= 20 )
{
    Console.WriteLine("You won a ticket to Silverbird's Cinema");
}

if (totalPoint == 17)
{
    Console.WriteLine("You won a 5000mAh power bank ");
}

if (totalPoint >= 14 && totalPoint <=16 )
{
    Console.WriteLine("You won a Notebook");
}

if (totalPoint >= 10 && totalPoint <= 13)
{
    Console.WriteLine("You won a balloon");
}

else 
{
    Console.WriteLine("You win no gift, try again");
}



