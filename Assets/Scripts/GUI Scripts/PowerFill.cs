using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerFill : MonoBehaviour {

    Image img;
    [SerializeField]
    private PlayerShoot playerShoot;

	// Use this for initialization
	void Start () {
        img = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        img.fillAmount = playerShoot.GetCharge();
	}
}
