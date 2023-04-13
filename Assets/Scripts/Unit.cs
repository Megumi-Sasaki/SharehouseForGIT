using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{
    //使い方　
    //まずGameObjectを作り、新たに作ったUnit型の変数に、作ったGameObjectを代入。
    //このとき、GameObjectはGetComponentでUnitのスクリプトを取得させて代入。
    //プレハブとして作ってあるものにUnitのスクリプトをつける。
    //インスペクターからそれぞれ個別にメジェドのステータスを入れる。
    //すると、個別の数字を持ったプレハブをオブジェクトとして呼び出せる。（Instatntiate

    public string unitName;

    public int HouseLevelNeed;


    public Sprite Mitame;  //いちおう

    public string[] Serifu;

    public GameObject iraira;
 
}
