using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score = 0;

    void Start()
    {
        score = 0;
        scoreText.text = "Score: 0";
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}