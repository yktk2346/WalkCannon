using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingGenerator : MonoBehaviour {

    //TowerPrefabを入れる
    public GameObject towerP;
    //Medieva_fantasy_housePrefabを入れる
    public GameObject fHP;
    //Medival_housePrefabを入れる
    public GameObject hP;
    //WatchtowerPrefabを入れる
    public GameObject wTP;



    //かんたんにしたいなら関数化してしまうのがいい
    //建物の座標をランダムで返す
    Vector3 GetBuildingPos()
    {
        float x = Random.Range(-5f, 60f);//xで生成される上限
        float z = Random.Range(10f, 30f);//zで生成される上限
        return new Vector3(x, 0, z);//GetBuildingPosに値を返しているため、GetBuildingPos関数が活用できる
    }

    void BuildingCreate() {

        //10回ループ
        for (int i = 0; i < 10; i++)
        {
            //どの建物を出すかランダムに設定（11枚のカードから一枚引く漢字（0が含まれる））
            int num = Random.Range(0, 10);
            if (num <= 1)
            {
                Instantiate(towerP, GetBuildingPos(), Quaternion.Euler(0, 180, 0));
            }
            else if (num <= 3)
            {
                Instantiate(fHP, GetBuildingPos(), Quaternion.Euler(0, 180, 0));
            }
            else if (num <= 5)
            {
                Instantiate(hP, GetBuildingPos(), Quaternion.identity);
            }
            else if (num <= 7)
            {
                Instantiate(wTP, GetBuildingPos(), Quaternion.Euler(-90, 180, 0));
            }
        }
    }

    // Use this for initialization
    //Start (GameObjectの初期化処理)
    void Start(){
        BuildingCreate(); //StartでBuildingCreateを呼ぶ
    }
            //オブジェクトの座標
            //float x = Random.Range(-5f, 30f);
            //float z = Random.Range(10f, 30f);

            //オブジェクトを生成
            //` Quaternion.identity `は回転の数値が０と言う認識
            //実際には Quaternion の中身は回転計算に使うためのちょっと複雑な数値になっている
            //Vectorのように 0,0,0 としても 全て０度という形にはならない
            //そのため、 identity にはその０度を示す初期値のような値が入っているので、それを指定している感じ
            //あとで出現確率も設定する予定
            //towerだけ向きを指定したいので別に作る
            //GameObject tower = Instantiate(towerP, new Vector3(x, 0, z), Quaternion.identity) as GameObject;
            //LookAt関数が内部的に回転角を計算して rotate をしているので、
            //表面的には rotation は変更しなくても大丈夫
            //tower.transform.LookAt(new Vector3(0, 0, 0));
            //倒れているタワーの角度を調整
            //Instantiate(towerP, GetBuildingPos(), Quaternion.Euler(0, 180, 0));
            //Instantiate(fHP, GetBuildingPos(), Quaternion.Euler(0, 180, 0));
            //Instantiate(hP, GetBuildingPos(), Quaternion.identity);
            //Instantiate(wTP, GetBuildingPos(), Quaternion.Euler(-90, 0, 0));
        //}
	
	// Update is called once per frame
	void Update () {
		
	}
}
