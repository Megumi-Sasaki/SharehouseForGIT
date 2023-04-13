using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class IrairaStaff : MonoBehaviour
{
    //static SaveDate SaveDatedayo = new SaveDate();

    public GameManager gameManager;
   
    CanvasGroup canvasGroup;

    public AudioSource audioSource;

    public string StaffName;

    public int NeedBomb; //消すのに要する爆弾のかず

    public int Money; //手に入るお金

    public string[] Shiraberu;  //調べたときのメッセ

    public int MyNumber;

    bool TouchOK;




    public void Awake()
    {
        //ゲームスタート時に消しとく
        this.gameObject.SetActive(false);

    }

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
       
        TouchOK = true;
        
    }

    public void ClickDown()
    {
       
        if (gameManager.Shiraberu == true)
        {
            return;
        }

        if (TouchOK)
        {
           
            gameManager.Ira(MyNumber);

            audioSource.PlayOneShot(audioSource.clip);
            TouchOK = false;
            
            gameManager.HouseLevelUp();
            //moneyランダム計算
            if (gameManager.money >= 1000000)
            {
                Money = 0;
            }
            else
            {
                Money = Random.Range(70, 200);
            }
            if (gameManager.money + Money >= 1000000)
            {
                gameManager.money = 1000000;
                Money = 0;
            }
            gameManager.moneyPlus = Money;

            gameManager.RefreshMoneyText();   //お金スコア更新
            DeleteMoneyText();
            gameManager.MoneyTextFadestart = true;

            gameManager.DoSave();
            canvasGroup.DOFade(0, 0.6f).SetEase(Ease.OutQuart).OnComplete(DeleteObject);
           

        }

    }
    void DeleteObject()
    {
        this.gameObject.SetActive(false);
        TouchOK = true;       
    }

    public void DeleteMoneyText()
    {
        gameManager.plusMoneyText.color = new Color(1, 0.1f, 0.1f, 1);
        gameManager.plusMoneyText.text = "+" + Money.ToString();

    }

    //ボタンはつけなくてもイベントトリガーで判断できる
    public void TouchShiraberuMeiwaku() //調べる用。
    {
        if (gameManager.Shiraberu == true)
        {
           // gameManager.MenuPanel.SetActive(false);
           // gameManager.MovePanel.SetActive(false);
            gameManager.RefreshMessageText(Shiraberu[0]);

        }
    }

    
}


   


   


