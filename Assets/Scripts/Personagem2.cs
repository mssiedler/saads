using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKey("up"))
		{
			this.transform.position += new Vector3(0,0.1f);
		}
		else if(Input.GetKey("down"))
		{
			this.transform.position += new Vector3(0,-0.1f);
		}

	}
}
