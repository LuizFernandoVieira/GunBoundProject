using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class LeftArrow : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    [SerializeField]
    PlayerController player;
    bool pressed = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        //player.SetKinematic(false);
        pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //player.SetKinematic(true);
        pressed = false;
    }

    void FixedUpdate()
    {
        if (pressed == false)
            return;

        player.Move(false);
    }
}