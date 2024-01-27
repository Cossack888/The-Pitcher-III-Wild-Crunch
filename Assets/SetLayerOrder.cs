using DragonBones;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLayerOrder : MonoBehaviour
{

    [SerializeField] int layerOrder;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            for (int i = 0; i < collision.transform.childCount; i++)
            {
                collision.transform.GetChild(i).gameObject.GetComponent<UnityArmatureComponent>().sortingOrder = layerOrder;
            }

        }
    }
}
