using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prompt : MonoBehaviour
{
    public GameObject prompt;
    bool inRange;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        prompt.SetActive(true);
        inRange = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        prompt.SetActive(false);
        inRange = false;
    }
    private void Update()
    {
        if (inRange)
        {
            if (Input.GetMouseButtonDown(1))
            {
                SceneManager.LoadScene(7);
            }

        }
    }
}
