using UnityEngine;
using GoogleMobileAds.Api;


public class GoogleAds : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject RewardExplanation;

    public GameObject YamerumiruPanel;

    private string adUnitId;
    private RewardedAd rewardedAd;
    // Use this for initialization
    void Start()
    {
        //アプリ起動時に一度必ず実行（他のスクリプトで実行していたら不要）
        MobileAds.Initialize(initStatus => { });
        //広告を表示
        RequestReward();
    }
    private void RequestReward()
    {
#if UNITY_ANDROID
        adUnitId = "ca-app-pub-6030845875548796/4314154807";  //本番
       // adUnitId = "ca-app-pub-3940256099942544/5224354917";  //テスト
#elif UNITY_IOS
        //adUnitId = "広告ユニットIDをコピペ（iOS）";  //本番
        adUnitId = "ca-app-pub-3940256099942544/1712485313";  //テスト
#endif
        this.rewardedAd = new RewardedAd(adUnitId);
        //動画の視聴が完了したら「HandleUserEarnedReward」を呼ぶ
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        AdRequest request = new AdRequest.Builder().Build();
        this.rewardedAd.LoadAd(request);
    }
    //動画の視聴が完了したら実行される（途中で閉じられた場合は呼ばれない）
    public void HandleUserEarnedReward(object sender, Reward args)
    {
        Debug.Log("報酬獲得！");

        gameManager.testtime = 0;
        RequestReward();
    }
    public void ShowReward()
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
        RewardExplanationOff();
    }

    public void RewardExplanationOn()
    {
        gameManager.RewardExplanationAppear();
        
    }

    public void RewardExplanationOff()
    {
        RewardExplanation.SetActive(false);
        YamerumiruPanel.SetActive(false);
    }

}
