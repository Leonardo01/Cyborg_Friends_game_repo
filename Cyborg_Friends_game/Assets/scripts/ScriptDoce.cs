using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDoce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D obj_col_doce){

         if(obj_col_doce.gameObject.tag == "Player"){
            
            // incrementar escore
            Destroy(gameObject);

         }
    }

    
}
