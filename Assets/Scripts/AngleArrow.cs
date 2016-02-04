using UnityEngine;
using System.Collections;

public class AngleArrow : MonoBehaviour
{

    [SerializeField]
    private PlayerShoot playerShoot;

    void Update ()
    {
            transform.localEulerAngles = new Vector3(0f, 0f, playerShoot.GetAngle());
    }

}