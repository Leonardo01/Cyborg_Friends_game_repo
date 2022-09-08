using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    bool canmove = true;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canmove){
            PlayerMove();
        }
    }

    void PlayerMove(){

        float xpos = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * xpos * speed * Time.deltaTime;



    }
}
