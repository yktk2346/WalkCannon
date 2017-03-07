using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    //敵ゲームオブジェクトを入れる
    public GameObject enemy;

    //関数化してしまい簡略化
    //敵の出現座標をランダムで返す
    Vector3 GetEnemyPos()
    {
        float x = Random.Range(-5f, 60f);//xで生成される上限
        float z = Random.Range(5f, 20f);//zで生成される上限
        return new Vector3(x, 0, z);//GetBuildingPosに値を返しているため、GetBuildingPos関数が活用できる
    }


    // Use this for initialization
    void Start()
    {
        //10回ループ、敵を10体出現させる
        for (int i = 0; i < 10; i++)
        {
            //どの建物を出すかランダムに設定（11枚のカードから一枚引く漢字（0が含まれる））
            int num = Random.Range(0, 10);
            if (num <= 7)
            {
                Instantiate(enemy, GetEnemyPos(), Quaternion.Euler(0, 180, 0));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}