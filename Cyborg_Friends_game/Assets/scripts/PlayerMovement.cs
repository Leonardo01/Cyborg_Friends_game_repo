using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public bool canmove = true;
    [SerializeField] float speed;
    [SerializeField] float maxpos;
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

        float xinputpos = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * xinputpos * speed * Time.deltaTime;

        // Outras formas para mover o player
        

       //transform.Translate(xinputpos,0,0);
       // transform.position += new Vector3(xinputpos,0,0);

        float xpos = Mathf.Clamp(transform.position.x,-maxpos,maxpos);

        transform.position = new Vector3(xpos,transform.position.y,transform.position.z);


    }
}
