using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //RaycastHit2D[] info2 = Physics2D.RaycastAll(this.transform.position, this.transform.right);
        RaycastHit2D[] info2 = Physics2D.CircleCastAll(Main.mousePositionInWorld, 10, Vector3.right);
        for (int i = 0; i < info2.Length ; i++)
        {
            //info2[i].rigidbody.AddForce();
        }

		if(Input.GetMouseButtonDown(2))
        {
            RaycastHit2D info = Physics2D.Raycast(this.transform.position, this.transform.right);
            if(info.transform != null) //Le pegué a algo?
            {
                if(info.rigidbody != null)
                {
                    info.rigidbody.AddForce(this.transform.right * 15, ForceMode2D.Impulse);
                }
            }
        }

        this.transform.right = (Main.mousePositionInWorld - this.transform.position).normalized;
	}
}
