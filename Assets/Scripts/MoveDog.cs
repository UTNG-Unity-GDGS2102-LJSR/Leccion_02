//Sandoval Rodríguez Lendy Joanna 1219100438
//GDGS2102-E

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDog : MonoBehaviour
{
    float limite = 23;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -limite){
            Destroy(gameObject);    // El objeto es destruido
        }
        transform.Translate(Vector3.forward * Time.deltaTime * 15);
    }
}
