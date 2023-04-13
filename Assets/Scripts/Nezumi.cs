using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//モンスターそのものにつけるもの
public class Nezumi : MonoBehaviour
{
   public GameManager gameManager;
    public OmiseManager omiseManager;
    //public SaveDate textMessageViwer;
  

    public string Setsumei;

    public GameObject MonsterImage; //個々の姿（パネルの
    public GameObject CookImage2;
    public GameObject CookImage3;
    public GameObject CookImage4;
    public GameObject CookImage5;
    public GameObject CookImage6;
    public GameObject BookofDeadToto;
    public GameObject BookofDeadOsi;

    public int MonsterNumber;   //個々のナンバーを登録。住人Ｎｏと一緒。
     // いたずらねずみ0 すからべ1
    

    public int MonsterHP;

    public string MonsterName;

    public Text ShoritsuText;
    public float Shoritsu;

    public Text MonsterEx;

    public GameObject LastBoss;
    public GameObject Nezumisan;
    public GameObject Usagisan;
    public GameObject Kawausosan;
    public GameObject Snakesan;
    public GameObject Amemitsan;
    void Start()
    {
        //再表示の手順
      
      /*  //料理ボタン表示
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
        }*/
    }

    internal T GetRandom<T>(params T [] Params)
    {
        return Params[Random.Range(0, Params.Length)];
    }

