using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KujyoItem : MonoBehaviour
{
    //ヘッダー部分のアイテムにつける


    public KujyoItemScriptable item;




    void Start()
    {
        
        this.gameObject.SetActive(false);
    }

   public void buyItem()
    {
        
            this.gameObject.SetActive(true);
        
    }

}
