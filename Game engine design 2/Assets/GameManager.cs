using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    int Score = 0;

    public void AddScore(int addedScore)
    {
        Score += addedScore;
    }

    public string GetScore() { return Score.ToString(); }
}
