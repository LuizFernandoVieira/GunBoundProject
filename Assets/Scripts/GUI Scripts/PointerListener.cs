using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public abstract class PointerListener : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool pressed = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
    }

    void Update()
    {
        if (pressed == false)
            return;

        ButtonAction();
    }

    public abstract void ButtonAction();
}
