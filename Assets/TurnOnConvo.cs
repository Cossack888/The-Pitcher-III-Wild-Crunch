using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TurnOnConvo : MonoBehaviour
{
    DialogueManager dialogueManager;


    private void Start()
    {
        StartCoroutine(Wait(2));
    }

    private IEnumerator Wait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        dialogueManager = FindObjectOfType<DialogueManager>();
        dialogueManager.EnterStory(dialogueManager.dialogueContainers[0].dialog);
        this.enabled = false;
    }
}
