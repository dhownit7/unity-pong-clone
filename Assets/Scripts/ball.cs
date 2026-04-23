using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Launch();
    }

    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(-1f, 1f);
        rb.velocity = new Vector2(x, y).normalized * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "WallTop" ||
            collision.gameObject.name == "WallBottom")
        {
            SoundManager.Instance.PlayBallBoundary();
        }
        else if (collision.gameObject.name == "PlayerPaddle")
        {
            SoundManager.Instance.PlayPlayerPaddleHit();
        }
        else if (collision.gameObject.name == "AIPaddle")
        {
            SoundManager.Instance.PlayAIPaddleHit();
        }
    }
}