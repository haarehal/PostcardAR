using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halikadic1_interfejsAplikacije : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ZatvoriAplikaciju() {
		Application.Quit();
	}

	public void OtvoriYoutube() {
		Application.OpenURL("https://www.youtube.com/results?search_query=george+enescu");
	}
}
