//Sandoval Rodríguez Lendy Joanna 1219100438
//GDGS2102-E 28/09/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Colisionador : MonoBehaviour
{
    /*Cuando un GameObject (en este caso los objetos como el animal o el hueso) 
    choca con otro GameObject, es necesario que Unity llame a un OnTriggerEnter
    para poder generar la destrucción del objeto*/
    void OnTriggerEnter(Collider other) 
    {    
        Destroy(gameObject); // El objeto es destruido
    }
    /*Se invoca dicha clase OnTrigger, para la cual se indica que se hará uso 
      de Collider other, el cual hace referencia a una colisión entre objetos
    */
}
