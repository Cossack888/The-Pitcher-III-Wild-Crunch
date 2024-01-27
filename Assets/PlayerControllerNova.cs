using DragonBones;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEditor;
using UnityEngine;

public class PlayerControllerNova : MonoBehaviour
{
    Vector3 direction;
    Rigidbody2D rb;
    [SerializeField] float speed;
    UnityArmatureComponent armature;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        armature = GetComponent<UnityArmatureComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        direction = new Vector3(moveHorizontal, moveVertical, 0);
        direction = transform.TransformDirection(direction);
        if (direction != Vector3.zero && !armature.animation.isPlaying)
        {
            armature.animation.Play("animtion0");
        }
        else if (direction == Vector3.zero)
        {
            armature.animation.Stop();
        }
        armature.sortingOrder = (int)Mathf.Floor(-transform.position.y);


    }
    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
    }
}