    public void OnClick()   
    {
        if (MonsterNumber != 30 && !gameManager.Shiraberu)
        {
            if (MonsterNumber != 31 && !gameManager.Shiraberu)
            {
                gameManager.MenuPanel.SetActive(false);
                gameManager.MovePanel.SetActive(false);
            }
        }

        //勝率の計算をいれる（もし、特定のアイテムを持っていればあがる。）↓わかんねーから手動
        if (MonsterNumber == 0) //いたずらねずみ
        {
           float damage = gameManager.HaveCrank * 10f + gameManager.HaveBrank * 30f + gameManager.HaveArank * 40f;
           
           float[] ForNezumiShoritsu = new float[]{1.0f,1.0f,1.0f,1.0f,1.0f,1.0f,1.4f,1.4f,1.5f,1.5f,1.5f,2.0f,2.0f,3.0f,3.0f,3.0f,4.0f,4.0f,5.0f,12.0f};

            float DamageRandom = GetRandom(ForNezumiShoritsu);

            Shoritsu = damage * DamageRandom;
       
           
           if(damage  >= 80f)
           {
             ShoritsuText.text = "成功率：いけるかも";
           }
           else if(damage >= 60f)
           {
             ShoritsuText.text = "成功率：まあまあ";
           }
           else
           {
             ShoritsuText.text = "成功率：びみょう";
           }

            //駆除パネルの中身書き換えて表示
            KujyoPanelHyouji();
            //モンスターの絵を移動させる
               LastBoss.transform.localPosition = new Vector2(0, 1800);

            MonsterImage.transform.localPosition = new Vector2(0, 100);
            //説明の変更
            MonsterEx.text = Setsumei;
            //イエスノーナンバーの指定
            gameManager.YesNoNumber = 30;

            //パネル移動トランスレート（キッチンの位置）1000ずつ移動すればいい台所からパネル動かさないで
            gameManager.KujyoPanel.transform.localPosition = new Vector2(1000, 11);

            //ねずみにタッチしたフラグ
            gameManager.NezumiHakken = true;
           
        }

        if(MonsterNumber == 1) //すからべの勝率
        {
            float damage = gameManager.HaveCrank * 10 + gameManager.HaveBrank * 10;

            float[] ForSukarabeShoritsu = new float[] { 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 3.5f, 4.0f, 5.0f, 5.0f, 5.0f, 5.0f, 5.0f, 6.0f };

            float DamageRandom = GetRandom(ForSukarabeShoritsu);

            Shoritsu = damage * DamageRandom;

            //プラネタリウムとうんちのどちらも所持が必要
            if (gameManager.HaveCrank == 1 && gameManager.HaveBrank == 1)
            {
                Shoritsu = 100;
                ShoritsuText.text = "成功率：いけるかも";

            }
            else if(damage >= 20)
            {
                ShoritsuText.text = "成功率：まあまあ";

            }
            else
            {
                ShoritsuText.text = "成功率：びみょう";
            }
            //駆除パネルの中身書き換えて表示
            KujyoPanelHyouji();
            //モンスターの絵を移動させる
            MonsterImage.transform.localPosition = new Vector2(0, 100);
            //説明の変更
            MonsterEx.text = Setsumei;

            //イエスノーナンバーの指定
            gameManager.YesNoNumber = 31;

            //パネル移動トランスレート（玄関の位置）
            gameManager.KujyoPanel.transform.localPosition = new Vector2(0, 11);
           

            //タッチしたフラグ
            gameManager.SukarabeHakken = true;
            omiseManager.ButtonSukarabeImageAppear(); //アイテム表示

        }

        if (MonsterNumber == 2) //ねこの勝率
        {
            float damage = gameManager.HaveCrank * 10 + gameManager.HaveBrank * 100;

            float[] ForCatShoritsu = new float[] { 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 2.0f, 3.5f, 4.0f, 5.0f, 5.0f, 5.0f, 5.0f, 5.0f, 6.0f };

            float DamageRandom = GetRandom(ForCatShoritsu);

            Shoritsu = damage * DamageRandom;

            //超音波があれば１００ぱー、
            if (gameManager.HaveBrank > 0)
            {
                ShoritsuText.text = "成功率：いけるかも";

            }
            else if (damage >= 30)//なべを３つ
            {
                ShoritsuText.text = "成功率：まあまあ";

            }
            else
            {
                ShoritsuText.text = "成功率：びみょう";
            }

            //駆除パネルの中身書き換えて表示
            KujyoPanelHyouji();
            //モンスターの絵を移動させる
            MonsterImage.transform.localPosition = new Vector2(0, 100);
            //説明の変更
            MonsterEx.text = Setsumei;
            //イエスノーナンバーの指定
            gameManager.YesNoNumber = 32;

            //パネル移動トランスレート（キッチンの位置）
            gameManager.KujyoPanel.transform.localPosition = new Vector2(4000, -11);


            //タッチしたフラグ
            gameManager.CatHakken= true;
            omiseManager.ButtonCatImageAppear(); //アイテム表示
        }

        if (MonsterNumber == 3) //うさぎの勝率
        {
            float damage = gameManager.HaveCrank * 10f + gameManager.HaveBrank * 20f + gameManager.HaveArank * 50f;

            float[] ForUsagiShoritsu = new float[] { 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.4f, 1.4f, 1.5f, 1.5f, 1.5f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 3.0f, 4.0f, 5.0f, 12.0f };

            float DamageRandom = GetRandom(ForUsagiShoritsu);

            Shoritsu = damage * DamageRandom;


            if (damage >= 90f)
            {
                ShoritsuText.text = "成功率：いけるかも";
            }
            else if (damage >= 60f)
            {
                ShoritsuText.text = "成功率：まあまあ";
            }
            else
            {
                ShoritsuText.text = "成功率：びみょう";
            }

            //駆除パネルの中身書き換えて表示
            KujyoPanelHyouji();
            //モンスターの絵を移動させる
            MonsterImage.transform.localPosition = new Vector2(0, 100);
            BookofDeadToto.transform.localPosition = new Vector2(0, 1800);
            LastBoss.transform.localPosition = new Vector2(0, 1800);
            BookofDeadOsi.transform.localPosition = new Vector2(0, 1800);
            //説明の変更
            MonsterEx.text = Setsumei;
            //イエスノーナンバーの指定
            gameManager.YesNoNumber = 33;
            
            //パネル移動トランスレート（ダイニング
            gameManager.KujyoPanel.transform.localPosition = new Vector2(3000, -11);


            //タッチしたフラグ
            gameManager.UsagiHakken = true;
            if (!gameManager.PCSystemFirst)
            {
                omiseManager.ButtonUsagiImageAppear(); //アイテム表示
            }
        }
        if (MonsterNumber == 4) //へびの勝率
        {

           ShoritsuText.text = "成功率：？？？";
            

            //駆除パネルの中身書き換えて表示
            KujyoPanelHyouji();
            //モンスターの絵を移動させる
            MonsterImage.transform.localPosition = new Vector2(0, 100);
            //説明の変更
            MonsterEx.text = Setsumei;
            //イエスノーナンバーの指定
            gameManager.YesNoNumber = 34;

            //パネル移動トランスレート（リビング
            gameManager.KujyoPanel.transform.localPosition = new Vector2(4000, -11);


            //タッチしたフラグ
            gameManager.SnakeHakken = true;

            omiseManager.ButtonSnakeImageAppear(); //アイテム表示

        }

        if (MonsterNumber == 5) //さそりの勝率
        {
           
            if(gameManager.HaveBrank >= 3)
            {
                Shoritsu = 40;
            }
            else
            {
                Shoritsu = 0;
            }

            ShoritsuText.text = "成功率：？？？";


            //駆除パネルの中身書き換えて表示
            KujyoPanelHyouji();
            //モンスターの絵を移動させる
            MonsterImage.transform.localPosition = new Vector2(0, 100);
            //説明の変更
            MonsterEx.text = Setsumei;
            //イエスノーナンバーの指定
            gameManager.YesNoNumber = 35;

            //パネル移動トランスレート（ダイニング
            gameManager.KujyoPanel.transform.localPosition = new Vector2(3000, -11);


            //タッチしたフラグ
            gameManager.SasoriHakken = true;
            omiseManager.ButtonSasoriImageAppear(); //アイテム表示

        }

        if (MonsterNumber == 6) //カワウソの勝率
        {
            
            //地図とコンパスのどちらも所持が必要絶対
            if (gameManager.HaveCrank >= 1 && gameManager.HaveBrank >= 1)
            {
                Shoritsu = 100;
                ShoritsuText.text = "成功率：いけるかも";

            }
            else
            {
                Shoritsu = 0;
                ShoritsuText.text = "成功率：びみょう";
            }


            //駆除パネルの中身書き換えて表示
            KujyoPanelHyouji();
            //モンスターの絵を移動させる
            MonsterImage.transform.localPosition = new Vector2(0, 100);
            BookofDeadToto.transform.localPosition = new Vector2(0, 1800);
            LastBoss.transform.localPosition = new Vector2(0, 1800);
            BookofDeadOsi.transform.localPosition = new Vector2(0, 1800);
            //説明の変更
            MonsterEx.text = Setsumei;
            //イエスノーナンバーの指定
            gameManager.YesNoNumber = 36;

            //パネル移動トランスレート（風呂
            gameManager.KujyoPanel.transform.localPosition = new Vector2(2000, -11);


            //タッチしたフラグ
            gameManager.KawausoHakken = true;
            omiseManager.ButtonKawausoImageAppear(); //アイテム表示

        }
        if (MonsterNumber == 7) //ラクダの勝率
        {
                ShoritsuText.text = "成功率：？？？";
            CookImage2.transform.localPosition = new Vector2(0, 1800);
            CookImage3.transform.localPosition = new Vector2(0, 1800);
            CookImage4.transform.localPosition = new Vector2(0, 1800);
            CookImage5.transform.localPosition = new Vector2(0, 1800);

            //駆除パネルの中身書き換えて表示
            KujyoPanelHyouji();
            //モンスターの絵を移動させる
            MonsterImage.transform.localPosition = new Vector2(0, 100);
            //説明の変更
            MonsterEx.text = Setsumei;
            //イエスノーナンバーの指定
            gameManager.YesNoNumber = 37;

            //パネル移動トランスレート（ガレージ
            gameManager.KujyoPanel.transform.localPosition = new Vector2(5000, -11);


            //タッチしたフラグ
            gameManager.RakudaHakken = true;
            omiseManager.ButtonRakudaImageAppear(); //アイテム表示

        }
       
        if (MonsterNumber == 20)//料理ボタン-------------------------
        {
            //アメミット画像の移動
            Amemitsan.transform.localPosition = new Vector2(0, 1800);
            //イエスノーナンバーの指定
            gameManager.YesNoNumber = 38;
            //料理するかどうかを、はいいいえボタンで選ぶ
            gameManager.YesNoButtonPanel.SetActive(true);
            gameManager.RefreshMessageText("持ってる材料で料理する？");
        }

        if (MonsterNumber == 8) //コブラの勝率
        {

            ShoritsuText.text = "成功率：？？？";


            //駆除パネルの中身書き換えて表示
            KujyoPanelHyouji();
            //モンスターの絵を移動させる
            MonsterImage.transform.localPosition = new Vector2(0, 100);
            //説明の変更
            MonsterEx.text = Setsumei;
            //イエスノーナンバーの指定
            gameManager.YesNoNumber = 39;

            //パネル移動トランスレート
            gameManager.KujyoPanel.transform.localPosition = new Vector2(4000, -11);


            //タッチしたフラグ
            gameManager.KoburaHakken = true;
            omiseManager.ButtonKoburaImageAppear(); //アイテム表示

        }

        if (MonsterNumber == 9) //あめみっとの勝率
        {

            ShoritsuText.text = "成功率：？？？";

            CookImage2.transform.localPosition = new Vector2(0, 1800);
            CookImage3.transform.localPosition = new Vector2(0, 1800);
            CookImage4.transform.localPosition = new Vector2(0, 1800);
            CookImage5.transform.localPosition = new Vector2(0, 1800);
            CookImage6.transform.localPosition = new Vector2(0, 1800);

            //駆除パネルの中身書き換えて表示
            KujyoPanelHyouji();
            //モンスターの絵を移動させる
            MonsterImage.transform.localPosition = new Vector2(0, 100); 
            //説明の変更
            MonsterEx.text = Setsumei;
            //イエスノーナンバーの指定
            gameManager.YesNoNumber = 40;

            //パネル移動トランスレート（ガレージ
            gameManager.KujyoPanel.transform.localPosition = new Vector2(5000, -11);


            //タッチしたフラグ
            gameManager.AmemittHekken = true;
            omiseManager.ButtonAmemittImageAppear(); //アイテム表示

        }

        if (MonsterNumber == 10) //スフィンクスの勝率
        {

            ShoritsuText.text = "成功率：？？？";

            //駆除パネルの中身書き換えて表示
            KujyoPanelHyouji();
            //モンスターの絵を移動させる
            Nezumisan.transform.localPosition = new Vector2(0, 1800);
            Usagisan.transform.localPosition = new Vector2(0, 1800);
            Kawausosan.transform.localPosition = new Vector2(0, 1800);
            Snakesan.transform.localPosition = new Vector2(0, 1800);
            MonsterImage.transform.localPosition = new Vector2(0, 100);
         
            //説明の変更
            MonsterEx.text = Setsumei;
            //イエスノーナンバーの指定
            gameManager.YesNoNumber = 43;
         
            //パネル移動トランスレート
            gameManager.KujyoPanel.transform.localPosition = new Vector2(5000, -11);

            if (gameManager.HaveHige)
            {
                gameManager.YesNoButtonPanel.SetActive(true);
                gameManager.RefreshMessageText("ひげを渡す？");
            }
            //タッチしたフラグ
            gameManager.LastBossHakken = true;
          　

        }

        if(MonsterNumber == 30 && gameManager.Shiraberu)//死者の書オシリス審判
        {
           
            ShoritsuText.text = "";
            //駆除パネルの中身書き換えて表示
            KujyoPanelHyouji();
            //モンスターの絵を移動させる
            Nezumisan.transform.localPosition = new Vector2(0, 1800);
            Usagisan.transform.localPosition = new Vector2(0, 1800);
            Kawausosan.transform.localPosition = new Vector2(0, 1800);
            Snakesan.transform.localPosition = new Vector2(0, 1800);
            LastBoss.transform.localPosition = new Vector2(0, 1800);
            BookofDeadToto.transform.localPosition = new Vector2(0, 1800);

            BookofDeadOsi.transform.localPosition = new Vector2(0, 70);

            //説明の変更
            MonsterEx.text = Setsumei;
            //パネル移動トランスレート（風呂
            gameManager.KujyoPanel.transform.localPosition = new Vector2(2000, -11);

        }
        if (MonsterNumber == 31 && gameManager.Shiraberu)//死者の書トト
        {
          
            ShoritsuText.text = "";
            //駆除パネルの中身書き換えて表示
            KujyoPanelHyouji();
            //モンスターの絵を移動させる
            Nezumisan.transform.localPosition = new Vector2(0, 1800);
            Usagisan.transform.localPosition = new Vector2(0, 1800);
            Kawausosan.transform.localPosition = new Vector2(0, 1800);
            Snakesan.transform.localPosition = new Vector2(0, 1800);
            LastBoss.transform.localPosition = new Vector2(0, 1800);
            BookofDeadOsi.transform.localPosition = new Vector2(0, 1800);
            BookofDeadToto.transform.localPosition = new Vector2(0, 80);

            //説明の変更
            MonsterEx.text = Setsumei;
            //パネル移動トランスレート（ダイニング
            gameManager.KujyoPanel.transform.localPosition = new Vector2(3000, -11);

        }
        gameManager.DoSave();//せーぶ
    }

