using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptObjects : MonoBehaviour
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

         if(obj_col.gameObject.tag == "Player"){
            
            
            GameManager.instance.incrementarScore();
            Destroy(gameObject);

         }else if(obj_col.gameObject.tag == "Boundary"){
            GameManager.instance.decrementlifes();
            Destroy(gameObject);
         }
    }

}
