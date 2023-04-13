using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Image icon;

    public Sprite ItemRanImage;

    public KujyoItemScriptable item;  //スクリプタブル型の箱を作り、ここにスクリプタブルオブジェクトを代入する

    //スロットの見かけを変更するための処理↓
    public void AddItem(KujyoItemScriptable newItem)
    {

        item = newItem;
        icon.sprite = newItem.icon; //スクリプタブルに登録した画像にかえる
        
    }

    public void ClearSlot()
    {

        item = null;
        icon.sprite = null;
        //アイテム欄の画像
        //icon.sprite = ItemRanImage;
      
    }

    public void OnRemoveButton()
    {
        if(item == null)
        {
            return;
        }
        ItemInventry.instance.Remove(item);
    }
}
