﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKey("w"))
		{
			this.transform.position += new Vector3(0,0.1f);
		}
		else if(Input.GetKey("s"))
		{
			this.transform.position += new Vector3(0,-0.1f);
		}

	}
}
