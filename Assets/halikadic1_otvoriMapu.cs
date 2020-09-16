using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class halikadic1_otvoriMapu : MonoBehaviour {

	Ray ray;
    RaycastHit hit;

	public GameObject Planeta;
	private float brzina;

	void Start () {
		brzina = 50.0f;
	}
	
	void Update () {
		transform.Rotate(Vector3.up * brzina * Time.deltaTime);

		if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "halikadic1_Planeta")
                {
					Application.OpenURL("https://www.google.com/maps/place/Romanian+Athenaeum/@44.4413202,26.0950905,17z/data=!3m1!4b1!4m5!3m4!1s0x40b1ff4f6e6d7997:0x5a73af5fe07876f2!8m2!3d44.4413202!4d26.0972792");
				}
            }
        }
	}
}
