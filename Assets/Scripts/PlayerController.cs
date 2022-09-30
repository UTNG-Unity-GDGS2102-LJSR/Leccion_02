//Sandoval Rodríguez Lendy Joanna 1219100438
//GDGS2102-E

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject proyectilBone;
    float horInput;
    float limiteMov = 20;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Se limita el campo en que el Player podrá moverse
        if(transform.position.x > limiteMov){ //Se establece el movimiento a la derecha
            transform.position = new Vector3(limiteMov, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -limiteMov){  //Se establece el movimiento a la izquierda
            transform.position = new Vector3(-limiteMov, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space)){ // Se crea un hueso em la posición del Player
            Instantiate(proyectilBone, transform.position, proyectilBone.transform.rotation);
        }

        // Se indican los movimientos del Player
        horInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * 20 * horInput);
    }
}
