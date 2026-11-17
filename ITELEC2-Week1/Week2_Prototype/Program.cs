
using System;

// Create two separate game objects.
MemoryGame firstGame = new MemoryGame("Alex");
MemoryGame secondGame = new MemoryGame("Jamie");

Console.WriteLine("=================================");
Console.WriteLine("       MINDMATCH MEMORY GAME");
Console.WriteLine("=================================");

// FIRST PLAYER
Console.WriteLine("\n--- FIRST PLAYER ---");

Console.WriteLine(firstGame.GetProgress());

Console.WriteLine("\nAnswer for Level 1: A");
Console.WriteLine(firstGame.SubmitAnswer("A"));
Console.WriteLine(firstGame.GetProgress());

Console.WriteLine("\nAnswer for Level 2: AB");
Console.WriteLine(firstGame.SubmitAnswer("AB"));
Console.WriteLine(firstGame.GetProgress());

Console.WriteLine("\nAnswer for Level 3: ABC");
Console.WriteLine(firstGame.SubmitAnswer("ABC"));
Console.WriteLine(firstGame.GetProgress());

// TEST THE BUSINESS RULE
Console.WriteLine("\n--- TESTING THE BUSINESS RULE ---");

Console.WriteLine("Attempting another answer after completion...");

Console.WriteLine(firstGame.SubmitAnswer("ABC"));
Console.WriteLine(firstGame.GetProgress());

// SECOND PLAYER
Console.WriteLine("\n--- SECOND PLAYER ---");

Console.WriteLine(secondGame.GetProgress());

Console.WriteLine("\nAnswer for Level 1: A");
Console.WriteLine(secondGame.SubmitAnswer("A"));

Console.WriteLine(secondGame.GetProgress());

Console.WriteLine("\n=================================");
Console.WriteLine("       DEMONSTRATION ENDED");
Console.WriteLine("=================================");

