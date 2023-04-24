using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        int level = SceneManager.GetActiveScene().buildIndex;
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        if (playerScore >= 5 && level == 0)
        {
            SceneManager.LoadScene(1);
        }
        else if (playerScore > 5 && level == 1)
        {
            SceneManager.LoadScene("level3");
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
