using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvoTrigger : MonoBehaviour
{
    Outline outline;
    DialogueManager manager;
    bool inRange;
    [SerializeField] int id;
    public ItemType itemType;
    public ItemType itemType1;
    private void Start()
    {
        outline = GetComponent<Outline>();
        manager = GameObject.FindObjectOfType<DialogueManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        inRange = true;
        //GetComponent<SpriteRenderer>().color = Color.green;
        //outline.OutlineColor = Color.green;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        inRange = false;
        //outline.OutlineColor = Color.white;
        // GetComponent<SpriteRenderer>().color = Color.white;
    }
    private void Update()
    {
        if (inRange)
        {
            if (Input.GetMouseButtonDown(0))
            {
                manager.EnterStory(manager.dialogueContainers[id].dialog);
                this.enabled = false;
            }
        }
    }


}
