using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    private void Awake(){

       instance = this;
    }

    int Score;
    int lifes = 3;
    public GameObject player;
    public GameObject GameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void incrementarScore(){
        Score ++;
        print("Pontos: " + Score.ToString() );
    }

    public void decrementlifes(){

        if(lifes > 0){

            lifes--;
            print("Vidas: " + lifes);
        }else if(lifes == 0){
           Gameover();
        }
    }

    public void Gameover(){
        GameOverPanel.SetActive(true);
        SpawnObjects.instance.SpawnInterval = 0;
        GameObject.Find("Player").GetComponent<PlayerMovement>().canmove = false;
    }

}
