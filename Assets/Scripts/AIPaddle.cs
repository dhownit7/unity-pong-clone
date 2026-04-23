using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    public float speed = 6f;
    public float boundary = 5f;
    public Transform ball;

    void Update()
    {
        // Move towards the ball's Y position
        if (ball != null)
        {
            float direction = ball.position.y - transform.position.y;
            transform.Translate(0, direction * speed * Time.deltaTime, 0);
        }

        // Same boundary clamp as player
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, -boundary, boundary);
        transform.position = pos;
    }
}