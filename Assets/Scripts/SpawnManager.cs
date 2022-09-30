//Sandoval Rodríguez Lendy Joanna 1219100438
//GDGS2102-E

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] arrDogs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateAnimal", 1.5F, 1.5F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Se crean los animales de forma aleatoria 
    void CreateAnimal(){

        int aleatorio = Random.Range(0,3);
        int valX = Random.Range(-20,20);

        Instantiate(arrDogs[aleatorio], 
                new Vector3(valX, 
                0, 11), 
                arrDogs[aleatorio].transform.rotation);

    }
}
