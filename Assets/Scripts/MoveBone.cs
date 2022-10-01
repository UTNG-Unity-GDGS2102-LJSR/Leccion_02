//Sandoval Rodríguez Lendy Joanna 1219100438
//GDGS2102-E 28/09/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBone : MonoBehaviour
{
    //Se declara variable para posicionar el hueso que se mostrará al inicio del juego
    public float distance = 21;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Se indica que el hueso se mueve
        if(transform.position.z > distance){
            Destroy(gameObject);// El objeto es destruido (en este caso el hueso)
        }
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
