using System;

namespace PlayerStats
{
    public class Player
    {
    private float highScore;
    public int PlayedGames { get; private set; }
    public int WonGames { get; private set; }
    public string Name { get; }

    public float HighScore
    {
        get => highScore;
        set
        {
            if (value > highScore)
            {
                highScore = value;
            }
        }
    }

    public float WinRate
    {
        get
        {
            if (PlayedGames == 0) return 0;
            return (float)WonGames / PlayedGames;
        }
    }

    public Player(string name)
    {
        Name = name;
        highScore = 0;
        PlayedGames = 0;
        WonGames = 0;
    }

    public void PlayGame(bool win)
    {
        PlayedGames++;
        if (win)
        {
            WonGames++;
        }
    }

    }
}
