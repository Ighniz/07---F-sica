using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour {

    public Rigidbody2D rb;
    public bool isPicked;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if(isPicked)
        {
            //this.transform.position = Main.mousePositionInWorld;
            rb.velocity = (Main.mousePositionInWorld - this.transform.position) * 15;
        }
    }

    private void OnMouseDown()
    {
        isPicked = true;
    }

    private void OnMouseUp()
    {
        isPicked = false;
    }
}
