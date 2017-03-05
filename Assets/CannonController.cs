using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {

    //CannonBallを生成するための変数
    public GameObject cannonBall;
    //砲弾の発射地点の変数、生成位置を指定
    public Transform muzzle;

    //Cannonを移動させるためのコンポーネントを入れる
    private Rigidbody myrb;

    //左ボタン押下の判定
    private bool isLButtonDown = false;
    //右ボタン押下の判定
    private bool isRButtonDown = false;
    //左の移動できる範囲
    private float canMoveL = 0f;
    //右の移動できる範囲
    private float canMoveR = 150f;
    //左右に移動するための力
    private float turnForce = 50f;


	// Use this for initialization
	void Start () {
        //Rigidbodyを取得
        myrb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //スペースキーが押された時
        if (Input.GetKeyDown(KeyCode.Space)) {
            //砲弾を複製
            Instantiate(cannonBall, muzzle.position, muzzle.rotation);
        }

        //Cannonをボタンに応じて移動させる
        //※移動上限未設定、後から修正の必要あり
        if ((isLButtonDown) && canMoveL < this.transform.position.x)
        {
            //左に移動
            this.myrb.AddForce(-this.turnForce, 0, 0);
        }
        else if ((isRButtonDown) && canMoveR > this.transform.position.x) {
            //右に移動
            this.myrb.AddForce(this.turnForce, 0, 0);
        }
	}
}
