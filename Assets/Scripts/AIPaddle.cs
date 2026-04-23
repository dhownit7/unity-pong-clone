using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    public float speed = 4f;
    public float boundary = 5f;
    public Transform ball;

    void Update()
    {
        if (ball != null)
        {
            float direction = ball.position.y - transform.position.y;
            float move = Mathf.Clamp(direction, -1f, 1f);
            transform.Translate(0, move * speed * Time.deltaTime, 0);
        }

        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, -boundary, boundary);
        transform.position = pos;
    }
}