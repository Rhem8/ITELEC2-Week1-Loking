
using System;

public class MemoryGame
{
    // Private field containing the correct sequences.
    private readonly string[] sequences =
    {
        "A",
        "AB",
        "ABC"
    };

    // Properties
    public string PlayerName { get; }

    public int Level { get; private set; }

    public int Score { get; private set; }

    public bool IsCompleted { get; private set; }

    // Constructor
    public MemoryGame(string playerName)
    {
        if (string.IsNullOrWhiteSpace(playerName))
        {
            throw new ArgumentException(
                "Player name cannot be empty."
            );
        }

        PlayerName = playerName;
        Level = 1;
        Score = 0;
        IsCompleted = false;
    }

    // Method 1: Submit an answer
    public string SubmitAnswer(string answer)
    {
        // Protect the completed game session.
        if (IsCompleted)
        {
            return "Rejected: The game is already completed.";
        }

        // Check whether the answer is correct.
        string correctAnswer = sequences[Level - 1];

        if (!string.Equals(
            answer?.Trim(),
            correctAnswer,
            StringComparison.OrdinalIgnoreCase))
        {
            IsCompleted = true;

            return "Incorrect answer. Game over!";
        }

        // Award points for a correct answer.
        Score += 10;

        // Check if the player completed the final level.
        if (Level == sequences.Length)
        {
            IsCompleted = true;

            return "Correct answer! Congratulations! Game completed.";
        }

        // Move to the next level.
        Level++;

        return "Correct answer! Moving to the next level.";
    }

    // Method 2: Display game progress
    public string GetProgress()
    {
        return $"Player: {PlayerName} | " +
               $"Level: {Level} | " +
               $"Score: {Score} | " +
               $"Completed: {IsCompleted}";
    }
}
