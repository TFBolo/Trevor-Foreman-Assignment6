using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int lives;
    public static int score;

    public Text livesText;
    public Text scoreText;

    void Start()
    {
        lives = 3;
        score = 0;
    }
    void Update()
    {
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
        if (lives <= 0 || score == 30)
        {
            SceneManager.LoadScene("1_multiple_agent_sizes");
        }
    }
}
