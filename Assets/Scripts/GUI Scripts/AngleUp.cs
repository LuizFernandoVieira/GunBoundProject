using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class AngleUp : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    [SerializeField]
    PlayerShoot player;
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

        player.ChangeAngle(true);
    }
}