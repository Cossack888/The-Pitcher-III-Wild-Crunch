using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossManager : MonoBehaviour
{
    [SerializeField] Image image;
    public float laughterMeter = 50;
    public GameObject[] Canvas;
    public int canva = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait(2));
    }

    // Update is called once per frame
    void Update()
    {
        image.fillAmount = laughterMeter / 100;
    }
    private IEnumerator Wait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        laughterMeter--;
        StartCoroutine(Wait(waitTime));
    }
    public void ChangeMeter(float amount)
    {
        laughterMeter += amount;
    }

    public void NextCanvas()
    {
        if (canva < Canvas.Length - 1)
        {
            canva++;
            foreach (var canvas in Canvas)
            {
                canvas.SetActive(false);
            }
            Canvas[canva].SetActive(true);

        }

    }

}
