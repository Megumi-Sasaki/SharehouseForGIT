using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class TextMessageViwer : MonoBehaviour
{
    //public static SaveDate SaveDate;

    /// <summary>
    /// 実装手順
    /// １．まず一気にテキストが表示されるようにする。クリックしたら次のテキストを一気に
    /// ２．次にDOTweenで文字を一個ずつ表示させる（文字送り）
    /// ３．次にクリックしたら文字送り中でも、一気に表示できるようにする
    /// </summary>

    public GameManager gameManager;
    public OmiseManager omiseManager;

    public string[] BoxMessages;  //ただの箱

    public string[] messages;//表示するメッセージの入った箱配列。これにセリフ入れて

    public string[] randomMessages; //いらっしゃいなど
    public string[] welcomeMessages;
    public string[] TouchMessages;
    public string[] TouchMessages1;
    public string[] TouchMessages2;
    public string[] TouchMessages3;
    public string[] TouchMessages4;
    public string[] TouchMessages5;
    public string[] TouchMessages6;
    public string[] TouchMessages7;
    public string[] TouchMessages8;
    public string[] TouchMessages9;
    public string[] TouchMessages10;

    public string[] nezumiMessages; //ねずみメッセージ
    public string[] sukarabeMessages;
    public string[] catMessages;
    public string[] UsagiMessages;
    public string[] SnakeMessages;
    public string[] SasoriMessages;
    public string[] KawausoMessages;
    public string[] RakudaMessages;
    public string[] KoburaMessages;
    public string[] AmemittMessages;
    public string[] RakudaMessages2;//料理作ってと話す
    public string[] TameiyaMessages;
    public string[] CurryMessages;
    public string[] PotatoCrocketMessages;
    public string[] TubeCurryMessages;
    public string[] HaveTotteokiBook;
    public string[] LastBossMessages;//航空券前
    public string[] FlightchicketMessages;//航空券出現
    public string[] GiveorNotChicket;
    public string[] ThanksChicket;//航空券あげた後21
    public string[] TotoridingPlane;
    public string[] TotoArriveEnter;//入国審査
    public string[] GoneMessage;//24
    public string[] NinjaMessage;//25
    public string[] NinjaMissMessage;//26
    public string[] UmakuNyukokuMessage;//27
    public string[] KeibiMessages;//28
    public string[] MakimonoMessages;//29
    public string[] MakimonoChinaMessages;//30
    public string[] YuyugioMessages;//31
    public string[] SoccerMessages;//32
    public string[] TotomonMessages;//33
    public string[] MakimonoChinaMessages2;//34
    public string[] YuyugioMessages2;//35
    public string[] SoccerMessages2;//36
    public string[] TotomonMessages2;//37
    public string[] VictoryKeibin;//38
    public string[] TotoBackMessages;//39
    public string[] TotoBackMessagesNext;//42
    public string[] TotoLastMessages;//40
    public string[] TotoBeforeLastMessages;//41

    public Text txtMessage;//メッセージ表示用

    public float wordSpeed;         // 1文字あたりの表示速度

    public int messagesIndex = 0;  //表示するメッセージの入った箱配列番号
    public int wordCount;          //１メッセージあたりの文字の総数
    private bool isTapped = false;//全文表示後にタップを待つフラグ
    public bool isDisplayedAllMessage = false;//全メッセージ表示完了のフラグ

    private IEnumerator waitCoroutine;  //全文表示までの待機時間メソッド代入用。
    private Tween tween;               // DOTween再生用

    public GameObject totoTextBox;

    public Image ClickIcon;

    private float elapsedTime;
    public float ClickFlashTime = 10f;

    public bool OnemessageComp;

    public GameObject TotoAirPlane;
    public GameObject TotoAirport;
    public GameObject TotoMuseum;

    public GameObject HigeInMuseum;
    public GameObject Shinazoroe;

    public GameObject TOTO;
    

    public void EnterOmise() //お店に入ったとき
    {
        messagesIndex = 0;
        wordCount = 0;
        isDisplayedAllMessage = false;
        if(gameManager.messagesNumber == 0)//自己紹介のときは戻るボタンを消す
        {
            gameManager.ModoruPanelOmise.SetActive(false);
        }
        if(gameManager.messagesNumber == 1 && gameManager.NezumiHakken)
        {
            gameManager.messagesNumber = 2;
            omiseManager.ButtonNezumiImageAppear();
        }
        if (gameManager.VictoryNezumi)
        {
            AvoidMessageNumber1();
          
        }
        if (gameManager.SukarabeHakken)
        {
            gameManager.messagesNumber = 3;
        }
        if(gameManager.Victorysukarabe)
        {
            AvoidMessageNumber1();

        }
        if(gameManager.CatHakken)
        {
            gameManager.messagesNumber = 4;
        }
        if(gameManager.Victorycat)
        {
            AvoidMessageNumber1();
        }

        if(gameManager.UsagiHakken && !gameManager.TotoGoToTravel)
        {
            gameManager.messagesNumber = 5;
        }
        if(gameManager.Victoryusagi)
        {
            AvoidMessageNumber1();
        }

        if(gameManager.SnakeHakken && !gameManager.TotoGoToTravel)
        {
            gameManager.messagesNumber = 6;
        }
        if(gameManager.Victorysnake)
        {
            AvoidMessageNumber1();
        }

        if(gameManager.SasoriHakken)
        {
            gameManager.messagesNumber = 7;
        }
        if (gameManager.Victorysasori)
        {
            AvoidMessageNumber1();
        }

        if (gameManager.KawausoHakken && !gameManager.TotoGoToTravel)
        {
            gameManager.messagesNumber = 8;
        }
        if (gameManager.Victorykawauso)
        {
            AvoidMessageNumber1();
        }

        if (gameManager.RakudaHakken && !gameManager.AppeardTotteoki)
        {
            gameManager.messagesNumber = 9;
        }
        //ラクダの本全部渡したら
        if(gameManager.HaveRakudaA && gameManager.HaveRakudaB && gameManager.HaveRakudaC)//本を全部使った
        {
            gameManager.messagesNumber = 12;
            gameManager.CookingButtonAppear();

        }
        //ターメイヤもってたら正解！！！
        if(gameManager.HaveTameiya)
        {
            gameManager.KaenaiPanel.SetActive(true);
            gameManager.messagesNumber = 13;
            gameManager.CookButton.SetActive(false);
            gameManager.HaveRakudaA = false;
            gameManager.HaveRakudaB = false;
            gameManager.HaveRakudaC = false;
        }
        //カレー
        if (gameManager.HaveCurry)
        {
            gameManager.messagesNumber = 14;
        }
        //コロッケ
        if (gameManager.HavePotatoCrocket)
        {
            gameManager.messagesNumber = 15;
        }
        //タイヤカレー
        if (gameManager.HaveTubeCurry)
        {
            gameManager.messagesNumber = 16;
        }
        //とっておきの本をもらったあと
        if(gameManager.HaveTotteoki)
        {
            gameManager.messagesNumber = 17;
        }
        if(gameManager.Victoryrakuda)
        {
            AvoidMessageNumber1();
        }

        if (gameManager.KoburaHakken)
        {
            gameManager.messagesNumber = 10;
        }
        if (gameManager.Victorykobura)
        {
            AvoidMessageNumber1();
        }

        if (gameManager.AmemittHekken)
        {
            gameManager.messagesNumber = 11;
            gameManager.CookButton.SetActive(true);
        }
        if (gameManager.Victoryamemitt)
        {
            AvoidMessageNumber1();

            gameManager.CookButton.SetActive(false);
            //アイテムグレーアウト
            for (int i = 0; i <= 32; i++)
            {
                omiseManager.Hatenas[i].SetActive(false);
                Button b = omiseManager.Shinazoroe[i].GetComponent<Button>();

                b.interactable = false;
                Color c = new Color(0.5f, 0.5f, 0.5f, 0.5f);
                omiseManager.ShohinGazou[i].SetActive(true);
                b.image.color = c;

            }
        }
        if (gameManager.LastBossHakken && !gameManager.TotoGoToTravel && gameManager.messagesNumber != 21) //スフィンクス発見後
        {
            if (gameManager.messagesNumber <= 18)
            {
                gameManager.messagesNumber = 18;
               
            }
            if(gameManager.Message18to19)
            {
                gameManager.messagesNumber = 19;
            }

        }
      
            if (gameManager.HaveFrightChicket >= 1 && gameManager.messagesNumber <= 20)
        {
            gameManager.messagesNumber = 20;
            omiseManager.ButttonflightchicketImageAppear();//航空券出現
        }
        if(gameManager.TotoGoToTravel && gameManager.messagesNumber == 21)
        {   //すべてのアイテムグレーアウト
            omiseManager.ALlImageDissapear();
            gameManager.TotoPanel.SetActive(false);
            gameManager.TotoPC.SetActive(true);
            gameManager.messagesNumber = 22;
        }
        if (gameManager.messagesNumber == 22)
        {
            if (gameManager.FlightTimeMinitues == 0 && !gameManager.Timereset)
            {
                gameManager.FlightTimeMinitues = 4;
                gameManager.FlightTimeSeconds = 59;
                gameManager.Timereset = true;
                gameManager.DoSave();
            }
        }
            if (gameManager.FlightTimeMinitues < 0)//到着
        {
            
            gameManager.messagesNumber = 23;
            gameManager.RefreshMessageText2("");
        }
        if(gameManager.messagesNumber == 23)
        {
            omiseManager.ButtonHeathlowAirportAppear();
            gameManager.PCSystemFirst = true;
        }
        if(gameManager.messagesNumber == 24 || gameManager.messagesNumber == 25)
        {
            if (gameManager.ItemRankNumber == 34 || gameManager.ItemRankNumber == 35)
            {
                gameManager.NezumiAppear = true;//掲示板にネズミ表示
               
            }
                omiseManager.AllTravelImageDissapear();
            omiseManager.ALlImageDissapear();
            if (gameManager.NezumiAp)//ネズミでて、掲示板見た瞬間に見つけてなくてもアイテム表示
            {              
                omiseManager.ButtonNezumiImageAppear();
                
            }
            if(gameManager.VictoryNezumi2 && gameManager.messagesNumber == 24)
                //楽器送ってネズミ倒した
            {
                
                gameManager.messagesNumber = 27; //入国うまくいったメッセ　➡音痴
                gameManager.Appear04 = true;//音痴掲示板表示
                
            }
            if(gameManager.VictoryNezumi2 && gameManager.messagesNumber == 25)
            //忍者なりきりセット送ってネズミ倒した
            {
                gameManager.VictoryNezumi2 = false; //ネズミに勝ったスイッチオフ
                gameManager.messagesNumber = 26;//失敗　➡　楽器送る➡　再びネズミ
            }
        }
        if (gameManager.messagesNumber == 27 && gameManager.UsagiAp)//入国後、掲示板みるAppear04➡　音痴現るusagiAp
        {
            omiseManager.ButtonUsagiImageAppear();//アイテム表示
            //ご本家来る
            gameManager.PicasoIn = false;
            gameManager.PicasoOut = true;
            gameManager.GohonkeIn = true;
            gameManager.HouseLevelUp();
        }

        if (gameManager.VictoryUsagi2 && gameManager.messagesNumber == 27)//2回目の音痴倒した
        {
            gameManager.messagesNumber = 28;//警備員
            omiseManager.MakimonoToEjimonImageAppear();//巻物～でる
        }
        if(gameManager.messagesNumber == 28)
        {
            omiseManager.MakimonoToEjimonImageAppear();//巻物～でる
            omiseManager.AllTravelImageDissapear();

        }
        if (gameManager.KawausoAp && gameManager.messagesNumber >= 28)
        {
            omiseManager.ButtonKawausoImageAppear();

        }

        if (gameManager.VictoryKawauso2)//２回目のカワウソ倒した
        {
            if (gameManager.messagesNumber == 29)//巻物
            {
                gameManager.messagesNumber = 38;//ガラスケース前へ!!!最後！！
                gameManager.Appear05 = true; //とりあえず、へび２回目表示
            }
            if(gameManager.messagesNumber == 30)//中華巻物
            {
                gameManager.messagesNumber = 34;
                gameManager.VictoryKawauso2 = false;
                omiseManager.MakimonoToEjimonImageAppear();
                omiseManager.AllTravelImageDissapear();
                gameManager.KawausoCount = 1;
            }
            if (gameManager.messagesNumber == 31)//ユユギ王
            {
                gameManager.messagesNumber = 35;
                gameManager.VictoryKawauso2 = false;
                omiseManager.MakimonoToEjimonImageAppear();
                omiseManager.AllTravelImageDissapear();
                gameManager.KawausoCount = 1;
            }
            if (gameManager.messagesNumber == 32)//サッカー
            {
                gameManager.messagesNumber = 36;
                gameManager.VictoryKawauso2 = false;
                omiseManager.MakimonoToEjimonImageAppear();
                omiseManager.AllTravelImageDissapear();
                gameManager.KawausoCount = 1;
            }
            if (gameManager.messagesNumber == 33)//パチモン
            {
                gameManager.messagesNumber = 37;
                gameManager.VictoryKawauso2 = false;
                omiseManager.MakimonoToEjimonImageAppear();
                omiseManager.AllTravelImageDissapear();
                gameManager.KawausoCount = 1;
            }
            if(gameManager.SnakeAp && gameManager.messagesNumber >= 38)
            {
                omiseManager.ButtonSnakeImageAppear(); //アイテム表示
            }
            if(gameManager.HaveHige && !gameManager.Victorylastboss)
            {
                gameManager.messagesNumber = 41;//いってこいよ
            }
        
            if(gameManager.Victorylastboss)//ゲーム終了
            {
                gameManager.messagesNumber = 40;
                
            }
          

        }

        //ここでBoxMessageにフラグ別に、喋らせたい配列を代入【喋り終えたときにmessagesNumberを変更
        switch (gameManager.messagesNumber)
        {
            case 0://紹介
                BoxMessages = messages;

                break;

            case 1:

                float testa = UnityEngine.Random.value;
                if (testa <= 0.5)
                {
                    BoxMessages = welcomeMessages;
                }
                else
                {
                    BoxMessages = randomMessages;
                }

                break;

            case 2: // ねずみ
                BoxMessages = nezumiMessages;
                break;

            case 3://スカラベ
                BoxMessages = sukarabeMessages;
                break;

            case 4://ネコ
                BoxMessages = catMessages;
                break;

            case 5://
                BoxMessages = UsagiMessages;
                break;

            case 6://
                BoxMessages = SnakeMessages;
                break;

            case 7://
                BoxMessages = SasoriMessages;
                break;

            case 8://
                BoxMessages = KawausoMessages;
                break;

            case 9://
                BoxMessages = RakudaMessages;
                break;

            case 10://
                BoxMessages = KoburaMessages;
                break;

            case 11://
                BoxMessages = AmemittMessages;
                break;

            case 12://料理して－
                BoxMessages = RakudaMessages2;
                gameManager.CookButton.SetActive(true);
                break;

            case 13://ターメイヤ(お店入ったらすぐ渡す感じにする。→とっておきの本
                BoxMessages = TameiyaMessages;
                break;

            case 14://カレー
                BoxMessages = CurryMessages;
                break;

            case 15://コロッケ
                BoxMessages = PotatoCrocketMessages;
                break;

            case 16://タイヤカレー
                BoxMessages = TubeCurryMessages;
                break;

            case 17: //とっておきの本をもらったあと
                BoxMessages = HaveTotteokiBook;
                break;

            case 18: //スフィンクス出現～航空券前
                BoxMessages = LastBossMessages;
                
                break;

            case 19: //航空券出現
                BoxMessages = FlightchicketMessages;
                break;

            case 20:
                BoxMessages = GiveorNotChicket;
                break;

            case 21:
                BoxMessages = ThanksChicket;
                break;

            case 22:
                BoxMessages = TotoridingPlane;
                //PC画面表示はGameManagerで。
                TotoAirPlane.SetActive(true);
                break;

            case 23:
                BoxMessages = TotoArriveEnter;
                TotoAirPlane.SetActive(false);
                TotoAirport.SetActive(true);
                break;

            case 24: //楽器
                BoxMessages = GoneMessage;

                TotoAirport.SetActive(true);
                break;

            case 25: //忍者なりきりセット
                BoxMessages = NinjaMessage;

                TotoAirport.SetActive(true);
                break;

            case 26://失敗
                BoxMessages = NinjaMissMessage;

                TotoAirport.SetActive(true);
                break;

            case 27://入国へ
                BoxMessages = UmakuNyukokuMessage;
                TotoAirport.SetActive(true);
                break;
            case 28://警備
                BoxMessages = KeibiMessages;
                TotoAirport.SetActive(false);
                TotoMuseum.SetActive(true);
                break;
            case 29://巻物正解
                BoxMessages = MakimonoMessages;
                TotoMuseum.SetActive(true);
                break;
            case 30://中華まき
                BoxMessages = MakimonoChinaMessages;
                TotoMuseum.SetActive(true);
                break;
            case 31://ユユギ王
                BoxMessages = YuyugioMessages;
                TotoMuseum.SetActive(true);
                break;
            case 32://サッカー
                BoxMessages = SoccerMessages;
                TotoMuseum.SetActive(true);
                break;
            case 33://パチモン
                BoxMessages = TotomonMessages;
                TotoMuseum.SetActive(true);
                break;
            case 34://中華まき２
                BoxMessages = MakimonoChinaMessages2;
                TotoMuseum.SetActive(true);
                break;
            case 35://ユユギ王２
                BoxMessages = YuyugioMessages2;
                TotoMuseum.SetActive(true);
                break;
            case 36://サッカー２
                BoxMessages = SoccerMessages2;
                TotoMuseum.SetActive(true);
                break;
            case 37://パチモン２
                BoxMessages = TotomonMessages2;
                TotoMuseum.SetActive(true);
                break;
            case 38://ガラスケース
                BoxMessages = VictoryKeibin;
                TotoMuseum.SetActive(true);
                if (gameManager.SnakeCount != 2)
                {
                    HigeInMuseum.SetActive(true);
                    Shinazoroe.SetActive(false);

                }
                break;
            case 39://トト、帰国
                BoxMessages = TotoBackMessages;
                HigeInMuseum.SetActive(false);
                gameManager.TotoPC.SetActive(false);
                gameManager.TotoPanel.SetActive(true);
                break;
            case 40://ラスト！！！！！！！！！！！！
                BoxMessages = TotoLastMessages;
                gameManager.TotoPC.SetActive(false);
                gameManager.TotoPanel.SetActive(true);

                break;
            case 41://早くわたしてこいよ
                BoxMessages = TotoBeforeLastMessages;
                gameManager.TotoPC.SetActive(false);
                gameManager.TotoPanel.SetActive(true);

                break;
            case 42:
                BoxMessages = TotoBackMessagesNext;
                gameManager.TotoPC.SetActive(false);
                gameManager.TotoPanel.SetActive(true);

                break;
        }
        if (gameManager.TotoTouchOn)
        {
            switch (gameManager.TOTOmessageNum)
            {
                case 43:
                    BoxMessages = TouchMessages;
                    break;
                case 44:
                    BoxMessages = TouchMessages1;
                    break;
                case 45:
                    BoxMessages = TouchMessages2;
                    break;
                case 46:
                    BoxMessages = TouchMessages3;
                    break;
                case 47:
                    BoxMessages = TouchMessages4;
                    break;
                case 48:
                    BoxMessages = TouchMessages5;
                    break;
                case 49:
                    BoxMessages = TouchMessages6;
                    break;
                case 50:
                    BoxMessages = TouchMessages7;
                    break;
                case 51:
                    BoxMessages = TouchMessages8;
                    break;
                case 52:
                    BoxMessages = TouchMessages9;
                    break;
                case 53:
                    BoxMessages = TouchMessages10;
                    break;
            }
        }
        StartCoroutine(DisplayMessage());


    }

    // Update is called once per frame
    void Update()
    {
        if(BoxMessages == null)
        {
            return;
        }
        if(isDisplayedAllMessage)//表記に問題あり、最後まで文が出ても、クリックしないとこれtrueにならない。
        {
            return;
        }
        
        if(Input.GetMouseButtonDown(0) && wordCount == BoxMessages[messagesIndex].Length)
        {
            Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            bool hit = totoTextBox.GetComponent<BoxCollider2D>().OverlapPoint(tapPoint);
            if (hit)
            {
                isTapped = true;
            }
        }

        //追加
        if(Input.GetMouseButtonDown(0) && tween != null)
        {
            Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            bool hit = totoTextBox.GetComponent<BoxCollider2D>().OverlapPoint(tapPoint);
            bool hitTOTO = TOTO.GetComponent<BoxCollider2D>().OverlapPoint(tapPoint);
            
            if (hit || hitTOTO)
            {
                //文字送り中にタップした場合、文字送り停止
                tween.Kill();
                tween = null;
                //文字送りのために待機時間も停止
                if (waitCoroutine != null)
                {
                    StopCoroutine(waitCoroutine);
                    waitCoroutine = null;
                }
                //全文をまとめて表示
                txtMessage.text = BoxMessages[messagesIndex];

                //メッセージ表示完了処理
                CompleteOneMessage();

                //タップするまで全文を表示したまま待機
                
                StartCoroutine(NextTouch());
            }
        }
        if (messagesIndex < BoxMessages.Length && wordCount == BoxMessages[messagesIndex].Length)
        {
            elapsedTime += Time.deltaTime;
            if( elapsedTime >= ClickFlashTime)
            {
                ClickIcon.enabled = !ClickIcon.enabled;
                elapsedTime = 0f;
                
            }
        }


    }

    public void EmptyTween()//セリフを空にする
    {
        tween.Kill();
        tween = null;
        txtMessage.text = null;
        BoxMessages = null;

    }
    ///<summary>
    /// メッセージ表示（一文字ずつ
    /// </summary>
    /// <returns></returns>
    private IEnumerator DisplayMessage()
    {
   
        isTapped = false;


        //表示テキストをリセット
        txtMessage.text = "";

        //Tweenをリセット
        tween = null;

        //文字送りの待機時間を初期化
        if(waitCoroutine != null)
        {
            StopCoroutine(waitCoroutine);
            waitCoroutine = null;
        }

        
        //DOTweenの前にWhile１文字ずつの文字送り表示が終了するまでループ
        while (BoxMessages[messagesIndex].Length > wordCount)
        {
            OnemessageComp = false;
            if(BoxMessages[messagesIndex] == null)
            {
                break;
            }
            //wordSpeed秒ごとに、文字を一文字ずつ表示。
            //DOTweenの処理をtween変数に代入して使用するように修正

            tween = txtMessage.DOText(BoxMessages[messagesIndex], BoxMessages[messagesIndex].Length * wordSpeed).
            SetEase(Ease.Linear).OnComplete(() =>
            {
                //OnCompleteは文字送りが終わった後に自動的に実行される
                //メッセージ表示完了処理
                CompleteOneMessage();
                OnemessageComp = true;

            });

            //文字送り表示が終了するまでの待機時間を設定してコルーチン処理による待機を実行
            waitCoroutine = WaitTime();
            yield return StartCoroutine(waitCoroutine);

        }

    }

    ///<summary>
    ///全文表示までの待機時間（文字数×１文字あたりの表示時間）
    ///タップして全文をまとめて表示した場合、この待機時間を停止
    ///</summary>
    ///<returns></returns>
    
    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(BoxMessages[messagesIndex].Length * wordSpeed);
    }

    /// <summary>
    /// 一つ分のメッセージ表示完了処理
    /// </summary>
    private void CompleteOneMessage()
    {
        //表示した文字の総数を更新（全文表示したんで全文字出したよーと代入）
        wordCount = BoxMessages[messagesIndex].Length;

    }



    /// <summary>
    /// タップするまで全文を表示したまま待機
    /// </summary>
    /// <returns></returns>
    private IEnumerator NextTouch()
    {
     
        //タップを待つ
        yield return new WaitUntil(() => isTapped);

        //次のメッセージ準備
        messagesIndex++;
        wordCount = 0;

        //リストに未表示のメッセージが残っている場合
        if(messagesIndex < BoxMessages.Length)
        {
            //次のメッセージを表示する処理をスタート
            StartCoroutine(DisplayMessage());
            OnemessageComp = false;

        }
        else
        {
            //全メッセージ表示終了
            isDisplayedAllMessage = true;
            ClickIcon.enabled = false;
            gameManager.TotoTouchOn = false;
            switch(gameManager.messagesNumber) //最後まで喋らせないとメッセナンバー変わらないので注意
         {
            case 0: //自己紹介
                    gameManager.messagesNumber = 1; //「いらっしゃい」次お店来た時に1の状態で入るので、１のメッセージが送られる
                gameManager.ModoruPanelOmise.SetActive(true);//自己紹介終了後。戻るボタン復活
            
            break;

                case 2://ねずみ
                  if(gameManager.VictoryNezumi)
                  {
                        gameManager.messagesNumber = 1; //とりあえずいらっしゃいで
                  }
                 break;

                case 3:
                  if(gameManager.Victorysukarabe)
                   {
                        gameManager.messagesNumber = 1;
                   }
                  break;

                 case 4:
                    if(gameManager.Victorycat)
                    {
                        gameManager.messagesNumber = 1;
                    }
                  break;

                case 5:
                    if (gameManager.Victoryusagi)
                    {
                        gameManager.messagesNumber = 1;
                    }
                    break;

                case 6:
                    if (gameManager.Victorysnake)
                    {
                        gameManager.messagesNumber = 1;
                    }
                    break;
                case 7:
                    if (gameManager.Victorysasori)
                    {
                        gameManager.messagesNumber = 1;
                    }
                    break;
                case 8:
                    if (gameManager.Victorykawauso)
                    {
                        gameManager.messagesNumber = 1;
                    }
                    break;
                case 12:
                    gameManager.ModoruPanelOmise.SetActive(true);
                    break;

                case 13://あたり、とっておきの本を手に入れる。（アイテム欄？）
                    //ターメイヤきる
                    gameManager.HaveTameiya = false;
                    gameManager.AppeardTotteoki = true;
                    //gameManager.RefreshMessageText("ボタンをおして受け取る↓");
                    //クレオパトラ本のボタン表示
                    gameManager.TotteokiButton.SetActive(true);
                    if (gameManager.HaveTotteoki)
                    {
                        gameManager.messagesNumber = 1;
                    }
                        break;

                case 14:
                    gameManager.HaveCurry = false;
                    gameManager.messagesNumber = 1;
                    break;
                case 15:
                    gameManager.HavePotatoCrocket = false;
                    gameManager.messagesNumber = 1;
                    break;
                case 16:
                    gameManager.HaveTubeCurry = false;
                    gameManager.messagesNumber = 1;
                    break;
                case 17:
                    if(gameManager.Victoryrakuda)
                    {
                        gameManager.messagesNumber = 1;
                    }
                    break;         
               
                case 19://航空券出現
                    omiseManager.ButttonflightchicketImageAppear();
                   break;
                case 18:
                    gameManager.Message18to19 = true;
                    break;
                   
                case 20://あげるあげない
                    gameManager.YesNoNumber = 41;
                    gameManager.RefreshMessageText("トトにチケットをあげますか？");
                    //パネル表示
                    gameManager.YesNoButtonPanel.SetActive(true);
                    break;
                case 21://GOTravel
                    gameManager.TotoGoToTravel = true;

                    break;
               
                case 24://楽器送る
                    //ねずみの出現、掲示板見てもらってから、また退治
                    //所持アイテ変数のリセット。
                    gameManager.HaveArank = 0;
                    gameManager.HaveBrank = 0;
                    gameManager.HaveCrank = 0;
                    //gameManager.NezumiAppear = true;
                    break;
                case 25: //忍者なりきりセット送る
                         //ねずみ
                         //所持アイテ変数のリセット。
                    gameManager.HaveArank = 0;
                    gameManager.HaveBrank = 0;
                    gameManager.HaveCrank = 0;

                    //gameManager.NezumiAppear = true;
                
                    break;

                case 26: //失敗
                    //再度アイテムの表示
                    omiseManager.AllTravelImageAppear();
                    break;

                case 27: //➡音痴をもう一回だす
                    if (!gameManager.UsagiAp)
                    {
                        gameManager.Appear04 = true;
                    }
                    break;
                case 42:
                    if (!gameManager.HaveHige)
                    {
                        gameManager.messagesNumber = 39;
                    }
                    break;
                case 39: //最後にひげの受け取り
                    if(!gameManager.HaveHige)
                    {
                        gameManager.Hige.SetActive(true);//でかい写真出してもいいかも
                        gameManager.messagesNumber = 42;
                        EnterOmise();
                    }
                    break;
              
                case 40://ゲーム終了.画面フェードアウトからThankyouforplaying!
                    
                    gameManager.FadeOutEnd();
                    break;

               
            }

            gameManager.DoSave();//せーぶ
        }
    }

    //メッセナンバーを1にしないためだけのメソッド
    public void AvoidMessageNumber1()
    {
        for(int i = 1; i <= 17; i++)
        {
            if(gameManager.messagesNumber == i)
            {
                Debug.Log(gameManager.messagesNumber);//19
                gameManager.messagesNumber = 1; //とりあえずいらっしゃいで
            }
        }
      
    }
   }
