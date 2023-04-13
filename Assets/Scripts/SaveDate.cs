using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[System.Serializable]
public class SaveDate 
{

        public  int ItemRankNumber;
        public  float HaveArank;
        public  float HaveBrank;
        public  float HaveCrank;
        public  bool HaveRakudaA;
        public  bool HaveRakudaB;
        public  bool HaveRakudaC;
        public  int HaveAArank;
        public  int HaveBBrank;
        public  int HaveCCrank;
        public int HaveHatu;
        public int HaveMermait;
        public int HaveUmaiTare;
    public int HaveFrightChicket;

    public  int HaveDrank;
        public  int HaveErank;
        public   int HaveFrank;
        public  int HavePotechi;
        public  int Havelicorice;
        public  int HaveTube;
        public  bool HaveTameiya;
        public  bool HaveCurry;
        public  bool HavePotatoCrocket;
        public  bool HaveTubeCurry;
        public  bool HaveTotteoki;
        public  bool HaveMermiteHatu;
        public  bool HaveTareHatu;
        public bool HaveInstrumental;
        public bool HaveNinjaSet;
        public bool HaveChinaScroll;
        public bool HaveSukarabeScroll;
        public bool HaveYUYUgiohCard;
        public bool HaveEjimonbawl;

    public  bool VictoryNezumi;
        public  bool Victorysukarabe;
        public  bool Victorycat;
        public  bool Victoryusagi;
        public  bool Victorysnake;
        public  bool Victorysasori;
        public  bool Victorykawauso;
        public  bool Victoryrakuda;
        public  bool Victorykobura;
        public  bool Victoryamemitt;

        public  bool TotoGoToTravel;
        public  bool Victorylastboss;

        public  int needmoney; //OmiseManagerから代入される


        public  bool NezumiAppear;
        public  bool Appear02;
        public  bool Appear03;
        public  bool Appear04;
        public  bool Appear05;
        public  bool Appear06;
        public  bool Appear07;
        public  bool Appear08;
        public  bool Appear09;
        public  bool Appear10;
        public  bool Appear11;

        public  bool NezumiHakken;
        public  bool SukarabeHakken;
        public  bool CatHakken;
        public  bool UsagiHakken;
        public  bool SnakeHakken;
        public  bool SasoriHakken;
        public  bool KawausoHakken;
        public  bool RakudaHakken;
        public  bool KoburaHakken;
        public  bool AmemittHekken;
        public bool LastBossHakken;

        public  int messagesNumber;

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

    
    //掲示板を見てモンスターを出現させたかどうか判定
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

    public  int bakudanNumber;   //ばくだん所持数
        public  int money;          //所持金
        public  int moneyPlus;
        public  float HouseLevel;    //家レベ

    public List<KujyoItemScriptable> items;
    

    public string Cook;

    //フライトタイム
    public int FlightTimeHour;
    public int FlightTimeMinitues;
    public double FlightTimeSeconds;
    //PC
    public bool PCSystemFirst;
  
    public bool VictoryNezumi2;
    public bool HaveHige;
    public bool VictoryUsagi2;
    public bool VictoryKawauso2;
    public bool Victorysnake2;

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

    public float testtime;
    public bool testtimeswich;

    public bool AppearedTotteoki;

    public bool Message18to19;
    public DateTime starttime;

    public bool Timereset;
}

