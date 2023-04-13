using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInventryUI : MonoBehaviour
{
    public GameManager gameManager;
    public Transform slotsParent;

    //ItemSlot型の配列に↓でスロットを（3つのコ）全取得、配列にスロットを入れる
    public ItemSlot[] slots;

    // Start is called before the first frame update
    void Start()
    {
        slots = slotsParent.GetComponentsInChildren<ItemSlot>();

        UpdateUI(); //ゲームスタート時、所持アイテムのUIへの反映
    }

    // Update is called once per frame
    public void UpdateUI()
    {
        

        for(int i=0; i<slots.Length; i++)//slots.Lengthは３
        {
            if(i< gameManager.items.Count)//買ったアイテムまず数える（ItemInventryのitemsのリストにスクリプタブルｐぶじぇくとが記録してある）
            {
                slots[i].AddItem(gameManager.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
        //ItemInventry.instance.
    }
}
