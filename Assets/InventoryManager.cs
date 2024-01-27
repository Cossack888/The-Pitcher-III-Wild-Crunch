using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public void SwapSlots(InventorySlot slot1, InventorySlot slot2)
    {
        Vector2 tempPosition = slot1.transform.position;
        slot1.transform.position = slot2.transform.position;
        slot2.transform.position = tempPosition;
    }

    public void ResetSlotPosition(InventorySlot slot)
    {
        // slot.ResetPosition();
    }
}