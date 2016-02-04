using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AngleRange : MonoBehaviour {

    [SerializeField]
    private PlayerShoot playerShoot;
    private Image image;

	// Use this for initialization
	void Start () {
        image = GetComponent<Image>();
        image.fillAmount = playerShoot.GetAngleRange();
        transform.localEulerAngles = new Vector3 (0f, 0f, playerShoot.GetMiddleAngle());
	}
	
}
