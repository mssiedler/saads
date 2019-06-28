using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

    // Use this for initialization
    Vector3 velocidade;
	void Start () {
        velocidade = new Vector3(0.1f, 0.1f);
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += velocidade;
	}

	private void OnCollisionEnter2D(Collision2D c)
	{
        if(c.gameObject.tag == "lateral")
        {
            velocidade.y = velocidade.y * -1;
        } else if (c.gameObject.tag == "jogador")
        {
            velocidade.x = velocidade.x * -1;
        }
	}
}
