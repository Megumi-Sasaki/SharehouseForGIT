using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    static SaveDate SaveDatedayo = new SaveDate(); //保存場所

    public List<KujyoItemScriptable> items = new List<KujyoItemScriptable>();

    public int ItemRankNumber;
    public float HaveArank;
    public float HaveBrank;
    public float HaveCrank;
    public bool HaveRakudaA;
    public bool HaveRakudaB;
    public bool HaveRakudaC;
    public int HaveAArank;
    public int HaveBBrank;
    public int HaveCCrank;
    public int HaveHatu;
    public int HaveMermait;
    public int HaveUmaiTare;
    public int HaveFrightChicket;

    public int HaveDrank;
    public int HaveErank;
    public int HaveFrank;
    public int HavePotechi;
    public int Havelicorice;
    public int HaveTube;
    public bool HaveTameiya;
    public bool HaveCurry;
    public bool HavePotatoCrocket;
    public bool HaveTubeCurry;
    public bool HaveTotteoki;
    public bool HaveMermiteHatu;
    public bool HaveTareHatu;
    public bool HaveInstrumental;
    public bool HaveNinjaSet;
    public bool HaveChinaScroll;
    public bool HaveSukarabeScroll;
    public bool HaveYUYUgiohCard;
    public bool HaveEjimonbawl;

    public bool VictoryNezumi;
    public bool Victorysukarabe;
    public bool Victorycat;
    public bool Victoryusagi;
    public bool Victorysnake;
    public bool Victorysasori;
    public bool Victorykawauso;
    public bool Victoryrakuda;
    public bool Victorykobura;
    public bool Victoryamemitt;
    public bool VictoryNezumi2;
    public bool VictoryUsagi2;
    public bool VictoryKawauso2;
    public bool Victorysnake2;

    public bool TotoGoToTravel;
    public bool Victorylastboss;

    public int needmoney; 


    public bool NezumiAppear;
    public bool Appear02;
    public bool Appear03;
    public bool Appear04;
    public bool Appear05;
    public bool Appear06;
    public bool Appear07;
    public bool Appear08;
    public bool Appear09;
    public bool Appear10;
    public bool Appear11;

    public bool NezumiHakken;
    public bool SukarabeHakken;
    public bool CatHakken;
    public bool UsagiHakken;
    public bool SnakeHakken;
    public bool SasoriHakken;
    public bool KawausoHakken;
    public bool RakudaHakken;
    public bool KoburaHakken;
    public bool AmemittHekken;
    public bool LastBossHakken;

    public int messagesNumber = 0;
    public int TOTOmessageNum = 0;

    public bool SalarymanIn;
    public bool SantaIn;
    public bool IrasutoyaIn;
    public bool HalloweenIn;
    public bool DotIn;
    public bool NagasugitaIn;
    public bool NanikaAttaIn;
    public bool PicasoIn;
    public bool YusyaIn;
    public bool KureoPatoraIn;
    public bool GohonkeIn;

    public bool MejedoOut;
    public bool YouTuberOut;
    public bool SalarymanOut;
    public bool SantaOut;
    public bool IrasutoyaOut;
    public bool HalloweenOut;
    public bool DotOut;
    public bool NagasugitaOut;
    public bool NanikaAttaOut;
    public bool PicasoOut;

    //いらいらぶっぴんのコルーチンをとめる
    public bool zero;
    public bool one;
    public bool two;
    public bool three;
    public bool four;
    public bool five;
    public bool six;
    public bool seven;
    public bool eight;
    public bool nine;
    public bool ten;
    public bool eleven;
    public bool twelve;

    public bool NezumiAp;
    public bool SukarabeAp;
    public bool CatAp;
    public bool UsagiAp;
    public bool SnakeAp;
    public bool SasoriAp;
    public bool KawausoAp;
    public bool RakudaAp;
    public bool KoburaAp;
    public bool AmemitAp;
    public bool LastBossAp;

    public int money;          //所持金
    public int moneyPlus;
    public float HouseLevel;    //家レベ
    

    public const int WALL_GENKAN = 1;
    public const int WALL_KITCHEN = 2;
    public const int WALL_MYROOM = 3;
    public const int WALL_DINING = 4;
    public const int WALL_LIVING = 5;
    public const int WALL_MACHI = 6;  
    public const int WALL_OMISE = 7;
    public const int WALL_CONVINI = 8;
    public const int WALL_DISCO = 9;
    public const int WALL_BATTLE = 10;
    public const int WALL_JYUNINROOM = 11;

    public GameObject panelWalls;

    public GameObject MovePanel;   //パネル関係
    public GameObject MenuPanel;
    public GameObject ModoruButton; //今のメニュー右上に
    public GameObject KeijiModoruButton;//掲示板から戻るボタン
    public GameObject ModoruPanelOmise;//お店から戻るボタンついたパネル

    public GameObject Keijiban;

    public GameObject KujyoPanel;    
    
    public GameObject KujyoName;
    public Transform KujyoImage;
    public GameObject[] ItemSlot;
    public GameObject Wanapanel;
    public Text MonterEx;

    public MonsterList monsterList;

    public Text CookingText;
    public GameObject TotteokiButton;

    public GameObject MonsterManager;
    //下はモンスターの箱なんで、モンスターについた数値を使いたいとき使って（出現したとき、MonsterManaからGetしてる）
    private GameObject Nezumi;
    private GameObject Sukarabe;
    private GameObject Cat;
    private GameObject Usagi;
    private GameObject Snake;
    private GameObject Sasori;
    private GameObject Kawauso;
    private GameObject Rakuda;
    private GameObject Kobura;
    private GameObject Amemitt;
    private GameObject LastBoss;

    public GameObject LastBossHIGE;
   
    
    public GameObject CookButton;

    public GameObject MessagePanel;
    //住人の写真、掲示板関係
    public GameObject[] JyuninPola;
    public GameObject PanelStatus;
    public GameObject StatusImagePanel;
    public GameObject PolaroidPanel;
    public int polaNumberGameM;

    public Text Komarigoto;
    

    public GameObject NameText;
    public GameObject Explanation;

    
    public bool Pola;


    public int wallNo;

    public bool HaveBomb;
    public bool Shiraberu;

    //public GameObject bakudanshojiNumber;//画面上のステータス
    public GameObject moneyshojiNumber;
    public GameObject FukkatsuSpeedText;
    public GameObject plusMoneyObj;
    public Text plusMoneyText;

    public GameObject messageText0;//画面下のメッセージ出るとこの行
    public GameObject messageText1;
    public GameObject messageText2;

    public GameObject MenuButton;//メニューボタン
    public GameObject YesNoButtonPanel;  //はい・いいえボタン


    public int YesNoNumber;

   
    public JyuninButton jyuninButton;
    //お店関係
    public OmiseManager omiseManager;
    public TextMessageViwer textMessageViwer;

    public GameObject TotoPanel;
    public GameObject TotoPC;
   
    //お店のスクロール
    public GameObject scrollRect;
    public GameObject scrollRectPCSouko;

    //住人のお部屋
    public GameObject[] jyuninRoom = new GameObject [3];
    

    public int MessageButton;


    //住人設定について
    public GameObject[] JyuninWeek1;   //住人達。

    public int scpObjNum;


    //いらいら物品
    public GameObject[] IrairaBuppin;

    public GameObject StartExplanation;

    //フライトタイム　ここはまずいかも
   // public int FlightTimeHour;
    public int FlightTimeMinitues;
    public double FlightTimeSeconds;
    //PC
    public bool PCSystemFirst;
    public bool PCSystemON; //パソコンをクリックしたか

    public bool HaveHige;

    public GameObject Hige;

    public int OshiraseMejedo;
    public int OshiraseYoutuber;
    public int OshiraseSaraly;
    public int OshiraseSanta;
    public int OshiraseIrasutoya;
    public int OshiraseHalloween;
    public int OshiraseDotPola;
    public int OshiraseNagasugi;
    public int OshiraseNanka;
    public int OshirasePica;
    public int OshiraseYusya;
    public int OshiraseKureo;
    public int OshiraseGohonke;

    public int NezumiCount;
    public int SukarabeCount;
    public int CatCount;
    public int UsagiCount;
    public int SnakeCount;
    public int SasoriCount;
    public int KawausoCount;
    public int RakudaCount;
    public int KoburaCount;
    public int AmemittCount;
    public int LastBossCount;

    public List<GameObject> Iraira = new List<GameObject>();
    public List<GameObject> WaitingIraira = new List<GameObject>();
  

    public float FukkatsuSpeed;
    public float testtime;
    public bool PushStart = false;

    public GameObject StartText0;
    public GameObject StartText1;
    public GameObject StartText2;
    int startbutton = 0;

    public Image EndingWhitePanel;
    public GameObject EndingThankyouPanel;
    public bool Isfadeout;
    public float alpha;
    float fadespeed = 0.0090f;
    string Twitterlink = "https://twitter.com/Jean_history";
    string MusicLink = "https://www.zapsplat.com";

    public AudioSource WindSound;
    public AudioSource DoraSound;
    public AudioSource CookaudioSource;
    public AudioSource BuyItemSound;

    public bool MoneyTextFadestart;
    public float a_color;

    public GoogleAds googleAds;

    public GameObject SoundButton;

    public bool TotoTouchOn;
    public int CountTotoTouch;

    public GameObject KaenaiPanel;
    public GameObject Totobrockpanel;

    public bool AppeardTotteoki;
    public GameObject END;

    public bool Message18to19;
    public DateTime startTime;
    public double Pasttime;

    public bool Timereset;


    public void Awake()
    {
        DoLoad();
        
        Iraira = new List<GameObject>();
        WaitingIraira = new List<GameObject>();
        if (SaveDatedayo.items == null)
        {
            items = new List<KujyoItemScriptable>();
        }
        else
        {
            items = SaveDatedayo.items; //アイテムリスト
        }

        startTime = SaveDatedayo.starttime;

        money = SaveDatedayo.money;      
        moneyPlus = SaveDatedayo.moneyPlus;
        HouseLevel = SaveDatedayo.HouseLevel;    //家レベ
        ItemRankNumber = SaveDatedayo.ItemRankNumber;
        HaveArank = SaveDatedayo.HaveArank;
        HaveBrank = SaveDatedayo.HaveBrank;
        HaveCrank = SaveDatedayo.HaveCrank;
        HaveRakudaA = SaveDatedayo.HaveRakudaA;
        HaveRakudaB = SaveDatedayo.HaveRakudaB;
        HaveRakudaC = SaveDatedayo.HaveRakudaC;
        HaveAArank = SaveDatedayo.HaveAArank;
        HaveBBrank = SaveDatedayo.HaveBBrank;
        HaveCCrank = SaveDatedayo.HaveCCrank;
        HaveHatu = SaveDatedayo.HaveHatu;
        HaveMermait = SaveDatedayo.HaveMermait;
        HaveUmaiTare = SaveDatedayo.HaveUmaiTare;

        HaveDrank = SaveDatedayo.HaveDrank;
        HaveErank = SaveDatedayo.HaveErank;
        HaveFrank = SaveDatedayo.HaveFrank;
        HavePotechi = SaveDatedayo.HavePotechi;
        Havelicorice = SaveDatedayo.Havelicorice;
        HaveTube = SaveDatedayo.HaveTube;
        HaveTameiya = SaveDatedayo.HaveTameiya;
        HaveCurry = SaveDatedayo.HaveCurry;
        HavePotatoCrocket = SaveDatedayo.HavePotatoCrocket;
        HaveTubeCurry = SaveDatedayo.HaveTubeCurry;
        HaveTotteoki = SaveDatedayo.HaveTotteoki;
        HaveMermiteHatu = SaveDatedayo.HaveMermiteHatu;
        HaveTareHatu = SaveDatedayo.HaveTareHatu;
        HaveFrightChicket = SaveDatedayo.HaveFrightChicket;
         HaveInstrumental = SaveDatedayo.HaveInstrumental;
         HaveNinjaSet = SaveDatedayo.HaveNinjaSet;
         HaveChinaScroll = SaveDatedayo.HaveChinaScroll;
         HaveSukarabeScroll = SaveDatedayo.HaveSukarabeScroll;
         HaveYUYUgiohCard = SaveDatedayo.HaveYUYUgiohCard;
         HaveEjimonbawl = SaveDatedayo.HaveEjimonbawl;

        VictoryNezumi = SaveDatedayo.VictoryNezumi;
        Victorysukarabe = SaveDatedayo.Victorysukarabe;
        Victorycat = SaveDatedayo.Victorycat;
        Victoryusagi = SaveDatedayo.Victoryusagi;
        Victorysnake = SaveDatedayo.Victorysnake;
        Victorysasori = SaveDatedayo.Victorysasori;
        Victorykawauso = SaveDatedayo.Victorykawauso;
        Victoryrakuda = SaveDatedayo.Victoryrakuda;
        Victorykobura = SaveDatedayo.Victorykobura;
        Victoryamemitt = SaveDatedayo.Victoryamemitt;

        TotoGoToTravel = SaveDatedayo.TotoGoToTravel;
        Victorylastboss = SaveDatedayo.Victorylastboss;

        needmoney = SaveDatedayo.needmoney; //OmiseManagerから代入される

        NezumiAppear = SaveDatedayo.NezumiAppear;
        Appear02 = SaveDatedayo.Appear02;
        Appear03 = SaveDatedayo.Appear03;
        Appear04 = SaveDatedayo.Appear04;
        Appear05 = SaveDatedayo.Appear05;
        Appear06 = SaveDatedayo.Appear06;
        Appear07 = SaveDatedayo.Appear07;
        Appear08 = SaveDatedayo.Appear08;
        Appear09 = SaveDatedayo.Appear09;
        Appear10 = SaveDatedayo.Appear10;
        Appear11 = SaveDatedayo.Appear11;

        NezumiHakken = SaveDatedayo.NezumiHakken; //ねずみをクリックしたとき。倒したらオフ
        SukarabeHakken = SaveDatedayo.SukarabeHakken;
        CatHakken = SaveDatedayo.CatHakken;
        UsagiHakken = SaveDatedayo.UsagiHakken;
        SnakeHakken = SaveDatedayo.SnakeHakken;
        SasoriHakken = SaveDatedayo.SasoriHakken;
        KawausoHakken = SaveDatedayo.KawausoHakken;
        RakudaHakken = SaveDatedayo.RakudaHakken;
        KoburaHakken = SaveDatedayo.KoburaHakken;
        AmemittHekken = SaveDatedayo.AmemittHekken;
        LastBossHakken = SaveDatedayo.LastBossHakken;

        messagesNumber = SaveDatedayo.messagesNumber;

        SalarymanIn = SaveDatedayo.SalarymanIn;
        SantaIn = SaveDatedayo.SantaIn;
        IrasutoyaIn = SaveDatedayo.IrasutoyaIn;
        HalloweenIn = SaveDatedayo.HalloweenIn;
        DotIn = SaveDatedayo.DotIn;
        NagasugitaIn = SaveDatedayo.NagasugitaIn;
        NanikaAttaIn = SaveDatedayo.NanikaAttaIn;
        PicasoIn = SaveDatedayo.PicasoIn;
        YusyaIn = SaveDatedayo.YusyaIn;
        KureoPatoraIn = SaveDatedayo.KureoPatoraIn;
        GohonkeIn = SaveDatedayo.GohonkeIn;

        MejedoOut = SaveDatedayo.MejedoOut;
        YouTuberOut = SaveDatedayo.YouTuberOut;
        SalarymanOut = SaveDatedayo.SalarymanOut;
        SantaOut = SaveDatedayo.SantaOut;
        IrasutoyaOut =  SaveDatedayo.IrasutoyaOut;
        HalloweenOut = SaveDatedayo.HalloweenOut;
        DotOut = SaveDatedayo.DotOut;
        NagasugitaOut = SaveDatedayo.NagasugitaOut;
        NanikaAttaOut = SaveDatedayo.NanikaAttaOut;
        PicasoOut = SaveDatedayo.PicasoOut;


        NezumiAp = SaveDatedayo.NezumiAp;
        SukarabeAp = SaveDatedayo.SukarabeAp;
        CatAp = SaveDatedayo.CatAp;
        UsagiAp = SaveDatedayo.UsagiAp;
        SnakeAp = SaveDatedayo.SnakeAp;
        SasoriAp = SaveDatedayo.SasoriAp;
        KawausoAp = SaveDatedayo.KawausoAp;
        RakudaAp = SaveDatedayo.RakudaAp;
        KoburaAp = SaveDatedayo.KoburaAp;
        AmemitAp = SaveDatedayo.AmemitAp;
        LastBossAp = SaveDatedayo.LastBossAp;

        CookingText.text = SaveDatedayo.Cook;

        FlightTimeMinitues = SaveDatedayo.FlightTimeMinitues;
        FlightTimeSeconds = SaveDatedayo.FlightTimeSeconds;

        PCSystemFirst = SaveDatedayo.PCSystemFirst;

        VictoryNezumi2 = SaveDatedayo.VictoryNezumi2;
        VictoryUsagi2 = SaveDatedayo.VictoryUsagi2;
        VictoryKawauso2 = SaveDatedayo.VictoryKawauso2;
        Victorysnake2 = SaveDatedayo.Victorysnake2;

        HaveHige = SaveDatedayo.HaveHige;

        OshiraseMejedo = SaveDatedayo.OshiraseMejedo;
        OshiraseYoutuber = SaveDatedayo.OshiraseYoutuber;
        OshiraseSaraly = SaveDatedayo.OshiraseSaraly;
        OshiraseSanta = SaveDatedayo.OshiraseSanta;
        OshiraseIrasutoya = SaveDatedayo.OshiraseIrasutoya;
        OshiraseHalloween = SaveDatedayo.OshiraseHalloween;
        OshiraseDotPola = SaveDatedayo.OshiraseDotPola;
        OshiraseNagasugi = SaveDatedayo.OshiraseNagasugi;
         OshiraseNanka = SaveDatedayo.OshiraseNanka;
         OshirasePica = SaveDatedayo.OshirasePica;
         OshiraseYusya = SaveDatedayo.OshiraseYusya;
         OshiraseKureo = SaveDatedayo.OshiraseKureo;
         OshiraseGohonke = SaveDatedayo.OshiraseGohonke;

         NezumiCount = SaveDatedayo.NezumiCount;
         SukarabeCount = SaveDatedayo.SukarabeCount;
         CatCount = SaveDatedayo.CatCount;
         UsagiCount = SaveDatedayo.UsagiCount;
         SnakeCount = SaveDatedayo.SnakeCount;
         SasoriCount = SaveDatedayo.SasoriCount;
         KawausoCount = SaveDatedayo.KawausoCount;
         RakudaCount = SaveDatedayo.RakudaCount;
         KoburaCount = SaveDatedayo.KoburaCount;
         AmemittCount = SaveDatedayo.AmemittCount;
         LastBossCount = SaveDatedayo.LastBossCount;

        AppeardTotteoki = SaveDatedayo.AppearedTotteoki;

        Message18to19 = SaveDatedayo.Message18to19;
        Timereset = SaveDatedayo.Timereset;

       
}


    void Start()
    {
       
        a_color = 1;

        Nezumi = monsterList.Monster[0];
        Sukarabe = monsterList.Monster[1];
        Cat = monsterList.Monster[2];
        Usagi = monsterList.Monster[3];
        Snake = monsterList.Monster[4];
        Sasori = monsterList.Monster[5];
        Kawauso = monsterList.Monster[6];
        Rakuda = monsterList.Monster[7];
        Kobura = monsterList.Monster[8];
        Amemitt = monsterList.Monster[9];
        LastBoss = monsterList.Monster[10];

        wallNo = WALL_GENKAN;

   

        MovePanel.SetActive(false);

        ModoruPanelOmise.SetActive(false);

        YesNoButtonPanel.SetActive(false);

        MenuButton.SetActive(true);

        KujyoPanel.SetActive(false);

        Keijiban.SetActive(true);

        HaveBomb = false;
        Shiraberu = false;

        PolaroidPanel.SetActive(true);
        
        //現在の所持金のＵＩへの反映
        moneyshojiNumber.GetComponent<Text>().text = money.ToString();

        //初期住

        if (Victorysukarabe == false && !MejedoOut) //まだスカラベに勝ってなければ最初のメジェドはいる
        {
            jyuninButton.JyuninPolaroid[0].SetActive(true);
                             
        }

        if(OshiraseMejedo == 0)//スタートボタン
        {
            StartExplanation.SetActive(true);
        }
        else
        {
            StartExplanation.SetActive(false);
        }

        CookingButtonAppear();

       
        //ポラロイド表示の判断
        HouseLevelUp();

        //PC表示の判断
        if(TotoGoToTravel)
        {
            TotoPanel.SetActive(false);
            TotoPC.SetActive(true);//初回はAirPlane内
        }

        //ごみ復活スピードの設定と反映
        FukkatsuSpeed = 60f;

        if (SaveDatedayo.testtime == 0)
        {
            testtime = FukkatsuSpeed;
            FukkatsuSpeedText.GetComponent<Text>().text = testtime.ToString();
        }
        else
        {
            testtime = SaveDatedayo.testtime;
            FukkatsuSpeedText.GetComponent<Text>().text = testtime.ToString();
        }

        if (HaveTotteoki == false && messagesNumber == 13)
        {
            HaveTameiya = true;
            HaveRakudaA = true;
            HaveRakudaB = true;
            HaveRakudaC = true;
        }


       
    }

    public void CookingButtonAppear()
    {
        //料理ボタン表示
        if (HaveRakudaA && HaveRakudaB && HaveRakudaC)
        {
            omiseManager.ButtonCookingImageAppear();
            CookButton.SetActive(true);
            //リコリスの表示
            omiseManager.Hatenas[22].SetActive(false);
            Button b = omiseManager.Shinazoroe[22].GetComponent<Button>();
            b.interactable = true;
            Color c = new Color(1f, 1f, 1f, 1f);
            b.image.color = c;
            omiseManager.ShohinGazou[22].SetActive(true);
            
        }
        else if (HaveTotteoki) //あとで消しても大丈夫かも
        {
            CookButton.SetActive(false);
        }
        else if (AmemittHekken)
        {
            //お店のアイテムをすべて表示する
            omiseManager.ButtonCookingImageAppear();
            CookButton.SetActive(true);
        }

    }

    public void PushStartExplanationButton()   
    {
        
        if(startbutton == 0)
        {
            startbutton += 1;
            StartText0.SetActive(false);
            StartText1.SetActive(true);
            return;
        }

        if (startbutton == 1)
        {
            startbutton += 1;
            StartText1.SetActive(false);
            StartText2.SetActive(true);
            return;
        }

        if (startbutton == 2)
        {
            StartExplanation.SetActive(false);
            OshiraseMejedo += 1;

            GameObject ira = IrairaBuppin[0];
            ira.SetActive(true);
            ira = IrairaBuppin[13];
            ira.SetActive(true);
            ira = IrairaBuppin[14];
            ira.SetActive(true);
            //リストに追加
            Iraira.Add(IrairaBuppin[0]);
            Iraira.Add(IrairaBuppin[13]);
            Iraira.Add(IrairaBuppin[14]);
            testtime = FukkatsuSpeed;
            FukkatsuSpeedText.GetComponent<Text>().text = testtime.ToString();
            PushStart = true;
        
         }

    }

    //メニューパネルーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー

    public void PushButtonIdo()　　//移動ボタン
    {
        MenuPanel.SetActive(false);
        MovePanel.SetActive(true);
        
    }

  

    public void PushShiraberuButton()     //調べるボタン
    {
        Shiraberu = true;
        messageText0.GetComponent<Text>().text = "調べるものをタッチしてね";

        MenuPanel.SetActive(false);
        MovePanel.SetActive(false);
        ModoruButton.SetActive(true);
    

    }

    public void PushButtonModoru()   //メニューボタン
    {
        HaveBomb = false;
        Shiraberu = false;
        YesNoButtonPanel.SetActive(false);
        TotoTouchOn = false;
        TOTOmessageNum = 0;
        textMessageViwer.isDisplayedAllMessage = true;
        MovePanel.SetActive(false); //移動パネルけす
        YesNoButtonPanel.SetActive(false); //はいいいえパネル消す
        KujyoPanel.SetActive(false);
            
            MenuPanel.SetActive(true);//メニュー表示
        

        RefreshMessageText("");
        RefreshMessageText1("");
        RefreshMessageText2("");
        

    }

    //ここから移動パネルーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー

    public void PushButtonGenkan()   //玄関ボタン
    {
        wallNo = 1;

        DisplayWall();      
        MovePanel.SetActive(true);
    }

    public void PushButtonKitchen()//キッチンボタン
    {
        wallNo = 2;
      
        DisplayWall();
    }

    public void PushButtonToilet()//トイレボタン
    {
        wallNo = 3;

        DisplayWall();
        
    }
    

    public void PushButtonDining()//ダイニングボタン
    {
        wallNo = 4;

        DisplayWall();
    }

    public void PushButtonLiving()//Livingボタン
    {
        wallNo = 5;

        DisplayWall();

    }

    public void PushButtonSoto()  //外ボタン
    {
        wallNo = 6;
        DisplayWall();
    }

    public void PushButtonOmise()    //お店ボタン------------------------------------------
    {
        wallNo = 7;

        DisplayWall();
       if(messagesNumber == 19)
      {
          omiseManager.ButttonflightchicketImageAppear();
      }
        ModoruButton.SetActive(false);   //戻るボタン消す
        ModoruPanelOmise.SetActive(true);//家へ」のボタン右上に

        MenuPanel.SetActive(false);  //メニューパネル消す

     
        textMessageViwer.EnterOmise(); //トトのセリフいれる
        

        //料理即渡すので、テキストも消す
        if (HaveTameiya || HaveTubeCurry || HaveCurry || HavePotatoCrocket)
        {
            CookingText.text = "";
        }

       if(messagesNumber == 22)
        {
            RefreshMessageText("到着まであと " + FlightTimeMinitues + ":" + FlightTimeSeconds.ToString("f0"));
        }

            //スクロール戻す
        scrollRect.GetComponent<ScrollRect>().verticalNormalizedPosition = 1.0f;
        YesNoNumber = 1;

        if (SnakeCount == 2)
        {
            textMessageViwer.Shinazoroe.SetActive(true);
        }
    }

    public void PushOmisekaraHomeButton() //お店から帰る
    {
        //セリフテキストボックスとTweenを空に
        textMessageViwer.EmptyTween();
        wallNo = 1;

        TotoTouchOn = false;
        TOTOmessageNum = 0;
        CountTotoTouch = 0;

        //これ要検討・・・・・・・・・・・・・・・・・・・・・・・・・・
        textMessageViwer.isDisplayedAllMessage = true;

        RefreshMessageText("");

        DisplayWall();

        ModoruPanelOmise.SetActive(false);
        ModoruButton.SetActive(true);
        YesNoButtonPanel.SetActive(false);
        MenuPanel.SetActive(true);
        Hige.SetActive(false);

        YesNoNumber = 1;

        if(HaveTotteoki == false && messagesNumber == 13)
        {
            HaveTameiya = true;
            HaveRakudaA = true;
            HaveRakudaB = true;
            HaveRakudaC = true;
        }
        TotteokiButton.SetActive(false);

    }


    public void JyuninRoomButton()//掲示板だよーーーーーーーーーーーーーーーーーーーーーーーーセーブ処理終了
    {
        wallNo = 11;

        DisplayWall();

        RefreshMessageText("住人用の掲示板だ。");
        Komarigoto.text = "いつもありがとうございます。";
        Pola = true;
        MenuButton.SetActive(false);
        MovePanel.SetActive(false);
        MenuPanel.SetActive(false);
        ModoruButton.SetActive(false);
        KeijiModoruButton.SetActive(true);
        OshiraseMejedo += 10000;

        ItemRankNumber = 0;

        //スフィンクス表示
        if (Appear11)
        {
            Appear11 = false;
            Komarigoto.text = "泣き声がすごいです";
            LastBossAp = true;
            LastBoss = MonsterManager.GetComponent<MonsterList>().Monster[10];

            LastBoss.SetActive(true);
        }
        if(LastBossAp)
        {
            Komarigoto.text = "泣き声がすごいです";
        
        }
        if (TotoGoToTravel)
        {
            if (UsagiAp == false)
            {
                Komarigoto.text = "泣き声がすごいです";
            }
            if (LastBossAp && NezumiAp == false && Appear04 == false && !Appear05)
            {

                if (KawausoAp == false)
                {
                    Komarigoto.text = "泣き声がすごいです";
                }
            }
            if (SnakeAp == false)
            {
                Komarigoto.text = "泣き声がすごいです";
            }
            if(Victorylastboss)
            {
                Komarigoto.text = "最後まで遊んでくれてありがとう";
            }
        }
        if(1 < OshiraseYoutuber)//Youtuber出現後
        {
            if(OshiraseYoutuber <= 10000)
            {
                OshiraseYoutuber += 10000;//お知らせスイッチきる
            }
        }
        if (1 < OshiraseSaraly)
        {
            if (OshiraseSaraly <= 10000)
            {
                OshiraseSaraly += 10000;//お知らせスイッチきる
            }
        }
        if (1 < OshiraseSanta)
        {
            if (OshiraseSanta <= 10000)
            {
                OshiraseSanta += 10000;//お知らせスイッチきる
            }
        }
        if (1 < OshiraseIrasutoya)
        {
            if (OshiraseIrasutoya <= 10000)
            {
                OshiraseIrasutoya += 10000;//お知らせスイッチきる
            }
        }
        if (1 < OshiraseHalloween)
        {
            if (OshiraseHalloween <= 10000)
            {
                OshiraseHalloween += 10000;//お知らせスイッチきる
            }
        }
        if (1 < OshiraseDotPola)
        {
            if (OshiraseDotPola <= 10000)
            {
                OshiraseDotPola += 10000;//お知らせスイッチきる
            }
        }
        if (1 < OshiraseNagasugi)
        {
            if (OshiraseNagasugi <= 10000)
            {
                OshiraseNagasugi += 10000;//お知らせスイッチきる
            }
        }
        if (1 < OshiraseNanka)
        {
            if (OshiraseNanka <= 10000)
            {
                OshiraseNanka += 10000;//お知らせスイッチきる
            }
        }
        if (1 < OshirasePica)
        {
            if (OshirasePica <= 10000)
            {
                OshirasePica += 10000;//お知らせスイッチきる
            }
        }
        if (1 < OshiraseYusya)
        {
            if (OshiraseYusya <= 10000)
            {
                OshiraseYusya += 10000;//お知らせスイッチきる
            }
        }
        if (1 < OshiraseKureo)
        {
            if (OshiraseKureo <= 10000)
            {
                OshiraseKureo += 10000;//お知らせスイッチきる
            }
        }
        if (1 < OshiraseGohonke)
        {
            if (OshiraseGohonke <= 10000)
            {
                OshiraseGohonke += 10000;//お知らせスイッチきる
            }
        }
        //ねずみ表示
        if (NezumiAppear)
        {
            NezumiAppear = false;
            Nezumi.SetActive(true);
            NezumiAp = true; //2週目ではここでアイテムが表示

        }
        if (NezumiAp) //テキストのための変数
        {
            Komarigoto.text = "ねずみが服をかじっています";
            
        }

        //すからべ表示(掲示板見てから表示にしたい
        if (Appear02)
        {
            Appear02 = false;
            Sukarabe = MonsterManager.GetComponent<MonsterList>().Monster[1];
            Sukarabe.SetActive(true);
            SukarabeAp = true;
        }

        if(SukarabeAp) //Sukarabeとかの使い方、これ誤解してた。箱の中に何か入ってたらtrueで、setactive関係ない
        {
            
            Komarigoto.text = "家の中にふんが転がっています";
        }
       
        //ねこ表示
        if (Appear03)
        {
            Appear03 = false;
            Komarigoto.text = "ねこが勝手に住み着いています";
            Cat = MonsterManager.GetComponent<MonsterList>().Monster[2];
            Cat.SetActive(true);
            CatAp = true;
        }

        if(CatAp)
        {
            Komarigoto.text = "ねこが勝手に住み着いています";
        }

        //うさぎ表示
        if (Appear04)
        {
           //Victorycat = false;
            Appear04 = false;
            Komarigoto.text = "騒音に困っています";
            Usagi = MonsterManager.GetComponent<MonsterList>().Monster[3];
            Usagi.SetActive(true);
            UsagiAp = true;
        }
        if (UsagiAp)
        {
            Komarigoto.text = "騒音に困っています";
        }
        //へび表示
        if (Appear05)
        {
            Appear05 = false;
            Komarigoto.text = "リモコンを占拠されています";
            Snake = MonsterManager.GetComponent<MonsterList>().Monster[4];
            Snake.SetActive(true);
            SnakeAp = true;
            textMessageViwer.HigeInMuseum.SetActive(false);

        }
        if (SnakeAp)
        {
            Komarigoto.text = "リモコンを占拠されています";
           
        }
        //さそり表示
        if (Appear06)
        {
            Appear06 = false;
            Komarigoto.text = "お菓子を勝手に食べられます";
            Sasori = MonsterManager.GetComponent<MonsterList>().Monster[5];
            Sasori.SetActive(true);
            SasoriAp = true;
        }
        if(SasoriAp)
        {
            Komarigoto.text = "お菓子を勝手に食べられます";
        }
        //カワウソ表示
        if (Appear07)
        {
            Appear07 = false;
            Komarigoto.text = "ばしゃばしゃという音が聞こえます";
            Kawauso = MonsterManager.GetComponent<MonsterList>().Monster[6];
            Kawauso.SetActive(true);
            KawausoAp = true;
           
        }
        if (KawausoAp)
        {
            Komarigoto.text = "ばしゃばしゃという音が聞こえます";
        }
        //らくだ表示
        if (Appear08)
        {
            Appear08 = false;
            Komarigoto.text = "乗り物がガレージに入りません";
            Rakuda = MonsterManager.GetComponent<MonsterList>().Monster[7];
            Rakuda.SetActive(true);
            RakudaAp = true;
        }
        if (RakudaAp)
        {
            Komarigoto.text = "乗り物がガレージに入りません";
        }
        //コブラ表示
        if (Appear09)
        {
            Appear09 = false;
            Komarigoto.text = "テレビを占拠されています";
            Kobura = MonsterManager.GetComponent<MonsterList>().Monster[8];
            Kobura.SetActive(true);
            KoburaAp = true;
        }
        if (KoburaAp)
        {
            Komarigoto.text = "テレビを占拠されています";
        }
        //アメミット表示
        if (Appear10)
        {
            Appear10 = false;
            Komarigoto.text = "よくわからない生き物がじゃまです";
            Amemitt = MonsterManager.GetComponent<MonsterList>().Monster[9];
            Amemitt.SetActive(true);
            AmemitAp = true;
        }
        if (AmemitAp)
        {
            Komarigoto.text = "よくわからない生き物がじゃまです";
        }
       
       
        DoSave();
    }

    public void PushKeijiModoruButton()
    {
        if (Pola)// ポラロイド画面なら、玄関にもどる、ステータスならポラロイドに戻る
        {
            wallNo = WALL_GENKAN;
            RefreshMessageText("");
            DisplayWall();
            MenuButton.SetActive(true);
            MenuPanel.SetActive(true);

            ModoruButton.SetActive(true);
            KeijiModoruButton.SetActive(false);
            Shiraberu = false;
            
        }
        else
        {
            //住民gazouidou
            JyuninWeek1[polaNumberGameM].transform.localPosition = new Vector2(0f, 1600f);
            PanelStatus.SetActive(false);
            StatusImagePanel.SetActive(false);
            PolaroidPanel.SetActive(true);
            Pola = true;
        }
    }

    public void PushJyuninPolaroid(int polaNumber) //ポラロイドおしたら
    {
        PolaroidPanel.SetActive(false);

        StatusImagePanel.SetActive(true);  //ステータス開く

        PanelStatus.SetActive(true);

        polaNumberGameM = polaNumber; 

        JyuninWeek1[polaNumber].transform.localPosition = new Vector2(0f, 0f);

        NameText.GetComponent<Text>().text = JyuninWeek1[polaNumber].GetComponent<Unit>().unitName;
        Explanation.GetComponent<Text>().text= JyuninWeek1[polaNumber].GetComponent<Unit>().Serifu[0];
               
               
    }


    public void DisplayWall()
    {
        switch (wallNo)
        {
            case WALL_GENKAN:
                panelWalls.transform.localPosition = new Vector2(0.0f, 0.0f);
                break;

            case WALL_KITCHEN:
                panelWalls.transform.localPosition = new Vector2(-1000.0f, 0.0f);
                break;

            case WALL_MYROOM:
                panelWalls.transform.localPosition = new Vector2(-2000.0f, 0.0f);
                break;

            case WALL_DINING:
                panelWalls.transform.localPosition = new Vector2(-3000.0f, 0.0f);
                break;

            case WALL_LIVING:
                panelWalls.transform.localPosition = new Vector2(-4000.0f, 0.0f);
                break;

            case WALL_MACHI:
                panelWalls.transform.localPosition = new Vector2(-5000.0f, 0.0f);
                break;

            case WALL_OMISE:
                panelWalls.transform.localPosition = new Vector2(-6000.0f, 0.0f);
                break;

           case WALL_CONVINI:
                panelWalls.transform.localPosition = new Vector2(-7000.0f, 0.0f);
                break;

            case WALL_DISCO:
                panelWalls.transform.localPosition = new Vector2(-8000.0f, 0.0f);
                break;

            case WALL_BATTLE:
                panelWalls.transform.localPosition = new Vector2(-9000.0f, 0.0f);
                break;

            case WALL_JYUNINROOM:
                panelWalls.transform.localPosition = new Vector2(-10000.00f, 0.0f);
                break;

        }


    }

    //お店のかんけい・・・・・・・・・・・・・・・・・・・・・・・・・・・・・・・・・・!!!!!!!!!!!
    //あとYesNoパネルもここ・・・・・・・・・・・・・・・・・・・・・・・・・・・・・・・・・
   

    public void PushYes()  //YesNoPanelでYesをおしたとき セーブ処理終了
    {
        switch (YesNoNumber)
        {
            case 0:   //買い物
                if(money < needmoney)
                {
                    RefreshMessageText("お金ないよ");
                    YesNoButtonPanel.SetActive(false);
                    YesNoNumber = 1;
                    return;
                }
                //お金が足りている
                if (money >= needmoney)
                {
                    //ItemSlotがいっぱいだったら
                    if (ItemSlot[0].GetComponent<ItemSlot>().item && ItemSlot[1].GetComponent<ItemSlot>().item && ItemSlot[2].GetComponent<ItemSlot>().item)
                    {
                        RefreshMessageText("持ち物がいっぱいだよ");
                        YesNoButtonPanel.SetActive(false);
                        return;
                    }

                    //所持金テキスト更
                    
                   MinusRefreshMoneyText();


                    //ヘッダーにアイテム画像表示.現在は３つまで

                    //ランクに応じて加算
                    if (ItemRankNumber == 0 || ItemRankNumber == 3 || ItemRankNumber == 5 || ItemRankNumber == 7 || ItemRankNumber == 10 || ItemRankNumber == 21 || ItemRankNumber == 15 || ItemRankNumber == 18 || ItemRankNumber == 13)
                    {
                        HaveCrank += 1f;
                    }
                    else if (ItemRankNumber == 1 || ItemRankNumber == 4 || ItemRankNumber == 6 || ItemRankNumber == 8 || ItemRankNumber == 11 || ItemRankNumber == 22 || ItemRankNumber == 16 || ItemRankNumber == 19 || ItemRankNumber == 14)
                    {
                        HaveBrank += 1f;
                    }
                    else if (ItemRankNumber == 2 || ItemRankNumber == 9 || ItemRankNumber == 12 || ItemRankNumber == 23 || ItemRankNumber == 17 || ItemRankNumber == 20)
                    {
                        HaveArank += 1f;
                    }
                    else if (ItemRankNumber == 24)//そらまめ
                    {
                        HaveAArank += 1;
                    }
                    else if (ItemRankNumber == 25)//じゃがい
                    {
                        HaveBBrank += 1;
                    }
                    else if (ItemRankNumber == 26)//パン粉
                    {
                        HaveCCrank += 1;
                    }
                    else if (ItemRankNumber == 27)//卵
                    {
                        HaveDrank += 1;
                    }
                    else if (ItemRankNumber == 28)//玉ねぎ
                    {
                        HaveErank += 1;
                    }
                    else if (ItemRankNumber == 29)//カレー粉
                    {
                        HaveFrank += 1;
                    }
                    //リコリス
                    if (ItemRankNumber == 22)
                    {
                        Havelicorice += 1;
                    }
                    //自転車
                    if (ItemRankNumber == 23)
                    {
                        HaveTube += 1;
                    }
                    if(ItemRankNumber == 30)
                    {
                        HaveHatu += 1 ;
                    }
                    if(ItemRankNumber == 31)
                    {
                        HaveMermait += 1;
                    }
                    if(ItemRankNumber == 32)
                    {
                        HaveUmaiTare += 1;
                    }
                    if(ItemRankNumber == 33)
                    {
                        HaveFrightChicket += 1;
                        //チケット売り切れ
                        omiseManager.ALlImageDissapear();
                    }
                    
         
                    //ItemInventryに追加(OmiseManagerの購入ボタンのメソッド発動
                    omiseManager.ItemInventryPlus(ItemRankNumber);


                    RefreshMessageText("まいどあり");

                    BuyItemSound.PlayOneShot(BuyItemSound.clip);


                    YesNoNumber = 1;

                }
                

                
                break;
            

            
            //ここから駆除ーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー

            case 30: //駆除する？でＹｅｓ(いたずらねずみ
                {   
                    //駆除パネルを消す
                    KujyoPanel.SetActive(false);

                    //ヘッダーのアイテムをすべて消す
                    Wanapanel.GetComponent<ItemInventry>().RemoveAll();
                    // Wanapanel.GetComponent<ItemInventry>().items = null;//これが原因
                    ItemSlot[0].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[1].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[2].GetComponent<ItemSlot>().ClearSlot();

                    //所持ランクアイテムをリセット
                    HaveArank = 0;
                    HaveBrank = 0;
                    HaveCrank = 0;

                    //勝敗判定
                    if(Nezumi.GetComponent<Nezumi>().Shoritsu >= 120)
                    {
                        RefreshMessageText("駆除成功！");
                        CookaudioSource.PlayOneShot(CookaudioSource.clip, 0.5f);

                        //ねずみを駆除したフラグオン
                        if (!PCSystemFirst)
                        {
                            VictoryNezumi = true;
                            //サラリーマン入る
                            SalarymanIn = true;
                           
                            //掲示板見たら、テキスト変わる
                            Appear02 = true;
                            
                             HouseLevelUp();
                        }
                        else
                        {
                            VictoryNezumi2 = true;
                                               
                        }
                            //ねずみオブジェクトを消す
                        Nezumi.SetActive(false);
                        //セリフかえる
                        NezumiHakken = false;
                        
                        
                        //次回ロード時にねずみを出現させない
                        NezumiAp = false;

                    }
                    else
                    {
                        RefreshMessageText("駆除失敗…");

                    }

                   
                    //MonsterImageの移動（画面外
                    Nezumi.GetComponent<Nezumi>().MonsterImage.transform.localPosition = new Vector2(0, 1800);

                    break;
                }

            case 31: //駆除する？でＹｅｓ(すからべ
                {
                    //駆除パネルを消す
                    KujyoPanel.SetActive(false);


                    //ヘッダーのアイテムをすべて消す
                    Wanapanel.GetComponent<ItemInventry>().RemoveAll();
                    
                    ItemSlot[0].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[1].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[2].GetComponent<ItemSlot>().ClearSlot();

                    //所持ランクアイテムをリセット
                    HaveArank = 0;
                    HaveBrank = 0;
                    HaveCrank = 0;

                    //勝敗判定
                    if (Sukarabe.GetComponent<Nezumi>().Shoritsu >= 100)
                    {
                        RefreshMessageText("駆除成功！");
                        CookaudioSource.PlayOneShot(CookaudioSource.clip, 0.5f);

                        //駆除したフラグオン
                        Victorysukarabe = true;
                        //オブジェクトを消す
                        Sukarabe.SetActive(false);
                        //セリフ変える
                        SukarabeHakken = false;
                        //掲示板見たら、テキスト変わる
                        Appear03 = true;
                        //サンタ入る
                        SantaIn = true;
                        HouseLevelUp();
                        //次回ロードで出現させない
                        SukarabeAp = false;
                    }
                    else
                    {
                        RefreshMessageText("駆除失敗…");

                    }

                    //MonsterImageの移動（画面外
                    Sukarabe.GetComponent<Nezumi>().MonsterImage.transform.localPosition = new Vector2(0, 1800);
                    break;

                }
            case 32: //駆除する？でＹｅｓ(ネコ
                {

                    //勝敗判定
                    if (Cat.GetComponent<Nezumi>().Shoritsu >= 60)
                    {
                        RefreshMessageText("駆除成功！");
                        CookaudioSource.PlayOneShot(CookaudioSource.clip, 0.5f);

                        //駆除したフラグオン
                        Victorycat = true;
                        //オブジェクトを消す
                        Cat.SetActive(false);

                        CatHakken = false;
                        //掲示板見たら、テキスト変わる
                        Appear04 = true;
                        //次の住人
                        IrasutoyaIn = true;
                        HouseLevelUp();
                        CatAp = false;
                    }
                    else
                    {
                        RefreshMessageText("駆除失敗…");

                    }


                    //駆除パネルを消す
                    KujyoPanel.SetActive(false);


                    //ヘッダーのアイテムをすべて消す
                    Wanapanel.GetComponent<ItemInventry>().RemoveAll();

                    ItemSlot[0].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[1].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[2].GetComponent<ItemSlot>().ClearSlot();

                    //所持ランクアイテムをリセット
                    HaveArank = 0;
                    HaveBrank = 0;
                    HaveCrank = 0;

                   
                    //MonsterImageの移動（画面外
                    Cat.GetComponent<Nezumi>().MonsterImage.transform.localPosition = new Vector2(0, 1800);
                    break;

                }
            case 33: //うさぎ
                {
                    //勝敗判定
                    if (Usagi.GetComponent<Nezumi>().Shoritsu >= 120)
                    {              
                        RefreshMessageText("駆除成功！");
                        CookaudioSource.PlayOneShot(CookaudioSource.clip, 0.5f);

                        //駆除したフラグオン
                        if (!PCSystemFirst)
                        {
                            Victoryusagi = true;
                            //掲示板見たら、テキスト変わる
                            Appear05 = true;
                            //次の住人
                            HalloweenIn = true;
                            HouseLevelUp();
                            // UsagiAp = false;
                        }
                        else
                        {
                            VictoryUsagi2 = true;
                            omiseManager.ALlImageDissapear();
                        }
                        //オブジェクトを消す
                        Usagi.SetActive(false);
                        //セリフかえる
                        UsagiHakken = false;

                        UsagiAp = false;
                    }
                    else
                    {
                        RefreshMessageText("駆除失敗…");

                    }
                    //駆除パネルを消す
                    KujyoPanel.SetActive(false);

                   

                    //ヘッダーのアイテムをすべて消す
                    Wanapanel.GetComponent<ItemInventry>().RemoveAll();

                    ItemSlot[0].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[1].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[2].GetComponent<ItemSlot>().ClearSlot();

                    //所持ランクアイテムをリセット
                    HaveArank = 0;
                    HaveBrank = 0;
                    HaveCrank = 0;

                    //MonsterImageの移動（画面外
                    Usagi.GetComponent<Nezumi>().MonsterImage.transform.localPosition = new Vector2(0, 1800);
                    break;
                   
                }
            case 34: //へび
                {
                    //勝敗判定。終わるまでランクアイテムをリセットせず、一度購入した履歴があるかで判断
                    if (HaveArank >= 1 && HaveBrank >=1 && HaveCrank >= 1)
                    {
                        RefreshMessageText("駆除成功！");
                        CookaudioSource.PlayOneShot(CookaudioSource.clip, 0.5f);

                        //駆除したフラグオン
                        if (!PCSystemFirst)
                        {
                            Victorysnake = true;

                            //ここでリセット
                            HaveArank = 0;
                            HaveBrank = 0;
                            HaveCrank = 0;
                          
                            //掲示板見たら、テキスト変わる
                            Appear06 = true;
                            //次の住人
                            DotIn = true;
                            HouseLevelUp();
                        }
                        else
                        {
                            Victorysnake2 = true;
                            //ここでリセット
                            HaveArank = 0;
                            HaveBrank = 0;
                            HaveCrank = 0;
                            //トト、帰国メッセージ➡　ひげ入手
                            messagesNumber = 39;

                        }
                        //オブジェクトを消す
                        Snake.SetActive(false);
                        SnakeHakken = false;
                        SnakeAp = false;
                    }
                    
                    else
                    {
                        RefreshMessageText("駆除失敗…");

                    }


                    //駆除パネルを消す
                    KujyoPanel.SetActive(false);


                    //ヘッダーのアイテムをすべて消す
                    Wanapanel.GetComponent<ItemInventry>().RemoveAll();

                    ItemSlot[0].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[1].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[2].GetComponent<ItemSlot>().ClearSlot();

                
                    //MonsterImageの移動（画面外
                    Snake.GetComponent<Nezumi>().MonsterImage.transform.localPosition = new Vector2(0, 1800);
                    break; 

                }
            case 35: //さそり
                {
                    //勝敗判定・・・いちおう、リコリス３つ与えてたら勝ち
                    if (Sasori.GetComponent<Nezumi>().Shoritsu >= 40)
                    {
                        RefreshMessageText("駆除成功！");
                        CookaudioSource.PlayOneShot(CookaudioSource.clip, 0.5f);

                        //駆除したフラグオン
                        Victorysasori = true;
                        //オブジェクトを消す
                        Sasori.SetActive(false);

                        SasoriHakken = false;
                        //掲示板見たら、テキスト変わる
                        Appear07 = true;
                        //次の住人
                        NagasugitaIn = true; 
                        HouseLevelUp();
                        SasoriAp = false;

                        //ここでリセット
                        HaveArank = 0;
                        HaveBrank = 0;
                        HaveCrank = 0;
                    }
                    else
                    {
                        RefreshMessageText("駆除失敗…");
                        //所持ランクアイテムをリセットしない
                    }


                    //駆除パネルを消す
                    KujyoPanel.SetActive(false);


                    //ヘッダーのアイテムをすべて消す
                    Wanapanel.GetComponent<ItemInventry>().RemoveAll();

                    ItemSlot[0].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[1].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[2].GetComponent<ItemSlot>().ClearSlot();

                    //所持ランクアイテムをリセット
                    HaveArank = 0;
                    HaveBrank = 0;
                    HaveCrank = 0;


                    //MonsterImageの移動（画面外
                    Sasori.GetComponent<Nezumi>().MonsterImage.transform.localPosition = new Vector2(0, 1800);
                    break;

                }
            case 36: //カワウソ
                {
                    //勝敗判定
                    if (Kawauso.GetComponent<Nezumi>().Shoritsu >= 100)
                    {
                        RefreshMessageText("駆除成功！");
                        CookaudioSource.PlayOneShot(CookaudioSource.clip, 0.5f);

                        //駆除したフラグオン
                        if (!PCSystemFirst)
                        {
                            Victorykawauso = true;
                            
                            //掲示板見たら、テキスト変わる
                            Appear08 = true;
                            //次の住人
                            NanikaAttaIn = true;
                            HouseLevelUp();
                        }
                        else
                        {
                            VictoryKawauso2 = true;
                        }
                        //オブジェクトを消す
                        Kawauso.SetActive(false);

                        KawausoHakken = false;

                        KawausoAp = false;
                    }
                    else
                    {
                        RefreshMessageText("駆除失敗…");
                    }

                    //駆除パネルを消す
                    KujyoPanel.SetActive(false);

                   
                    //ヘッダーのアイテムをすべて消す
                    Wanapanel.GetComponent<ItemInventry>().RemoveAll();

                    ItemSlot[0].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[1].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[2].GetComponent<ItemSlot>().ClearSlot();

                    //所持ランクアイテムをリセット
                    HaveArank = 0;
                    HaveBrank = 0;
                    HaveCrank = 0;

                    //MonsterImageの移動（画面外
                    Kawauso.GetComponent<Nezumi>().MonsterImage.transform.localPosition = new Vector2(0, 1800);
                    break;

                }
            case 37: //ラクダ
                {
                    //勝敗判定、トトのとっておきの本所持
                    if (HaveTotteoki)
                    {
                        RefreshMessageText("駆除成功！");
                        CookaudioSource.PlayOneShot(CookaudioSource.clip, 0.5f);

                        //駆除したフラグオン
                        Victoryrakuda = true;
                        //オブジェクトを消す
                        Rakuda.SetActive(false);

                        RakudaHakken = false;
                        //掲示板見たら、テキスト変わる
                        Appear09 = true;
                        //次の住人
                        PicasoIn = true;
                        HouseLevelUp();
                        RakudaAp = false;
                        HaveTotteoki = false;
                        HaveRakudaA = false;
                        HaveRakudaB = false;
                        HaveRakudaC = false;
                    }
                    else
                    {
                        RefreshMessageText("駆除失敗…");
                    }
                    //すべての本をあげてみる必要がある。
                    if(HaveArank > 0)
                    {
                        HaveRakudaA = true;
                    }
                    if(HaveBrank > 0)
                    {
                        HaveRakudaB = true;
                    }
                    if(HaveCrank > 0)
                    {
                        HaveRakudaC = true;
                    }

                    //駆除パネルを消す
                    KujyoPanel.SetActive(false);


                    //ヘッダーのアイテムをすべて消す
                    Wanapanel.GetComponent<ItemInventry>().RemoveAll();

                    ItemSlot[0].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[1].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[2].GetComponent<ItemSlot>().ClearSlot();

                    //所持ランクアイテムをリセット
                    HaveArank = 0;
                    HaveBrank = 0;
                    HaveCrank = 0;

                    //MonsterImageの移動（画面外
                    Rakuda.GetComponent<Nezumi>().MonsterImage.transform.localPosition = new Vector2(0, 1800);
                    break;

                }
            case 38://料理
                {
                    //ターメイヤ
                    if (HaveAArank == 1 && HaveDrank == 1 && HaveCCrank == 1)
                    {
                        CookButton.GetComponent<Nezumi>().CookingtTamePanel();
                        //ターメイヤがアイテム欄に
                        CookingText.text = "料理：ターメイヤ";
                        //変数をオンに
                        HaveTameiya = true;
                        CookaudioSource.PlayOneShot(CookaudioSource.clip);
                    }
                    //カレー
                    else if (HaveBBrank == 1 && HaveErank == 1 && HaveFrank == 1)
                    {
                        CookButton.GetComponent<Nezumi>().CookingtCurryPanel();
                        CookingText.text = "料理：カレー";
                        //変数をオンに
                        HaveCurry = true;
                        CookaudioSource.PlayOneShot(CookaudioSource.clip);
                    }
                    //コロッケじゃが
                    else if (HaveBBrank == 1 && HaveCCrank == 1)
                    {
                        CookButton.GetComponent<Nezumi>().CookingtCrocketPanel();
                        CookingText.text = "料理：ポテトコロッケ";
                        //変数をオンに
                        HavePotatoCrocket = true;
                        CookaudioSource.PlayOneShot(CookaudioSource.clip);

                    }
                    //タイヤ味のカレーとカレー味のタイヤを同時に楽しめる一品。
                    else if (Havelicorice == 1 && HaveBBrank == 1 && HaveFrank == 1)
                    {
                        CookButton.GetComponent<Nezumi>().CookingtlicoriceCurryPanel();
                        CookingText.text = "料理：タイヤ味のカレー（食用）";
                        //変数をオンに
                        HaveTubeCurry = true;
                        CookaudioSource.PlayOneShot(CookaudioSource.clip);
                    }
                    //おいしいハツ（ハツとタレ。ハツとタレが１、マーマイトが０
                    else if (HaveHatu == 1 && HaveUmaiTare == 1 && HaveMermait == 0)
                    {
                        CookButton.GetComponent<Nezumi>().CookingUmaiTareHatuPanel();
                        CookingText.text = "料理：ハツ（タレ味）";
                        //変数をオンに
                        HaveTareHatu = true;
                        HaveMermiteHatu = false;
                        CookaudioSource.PlayOneShot(CookaudioSource.clip);

                    }
                    //マーマイトハツ　ハツとマーマイトが１、タレが０
                    else if (HaveHatu == 1 && HaveMermait == 1 && HaveUmaiTare == 0)
                    {
                        CookButton.GetComponent<Nezumi>().CookingMermiteHatuPanel();
                        CookingText.text = "料理：マーマイトが詰まったハツ";
                        //変数をオンに
                        HaveMermiteHatu = true;
                        HaveTareHatu = false;
                        CookaudioSource.PlayOneShot(CookaudioSource.clip);
                    }
                    else
                    {
                        RefreshMessageText("失敗した…");
                    }

                    //所持ランクアイテムをリセット
                    HaveArank = 0;
                    HaveBrank = 0;
                    HaveCrank = 0;
                    HaveAArank = 0;
                    HaveBBrank = 0;
                    HaveCCrank = 0;
                    HaveDrank = 0;
                    HaveErank = 0;
                    HaveFrank = 0;
                    Havelicorice = 0;
                    HaveTube = 0;
                    HaveHatu = 0;
                    HaveMermait = 0;
                    HaveUmaiTare = 0;
                  
                    //ヘッダーのアイテムをすべて消す
                    Wanapanel.GetComponent<ItemInventry>().RemoveAll();

                    ItemSlot[0].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[1].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[2].GetComponent<ItemSlot>().ClearSlot();
                    break;
                }
            case 39: //コブラ
                {
                    //勝敗判定。終わるまでランクアイテムをリセットせず、一度購入した履歴があるかで判断
                    if (HaveArank >= 1 && HaveBrank >= 1 && HaveCrank >= 1)
                    {
                        RefreshMessageText("駆除成功！");
                        CookaudioSource.PlayOneShot(CookaudioSource.clip, 0.5f);

                        //駆除したフラグオン
                        Victorykobura = true;
                        //オブジェクトを消す
                        Kobura.SetActive(false);

                        //ここでリセット
                        HaveArank = 0;
                        HaveBrank = 0;
                        HaveCrank = 0;

                        KoburaHakken = false;
                        //掲示板見たら、テキスト変わる
                        Appear10 = true;
                        //次の住人
                        YusyaIn = true;
                        HouseLevelUp();
                        KoburaAp = false;
                    }
                    else
                    {
                        RefreshMessageText("駆除失敗…");
                    }

                    //駆除パネルを消す
                    KujyoPanel.SetActive(false);

                    //ヘッダーのアイテムをすべて消す
                    Wanapanel.GetComponent<ItemInventry>().RemoveAll();

                    ItemSlot[0].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[1].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[2].GetComponent<ItemSlot>().ClearSlot();

                    //MonsterImageの移動（画面外
                    Kobura.GetComponent<Nezumi>().MonsterImage.transform.localPosition = new Vector2(0, 1800);
                    break;

                }
            case 40: //アメミット
                {
                    //マーマイトハツを持っていればＯＫ
                    if(HaveMermiteHatu)
                    {
                        CookaudioSource.PlayOneShot(CookaudioSource.clip, 0.5f);
                        RefreshMessageText("アメミットは一口食べると");
                        RefreshMessageText1("逃げ出した！");
                        CookingText.text = "";
                        HaveMermiteHatu = false;
                        //駆除したフラグオン
                        Victoryamemitt = true;
                        //オブジェクトを消す
                        Amemitt.SetActive(false);

                        AmemittHekken = false;
                        AmemitAp = false;
                        //掲示板見たら、テキスト変わる
                        Appear11 = true;
                        //次の住人
                        KureoPatoraIn = true;
                        HouseLevelUp();
                    }
                    else if(HaveTareHatu)
                    {
                        RefreshMessageText("アメミットはハツを");
                        RefreshMessageText1("おいしそうに食べている！");
                        HaveTareHatu = false;
                        CookingText.text = "";
                    }
                    else
                    {
                        RefreshMessageText("駆除失敗・・・");
                        CookingText.text = "";
                    }
                    //アイテムリセット
                    HaveMermait = 0;
                    HaveUmaiTare = 0;
                    HaveHatu = 0;
                    HaveMermiteHatu = false;
                    HaveTareHatu = false;
                    //駆除パネルを消す
                    KujyoPanel.SetActive(false);

                    //ヘッダーのアイテムをすべて消す
                    Wanapanel.GetComponent<ItemInventry>().RemoveAll();

                    ItemSlot[0].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[1].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[2].GetComponent<ItemSlot>().ClearSlot();

                    //MonsterImageの移動（画面外
                    Amemitt.GetComponent<Nezumi>().MonsterImage.transform.localPosition = new Vector2(0, 1800);
                   
                    break;
                }
            case 41://チケットあげますか？ではい
                {
                    if(HaveFrightChicket == 0)
                    {
                        YesNoButtonPanel.SetActive(false);
                        RefreshMessageText("もってないよ");
                        //ヘッダーのアイテムをすべて消す
                        Wanapanel.GetComponent<ItemInventry>().RemoveAll();

                        ItemSlot[0].GetComponent<ItemSlot>().ClearSlot();
                        ItemSlot[1].GetComponent<ItemSlot>().ClearSlot();
                        ItemSlot[2].GetComponent<ItemSlot>().ClearSlot();

                    }
                    if (HaveFrightChicket > 0)
                    {
                        messagesNumber = 21;

                        RefreshMessageText("");
                        //店入り直し
                        textMessageViwer.EmptyTween();
                        textMessageViwer.EnterOmise();
                        //チケットなくなる
                        HaveFrightChicket = 0;
                        //ヘッダーのアイテムをすべて消す→ではなく、チケットだけ消すできる？
                        //↓とりあえず一種類のていで
                        Wanapanel.GetComponent<ItemInventry>().RemoveAll();
                        ItemSlot[0].GetComponent<ItemSlot>().ClearSlot();
                        ItemSlot[1].GetComponent<ItemSlot>().ClearSlot();
                        ItemSlot[2].GetComponent<ItemSlot>().ClearSlot();

                        ItemInventry wana = Wanapanel.GetComponent<ItemInventry>();
                       
                    }
                    break;
                }
            case 42: //PC転送-------------------------------------------------

                if (money >= needmoney)
                {
                    //ItemSlotがいっぱいだったら
                    if (ItemSlot[0].GetComponent<ItemSlot>().item && ItemSlot[1].GetComponent<ItemSlot>().item && ItemSlot[2].GetComponent<ItemSlot>().item)
                    {
                        RefreshMessageText("持ち物がいっぱいだよ");
                        YesNoButtonPanel.SetActive(false);
                        return;
                    }
                }

                    if (ItemRankNumber == 34)//送ったのが楽器ケース//必ずボタングレーにする
                    {
                    //代金支払い 
                    money -= omiseManager.Shinazoroe[ItemRankNumber].GetComponent<OmiseButton>().Needmoney;
                    //所持金テキスト更新
                    MinusRefreshMoneyText();

                    messagesNumber = 24;
                    textMessageViwer.EnterOmise();

                    }
               if(ItemRankNumber == 35)//忍者なりきりセット
                {
                    //代金支払い 
                    money -= omiseManager.Shinazoroe[ItemRankNumber].GetComponent<OmiseButton>().Needmoney;
                    //所持金テキスト更新
                    MinusRefreshMoneyText();

                    messagesNumber = 25;
                    textMessageViwer.EnterOmise();
                }
              
                if (ItemRankNumber == 36) //巻物
                {
                    //代金支払い 
                    money -= omiseManager.Shinazoroe[ItemRankNumber].GetComponent<OmiseButton>().Needmoney;
                    //所持金テキスト更新
                    MinusRefreshMoneyText();

                    messagesNumber = 29;
                    textMessageViwer.EnterOmise();
                    Appear07 = true;//掲示板にカワウソ表示
                    omiseManager.MakimonoToEjimonImageDISAppear();
                }
                if (ItemRankNumber == 37) //巻物中華
                {
                    //代金支払い 
                    money -= omiseManager.Shinazoroe[ItemRankNumber].GetComponent<OmiseButton>().Needmoney;
                    //所持金テキスト更新→　アニメおかしい
                    MinusRefreshMoneyText();

                    messagesNumber = 30;
                    textMessageViwer.EnterOmise();
                    Appear07 = true;//掲示板にカワウソ表示
                    omiseManager.MakimonoToEjimonImageDISAppear();
                }
                if (ItemRankNumber == 38) 
                {
                    //代金支払い 
                    money -= omiseManager.Shinazoroe[ItemRankNumber].GetComponent<OmiseButton>().Needmoney;
                    //所持金テキスト更新
                    MinusRefreshMoneyText();

                    messagesNumber = 31;
                   
                    textMessageViwer.EnterOmise();
                    Appear07 = true;//掲示板にカワウソ表示
                    omiseManager.MakimonoToEjimonImageDISAppear();
                }
                if (ItemRankNumber == 39) //サッカー
                {
                    //代金支払い 
                    money -= omiseManager.Shinazoroe[ItemRankNumber].GetComponent<OmiseButton>().Needmoney;
                    //所持金テキスト更
                    MinusRefreshMoneyText();

                    messagesNumber = 32;
                    textMessageViwer.EnterOmise();
                    Appear07 = true;//掲示板にカワウソ表示
                    omiseManager.MakimonoToEjimonImageDISAppear();
                }
                if (ItemRankNumber == 40) 
                {
                    //代金支払い 
                    money -= omiseManager.Shinazoroe[ItemRankNumber].GetComponent<OmiseButton>().Needmoney;
                    //所持金テキスト更新
                    MinusRefreshMoneyText();

                    messagesNumber = 33;
                    textMessageViwer.EnterOmise();
                    Appear07 = true;//掲示板にカワウソ表示
                    omiseManager.MakimonoToEjimonImageDISAppear();
                }
                RefreshMessageText("転送に成功した！");
                omiseManager.AllTravelImageDissapear();
                break;

               
            case 43: //スフィンクス
                if(HaveHige)
                {
                    //効果音
                    DoraSound.PlayOneShot(DoraSound.clip,0.5f);

                    RefreshMessageText("スフィンクスは");
                    RefreshMessageText1("感動して去っていった……");
                    HaveHige = false;
                    //駆除したフラグオン
                   Victorylastboss = true;
                    //ひげ付きと画像チェンジ
                    LastBoss.SetActive(false);
                    LastBossHIGE.SetActive(true);
                    //駆除パネルを消す
                    KujyoPanel.SetActive(false);

                    LastBossHakken = false;
                    LastBossAp = false;
                    //ヘッダーのアイテムをすべて消す
                    Wanapanel.GetComponent<ItemInventry>().RemoveAll();

                    ItemSlot[0].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[1].GetComponent<ItemSlot>().ClearSlot();
                    ItemSlot[2].GetComponent<ItemSlot>().ClearSlot();

                }
                else
                {
                    RefreshMessageText("スフィンクスは泣いている。");
                }
                break;
        
        }
                     DoSave();

                    YesNoButtonPanel.SetActive(false);
    }

    public void PushNo()  //YesNoPanelでNoをおしたとき
    {
        YesNoButtonPanel.SetActive(false);
        KujyoPanel.SetActive(false);
        RefreshMessageText("");
        //お店シーン以外で、メニューパネルを自動的に出す
        if(wallNo != WALL_OMISE)
        {
            MenuPanel.SetActive(true);
        }
        if(wallNo == WALL_CONVINI)
        {
            MenuPanel.SetActive(false);
        }
        if(messagesNumber == 22)
        {
            YesNoNumber = 1;
        }
    }



    //メジェド引っ越し処理ーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーsave
    public void HouseLevelUp()
    {
        HouseLevel += 0.5f;
     
        if(HouseLevel == 1)
        {
            Nezumi = MonsterManager.GetComponent<MonsterList>().Monster[0];
            NezumiAppear = true;
            
        }

       if (HouseLevel >= 3 && !Victorycat && YouTuberOut == false)//まだ猫に勝っていない状態
        {
            OshiraseYoutuber += 1 ;
            
            //ポラ表示
            jyuninButton.JyuninPolaroid[1].SetActive(true);
      
        }


        if(SalarymanIn)
        {
            OshiraseSaraly += 1;
         
            //ポラ表示
            jyuninButton.JyuninPolaroid[2].SetActive(true);
          
        }

        if (SantaIn)
        {
            OshiraseSanta += 1;
            jyuninButton.JyuninPolaroid[0].SetActive(false);
            MejedoOut = true;
            //待機リストからリムーブ
            IrairaBuppin[0].SetActive(false);
            IrairaBuppin[13].SetActive(false);
            IrairaBuppin[14].SetActive(false);
            Iraira.Remove(IrairaBuppin[0]);
            Iraira.Remove(IrairaBuppin[13]);
            Iraira.Remove(IrairaBuppin[14]);
            
            //ポラ表示
            jyuninButton.JyuninPolaroid[3].SetActive(true);
            
        }

        if (IrasutoyaIn && MejedoOut)
        {
            OshiraseIrasutoya += 1;
            jyuninButton.JyuninPolaroid[1].SetActive(false);
            YouTuberOut = true;
            //待機リストからリムーブ
            IrairaBuppin[1].SetActive(false);
            IrairaBuppin[15].SetActive(false);
            IrairaBuppin[16].SetActive(false);
            Iraira.Remove(IrairaBuppin[1]);
            Iraira.Remove(IrairaBuppin[15]);
            Iraira.Remove(IrairaBuppin[16]);
         

            //ポラ表示
            jyuninButton.JyuninPolaroid[4].SetActive(true);
          
        }

        if (HalloweenIn)
        {
            OshiraseHalloween += 1;
            
            SalarymanIn = false;
            SalarymanOut = true; 
            jyuninButton.JyuninPolaroid[2].SetActive(false);
          
            //待機リストからリムーブ
            IrairaBuppin[2].SetActive(false);
            IrairaBuppin[17].SetActive(false);
            IrairaBuppin[18].SetActive(false);
            Iraira.Remove(IrairaBuppin[2]);
            Iraira.Remove(IrairaBuppin[17]);
            Iraira.Remove(IrairaBuppin[18]);
         
            //ポラ表示
            jyuninButton.JyuninPolaroid[5].SetActive(true);
          
        }

        if (DotIn && SalarymanOut)
        {
            OshiraseDotPola += 1;
            SantaIn = false;
            SantaOut = true;
            jyuninButton.JyuninPolaroid[3].SetActive(false);
           
            //待機リストからリムーブ
            IrairaBuppin[3].SetActive(false);
            IrairaBuppin[19].SetActive(false);
            IrairaBuppin[20].SetActive(false);
            Iraira.Remove(IrairaBuppin[3]);
            Iraira.Remove(IrairaBuppin[19]);
            Iraira.Remove(IrairaBuppin[20]);
           
            //ポラ表示
            jyuninButton.JyuninPolaroid[6].SetActive(true);
            
        }

        if (NagasugitaIn && SantaOut)
        {
            OshiraseNagasugi += 1;
            IrasutoyaIn = false;
            IrasutoyaOut = true;
            jyuninButton.JyuninPolaroid[4].SetActive(false);
            
            //待機リストからリムーブ
            IrairaBuppin[4].SetActive(false);
            IrairaBuppin[21].SetActive(false);
            IrairaBuppin[22].SetActive(false);
            Iraira.Remove(IrairaBuppin[4]);
            Iraira.Remove(IrairaBuppin[21]);
            Iraira.Remove(IrairaBuppin[22]);
           
            //ポラ表示
            jyuninButton.JyuninPolaroid[7].SetActive(true);
         
        }

        if (NanikaAttaIn && IrasutoyaOut)
        {
            OshiraseNanka += 1;
            HalloweenIn = false;
            HalloweenOut = true;
            jyuninButton.JyuninPolaroid[5].SetActive(false);

            //待機リストからリムーブ
            IrairaBuppin[5].SetActive(false);
            IrairaBuppin[23].SetActive(false);
            IrairaBuppin[24].SetActive(false);
            Iraira.Remove(IrairaBuppin[5]);
            Iraira.Remove(IrairaBuppin[23]);
            Iraira.Remove(IrairaBuppin[24]);

            //ポラ表示
            jyuninButton.JyuninPolaroid[8].SetActive(true);
           
        }

        if (PicasoIn && HalloweenOut)
        {
            OshirasePica += 1;
            DotIn = false;
            DotOut = true;
            jyuninButton.JyuninPolaroid[6].SetActive(false);
           
            //待機リストからリムーブ
            IrairaBuppin[6].SetActive(false);
            IrairaBuppin[25].SetActive(false);  
            Iraira.Remove(IrairaBuppin[6]);
            Iraira.Remove(IrairaBuppin[25]);
            //ポラ表示
            jyuninButton.JyuninPolaroid[9].SetActive(true);
            
        }

        if (YusyaIn && DotOut)
        {
            OshiraseYusya += 1;
            NagasugitaIn = false;
            NagasugitaOut = true;
            jyuninButton.JyuninPolaroid[7].SetActive(false);
            //待機リストからリムーブ
            IrairaBuppin[7].SetActive(false);
            IrairaBuppin[26].SetActive(false);
            IrairaBuppin[27].SetActive(false);
            Iraira.Remove(IrairaBuppin[7]);
            Iraira.Remove(IrairaBuppin[26]);
            Iraira.Remove(IrairaBuppin[27]);

            //ポラ表示
            jyuninButton.JyuninPolaroid[10].SetActive(true);
                  
        }

        if (KureoPatoraIn && NagasugitaOut)
        {
            OshiraseKureo += 1;
            NanikaAttaIn = false;
            NanikaAttaOut = true;
            jyuninButton.JyuninPolaroid[8].SetActive(false);
            //待機リストからリムーブ
            IrairaBuppin[8].SetActive(false);
            IrairaBuppin[28].SetActive(false);
            IrairaBuppin[29].SetActive(false);
            Iraira.Remove(IrairaBuppin[8]);
            Iraira.Remove(IrairaBuppin[28]);
            Iraira.Remove(IrairaBuppin[29]);

            //ポラ表示
            jyuninButton.JyuninPolaroid[11].SetActive(true);
         
        }

        if (TotoGoToTravel && GohonkeIn && PicasoOut)
        {
            OshiraseGohonke += 1; 
            jyuninButton.JyuninPolaroid[9].SetActive(false);
            //待機リストからリムーブ
            IrairaBuppin[9].SetActive(false);
            IrairaBuppin[30].SetActive(false);
            IrairaBuppin[31].SetActive(false);
            Iraira.Remove(IrairaBuppin[9]);
            Iraira.Remove(IrairaBuppin[30]);
            Iraira.Remove(IrairaBuppin[31]);

            //ポラ表示
            jyuninButton.JyuninPolaroid[12].SetActive(true);
           
        }
        DoSave();
    }

  
    public void Ira(int myNumber)
    {
        Iraira.Remove(IrairaBuppin[myNumber]);
       
    }

   

