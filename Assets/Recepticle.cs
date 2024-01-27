using DragonBones;
using UnityEngine;
using UnityEngine.EventSystems;

public class Recepticle : MonoBehaviour, IDropHandler
{
    BossManager bossManager;
    public int slotID;
    public ItemType item;

    private void Start()
    {
        bossManager = FindObjectOfType<BossManager>();
    }


    public void OnDrop(PointerEventData eventData)
    {
        InventoryItem draggedItem = eventData.pointerDrag.GetComponent<InventoryItem>();

        if (draggedItem != null)
        {

            // Optionally, you can add logic here to check if the drop is valid
            // For example, check if the slot already contains an item, or implement stacking rules.
            Debug.Log(draggedItem.name);
            // Set the parent of the dragged item to this slot
            draggedItem.transform.SetParent(transform, false);
            draggedItem.transform.position = transform.position;
            if (slotID == draggedItem.type.SlotId)
            {
                bossManager.ChangeMeter(5);
            }
            else if (item = draggedItem.type)
            {
                bossManager.ChangeMeter(2);
            }
        }

    }
}