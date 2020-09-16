using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class halikadic_pustiMuziku : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    public GameObject Audio;
    public GameObject Instrument;
    public GameObject Efekat;

    void Start()
    {
        Audio.SetActive(false);
        Efekat.SetActive(false);
    }

    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "halikadic1_Instrument")
                {
                    Efekat.SetActive(true);
                    Audio.SetActive(true);
                }
                if (hit.collider.gameObject.name == "halikadic1_Efekat")
                {
                    Efekat.SetActive(false);
                    Audio.SetActive(false);
                }
            }
        }
    }
}
