using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OmiseButton : MonoBehaviour
{
    //お店の購入ボタン自体にスクリプタブルオブジェクトを登録してある。
    public KujyoItemScriptable item;

    public GameObject wanapanel;

    public int Needmoney;

   public void Pickup()
    {
        //ItemInventryのスクリプタブル型itemリストへの追加。（OmiseManager側から参照
        //ItemInventry.instance.Add(item);//上も下も同じこと
       wanapanel.GetComponent<ItemInventry>().Add(item);

    }

}
