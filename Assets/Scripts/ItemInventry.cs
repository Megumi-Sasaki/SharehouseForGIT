using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInventry : MonoBehaviour
{
    public GameManager gameManager;
    public static ItemInventry instance;
    ItemInventryUI iteminventryUI;

    //買ったアイテムのスクリプタブルオブジェクトをリストにいれる。
   public List<KujyoItemScriptable> Inventrynoitems = new List<KujyoItemScriptable>();

   
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

    }

    void Start()
    {
        Inventrynoitems = new List<KujyoItemScriptable>();
        Inventrynoitems = gameManager.items;
        iteminventryUI = GetComponent<ItemInventryUI>();

}

    public void Add(KujyoItemScriptable item)//購入すると発動
    {
        Inventrynoitems.Add(item);
       gameManager.items = Inventrynoitems;
        iteminventryUI.UpdateUI();
    }

    public void Remove(KujyoItemScriptable item)//アイテム捨てるときなど
    {
        Inventrynoitems.Remove(item);
       gameManager.items = Inventrynoitems;
        iteminventryUI.UpdateUI();
    }

    public void RemoveAll()
    {
        if(Inventrynoitems == null)
        {
            return;
        }
        Inventrynoitems.Clear();
        gameManager.items = Inventrynoitems;
    }
}
