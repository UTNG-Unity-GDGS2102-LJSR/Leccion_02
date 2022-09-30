//Sandoval Rodríguez Lendy Joanna 1219100438
//GDGS2102-E

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBone : MonoBehaviour
{
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
            Destroy(gameObject);    // El objeto es destruido
        }
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
