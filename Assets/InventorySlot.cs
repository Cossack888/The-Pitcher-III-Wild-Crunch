using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        InventoryItem draggedItem = eventData.pointerDrag.GetComponent<InventoryItem>();

        if (draggedItem != null)
        {
            // Optionally, you can add logic here to check if the drop is valid
            // For example, check if the slot already contains an item, or implement stacking rules.

            // Set the parent of the dragged item to this slot
            draggedItem.transform.SetParent(transform, false);
        }
    }
}