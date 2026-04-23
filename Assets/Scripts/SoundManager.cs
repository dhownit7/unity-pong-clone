using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioClip playerPaddleHit;
    public AudioClip aiPaddleHit;
    public AudioClip paddleBoundaryHit;
    public AudioClip ballBoundaryHit;
    public AudioClip scoreSound;
    public AudioClip winSound;
    public AudioClip loseSound;

    private AudioSource audioSource;

    void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayPlayerPaddleHit()
    {
        audioSource.PlayOneShot(playerPaddleHit,0.5f);
    }

    public void PlayAIPaddleHit()
    {
        audioSource.PlayOneShot(aiPaddleHit, 0.5f);
    }

    public void PlayPaddleBoundary()
    {
        audioSource.PlayOneShot(paddleBoundaryHit, 0.5f);
    }

    public void PlayBallBoundary()
    {
        audioSource.PlayOneShot(ballBoundaryHit, 0.5f);
    }

    public void PlayScore()
    {
        audioSource.PlayOneShot(scoreSound, 0.5f);
    }

    public void PlayWin()
    {
        audioSource.PlayOneShot(winSound, 0.5f);
    }

    public void PlayLose()
    {
        audioSource.PlayOneShot(loseSound);
    }
}