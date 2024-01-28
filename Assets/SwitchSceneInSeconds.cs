using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneInSeconds : MonoBehaviour
{
    [SerializeField] int sceneBuildIndex;

    private void Start()
    {
        StartCoroutine(Wait(5));
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneBuildIndex);
    }
    private IEnumerator Wait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        ChangeScene();
    }
}
