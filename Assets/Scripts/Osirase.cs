using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Osirase : MonoBehaviour
{
    public GameManager gameManager;
    private float textScrollSpeed = 0.8f;
    private float limitPosition = -606f;
    public string[] OshiraseMessages;
    public GameObject oshirase;
    public GameObject oshiraseMonster;

    public GameObject oshiraseprefab;

    private GameObject obj;

    public List<GameObject> OshiraseList = new List<GameObject>();

    public int NezumiCount = 0;

    private float NowOshirasePosition;

    public void Start()
    {
        OshiraseList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ddd");
        if (gameManager.NezumiAppear)
        {
            Debug.Log("ccc");
            if (NezumiCount == 0)
            {
                NezumiCount += 1;
              
                obj.GetComponentInChildren<Text>().text = "掲示板に新しい書き込みがありました";
                OshiraseList.Add(obj);//ここでリスト[1]に入る
            }
            
            if(gameManager.ItemRankNumber == 34 || gameManager.ItemRankNumber == 35)
            {
                Debug.Log("aaa");
                 obj.GetComponentInChildren<Text>().text = "掲示板に新しい書き込みがありました";
                 OshiraseList.Add(obj);//ここでリスト[1]に入る
                oshirase.GetComponent<Text>().text = OshiraseMessages[0];
                MoveTextPanel();
            }
            
               
        }
        if (gameManager.Appear02)
        {
            oshirase.GetComponent<Text>().text = OshiraseMessages[0];
            
        }
        if (gameManager.Appear03)
        {
            oshirase.GetComponent<Text>().text = OshiraseMessages[0];
            MoveTextPanel();
        }
        if (gameManager.Appear04)
        {
            oshirase.GetComponent<Text>().text = OshiraseMessages[0];
            MoveTextPanel();
        }
        if (gameManager.Appear05)
        {
            oshirase.GetComponent<Text>().text = OshiraseMessages[0];
            MoveTextPanel();
        }
        if (gameManager.Appear06)
        {
            oshirase.GetComponent<Text>().text = OshiraseMessages[0];
            MoveTextPanel();
        }
        if (gameManager.Appear07)
        {
            oshirase.GetComponent<Text>().text = OshiraseMessages[0];
            MoveTextPanel();
        }
        if (gameManager.Appear08)
        {
            oshirase.GetComponent<Text>().text = OshiraseMessages[0];
            MoveTextPanel();
        }
        if (gameManager.Appear09)
        {
            oshirase.GetComponent<Text>().text = OshiraseMessages[0];
            MoveTextPanel();
        }
        if (gameManager.Appear10)
        {
            oshirase.GetComponent<Text>().text = OshiraseMessages[0];
            MoveTextPanel();
        }
        if (gameManager.Appear11)
        {
            oshirase.GetComponent<Text>().text = OshiraseMessages[0];
            MoveTextPanel();
        }
        //住人
        if (1 <= gameManager.OshiraseMejedo)
        {
            if (gameManager.OshiraseMejedo == 1)
            {
                gameManager.OshiraseMejedo += 1;
 
                   obj = Instantiate(oshiraseprefab, Vector3.zero, Quaternion.identity);
                    obj.transform.SetParent(this.transform, false);
                RectTransform rect = obj.GetComponent<RectTransform>();

                    rect.anchoredPosition = new Vector2(600, 129);
                obj.GetComponentInChildren<Text>().text = "新しい住人がきました";

               
                OshiraseList.Add(obj);
                
            }
            MoveTextPanel();
        }
        if (1 <= gameManager.OshiraseSaraly)
        {
            if (gameManager.OshiraseSaraly <= 10000)
            {
                //oshirase.GetComponent<Text>().text = OshiraseMessages[2];
                MoveTextPanel();
            }
        }
        if (1 <= gameManager.OshiraseYoutuber)
        {
            if (gameManager.OshiraseYoutuber == 1)
            {
                gameManager.OshiraseYoutuber += 1;
                {
                    obj = Instantiate(oshiraseprefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
                    obj.transform.SetParent(this.transform);

                    obj.transform.position = new Vector3(10f, -4f);

                }
            }
         
        }
        if (1 <= gameManager.OshiraseSanta)
        {
            if (gameManager.OshiraseSanta <= 10000)
            {
                oshirase.GetComponent<Text>().text = OshiraseMessages[2];
                MoveTextPanel();
            }
        }
        if (1 <= gameManager.OshiraseIrasutoya)
        {
            if (gameManager.OshiraseIrasutoya <= 10000)
            {
                oshirase.GetComponent<Text>().text = OshiraseMessages[2];
                MoveTextPanel();
            }
        }
        if (1 <= gameManager.OshiraseHalloween)
        {
            if (gameManager.OshiraseHalloween<= 10000)
            {
                oshirase.GetComponent<Text>().text = OshiraseMessages[2];
                MoveTextPanel();
            }
        }
        if (1 <= gameManager.OshiraseDotPola)
        {
            if (gameManager.OshiraseDotPola <= 10000)
            {
                oshirase.GetComponent<Text>().text = OshiraseMessages[2];
                MoveTextPanel();
            }
        }
        if (1 <= gameManager.OshiraseNagasugi)
        {
            if (gameManager.OshiraseNagasugi <= 10000)
            {
                oshirase.GetComponent<Text>().text = OshiraseMessages[2];
                MoveTextPanel();
            }
        }
        if (1 <= gameManager.OshiraseNanka)
        {
            if (gameManager.OshiraseNanka <= 10000)
            {
                oshirase.GetComponent<Text>().text = OshiraseMessages[2];
                MoveTextPanel();
            }
        }
        if (1 <= gameManager.OshirasePica)
        {
            if (gameManager.OshirasePica <= 10000)
            {
                oshirase.GetComponent<Text>().text = OshiraseMessages[2];
                MoveTextPanel();
            }
        }
        if (1 <= gameManager.OshiraseYusya)
        {
            if (gameManager.OshiraseYusya <= 10000)
            {
                oshirase.GetComponent<Text>().text = OshiraseMessages[2];
                MoveTextPanel();
            }
        }
        if (1 <= gameManager.OshiraseKureo)
        {
            if (gameManager.OshiraseKureo <= 10000)
            {
                oshirase.GetComponent<Text>().text = OshiraseMessages[2];
                MoveTextPanel();
            }
        }
        if (1 <= gameManager.OshiraseGohonke)
        {
            if (gameManager.OshiraseGohonke <= 10000) 
            {
                oshirase.GetComponent<Text>().text = OshiraseMessages[1];
                MoveTextPanel();
            }
        }
        void MoveTextPanel()
        {
           // Debug.Log(OshiraseList.Count);
            if (OshiraseList.Count >= 1)
            {
                Debug.Log("aaaaa");
                RectTransform rect = OshiraseList[0].GetComponent<RectTransform>();
                rect.anchoredPosition = new Vector3(rect.anchoredPosition.x - textScrollSpeed * Time.deltaTime, rect.anchoredPosition.y);

                if (rect.anchoredPosition.x <= limitPosition)
                {
                   // OshiraseList.RemoveAt(0);
                    //元の場所に戻す（Desしない
                    rect.anchoredPosition = new Vector2(600, 129);
                }

            }

        }

    }

}
