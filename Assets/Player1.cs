using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontal, vertical) * speed * Time.deltaTime;
        transform.Translate(movement);

        if (Mathf.Abs(transform.position.x) > 29.35f)
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, transform.position.z);
        }

        if (Mathf.Abs(transform.position.y) > 7.9f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y * -1, transform.position.z);
        }
    }
}
