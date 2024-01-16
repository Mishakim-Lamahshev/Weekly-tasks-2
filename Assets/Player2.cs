using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S)){transform.Translate(Vector3.down * Time.deltaTime * speed);}
        if (Input.GetKey(KeyCode.A))
        {transform.Translate(Vector3.left * Time.deltaTime * speed);
        }if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
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
