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

        /*  Jakby znowu miało być point and click
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if(hit.collider != null)
        {
            Debug.Log(hit.collider.name);
            ChangeScene(hit.collider);
        }
        */
        
    }

    void ChangeScene(Collider2D col)
    {
        SceneSwitch sceneSwitch;
        col.TryGetComponent<SceneSwitch>(out sceneSwitch);
        if(sceneSwitch != null)
            sceneSwitch.ChangeScene();
    }

}
