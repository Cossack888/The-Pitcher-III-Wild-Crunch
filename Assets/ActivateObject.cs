using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateObject : MonoBehaviour
{
    public int SceneIndex;
    public GameObject Object;

    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == SceneIndex)
        {
            Object.SetActive(true);
        }
    }
}
