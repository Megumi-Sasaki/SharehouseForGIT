using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OmiseManager : MonoBehaviour
{

    public GameManager gameManager;

    public GameObject[] Shinazoroe;//ボタン
    public GameObject[] ShohinGazou;
    public GameObject[] Hatenas;

    public void Start()
    {
        if (gameManager.NezumiHakken || gameManager.SukarabeAp)
        {
            ButtonNezumiImageAppear();
        }
        if (gameManager.SukarabeHakken || gameManager.CatAp)
        {
            ButtonSukarabeImageAppear();
        }
        if (gameManager.CatHakken || gameManager.UsagiAp)
        {
            ButtonCatImageAppear();
        }
        if (gameManager.UsagiHakken || gameManager.SnakeAp)
        {
            ButtonUsagiImageAppear();
        }
        if(gameManager.SnakeHakken || gameManager.SasoriAp)
        {
            ButtonSnakeImageAppear();
        }
        if (gameManager.SasoriHakken || gameManager.KawausoAp)
        {
            ButtonSasoriImageAppear();
        }
        if (gameManager.KawausoHakken || gameManager.RakudaAp)
        {
            ButtonKawausoImageAppear();
        }
        if (gameManager.RakudaHakken || gameManager.KoburaAp)
        {
            ButtonRakudaImageAppear();
        }
        if(gameManager.KoburaHakken || gameManager.AmemitAp)
        {
            ButtonKoburaImageAppear();
        }
        if (gameManager.AmemittHekken || gameManager.LastBossAp)
        {
            ButtonAmemittImageAppear();
        }
     
        if (gameManager.HaveFrightChicket == 1)//正規のチケット
        {
            ALlImageDissapear();
        }
        gameManager.CookingButtonAppear();

    }

    //ボタン処理
    public void PushNezumitori(int rank) //0はＣランク、ボタン押したらここに数字入る
    {
        FlightTimeDelete();

        gameManager.YesNoButtonPanel.SetActive(true);//YesNoパネル出現
        if (rank == 0)
        {
            gameManager.RefreshMessageText("ねずみとりを買う？");

        }
        if (rank == 1)
        {
            gameManager.RefreshMessageText("どく入りチーズを買う？");
        }
        if (rank == 2)
        {
            gameManager.RefreshMessageText("利用料が高いねずみの写真を買う？");
        }
        gameManager.YesNoNumber = 0;
        //rankをOmiseManagerで受け取り、ゲーマネに渡す
        gameManager.ItemRankNumber = rank;
        //お金もわたす
        gameManager.needmoney = Shinazoroe[rank].GetComponent<OmiseButton>().Needmoney;
        

    }

    public void PushSukarabeItem(int rank) //0はＣランク、ボタン押したらここに数字入る
    {
        FlightTimeDelete();
        gameManager.YesNoButtonPanel.SetActive(true);//YesNoパネル出現
        if (rank == 3)
        {
            gameManager.RefreshMessageText("どくうんちを買う？");
        }
        if (rank == 4)
        {
            gameManager.RefreshMessageText("ミニプラネタリウムを買う？");
        }

        gameManager.YesNoNumber = 0;
        //rankをOmiseManagerで受け取り、ゲーマネに渡す
        gameManager.ItemRankNumber = rank;
        //お金もわたす？
        gameManager.needmoney = Shinazoroe[rank].GetComponent<OmiseButton>().Needmoney;
    }

    public void PushCatItem(int rank) //0はＣランク、ボタン押したらここに数字入る
    {
        FlightTimeDelete();
        gameManager.YesNoButtonPanel.SetActive(true);//YesNoパネル出現
        if (rank == 5)
        {
            gameManager.RefreshMessageText("空のなべを買う？");
        }
        if (rank == 6)
        {
            gameManager.RefreshMessageText("ハイテク超音波装置（金）を買う？");
        }

        gameManager.YesNoNumber = 0;
        //rankをOmiseManagerで受け取り、ゲーマネに渡す
        gameManager.ItemRankNumber = rank;
        //お金もわたす？
        gameManager.needmoney = Shinazoroe[rank].GetComponent<OmiseButton>().Needmoney;
    }


    public void PushUsagiItem(int rank) //0はＣランク、ボタン押したらここに数字入る
    {
        FlightTimeDelete();
        gameManager.YesNoButtonPanel.SetActive(true);//YesNoパネル出現
        if (rank == 7)
        {
            gameManager.RefreshMessageText("ポリバケツを買う？");
        }
        if (rank == 8)
        {
            gameManager.RefreshMessageText("アイアンメットを買う？");
        }
        if (rank == 9)
        {
            gameManager.RefreshMessageText("ツタンカーメンのマスク（呪）を買う？");
        }
        gameManager.YesNoNumber = 0;
        //rankをOmiseManagerで受け取り、ゲーマネに渡す
        gameManager.ItemRankNumber = rank;
        //お金もわたす？
        gameManager.needmoney = Shinazoroe[rank].GetComponent<OmiseButton>().Needmoney;
    }

    public void PushSnakeItem(int rank) //0はＣランク、ボタン押したらここに数字入る
    {
        FlightTimeDelete();
        gameManager.YesNoButtonPanel.SetActive(true);//YesNoパネル出現
        if (rank == 10)
        {
            gameManager.RefreshMessageText("ハム○プ○ラのＤＶＤ1巻を買う？");
        }
        if (rank == 11)
        {
            gameManager.RefreshMessageText("ハム○プ○ラのＤＶＤ2巻を買う？");
        }
        if (rank == 12)
        {
            gameManager.RefreshMessageText("ハム○プ○ラのＤＶＤ3巻を買う？");
        }
        gameManager.YesNoNumber = 0;
        //rankをOmiseManagerで受け取り、ゲーマネに渡す
        gameManager.ItemRankNumber = rank;
        //お金もわたす？
        gameManager.needmoney = Shinazoroe[rank].GetComponent<OmiseButton>().Needmoney;
    }

    public void PushSasoriItem(int rank) //0はＣランク、ボタン押したらここに数字入る
    {
        FlightTimeDelete();
        if (gameManager.PCSystemON)
        {
            gameManager.RefreshMessageText("それは送れないよ");
            return;
        }
        gameManager.YesNoButtonPanel.SetActive(true);//YesNoパネル出現
        if (rank == 21)
        {
            gameManager.RefreshMessageText("ポテチ（ショートケーキ味）を買う？");
        }
        if (rank == 22)
        {
            gameManager.RefreshMessageText("自転車のチューブに見えるグミを買う？");
        }
        if (rank == 23)
        {
            gameManager.RefreshMessageText("グミに見える自転車のチューブを買う？");
        }
        gameManager.YesNoNumber = 0;
        //rankをOmiseManagerで受け取り、ゲーマネに渡す
        gameManager.ItemRankNumber = rank;
        //お金もわたす？
        gameManager.needmoney = Shinazoroe[rank].GetComponent<OmiseButton>().Needmoney;
    }
    public void PushKawausoItem(int rank) //0はＣランク、ボタン押したらここに数字入る
    {
        FlightTimeDelete();

        gameManager.YesNoButtonPanel.SetActive(true);//YesNoパネル出現
        if (rank == 13)
        {
            gameManager.RefreshMessageText("エジプトの地図を買う？");
        }
        if (rank == 14)
        {
            gameManager.RefreshMessageText("コンパスを買う？");
        }

        gameManager.YesNoNumber = 0;
        //rankをOmiseManagerで受け取り、ゲーマネに渡す
        gameManager.ItemRankNumber = rank;
        //お金もわたす？
        gameManager.needmoney = Shinazoroe[rank].GetComponent<OmiseButton>().Needmoney;
    }

    public void PushRakudaItem(int rank) //0はＣランク、ボタン押したらここに数字入る
    {
        FlightTimeDelete();
        gameManager.YesNoButtonPanel.SetActive(true);//YesNoパネル出現
        if (rank == 15)
        {
            gameManager.RefreshMessageText("「自己肯定感を上げる7000の秘訣」を買う？");
        }
        if (rank == 16)
        {
            gameManager.RefreshMessageText("「部屋を大きく見せる！プロの収納」を買う？");
        }
        if (rank == 17)
        {
            gameManager.RefreshMessageText("「スティー○・ジョ○ズ自伝」を買う？");
        }

        gameManager.YesNoNumber = 0;
        //rankをOmiseManagerで受け取り、ゲーマネに渡す
        gameManager.ItemRankNumber = rank;
        //お金もわたす？
        gameManager.needmoney = Shinazoroe[rank].GetComponent<OmiseButton>().Needmoney;
    }

    public void PushCookingItem(int rank) //0はＣランク、ボタン押したらここに数字入る
    {
        FlightTimeDelete();
        gameManager.YesNoButtonPanel.SetActive(true);//YesNoパネル出現
        if (rank == 24)
        {
            gameManager.RefreshMessageText("そら豆を買う？");
        }
        if (rank == 25)
        {
            gameManager.RefreshMessageText("じゃがいもを買う？");
        }
        if (rank == 26)
        {
            gameManager.RefreshMessageText("パン粉を買う？");
        }
        if (rank == 27)
        {
            gameManager.RefreshMessageText("たまごを買う？");
        }
        if (rank == 28)
        {
            gameManager.RefreshMessageText("玉ねぎを買う？");
        }
        if (rank == 29)
        {
            gameManager.RefreshMessageText("カレー粉を買う？");
        }

        gameManager.YesNoNumber = 0;
        //rankをOmiseManagerで受け取り、ゲーマネに渡す
        gameManager.ItemRankNumber = rank;
        //お金もわたす？
        gameManager.needmoney = Shinazoroe[rank].GetComponent<OmiseButton>().Needmoney;
    }

    public void PushKoburaItem(int rank) //0はＣランク、ボタン押したらここに数字入る
    {
        FlightTimeDelete();

        gameManager.YesNoButtonPanel.SetActive(true);//YesNoパネル出現
        if (rank == 18)
        {
            gameManager.RefreshMessageText("ハム○プ○ラブルーレイ1巻を買う？");
        }
        if (rank == 19)
        {
            gameManager.RefreshMessageText("ハム○プ○ラブルーレイ2巻を買う？");
        }
        if (rank == 20)
        {
            gameManager.RefreshMessageText("ハム○プ○ラブルーレイ3巻を買う？");
        }

        gameManager.YesNoNumber = 0;
        //rankをOmiseManagerで受け取り、ゲーマネに渡す
        gameManager.ItemRankNumber = rank;
        //お金もわたす？
        gameManager.needmoney = Shinazoroe[rank].GetComponent<OmiseButton>().Needmoney;
    }

    public void PushAmemittAtem(int rank)
    {
        FlightTimeDelete();
        gameManager.YesNoButtonPanel.SetActive(true);//YesNoパネル出現
        if (rank == 30)
        {
            gameManager.RefreshMessageText("ハツを買う？");
        }
        if (rank == 31)
        {
            gameManager.RefreshMessageText("マーマイトを買う？");
        }
        if (rank == 32)
        {
            gameManager.RefreshMessageText("うまい！タレを買う？");
        }

        gameManager.YesNoNumber = 0;
        //rankをOmiseManagerで受け取り、ゲーマネに渡す
        gameManager.ItemRankNumber = rank;
        //お金もわたす？
        gameManager.needmoney = Shinazoroe[rank].GetComponent<OmiseButton>().Needmoney;

    }
    public void PushFrightChicketItem(int rank)
    {
        FlightTimeDelete();
        gameManager.YesNoButtonPanel.SetActive(true);//YesNoパネル出現
        if (rank == 33)
        {
            gameManager.RefreshMessageText("ロンドン行きチケットを買う？");
        }

        gameManager.YesNoNumber = 0;
        //rankをOmiseManagerで受け取り、ゲーマネに渡す
        gameManager.ItemRankNumber = rank;
        //お金もわたす？
        gameManager.needmoney = Shinazoroe[rank].GetComponent<OmiseButton>().Needmoney;

    }

    public void PushAirportItem(int rank)
    {
            gameManager.YesNoNumber = 42;
            gameManager.YesNoButtonPanel.SetActive(true);
            if (rank == 34)
            {
                gameManager.RefreshMessageText("楽器ケースを送る？");
            }

            gameManager.YesNoButtonPanel.SetActive(true);
            if (rank == 35)
            {
                gameManager.RefreshMessageText("忍者なりきりセットを送る？");
            }

            if(rank == 36) //まきもの
            {
                gameManager.RefreshMessageText("魔法のスクロール（かな？）を送る？");
            }

        if(rank == 37)//中華製まきもの
        {
            gameManager.RefreshMessageText("魔法のスクロール（かも）を送る？");

        }
        if (rank == 38)//ユユギ
        {
            gameManager.RefreshMessageText("ユユギ王カードを送る？");

        }
        if (rank == 39)//サッカーボール
        {
            gameManager.RefreshMessageText("サッカーボールを送る？");

        }
        if (rank == 40)//トトモンボール
        {
            gameManager.RefreshMessageText("パチモンボールを送る？");

        }

        //rankをOmiseManagerで受け取り、ゲーマネに渡す
        gameManager.ItemRankNumber = rank;
            //お金もわたす
            gameManager.needmoney = Shinazoroe[rank].GetComponent<OmiseButton>().Needmoney;
        
        
    }

    public void ItemInventryPlus(int ItemNum)//アイテムインベントリに追加用。
    {
        Shinazoroe[ItemNum].GetComponent<OmiseButton>().Pickup();

    }

    public void ItemInventryPlusTotteoki()//アイテムインベントリに追加用。
    {
        //テキスト欄にとっておきの本のボタン表示。クリックしたらインベントリ。
        gameManager.TotteokiButton.GetComponent<OmiseButton>().Pickup();
        gameManager.HaveTotteoki = true;
        gameManager.TotteokiButton.SetActive(false);
        gameManager.RefreshMessageText("とっておきの本をもらった。");
        gameManager.KaenaiPanel.SetActive(false);
        gameManager.DoSave();
    }

    public void HigePlus()
    {
        gameManager.Hige.GetComponent<OmiseButton>().Pickup();
        gameManager.HaveHige = true;
        gameManager.Hige.SetActive(false);
        gameManager.RefreshMessageText("スフィンクスのひげをもらった！");
        gameManager.DoSave();
    }

    //頼み事発生時に、アイテムが表示されるように
    public void ButtonNezumiImageAppear()
    {
        for (int i = 0; i <= 2; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();
            b.interactable = true;
            Color c = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            b.image.color = c;

            ShohinGazou[i].SetActive(true);
        }
    }

    public void ButtonSukarabeImageAppear()
    {
        for (int i = 0; i <= 2; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();
            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            b.image.color = c;

            ShohinGazou[i].SetActive(true);
        }
        for (int i = 3; i <= 4; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();
            b.interactable = true;
            ShohinGazou[i].SetActive(true);
        }
    }
    public void ButtonCatImageAppear()
    {
        for (int i = 0; i <= 4; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;


        }
        for (int i = 5; i <= 6; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();
            b.interactable = true;
            ShohinGazou[i].SetActive(true);
        }
    }

    public void ButtonUsagiImageAppear()
    {
        for (int i = 0; i <= 6; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
        for (int i = 7; i <= 9; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();
            b.interactable = true;
            ShohinGazou[i].SetActive(true);
            Color c = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            b.image.color = c;
        }
    }

    public void ButtonSnakeImageAppear()
    {
        for (int i = 0; i <= 9; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
        for (int i = 10; i <= 12; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();
            b.interactable = true;
            Color c = new Color(1f, 1f, 1f, 1f);
            b.image.color = c;

            ShohinGazou[i].SetActive(true);
        }


    }
    public void ButtonSasoriImageAppear()
    {
        for (int i = 0; i <= 12; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
        for (int i = 21; i <= 23; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();
            b.interactable = true;
            ShohinGazou[i].SetActive(true);
        }
    }
    public void ButtonKawausoImageAppear()
    {
        for (int i = 0; i <= 12; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
        for (int i = 21; i <= 23; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
        for (int i = 13; i <= 14; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();
            b.interactable = true;
            Color c = new Color(1f, 1f, 1f, 1f);
            b.image.color = c;
            ShohinGazou[i].SetActive(true);
        }
    }
    public void ButtonRakudaImageAppear()
    {
        for (int i = 0; i <= 14; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
        for (int i = 21; i <= 23; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
        for (int i = 15; i <= 17; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();
            b.interactable = true;
            ShohinGazou[i].SetActive(true);
        }
    }
    public void ButtonCookingImageAppear()
    {
        for (int i = 0; i <= 17; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
        for (int i = 21; i <= 23; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
        for (int i = 24; i <= 29; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();
            b.interactable = true;
            ShohinGazou[i].SetActive(true);
        }
    }
    public void ButtonKoburaImageAppear()
    {
        for (int i = 0; i <= 17; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
        for (int i = 21; i <= 29; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
        for (int i = 18; i <= 20; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();
            b.interactable = true;
            ShohinGazou[i].SetActive(true);
        }
    }
    public void ButtonAmemittImageAppear()
    {
        for (int i = 0; i <= 29; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
        for (int i = 30; i <= 32; i++)
        {
            Hatenas[i].SetActive(false);

            Button b = Shinazoroe[i].GetComponent<Button>();
            b.interactable = true;
            ShohinGazou[i].SetActive(true);
        }
    }
    public void ButttonflightchicketImageAppear()
    {
        //まず航空券以外を非アクティブ //ボタンと一緒に画像色変え方法調べる
        for (int i = 0; i <= 32; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
        Hatenas[33].SetActive(false);
        Shinazoroe[33].GetComponent<Button>().interactable = true;
        ShohinGazou[33].SetActive(true);
    }

    public void ALlImageDissapear()
    {
        //航空券まですべて非アクティ
        for (int i = 0; i <= 33; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
    }
    public void AllTravelImageDissapear()
    {
        for (int i = 34; i <= 35; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
    }

    public void AllTravelImageAppear()//楽器と忍者けす
    {
        for (int i = 34; i <= 35; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = true;
            Color c = new Color(1f, 1f, 1f, 1f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
    }
    public void MakimonoToEjimonImageAppear()
    {
       
        for (int i = 36; i <= 40; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = true;
            Color c = new Color(1f, 1f, 1f, 1f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
    }

    public void MakimonoToEjimonImageDISAppear()
    {
        for (int i = 36; i <= 40; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
    }


    public void FlightTimeDelete()
    {
        if(gameManager.messagesNumber == 22)
        {
            gameManager.RefreshMessageText2("");
        }
    }

    public void ButtonHeathlowAirportAppear()
    {
        for (int i = 0; i <= 33; i++)
        {
            Hatenas[i].SetActive(false);
            Button b = Shinazoroe[i].GetComponent<Button>();

            b.interactable = false;
            Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            ShohinGazou[i].SetActive(true);
            b.image.color = c;

        }
        for (int i = 34; i <= 35; i++)//忍者なりきりセット楽器ケース
        {
            Hatenas[i].SetActive(false);
            Shinazoroe[i].GetComponent<Button>().interactable = true;
            ShohinGazou[i].SetActive(true);

        }
    }

   

}
