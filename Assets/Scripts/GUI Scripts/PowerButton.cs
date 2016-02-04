using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PowerButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    [SerializeField]
    PlayerShoot playerShoot;
    bool pressed = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        playerShoot.Shoot();
        pressed = false;
    }

    void FixedUpdate()
    {
        if (pressed == false)
        {
            return;
        }
        playerShoot.Charge();
    }
}