using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifescript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D obj_col){

         if(obj_col.gameObject.tag == "Player"){// preciso terminar aqui.... 

               GameManager.instance.GiveLife();
               Destroy(gameObject);               

             }else if(obj_col.gameObject.tag == "Boundary"){
                Destroy(gameObject);
             }

    }
}
