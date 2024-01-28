using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DectivateObject : MonoBehaviour
{
    public int SceneIndex;
    public int SceneIndex1;
    public int SceneIndex2;
    public GameObject Object;

    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == SceneIndex || SceneManager.GetActiveScene().buildIndex == SceneIndex1 || SceneManager.GetActiveScene().buildIndex == SceneIndex2)
        {
            Object.SetActive(false);
        }
    }
}