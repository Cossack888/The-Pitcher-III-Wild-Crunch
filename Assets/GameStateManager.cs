using Ink.Parsed;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public List<ItemType> items;

    public void AddItemToList(ItemType type)
    {
        items.Add(type);
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
