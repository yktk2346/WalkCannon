﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    Rigidbody rb;
    public float speed;
    


    // Use this for initialization
    void Start () {

        //ボールのVector3に前へ進む力を加え、Rigidbodyを取得し、それに代入
        Vector3 force;
        force = this.gameObject.transform.forward * speed;
        rb = GetComponent<Rigidbody>();
        rb.AddForce(force);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //「other.gameObject.tag」＝「衝突したオブジェクト(相手)のタグ」
    void OnCollisionEnter(Collision other) {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "EnemyTag") {
            Destroy(other.gameObject);
        }
        Destroy(this.gameObject);
    }
}
