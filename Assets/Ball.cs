using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    Rigidbody rb;
    public float speed;

   
    //ヒット時にDestroyされるオブジェクトを入れる
    GameObject enemy;
    GameObject building1;
    GameObject building2;
    GameObject building3;
    GameObject bossTower;
    


    // Use this for initialization
    void Start () {

        //ボールのVector3に前へ進む力を加え、Rigidbodyを取得し、それに代入
        Vector3 force;
        force = this.gameObject.transform.forward * speed;
        rb = GetComponent<Rigidbody>();
        rb.AddForce(force);

        //ヒット時にDestroyされるオブジェクトを取得
        enemy = GameObject.Find("Enemy");
        //if (enemy == null)
        //{
       //     Debug.Log("enemyがnullだよ");
        //}
        building1 = GameObject.Find("House1");
        building2 = GameObject.Find("House2");
        building3 = GameObject.Find("WatchTower");
        bossTower = GameObject.Find("Tower");
        //Debug.Log("ログは来ている");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other) {
        Debug.Log(other.gameObject);
        Destroy(gameObject);
        Destroy(enemy);
        Destroy(building1);
        Destroy(building2);
        Destroy(building3);
        Destroy(bossTower);
    }
}
