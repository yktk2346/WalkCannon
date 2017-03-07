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

    //発射ボタン押下の判定
    private bool isFireButtonDown = false;
    //左ボタン押下の判定
    private bool isLButtonDown = false;
    //右ボタン押下の判定
    private bool isRButtonDown = false;
    //左の移動できる範囲
    private float canMoveL = 0f;
    //右の移動できる範囲
    private float canMoveR = 150f;
    //左右に移動するための力
    private float turnForce = 20f;


	// Use this for initialization
	void Start () {
        //Rigidbodyを取得
        myrb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        //Cannonをボタンに応じて移動させる
        if ((isLButtonDown) && canMoveL < this.transform.position.x)
        {
            //左に移動
            this.myrb.AddForce(-this.turnForce, 0, 0);
        }
        else if ((isRButtonDown) && canMoveR > this.transform.position.x) {
            //右に移動
            this.myrb.AddForce(this.turnForce, 0, 0);
        }
        //発射ボタンを押した場合の処理
        if (Input.GetKeyDown(KeyCode.Space) || isFireButtonDown) {
            //砲弾を複製
            Instantiate(cannonBall, muzzle.position, muzzle.rotation);
        }
        //発射ボタンを離した場合
        if (Input.GetKeyUp(KeyCode.Space) || isFireButtonDown) {
            isFireButtonDown = false;
        }
}

    //発射ボタンを押した場合の処理
    public void GetMyFireButtonDown() {
        this.isFireButtonDown = true;
    }

    //左ボタンを押し続けた場合　ここに移動用矢印のオブジェクトを入れる
    public void GetMyLeftButtonDown() {
        this.isLButtonDown = true;
    }
    //左ボタンを離した場合
    public void GetMyLeftButtonUp() {
        this.isLButtonDown = false;
    }

    //右ボタンを押し続けた場合
    public void GetMyRightButtonDown() {
        this.isRButtonDown = true;
    }
    //右ボタンを離した場合
    public void GetMyRightButtonUp() {
        this.isRButtonDown = false;
    }
}