   public void KujyoPanelHyouji()
    {
        gameManager.KujyoPanel.SetActive(true);

        gameManager.KujyoName.GetComponent<Text>().text = MonsterName;

        //駆除するかどうかを、はいいいえボタンで選ぶ
        if(MonsterNumber == 10)//ひげもってれば選択肢だす
        {
            return;
        }
        if (MonsterNumber != 30 && MonsterNumber != 31)
        {
            gameManager.YesNoButtonPanel.SetActive(true);

            gameManager.RefreshMessageText("駆除する？");
        }
     
    }

    public void CookingtTamePanel()
    {
        gameManager.RefreshMessageText("ターメイヤができた！");
        gameManager.KujyoPanel.SetActive(true);
        gameManager.KujyoPanel.transform.localPosition = new Vector2(1000, -11);
        //ターメイヤの画像表示
        MonsterImage.transform.localPosition = new Vector2(0, 100);
       
        CookImage2.transform.localPosition = new Vector2(0, 1800);
        CookImage3.transform.localPosition = new Vector2(0, 1800);
        CookImage4.transform.localPosition = new Vector2(0, 1800);
        CookImage5.transform.localPosition = new Vector2(0, 1800);
        CookImage6.transform.localPosition = new Vector2(0, 1800);

        gameManager.KujyoName.GetComponent<Text>().text = "ターメイヤ";
        //説明の変更
        MonsterEx.text = "そら豆で作ったコロッケ。";
        ShoritsuText.text = "";
        gameManager.YesNoButtonPanel.SetActive(false);
    }

