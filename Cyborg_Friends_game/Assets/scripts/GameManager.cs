using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    private void Awake(){

       instance = this;
    }

    int Score = 0;
    int lifes = 3;
    bool GameOver = false;
    public GameObject player;
    public GameObject GameOverPanel;
    public GameObject LifePanel;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     //        print(lifes);
    }

    public void incrementarScore(){
        if(!GameOver){
        Score ++;
        ScoreText.text = Score.ToString();
        }
    }

    public void decrementlifes(){

        if(lifes > 0){

            lifes--;
            LifePanel.transform.GetChild(lifes).gameObject.SetActive(false);
        }else if(lifes == 0){
           Gameoverf();
        }
    }

    public void Gameoverf(){
        GameOver = true;
        GameOverPanel.SetActive(true);
        SpawnObjects.instance.SpawnInterval = 0;
        GameObject.Find("Player").GetComponent<PlayerMovement>().canmove = false;
    }

    public void GiveLife(){ // preciso terminar aqui.... 
        if(lifes < 2){

        lifes += 1;  
        LifePanel.transform.GetChild(lifes).gameObject.SetActive(true);
   
        }      

    }
}
