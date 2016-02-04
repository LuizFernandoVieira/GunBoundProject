using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class SwitchButton : MonoBehaviour, IPointerClickHandler {

    [SerializeField]
    GameObject obj1;
    [SerializeField]
    GameObject obj2;
	

	public void OnPointerClick (PointerEventData eventData)
    {
        obj1.SetActive(!obj1.activeSelf);
        obj2.SetActive(!obj2.activeSelf);
    }
}
