using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private Score scoreManager;
    private bool hasScored = false;

    void Start()
    {
        scoreManager = FindObjectOfType<Score>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (hasScored) return;

        if (collision.CompareTag("Player"))
        {
            hasScored = true;
            scoreManager.AddScore();
        }
    }
}