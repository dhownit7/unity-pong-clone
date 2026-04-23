using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI aiScoreText;
    public TextMeshProUGUI winText;
    public Transform ball;

    private int playerScore = 0;
    private int aiScore = 0;
    private int winScore = 5;

    void Start()
    {
        winText.gameObject.SetActive(false);
    }

    public void PlayerScores()
    {
        SoundManager.Instance.PlayScore();
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        if (playerScore >= winScore)
            ShowWinner("Player Wins!");
        else
            ResetBall();
    }

    public void AIScores()
    {
        SoundManager.Instance.PlayScore();
        aiScore++;
        aiScoreText.text = aiScore.ToString();
        if (aiScore >= winScore)
            ShowWinner("AI Wins!");
        else
            ResetBall();
    }

    void ShowWinner(string message)
    {
        winText.gameObject.SetActive(true);
        winText.text = message + "\nPress R to Restart";
        ball.gameObject.SetActive(false);

        if (message.Contains("Player"))
            SoundManager.Instance.PlayWin();
        else
            SoundManager.Instance.PlayLose();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void ResetBall()
    {
        ball.position = Vector2.zero;
        Ball ballScript = ball.GetComponent<Ball>();
        ballScript.Launch();
    }
}