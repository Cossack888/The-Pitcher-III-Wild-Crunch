using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyScriptInScene : MonoBehaviour
{
    public int SceneIndex;

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == SceneIndex)
        {
            Destroy(this.gameObject);
        }
    }
}
