using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    public static SpawnObjects instance;

    private void Awake(){
        if(instance == null){
            instance = this;
        }
    }
    [SerializeField] GameObject [] objetos;
    [SerializeField] float ObjMaxpos;
    public float SpawnInterval;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("spawnobjetos",1,1);

        Startcospawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnobjetos(){

        int randomnumber = Random.Range(0,objetos.Length);


         if(randomnumber == 4){// Aqui aumento a dificuldade para o spawn de vidas elas ficam mais raras
            randomnumber = Random.Range(0,objetos.Length);
         }

        float randompos = Random.Range(-ObjMaxpos,ObjMaxpos);

        Vector3 randomspawn = new Vector3(randompos,transform.position.y,transform.position.z);

        Instantiate(objetos[randomnumber],randomspawn,transform.rotation);
    }

    IEnumerator StartSpawn(){

        yield return new WaitForSeconds(1f);

        while(true){
            yield return new WaitForSeconds(SpawnInterval);
            spawnobjetos();
        }
    }

    public void Startcospawn(){
        StartCoroutine("StartSpawn");
    }

    public void stopcospawn(){
        StopCoroutine("StartSpawn");
    }
    
}
