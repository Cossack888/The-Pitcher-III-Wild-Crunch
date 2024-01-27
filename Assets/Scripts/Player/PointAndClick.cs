using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointAndClick : MonoBehaviour
{
    Vector2 mousePosition;
    public void ReceivePosition(Vector2 _mousePosition)
    {
        mousePosition = _mousePosition;
    }

    public void OnMouseClick()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
            pointerEventData.position = mousePosition;
            var raycastResults = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerEventData, raycastResults);
            foreach (var result in raycastResults)
            {
                Debug.Log("UI Element Clicked: " + result.gameObject.name);
            }
        }
        else
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(mousePosition), out hit, Mathf.Infinity))
            {
                Debug.Log("3D Object Clicked: " + hit.collider.name);
            }
        }
    }



}
