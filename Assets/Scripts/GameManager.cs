using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI aiScoreText;
    public Transform ball;

    private int playerScore = 0;
    private int aiScore = 0;

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        ResetBall();
    }

    public void AIScores()
    {
        aiScore++;
        aiScoreText.text = aiScore.ToString();
        ResetBall();
    }

    void ResetBall()
    {
        ball.position = Vector2.zero;
        Ball ballScript = ball.GetComponent<Ball>();
        ballScript.Launch();
    }
}