    public void CookingtCurryPanel()
    {
        gameManager.RefreshMessageText("カレーができた！");
        gameManager.KujyoPanel.SetActive(true);
        gameManager.KujyoPanel.transform.localPosition = new Vector2(1000, -11);
        //カレーの画像表示
        CookImage2.transform.localPosition = new Vector2(0, 100);
        
        CookImage3.transform.localPosition = new Vector2(0, 1800);
        CookImage4.transform.localPosition = new Vector2(0, 1800);
        CookImage5.transform.localPosition = new Vector2(0, 1800);
        CookImage6.transform.localPosition = new Vector2(0, 1800);

        gameManager.KujyoName.GetComponent<Text>().text = "カレー";
        //説明の変更
        MonsterEx.text = "普通にカレー";
        ShoritsuText.text = "";
        gameManager.YesNoButtonPanel.SetActive(false);
    }

    public void CookingtCrocketPanel()
    {
        gameManager.RefreshMessageText("ポテトコロッケができた！");
        gameManager.KujyoPanel.SetActive(true);
        gameManager.KujyoPanel.transform.localPosition = new Vector2(1000, -11);
        //コロッケの画像表示
        CookImage3.transform.localPosition = new Vector2(0, 100);

        CookImage2.transform.localPosition = new Vector2(0, 1800);
        CookImage4.transform.localPosition = new Vector2(0, 1800);
        CookImage5.transform.localPosition = new Vector2(0, 1800);
        CookImage6.transform.localPosition = new Vector2(0, 1800);

        gameManager.KujyoName.GetComponent<Text>().text = "ポテトコロッケ";
        //説明の変更
        MonsterEx.text = "じゃがいもにパン粉をつけて揚げたもの。";
        ShoritsuText.text = "";
        gameManager.YesNoButtonPanel.SetActive(false);

    }

