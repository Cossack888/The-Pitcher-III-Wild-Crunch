using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvoTrigger : MonoBehaviour
{
    [SerializeField] DialogueManager manager;

    [SerializeField] int id;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        manager.EnterStory(manager.dialogueContainers[id].dialog);
        gameObject.SetActive(false);

    }

}
