using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSIRYSStatue : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource audioSource;
    public string[] Shiraberu;  //調べたときのメッセ

    internal T GetRandom<T>(params T[] Params)
    {
        return Params[Random.Range(0, Params.Length)];
    }

    public void PushOsirisstatue()
    {
        if (gameManager.Shiraberu == true)
        {
            return;
        }
        gameManager.plusMoneyText.text = "";
        audioSource.PlayOneShot(audioSource.clip);
          
            if (gameManager.money >= 1000000)
            {
                gameManager.moneyPlus = 0;
            }
            else
            {
               int[] ForOsiris = new int[] { 0,0,0,0,0,0,1};
               int OsirisRandom = GetRandom(ForOsiris);

              gameManager.moneyPlus = OsirisRandom;
        }

            if (gameManager.money + gameManager.moneyPlus >= 1000000)
            {
                gameManager.money = 1000000;
                gameManager.moneyPlus = 0;
            }


            gameManager.RefreshMoneyText();   //お金スコア更新
          
            gameManager.MoneyTextFadestart = true;

            gameManager.DoSave();
        

    }

    public void TouchShiraberuMeiwaku() //調べる用。
    {
        if (gameManager.Shiraberu == true)
        {
            gameManager.MenuPanel.SetActive(false);
            gameManager.MovePanel.SetActive(false);
            gameManager.RefreshMessageText(Shiraberu[0]);

        }
    }

}
