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
    public GameObject[] faces;
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
        if (direction.x > 0)
        {
            foreach (GameObject gameObject in faces)
            {
                gameObject.SetActive(false);
            }
            faces[2].SetActive(true);
        }
        if (direction.x < 0)
        {
            foreach (GameObject gameObject in faces)
            {
                gameObject.SetActive(false);
            }
            faces[1].SetActive(true);
        }
        if (direction == Vector3.zero && !faces[0].activeSelf)
        {
            foreach (GameObject gameObject in faces)
            {
                gameObject.SetActive(false);
            }
            faces[0].SetActive(true);
        }

        if (direction.y > 0)
        {
            foreach (GameObject gameObject in faces)
            {
                gameObject.SetActive(false);
            }
            faces[3].SetActive(true);
        }


    }
    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
    }
}
