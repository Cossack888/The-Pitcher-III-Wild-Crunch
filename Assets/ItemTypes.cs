using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "ItemType")]
public class ItemType : ScriptableObject
{
    public Sprite sprite;
    public string itemName;
    public int SlotId;

    public Class typeofItem;
    public enum Class
    {
        animals,
        gamedev,
        food,
        items
    }


}