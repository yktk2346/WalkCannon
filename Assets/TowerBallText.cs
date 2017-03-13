using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBallText : MonoBehaviour {

    //TowerBallを生成するための変数
    public GameObject towerBall;
    //砲弾の発射地点の変数、生成位置を指定
    public Transform towerMuzzle;

    //プレイヤーの位置を入れる箱
    private GameObject cannon;

    //弾を討つ時間の感覚
    float timeCount;


    // Use this for initialization
    void Start () {

        //プレイヤーのオブジェクトを取得
        cannon = GameObject.Find("Cannon");
    }
	
	// Update is called once per frame
	void Update () {

        timeCount += Time.deltaTime;
        if (timeCount >= 5.0f)
        {
            //弾を撃つ処理
            timeCount = 0;
            Debug.Log("ログは来ているよ");
            //砲弾を複製
            GameObject ball = Instantiate(towerBall, towerMuzzle.position, towerMuzzle.rotation) as GameObject;
            Debug.Log("Muzzle " + towerMuzzle.position.ToString());
            Debug.Log("Ball " + ball.transform.position.ToString());
        }

        transform.LookAt(cannon.transform);
    }
}
