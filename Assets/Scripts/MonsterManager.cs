using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    public MonsterList monsterList;
    public GameManager gameManager;
    public OmiseManager omiseManager;
    // Start is called before the first frame update
    void Start()
    {
        if (gameManager.NezumiAp == true)
        {
            monsterList.Monster[0].SetActive(true);

        }
        else if (gameManager.SukarabeAp)
        {
            monsterList.Monster[1].SetActive(true);

        }
        else if (gameManager.CatAp)
        {
            monsterList.Monster[2].SetActive(true);
        }
        else if (gameManager.UsagiAp)
        {
            monsterList.Monster[3].SetActive(true);
        }
        else if (gameManager.SnakeAp)
        {
            monsterList.Monster[4].SetActive(true);
        }
        else if (gameManager.SasoriAp)
        {
            monsterList.Monster[5].SetActive(true);
        }
        else if (gameManager.KawausoAp)
        {
            monsterList.Monster[6].SetActive(true);
        }
        else if (gameManager.RakudaAp)
        {
            monsterList.Monster[7].SetActive(true);
        }
        else if (gameManager.KoburaAp)
        {
            monsterList.Monster[8].SetActive(true);
        }
        else if (gameManager.AmemitAp)
        {
            monsterList.Monster[9].SetActive(true);
        }
       if (gameManager.LastBossAp)
        {
            monsterList.Monster[10].SetActive(true);
        }
        

        //料理ボタン表示
        if (gameManager.HaveRakudaA && gameManager.HaveRakudaB && gameManager.HaveRakudaC)
        {
            omiseManager.ButtonCookingImageAppear();
            gameManager.CookButton.SetActive(true);
        }
        else if (gameManager.HaveTotteoki) //あとで消しても大丈夫かも
        {
            gameManager.CookButton.SetActive(false);
        }
        else if (gameManager.AmemittHekken)
        {
            //お店のアイテムをすべて表示する
            omiseManager.ButtonCookingImageAppear();
            gameManager.CookButton.SetActive(true);
        }
    }

   
}
