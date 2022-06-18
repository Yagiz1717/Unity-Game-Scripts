using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    //Script
    public BirdScript BirdScript;
    public GoldScript GoldScript;
    

    //Text
    public Text ScoreText;
    public Text DeathScoreText;
    public Text BestScoreText;
    public Text GoldScoreText;
    public Text ShopGoldText;
    public Text RedBirdPriceText;
    public Text BlueBirdPriceText;
    public Text YellowBirdPriceText;

    //GameObject
    public GameObject DeathScreen;
    public GameObject PlayScreen;
    public GameObject ShopScreen;
    public GameObject MenuBackgroundObject;
    public GameObject YellowBirdObject;
    public GameObject RedBirdObject;
    public GameObject BlueBirdObject;
    public GameObject RedBirdButton;
    public GameObject YellowBirdButton;

    //Audio
   


    //Veriable
    public int GameScore;
    public static int GoldScore;
    public static int BestScore;
    int RedPrice=2;
    int BluePrice = 3;
    


    public static bool RedBirdSelectControl;
    public static bool BlueBirdSelectControl;
    public static bool YellowBirdSelectControl=true;

    public static bool BlueBirdBuyedControl = false;
    public static bool RedBirdBuyedControl = false;

    public static int x;

    

    void Start()
    {
       
        if (BlueBirdBuyedControl==false)
        {
            BlueBirdPriceText.text = BluePrice.ToString();
        }
        else
        {
            BlueBirdPriceText.text = "Buyed";
        }
        if (RedBirdBuyedControl == false)
        {
            RedBirdPriceText.text = RedPrice.ToString();
        }
        else{
            RedBirdPriceText.text = "Buyed";
        }
        if (RedBirdSelectControl==true)
        {
            RedBirdObject.SetActive(true);
            YellowBirdObject.SetActive(false);
            BlueBirdObject.SetActive(false);
        }
        if (BlueBirdSelectControl==true)
        {
            BlueBirdObject.SetActive(true);
            YellowBirdObject.SetActive(false);
            RedBirdObject.SetActive(false);
        }
        if (YellowBirdSelectControl==true)
        {
            YellowBirdObject.SetActive(true);
            RedBirdObject.SetActive(false);
            BlueBirdObject.SetActive(false);
        }
    }
    void Update()
    {
        if (GameScore>BestScore)
        {
            BestScore = GameScore;
        }
    }

    public void BirdDeath()
    {
        BirdScript.dead = true;
        DeathScreen.SetActive(true);
        DeathScoreText.text = GameScore.ToString();
        BestScoreText.text = BestScore.ToString();
        GoldScoreText.text = GoldScore.ToString();
        Time.timeScale = 0;
    }
    public void ScoreUpdate()
    {
        GameScore++;
        ScoreText.text = GameScore.ToString();  
    }
    public void GoldUpdate()
    {
        GoldScore++;
    }
    public void PlayGame()
    {
        Time.timeScale = 1;
        DeathScreen.SetActive(false);
        ShopScreen.SetActive(false);
        PlayScreen.SetActive(true);
        MenuBackgroundObject.SetActive(false);
        BirdScript.dead = false;
        SceneManager.LoadScene(0);
    }   
    public void RedButton()
    {
        if (RedBirdBuyedControl == false)
        {
            if (GoldScore >= RedPrice)
            {
                GoldScore -= RedPrice;
                RedBirdBuyedControl = true;
                RedBirdSelectControl = true;
                BlueBirdSelectControl = false;
                YellowBirdSelectControl = false;
                RedBirdPriceText.text = "Buyed";
                ShopGoldText.text = "Gold; " + GoldScore.ToString();
            }
        }
        if (RedBirdBuyedControl == true)
        {
            BlueBirdSelectControl = false;
            RedBirdSelectControl = true;
            YellowBirdSelectControl = false;
        }
    }
    public void BlueButton()
    {
        if (BlueBirdBuyedControl==false)
        {
            if (GoldScore >= BluePrice)
            {
                GoldScore -= BluePrice;
                BlueBirdBuyedControl = true;
                BlueBirdSelectControl = true;
                RedBirdSelectControl = false;
                YellowBirdSelectControl = false;
                BlueBirdPriceText.text = "Buyed";
                ShopGoldText.text = "Gold; " + GoldScore.ToString();
            }
        }
        if (BlueBirdBuyedControl==true)
        {
            BlueBirdSelectControl = true;
            RedBirdSelectControl = false;
            YellowBirdSelectControl = false;
        }
    }
    public void YellowButton()
    {
        YellowBirdSelectControl = true;
        RedBirdSelectControl = false;
        BlueBirdSelectControl = false;
    }
    public void Menu()
    { 
        MenuBackgroundObject.SetActive(true);
        DeathScreen.SetActive(false);
        ShopScreen.SetActive(true);
        PlayScreen.SetActive(false);
        ShopGoldText.text+= " "+GoldScore.ToString();
        ScoreText.text = " ";
        if (RedBirdSelectControl==true)
        {
            RedBirdPriceText.text = "Buyed";
        }
        if (BlueBirdSelectControl==true)
        {
            BlueBirdPriceText.text = "Buyed";
        }
        if (YellowBirdSelectControl==true)
        {
            YellowBirdPriceText.text = "Buyed";
        }
    }
}
