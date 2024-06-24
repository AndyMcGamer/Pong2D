using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int playerScore;
    private int aiScore;

    private void Awake()
    {
        playerScore = 0;
        aiScore = 0;
        scoreText.text = $"Player: {playerScore} -- CPU: {aiScore}";
    }

    public void AddScore(bool isPlayerGoal)
    {
        if (!isPlayerGoal)
        {
            playerScore++;
        }
        else
        {
            aiScore++;
        }

        scoreText.text = $"Player: {playerScore} -- CPU: {aiScore}";
    }
}
