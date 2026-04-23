using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    public float speed = 10f;
    public float boundary = 4.5f;

    void Update()
    {
        float move = Input.GetAxis("Vertical");
        transform.Translate(0, move * speed * Time.deltaTime, 0);

        // Clamp position so paddle can't leave screen
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, -boundary, boundary);
        transform.position = pos;

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.name == "WallTop" ||
                collision.gameObject.name == "WallBottom")
            {
                SoundManager.Instance.PlayPaddleBoundary();
            }
        }
    }
}