    public void CookingtlicoriceCurryPanel()
    {
        gameManager.RefreshMessageText("タイヤ味のカレー（食用）ができた！");
        gameManager.KujyoPanel.SetActive(true);
        gameManager.KujyoPanel.transform.localPosition = new Vector2(1000, -11);
        //タイヤカレーの画像表示
        CookImage4.transform.localPosition = new Vector2(0, 100);

        CookImage2.transform.localPosition = new Vector2(0, 1800);
        CookImage3.transform.localPosition = new Vector2(0, 1800);
        CookImage5.transform.localPosition = new Vector2(0, 1800);
        CookImage6.transform.localPosition = new Vector2(0, 1800);

        gameManager.KujyoName.GetComponent<Text>().text = "タイヤカレー（食用）";
        //説明の変更
        MonsterEx.text = "まずそーーっ！";
        ShoritsuText.text = "";
        gameManager.YesNoButtonPanel.SetActive(false);
    }
    public void CookingMermiteHatuPanel()
    {
        gameManager.RefreshMessageText("マーマイト詰めハツができた！");
        gameManager.KujyoPanel.SetActive(true);
        gameManager.KujyoPanel.transform.localPosition = new Vector2(1000, -11);
        //マーマイトハツの画像表示
        CookImage5.transform.localPosition = new Vector2(0, 100);

        CookImage2.transform.localPosition = new Vector2(0, 1800);
        CookImage3.transform.localPosition = new Vector2(0, 1800);
        CookImage4.transform.localPosition = new Vector2(0, 1800);
        CookImage6.transform.localPosition = new Vector2(0, 1800);

        gameManager.KujyoName.GetComponent<Text>().text = "マーマイト詰めハツ";
        //説明の変更
        MonsterEx.text = "中にマーマイトをたっぷり詰めた特製ハツ。";
        ShoritsuText.text = "";
        gameManager.YesNoButtonPanel.SetActive(false);
    }
    public void CookingUmaiTareHatuPanel()
    {
        gameManager.RefreshMessageText("タレ味のハツができた！");
        gameManager.KujyoPanel.SetActive(true);
        gameManager.KujyoPanel.transform.localPosition = new Vector2(1000, -11);
        //マーマイトハツの画像表示
        CookImage6.transform.localPosition = new Vector2(0, 100);

        CookImage2.transform.localPosition = new Vector2(0, 1800);
        CookImage3.transform.localPosition = new Vector2(0, 1800);
        CookImage4.transform.localPosition = new Vector2(0, 1800);
        CookImage5.transform.localPosition = new Vector2(0, 1800);

        gameManager.KujyoName.GetComponent<Text>().text = "タレ味のハツ";
        //説明の変更
        MonsterEx.text = "おいしいタレがたっぷりのハツ。";
        ShoritsuText.text = "";
        gameManager.YesNoButtonPanel.SetActive(false);
    }
}
