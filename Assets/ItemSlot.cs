using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    private bool isDragging = false;
    private RectTransform draggedRectTransform;
    private Transform originalParent;
    private Vector2 offset;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            isDragging = true;
            draggedRectTransform = GetComponent<RectTransform>();
            originalParent = draggedRectTransform.parent;

            // Calculate the offset between the clicked position and the UI element's local position
            RectTransformUtility.ScreenPointToLocalPointInRectangle(draggedRectTransform, eventData.position, eventData.pressEventCamera, out offset);

            // Optionally, you can add some logic when the UI element is clicked
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isDragging)
        {
            // Drag the UI element
            Vector2 localPointerPosition;
            if (RectTransformUtility.ScreenPointToLocalPointInRectangle(draggedRectTransform, eventData.position, eventData.pressEventCamera, out localPointerPosition))
            {
                draggedRectTransform.localPosition = localPointerPosition - offset;

                // Optionally, you can add some logic while the UI element is being dragged
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            // Drop the UI element
            isDragging = false;

            // Optionally, you can add some logic when the UI element is released

            // Check if the object is over a UI element
            PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
            pointerEventData.position = Input.mousePosition;

            var results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerEventData, results);

            // Find the first UI element in the results
            foreach (var result in results)
            {
                if (result.gameObject.GetComponent<RectTransform>() != null)
                {
                    // Make the object a child of the UI element
                    draggedRectTransform.SetParent(result.gameObject.transform);

                    // Optionally, you can add some logic when the object becomes a child of the UI element
                    break;
                }
            }

            // If the object was not dropped onto a UI element, revert its parent
            if (draggedRectTransform.parent == originalParent)
            {
                draggedRectTransform.SetParent(originalParent);
            }
        }
    }
}
