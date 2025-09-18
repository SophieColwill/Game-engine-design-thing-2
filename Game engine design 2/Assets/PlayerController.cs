using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D controller;

    void Start()
    {
        controller = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            controller.linearVelocity = new Vector2(3, controller.linearVelocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            controller.linearVelocity = new Vector2(-3, controller.linearVelocity.y);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            controller.linearVelocity = new Vector2(controller.linearVelocity.x, 7);
        }
    }
}
