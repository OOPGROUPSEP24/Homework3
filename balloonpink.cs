using UnityEngine;

public class balloonpink : MonoBehaviour
{
    public float moveSpeed = 2f; // Speed at which the balloon moves

    void Update()
    {
        // Move the balloon upwards
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);

        // Destroy the balloon once it goes off the screen
        if (transform.position.y > Camera.main.orthographicSize + 1f)
        {
            Destroy(gameObject);
        }
    }
}
