using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instatiate_obj : MonoBehaviour
{
    public GameObject[] Objects; //裝生成物件的陣列。

    public Transform[] Points; //裝生成點的陣列。

    public float Ins_Time = 1; //每幾秒生成一次。

    //public 公開 –在宣告前面加上public，程式碼底下會出現欄位，可以從外部放入指定的物件(要與宣告類型相同哦!)。

    

    void Start ()
    {

    }

    public void startAppear(){
        
        
        InvokeRepeating("Ins_Objs", Ins_Time, Ins_Time);

        //重複呼叫(“函式名”，第一次間隔幾秒呼叫，每幾秒呼叫一次)。
    }

    

    void Ins_Objs() //生成物件函式。

    {

        int Random_Objects = Random.Range(0, Objects.Length);

        //~物件陣列長度的整數-1(不包含最大值所以-1)。

        

        int Random_Points = Random.Range(0, Points.Length);

        //隨機產生0~生成點陣列長度的整數-1(不包含最大值所以-1)。

        

        Instantiate(Objects[Random_Objects], Points[Random_Points].transform.position, Points [Random_Points].transform.rotation);

        //Instantiate實例化(要生成的物件, 物件位置, 物件旋轉值);

    }
}
