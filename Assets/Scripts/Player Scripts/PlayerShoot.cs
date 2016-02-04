using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{

    public GameObject bullet;

    [SerializeField]
    private float bulletMaximumVelocity;
    [SerializeField]
    private int angularVelocity;
    [SerializeField]
    private float chargeRatio = 0.3f;
    [SerializeField]
    private int maxAngle;
    [SerializeField]
    private int minAngle;
    [SerializeField]
    private float angle;
    [SerializeField]
    private float bulletOffset;

    private float power = 0f;

    void Start()
    {
        angle = GetMiddleAngle();
    }

    public float GetAngleRange()
    {
        return (maxAngle - minAngle) / 360f;
    }
    public int GetMiddleAngle()
    {
        return (maxAngle + minAngle) / 2;
    }
    public float GetCharge()
    {
        return power;
    }
    public int GetAngle()
    {
        return (int)angle;
    }
    public Vector3 GetRotation()
    {
        return new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z + angle);
    }

    //[SerializeField] private bool charging = false;
    //private bool angleChanging = false;
    //private bool angleDirection = false;


    //public void SetCharging(bool value)
    //{
    //    charging = value;
    //}
    //public void SetAngleUp(bool value)
    //{
    //    angleChanging = value;
    //    angleDirection = true;
    //}
    //public void SetAngleDown(bool value)
    //{
    //    angleChanging = value;
    //    angleDirection = false;
    //}

    public void Charge()
    {
        power = power + (Time.deltaTime * chargeRatio);
        if (power >= 1f)
        {
            power = 1f;
        }
    }

    public void Shoot()
    {
        GameObject b = Instantiate(bullet);
        b.transform.rotation = Quaternion.Euler(GetRotation());
        b.transform.position = transform.position + (b.transform.right * bulletOffset);
        b.GetComponent<Rigidbody2D>().velocity = b.transform.right * bulletMaximumVelocity * power;
        
        power = 0f;
    }

    public void ChangeAngle(bool counterClockWise)
    {
        if (counterClockWise == true)
        { //  sentido anti-horario
            angle = angle + angularVelocity * Time.fixedDeltaTime;
            if (angle > maxAngle)
            {
                angle = maxAngle;
            }
        }
        if (counterClockWise == false)
        {
            angle = angle - angularVelocity * Time.fixedDeltaTime;
            if (angle < minAngle)
            {
                angle = minAngle;
            }
        }
    }

}
