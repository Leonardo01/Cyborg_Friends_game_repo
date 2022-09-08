using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    [SerializeField] GameObject [] objetos;
    [SerializeField] float ObjMaxpos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnobjetos",1,1);
        // trocar por coroutine
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnobjetos(){

        int randomnumber = Random.Range(0,objetos.Length);

        float randompos = Random.Range(-ObjMaxpos,ObjMaxpos);

        Vector3 randomspawn = new Vector3(randompos,transform.position.y,transform.position.z);

        Instantiate(objetos[randomnumber],randomspawn,transform.rotation);
    }
}