//更新けいーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー

    public void RefreshMoneyText()     //お金テキスト更新用
    {
        StartCoroutine(MoneyAnimation(moneyPlus, 0.5f));
    }

    public void MinusRefreshMoneyText()
    {
        StartCoroutine(MinusMoneyAnimation(0.5f));
    }

    IEnumerator MoneyAnimation(int addScore, float time)
    {
        //今のお金
        int befor = money;

        int after = money + moneyPlus;

        if (after >= 1000000)
        {
            after = 1000000;//上限100万まで
           

        }
        money += moneyPlus;

        float elapsedTime = 0.0f;

        while(elapsedTime < time)
        {
            float rate = elapsedTime / time;

            moneyshojiNumber.GetComponent<Text>().text = (befor + (after - befor)* rate).ToString("f0");

            elapsedTime += Time.deltaTime;

            yield return new WaitForSeconds(0.01f);
        }
        
        moneyshojiNumber.GetComponent<Text>().text = after.ToString();

    }
    IEnumerator MinusMoneyAnimation(float time)
    {
        //今のお金
        int befor = money;

        int after = money - needmoney;

        money -= needmoney;

        float elapsedTime = 0.0f;

        while (elapsedTime < time)
        {
            float rate = elapsedTime / time;

            moneyshojiNumber.GetComponent<Text>().text = (befor - needmoney * rate).ToString("f0");

            elapsedTime += Time.deltaTime;

            yield return new WaitForSeconds(0.01f);
        }

        moneyshojiNumber.GetComponent<Text>().text = after.ToString();
    }

    public void RefreshMessageText(string message) //メッセテキスト更新０行目
    {
        messageText0.GetComponent<Text>().text = message;

    }

    public void RefreshMessageText1(string message) //メッセテキスト更新１行目
    {
        messageText1.GetComponent<Text>().text = message;

    }

    public void RefreshMessageText2(string message) //メッセテキスト更新２行目
    {
        messageText2.GetComponent<Text>().text = message;

    }
   
    public void TOTOTouch()
    {
        if(messagesNumber == 0 || messagesNumber == 20 || messagesNumber == 21 || messagesNumber == 40)
        {
            return;
        }
        TotoTouchOn = true;

        if (CountTotoTouch > 10)
        {
            CountTotoTouch = 0;
        }

        if (CountTotoTouch == 0)
        {
            TOTOmessageNum = 43;
        }
        if (CountTotoTouch == 1)
        {
            TOTOmessageNum = 44;
        }
        if (CountTotoTouch == 2)
        {
            TOTOmessageNum = 45;
        }
        if (CountTotoTouch == 3)
        {
            TOTOmessageNum = 46;
        }
        if (CountTotoTouch == 4)
        {
            TOTOmessageNum = 47;
        }
        if (CountTotoTouch == 5)
        {
            TOTOmessageNum = 48;
        }
        if (CountTotoTouch == 6)
        {
            TOTOmessageNum = 49;
        }
        if (CountTotoTouch == 7)
        {
            TOTOmessageNum = 50;
        }
        if (CountTotoTouch == 8)
        {
            TOTOmessageNum = 51;
        }
        if (CountTotoTouch == 9)
        {
            TOTOmessageNum = 52;
        }
        if (CountTotoTouch == 10)
        {
            TOTOmessageNum = 53;
        }
        CountTotoTouch += 1;
        textMessageViwer.EnterOmise();

    }

    public void DoSave()
    {
        SaveDatedayo.items = items; //アイテムリスト

        SaveDatedayo.money = money;          //所持金
        SaveDatedayo.moneyPlus = moneyPlus;
        SaveDatedayo.HouseLevel = HouseLevel;    //家レベ
        SaveDatedayo.ItemRankNumber = ItemRankNumber;
        SaveDatedayo.HaveArank = HaveArank;
        SaveDatedayo.HaveBrank  = HaveBrank;
        SaveDatedayo.HaveCrank  = HaveCrank;
        SaveDatedayo.HaveRakudaA = HaveRakudaA; 
        SaveDatedayo.HaveRakudaB = HaveRakudaB;
        SaveDatedayo.HaveRakudaC = HaveRakudaC;
        SaveDatedayo.HaveAArank = HaveAArank;
        SaveDatedayo.HaveBBrank = HaveBBrank;
        SaveDatedayo.HaveCCrank = HaveCCrank;
        SaveDatedayo.HaveHatu = HaveHatu;
        SaveDatedayo.HaveMermait = HaveMermait;
        SaveDatedayo.HaveUmaiTare = HaveUmaiTare;

        SaveDatedayo.HaveDrank = HaveDrank;
        SaveDatedayo.HaveErank = HaveErank;
        SaveDatedayo.HaveFrank = HaveFrank;
        SaveDatedayo.HavePotechi = HavePotechi;
        SaveDatedayo.Havelicorice = Havelicorice;
        SaveDatedayo.HaveTube = HaveTube;
        SaveDatedayo.HaveTameiya = HaveTameiya;
        SaveDatedayo.HaveCurry = HaveCurry;
        SaveDatedayo.HavePotatoCrocket = HavePotatoCrocket;
        SaveDatedayo.HaveTubeCurry = HaveTubeCurry;
        SaveDatedayo.HaveTotteoki = HaveTotteoki;
        SaveDatedayo.HaveMermiteHatu = HaveMermiteHatu;
        SaveDatedayo.HaveTareHatu = HaveTareHatu;
        SaveDatedayo.HaveFrightChicket = HaveFrightChicket;

        SaveDatedayo.HaveInstrumental = HaveInstrumental;
        SaveDatedayo.HaveNinjaSet = HaveNinjaSet;
        SaveDatedayo.HaveChinaScroll = HaveChinaScroll;
        SaveDatedayo.HaveSukarabeScroll = HaveSukarabeScroll;
        SaveDatedayo.HaveYUYUgiohCard = HaveYUYUgiohCard;
        SaveDatedayo.HaveEjimonbawl = HaveEjimonbawl;

        SaveDatedayo.VictoryNezumi = VictoryNezumi;
        SaveDatedayo.Victorysukarabe = Victorysukarabe;
        SaveDatedayo.Victorycat = Victorycat;
        SaveDatedayo.Victoryusagi = Victoryusagi;
        SaveDatedayo.Victorysnake = Victorysnake;
        SaveDatedayo.Victorysasori = Victorysasori;
        SaveDatedayo.Victorykawauso = Victorykawauso;
        SaveDatedayo.Victoryrakuda = Victoryrakuda;
        SaveDatedayo.Victorykobura = Victorykobura;
        SaveDatedayo.Victoryamemitt = Victoryamemitt;

        SaveDatedayo.TotoGoToTravel = TotoGoToTravel;
        SaveDatedayo.Victorylastboss = Victorylastboss;

        SaveDatedayo.needmoney = needmoney; //OmiseManagerから代入される

        SaveDatedayo.NezumiAppear = NezumiAppear;
        SaveDatedayo.Appear02 = Appear02;
        SaveDatedayo.Appear03 = Appear03;
        SaveDatedayo.Appear04 = Appear04;
        SaveDatedayo.Appear05 = Appear05;
        SaveDatedayo.Appear06 = Appear06;
        SaveDatedayo.Appear07 = Appear07;
        SaveDatedayo.Appear08 = Appear08;
        SaveDatedayo.Appear09 = Appear09;
        SaveDatedayo.Appear10 = Appear10;
        SaveDatedayo.Appear11 = Appear11;

        SaveDatedayo.NezumiHakken = NezumiHakken; //ねずみをクリックしたとき。倒したらオフ
        SaveDatedayo.SukarabeHakken = SukarabeHakken;
        SaveDatedayo.CatHakken = CatHakken;
        SaveDatedayo.UsagiHakken = UsagiHakken;
        SaveDatedayo.SnakeHakken = SnakeHakken;
        SaveDatedayo.SasoriHakken = SasoriHakken;
        SaveDatedayo.KawausoHakken = KawausoHakken;
        SaveDatedayo.RakudaHakken = RakudaHakken;
        SaveDatedayo.KoburaHakken = KoburaHakken;
        SaveDatedayo.AmemittHekken = AmemittHekken;
        SaveDatedayo.LastBossHakken = LastBossHakken;

        SaveDatedayo.messagesNumber = messagesNumber;

        SaveDatedayo.SalarymanIn = SalarymanIn;
        SaveDatedayo.SantaIn = SantaIn;
        SaveDatedayo.IrasutoyaIn = IrasutoyaIn;
        SaveDatedayo.HalloweenIn = HalloweenIn;
        SaveDatedayo.DotIn = DotIn;
        SaveDatedayo.NagasugitaIn = NagasugitaIn;
        SaveDatedayo.NanikaAttaIn = NanikaAttaIn;
        SaveDatedayo.PicasoIn = PicasoIn;
        SaveDatedayo.YusyaIn = YusyaIn;
        SaveDatedayo.KureoPatoraIn = KureoPatoraIn;
        SaveDatedayo.GohonkeIn = GohonkeIn;

        SaveDatedayo.MejedoOut = MejedoOut;
        SaveDatedayo.YouTuberOut = YouTuberOut;
        SaveDatedayo.SalarymanOut = SalarymanOut;
        SaveDatedayo.SantaOut = SantaOut;
        SaveDatedayo.IrasutoyaOut = IrasutoyaOut;
        SaveDatedayo.HalloweenOut = HalloweenOut;
        SaveDatedayo.DotOut = DotOut;
        SaveDatedayo.NagasugitaOut = NagasugitaOut;
        SaveDatedayo.NanikaAttaOut = NanikaAttaOut;
        SaveDatedayo.PicasoOut = PicasoOut;
        

        SaveDatedayo.NezumiAp = NezumiAp;
        SaveDatedayo.SukarabeAp = SukarabeAp;
       
        SaveDatedayo.CatAp = CatAp;
        SaveDatedayo.UsagiAp = UsagiAp;
        SaveDatedayo.SnakeAp = SnakeAp;
        SaveDatedayo.SasoriAp = SasoriAp;
        SaveDatedayo.KawausoAp = KawausoAp;
        SaveDatedayo.RakudaAp = RakudaAp;
        SaveDatedayo.KoburaAp = KoburaAp;
        SaveDatedayo.AmemitAp = AmemitAp;
        SaveDatedayo.LastBossAp = LastBossAp;
        SaveDatedayo.Cook = CookingText.text;

        SaveDatedayo.FlightTimeMinitues = FlightTimeMinitues;
        SaveDatedayo.FlightTimeSeconds = FlightTimeSeconds;

        SaveDatedayo.PCSystemFirst = PCSystemFirst;

        SaveDatedayo.VictoryNezumi2 = VictoryNezumi2;
        SaveDatedayo.HaveHige = HaveHige;
        SaveDatedayo.VictoryUsagi2 = VictoryUsagi2;
        SaveDatedayo.VictoryKawauso2 = VictoryKawauso2;
        SaveDatedayo.Victorysnake2 = Victorysnake2;

        SaveDatedayo.OshiraseMejedo = OshiraseMejedo;
        SaveDatedayo.OshiraseYoutuber = OshiraseYoutuber;
        SaveDatedayo.OshiraseSaraly = OshiraseSaraly;
        SaveDatedayo.OshiraseSanta = OshiraseSanta;
        SaveDatedayo.OshiraseIrasutoya = OshiraseIrasutoya;
        SaveDatedayo.OshiraseHalloween = OshiraseHalloween;
        SaveDatedayo.OshiraseDotPola = OshiraseDotPola;
        SaveDatedayo.OshiraseNagasugi = OshiraseNagasugi;
        SaveDatedayo.OshiraseNanka = OshiraseNanka;
        SaveDatedayo.OshirasePica = OshirasePica;
        SaveDatedayo.OshiraseYusya = OshiraseYusya;
        SaveDatedayo.OshiraseKureo = OshiraseKureo;
        SaveDatedayo.OshiraseGohonke = OshiraseGohonke;
         
        SaveDatedayo.NezumiCount = NezumiCount;
        SaveDatedayo.SukarabeCount = SukarabeCount;
        SaveDatedayo.CatCount = CatCount;
        SaveDatedayo.UsagiCount = UsagiCount;
        SaveDatedayo.SnakeCount = SnakeCount;
        SaveDatedayo.SasoriCount = SasoriCount;
        SaveDatedayo.KawausoCount = KawausoCount;
        SaveDatedayo.RakudaCount = RakudaCount;
        SaveDatedayo.KoburaCount = KoburaCount;
        SaveDatedayo.AmemittCount = AmemittCount;
        SaveDatedayo.LastBossCount = LastBossCount;

        SaveDatedayo.AppearedTotteoki = AppeardTotteoki;
        SaveDatedayo.Message18to19 = Message18to19;

        SaveDatedayo.Timereset = Timereset;

        Save(SaveDatedayo);

    }

    public void Save(SaveDate SaveDatedayo)
    {
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(SaveDatedayo);

        writer = new StreamWriter(Application.persistentDataPath + "/savedata.json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();

    }

    public SaveDate Load()
    {
        if (File.Exists(Application.persistentDataPath + "/savedata.json"))
        {
            string datastr = "";
            StreamReader reader;
            reader = new StreamReader(Application.persistentDataPath + "/savedata.json");
            datastr = reader.ReadToEnd();
            reader.Close();

            return JsonUtility.FromJson<SaveDate>(datastr);
        }

        SaveDate SaveDatedayo2 = new SaveDate();
       
        return SaveDatedayo2;

    }

    public void DoLoad()
    {
        SaveDatedayo = Load();
     
    }

    public void PushPC()
    {
      if(PCSystemFirst)//空港到着後より使用可
        {
            wallNo = WALL_CONVINI;//倉庫
            DisplayWall();
            scrollRectPCSouko.GetComponent<ScrollRect>().verticalNormalizedPosition = 1.0f;

            RefreshMessageText("送るものを選んでね");
            
        }
         
    }

    public void FukkatsuIraira()
    {
    
        if (Victorysukarabe == false && !MejedoOut)
        {
            Iraira.Add(IrairaBuppin[0]);
            Iraira.Add(IrairaBuppin[13]);
            Iraira.Add(IrairaBuppin[14]);
        }
        if (HouseLevel >= 3 && !Victorycat && YouTuberOut == false)
        {
            Iraira.Add(IrairaBuppin[1]);
            Iraira.Add(IrairaBuppin[15]);
            Iraira.Add(IrairaBuppin[16]);
        }
        if (SalarymanIn)
        {
            Iraira.Add(IrairaBuppin[2]);
            Iraira.Add(IrairaBuppin[17]);
            Iraira.Add(IrairaBuppin[18]);
        }
        if (SantaIn)
        {
            Iraira.Add(IrairaBuppin[3]);
            Iraira.Add(IrairaBuppin[19]);
            Iraira.Add(IrairaBuppin[20]);
        }
        if (IrasutoyaIn && MejedoOut)
        {
            Iraira.Add(IrairaBuppin[4]);
            Iraira.Add(IrairaBuppin[21]);
            Iraira.Add(IrairaBuppin[22]);
        }
        if (HalloweenIn)
        {
            Iraira.Add(IrairaBuppin[5]);
            Iraira.Add(IrairaBuppin[23]);
            Iraira.Add(IrairaBuppin[24]);
        }
        if (DotIn && SalarymanOut)
        {
            Iraira.Add(IrairaBuppin[6]);
            Iraira.Add(IrairaBuppin[25]);
          
        }
        if (NagasugitaIn && SantaOut)
        {
            Iraira.Add(IrairaBuppin[7]);
            Iraira.Add(IrairaBuppin[26]);
            Iraira.Add(IrairaBuppin[27]);
        }
        if (NanikaAttaIn && IrasutoyaOut)
        {
            Iraira.Add(IrairaBuppin[8]);
            Iraira.Add(IrairaBuppin[28]);
            Iraira.Add(IrairaBuppin[29]);
        }
        if (PicasoIn && HalloweenOut)
        {
            Iraira.Add(IrairaBuppin[9]);
            Iraira.Add(IrairaBuppin[30]);
            Iraira.Add(IrairaBuppin[31]);
        }
        if (YusyaIn && DotOut)
        {
            Iraira.Add(IrairaBuppin[10]);
            Iraira.Add(IrairaBuppin[32]);
           
        }
        if (KureoPatoraIn && NagasugitaOut)
        {
            Iraira.Add(IrairaBuppin[11]);
            Iraira.Add(IrairaBuppin[34]);
            Iraira.Add(IrairaBuppin[35]);
        }
        if (TotoGoToTravel && GohonkeIn && PicasoOut)
        {
            Iraira.Add(IrairaBuppin[12]);
            Iraira.Add(IrairaBuppin[36]);

        }

        testtime = FukkatsuSpeed;
        FukkatsuSpeedText.GetComponent<Text>().text = testtime.ToString();

        for (int i = 0; i < Iraira.Count; i++)//再びすべてを表示(コルーチンで待機)
        {
            Iraira[i].SetActive(true);
            Iraira[i].GetComponent<CanvasGroup>().alpha = 1;
         
        }
       
    }

    public void FadeOutEnd()
    {
        END.SetActive(true);
        alpha = EndingWhitePanel.color.a;
        Isfadeout = true;
        
    }

    public void Update()
    {
        SaveDatedayo.testtime = testtime;
        Save(SaveDatedayo);
      
        int iracount = Iraira.Count;
        //完全に全部消してからカウントする。
        if (OshiraseMejedo > 0)
        {
            if (iracount <= 0)
            {

                testtime -= Time.deltaTime;
               
                if (testtime < 0)
                {

                    FukkatsuIraira();
                }
                FukkatsuSpeedText.GetComponent<Text>().text = testtime.ToString("f0");

            }
        }

        if (wallNo == 8)
        {
            PCSystemON = true;
        }
        if (FlightTimeMinitues <0)
        {
            bool Arrived = true;
            if (Arrived)
            {
               
                textMessageViwer.EnterOmise();
                Arrived = false;
                FlightTimeMinitues = 5;
            }
                return;
        }
       if(messagesNumber == 22)
        {
            FlightTimeSeconds -= Time.deltaTime;
            if(FlightTimeSeconds < 0)
            {
                FlightTimeMinitues -= 1;
                FlightTimeSeconds = 59;
                
            }
          
            if(wallNo == WALL_OMISE)
            {
                if (YesNoNumber == 0)
                {
                    return;
                }
                else
                {
                    if (FlightTimeMinitues < 0)
                    {
                        RefreshMessageText("");
                        return;
                    }
                    else if (FlightTimeMinitues <= 5)
                    {
        
                        RefreshMessageText("到着まであと " + FlightTimeMinitues + ":" + FlightTimeSeconds.ToString("f0"));
                    }
                    
                 }
            }
           
       }
      
       if(Isfadeout)
        {           
            alpha += fadespeed;
            ChangeColor();
            if(alpha >= 1.5)
            {
                Isfadeout = false;
                
                EndingThankyouPanel.SetActive(true);
                EndingWhitePanel.enabled = false;
                DoraSound.PlayOneShot(DoraSound.clip, 0.5f);


            }
        }

        if (MoneyTextFadestart)//お金の赤文字表示
        {
            plusMoneyText.color = new Color(1, 0.1f, 0.1f, a_color);
            a_color -= Time.deltaTime * 0.5f ;

            if (a_color < 0)
            {
                MoneyTextFadestart = false;
                a_color = 1;
            }
        }
    }

   public void RewardExplanationAppear()
    {
        googleAds.RewardExplanation.SetActive(true);
        if(Iraira.Count > 0)//まだ残っている場合
        {
            GameObject obj = googleAds.RewardExplanation.transform.GetChild(1).gameObject;
            obj.SetActive(true);
            obj = googleAds.RewardExplanation.transform.GetChild(0).gameObject;
            obj.SetActive(false);
            googleAds.YamerumiruPanel.SetActive(true);
            obj = googleAds.YamerumiruPanel.transform.GetChild(0).gameObject;
            obj.SetActive(true);
            obj = googleAds.YamerumiruPanel.transform.GetChild(1).gameObject;
            obj.SetActive(false);

        }
        else//すべて消している場合
        {
            GameObject obj = googleAds.RewardExplanation.transform.GetChild(0).gameObject;
            obj.SetActive(true);
            obj = googleAds.RewardExplanation.transform.GetChild(1).gameObject;
            obj.SetActive(false);
            googleAds.YamerumiruPanel.SetActive(true);
            obj = googleAds.YamerumiruPanel.transform.GetChild(0).gameObject;
            obj.SetActive(true);
            obj = googleAds.YamerumiruPanel.transform.GetChild(1).gameObject;
            obj.SetActive(true);
        }
    }

    public void PushSoundOffButton()
    {
        if (AudioListener.volume != 0)
        {
            AudioListener.volume = 0;
            GameObject obj = SoundButton.transform.GetChild(0).gameObject;
            obj.SetActive(false);
            obj = SoundButton.transform.GetChild(1).gameObject;
            obj.SetActive(true);
        }
        else
        {
            AudioListener.volume = 1;
            GameObject obj = SoundButton.transform.GetChild(0).gameObject;
            obj.SetActive(true);
            obj = SoundButton.transform.GetChild(1).gameObject;
            obj.SetActive(false);
        }
    }

    public void ChangeColor()
    {
        EndingWhitePanel.color = new Color(1, 1, 1, alpha);
    }

    public void PushTwitterButton()
    {
        Application.OpenURL(Twitterlink);
    }

    public void PushOpenMusicLinkButton()
    {
        Application.OpenURL(MusicLink);
    }

    public void PushRestartButton()
    {
        wallNo = WALL_GENKAN;
        DisplayWall();
        if (Iraira.Count > 0)
        {
            for (int i = 0; i < Iraira.Count; i++)//すべて消す
            {
                Iraira[i].SetActive(false);
            }
        }
        startbutton = 0;
        StartExplanation.SetActive(true);
        Debug.Log(startbutton);

        if (File.Exists(Application.persistentDataPath + "/savedata.json"))
        {
           SaveDatedayo = new SaveDate();
        }
        
        Scene ThisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(ThisScene.name);
        Debug.Log(startbutton);
    }

}
