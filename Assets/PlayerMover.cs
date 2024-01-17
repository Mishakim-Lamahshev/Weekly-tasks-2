using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Tooltip("Movement speed in units per second")]
    [SerializeField]
    public float speed = 5f;

    void Update()
    {
        // Get input from arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);

        // Move the player
        transform.Translate(movement * speed * Time.deltaTime);

        // Validate player in bounds
        if (Mathf.Abs(transform.position.x) > 278f)
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, transform.position.z);
        }
        if (Mathf.Abs(transform.position.y) > 110f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y * -1, transform.position.z);
        }
    }
}
