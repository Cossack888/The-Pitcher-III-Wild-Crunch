using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 10f;
    Vector3 horizontalInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector3 horizontalVelocity = (transform.right * horizontalInput.x + transform.up * horizontalInput.y) * speed;
        //horizontalVelocity.x += transform.position.x;
        //horizontalVelocity.y += transform.position.y;
        rb.MovePosition(transform.position + horizontalVelocity * Time.deltaTime);
    }

    public void ReceiveInput(Vector2 _horizontalInput)
    {
        horizontalInput = _horizontalInput; ;

    }
}
