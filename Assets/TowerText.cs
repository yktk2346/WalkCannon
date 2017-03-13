using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerText : MonoBehaviour {

    public int HP;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (HP <= 0) {
            Destroy(this.gameObject);
        }
	}

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Ball") {
            HP--;
        }
    }
}
