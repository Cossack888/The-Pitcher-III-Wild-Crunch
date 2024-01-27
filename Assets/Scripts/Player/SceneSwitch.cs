using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    Outline outline;
    bool inRange;
    
    [SerializeField] int sceneBuildIndex;

    private void Start()
    {
        outline = GetComponent<Outline>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        inRange = true;
        outline.OutlineColor = Color.green;
    }

    private void OnTriggerExit2D(Collider2D other) {
        inRange = false;
        outline.OutlineColor = Color.white;
    }

    private void Update() {
        if(inRange && Input.GetMouseButtonDown(0))
        {
            ChangeScene();
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneBuildIndex);
    }
}
