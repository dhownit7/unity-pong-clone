using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    public bool isLeftZone;
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            if (isLeftZone)
                gameManager.AIScores();
            else
                gameManager.PlayerScores();
        }
    }
}