using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TesOshira : MonoBehaviour
{
    public GameManager gameManager;

    [SerializeField] GameObject oshirasePrefab; // ただのTextをPrefabにしたもの
    public List<GameObject> oshiraseQueue = new List<GameObject>(); // お知らせを順番にスタックする入れ物

    float textScrollSpeed = 150;
    float limitPosition = -850;


    void Update()
    {
        
        if (gameManager.OshiraseMejedo == 1)
        {
            gameManager.OshiraseMejedo += 1;
            CreateNewOshirase("新しい住人がきました");
        }
               
        if (gameManager.OshiraseYoutuber == 1)
        {
                gameManager.OshiraseYoutuber += 1;
                CreateNewOshirase("新しい住人がきました");
        }
        if (gameManager.OshiraseSaraly == 1)
        {
            gameManager.OshiraseSaraly += 1;
            CreateNewOshirase("新しい住人がきました");
        }

        if (gameManager.OshiraseSanta == 1)
        {
            gameManager.OshiraseSanta += 1;
            CreateNewOshirase("新しい住人がきました");
        }

        if (gameManager.OshiraseIrasutoya == 1)
        {
            gameManager.OshiraseIrasutoya += 1;
            CreateNewOshirase("新しい住人がきました");
        }

        if (gameManager.OshiraseHalloween == 1)
        {
            gameManager.OshiraseHalloween += 1;
            CreateNewOshirase("新しい住人がきました");
        }

        if (gameManager.OshiraseDotPola == 1)
        {
            gameManager.OshiraseDotPola += 1;
            CreateNewOshirase("新しい住人がきました");
        }

        if (gameManager.OshiraseNagasugi == 1)
        {
            gameManager.OshiraseNagasugi += 1;
            CreateNewOshirase("新しい住人がきました");
        }

        if (gameManager.OshiraseNanka == 1)
        {
            gameManager.OshiraseNanka += 1;
            CreateNewOshirase("新しい住人がきました");
        }

        if (gameManager.OshirasePica == 1)
        {
            gameManager.OshirasePica += 1;
            CreateNewOshirase("新しい住人がきました");
        }

        if (gameManager.OshiraseYusya == 1)
        {
            gameManager.OshiraseYusya += 1;
            CreateNewOshirase("新しい住人がきました");
        }

        if (gameManager.OshiraseKureo == 1)
        {
            gameManager.OshiraseKureo += 1;
            CreateNewOshirase("新しい住人がきました");
        }

        if (gameManager.OshiraseGohonke == 1)
        {
            gameManager.OshiraseGohonke += 1;
            CreateNewOshirase("新しい住人がきました");
        }

        if (gameManager.NezumiAppear)
        {
            if (gameManager.NezumiCount == 0)
            {
               gameManager.NezumiCount += 1;
                CreateNewOshirase("掲示板に新しい書き込みがありました");
            }
            if (gameManager.ItemRankNumber == 34 || gameManager.ItemRankNumber == 35)
            {
                gameManager.ItemRankNumber = 0;
                 CreateNewOshirase("掲示板に新しい書き込みがありました");
                
            }
        }
        if (gameManager.Appear02)
        {
            if (gameManager.SukarabeCount == 0)
            {
                gameManager.SukarabeCount += 1;
                CreateNewOshirase("掲示板に新しい書き込みがありました");
            }
        }
        if (gameManager.Appear03)
        {
            if (gameManager.CatCount == 0)
            {
                gameManager.CatCount += 1;
                CreateNewOshirase("掲示板に新しい書き込みがありました");
            }
        }
        if (gameManager.Appear04)
        {
            if (gameManager.UsagiCount == 0)
            {
                gameManager.UsagiCount += 1;
                CreateNewOshirase("掲示板に新しい書き込みがありました");
            }
            if (gameManager.messagesNumber == 27)
            {
                if (gameManager.UsagiCount == 1)
                {
                    gameManager.UsagiCount += 1;
                    CreateNewOshirase("掲示板に新しい書き込みがありました");
                }
            }
        }
        if (gameManager.Appear05)
        {
            if (gameManager.SnakeCount == 0)
            {
                gameManager.SnakeCount += 1;
                CreateNewOshirase("掲示板に新しい書き込みがありました");
            }
            if(gameManager.messagesNumber == 38)
            {
                if (gameManager.SnakeCount == 1)
                {
                    gameManager.SnakeCount += 1;
                    CreateNewOshirase("掲示板に新しい書き込みがありました");
                }
            }
        }
        if (gameManager.Appear06)
        {
            if (gameManager.SasoriCount == 0)
            {
                gameManager.SasoriCount += 1;
                CreateNewOshirase("掲示板に新しい書き込みがありました");
            }
        }
        if (gameManager.Appear07)
        {
            if (gameManager.KawausoCount == 0)
            {
                gameManager.KawausoCount += 1;
                CreateNewOshirase("掲示板に新しい書き込みがありました");
            }
            if (gameManager.messagesNumber == 29 || gameManager.messagesNumber == 30 || gameManager.messagesNumber == 31 || gameManager.messagesNumber == 32 || gameManager.messagesNumber == 33)
            {
                if (gameManager.KawausoCount == 1)
                {
                    gameManager.KawausoCount += 1;
                    CreateNewOshirase("掲示板に新しい書き込みがありました");
                }
            }
        }
        if (gameManager.Appear08)
        {
            if (gameManager.RakudaCount == 0)
            {
                gameManager.RakudaCount += 1;
                CreateNewOshirase("掲示板に新しい書き込みがありました");
            }
        }
        if (gameManager.Appear09)
        {
            if (gameManager.KoburaCount == 0)
            {
                gameManager.KoburaCount += 1;
                CreateNewOshirase("掲示板に新しい書き込みがありました");
            }
        }
        if (gameManager.Appear10)
        {
            if (gameManager.AmemittCount == 0)
            {
                gameManager.AmemittCount += 1;
                CreateNewOshirase("掲示板に新しい書き込みがありました");
            }
        }
        if (gameManager.Appear11)
        {
            if (gameManager.LastBossCount == 0)
            {
                gameManager.LastBossCount += 1;
                CreateNewOshirase("掲示板に新しい書き込みがありました");
            }
        }
        /* // デバッグ用 - A/B/C ボタンを押すとメッセージが流れる
         if (Input.GetKeyDown(KeyCode.A))
         {
             CreateNewOshirase("新しい住人がきました");
         }
         else if (Input.GetKeyDown(KeyCode.B))
         {
             CreateNewOshirase("掲示板に新しい書き込みがありました");
         }
         else if (Input.GetKeyDown(KeyCode.C))
         {
             CreateNewOshirase("【お知らせ】2021/12/12 午後1時よりサーバーメンテナンスを行います");
         }*/

        // スクロール処理
        if (oshiraseQueue.Count >= 1)
            {
                //とりあえずプレハブを外側に作っといて、リスト入れといて、それから改めてリスト０の位置情報スクリを取得、代入、外から動かす
                var _rect = oshiraseQueue[0].GetComponent<RectTransform>(); // Updateで毎回GetComponentはあんまりよろしくない

                _rect.anchoredPosition =
                    new Vector3(_rect.anchoredPosition.x - textScrollSpeed * Time.deltaTime,
                    _rect.anchoredPosition.y);

                // 画面外処理（仮）
                if (_rect.anchoredPosition.x <= limitPosition)
                {
                    Destroy(oshiraseQueue[0]);
                    oshiraseQueue.RemoveAt(0);
                }
            }

        }
        void CreateNewOshirase(string _msg)
        {
            var _obj = Instantiate(oshirasePrefab, Vector3.zero, Quaternion.identity);
            var _rect = _obj.GetComponent<RectTransform>();

            _obj.GetComponent<Text>().text = _msg;
            _obj.transform.SetParent(this.transform, false);
            _rect.anchoredPosition = new Vector2(750, 0); // UI上のオブジェクトを動かしたいのでanchoredPositionを使う

            oshiraseQueue.Add(_obj); // 新しいお知らせなのでスタックに積む
        }
}






