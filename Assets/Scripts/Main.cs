using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    public GameObject prefabBox;
    static public Vector3 mousePositionInWorld;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        mousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePositionInWorld.z = 0;

		if(Input.GetMouseButtonDown(1)) //Si apreto click derecho...
        {
            GameObject box = GameObject.Instantiate(prefabBox);
            box.transform.position = mousePositionInWorld;
        }
	}
}
