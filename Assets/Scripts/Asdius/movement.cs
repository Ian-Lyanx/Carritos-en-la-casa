using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    /*
     acel: que tan rapido gana la velocidad
     maxVel: a lo maximo que se movera el vehicul
     vel: su velocidad actual... y no será mas alta que maxVel
     timerR:el aumento de la aceleracion por segundo
         */
   [SerializeField] float acel, maxVel, vel, timerR;
    Rigidbody rb;
    Vector3 movementD;

    public float Vel { get => vel;  }
    public float MaxVel { get => maxVel;  }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movementD = new Vector3(0, 0, 1);

    }


    private void Update()
    {
       
        vel += timerR;

        if (maxVel <= Vel)
        {
            vel = maxVel;
            timerR = 0;
            
        }
        else timerR += Time.deltaTime * acel;//se acelera por segundo la cantidad de aceleracion
    }
    void FixedUpdate()
    {

        transform.position += transform.forward * Vel; //movementD*vel;
       
    }
    public void zeroVel()   //forma rapida de hacer que el jugador baje su velocidad a 0.
    {
        vel = 0;
    }
 
}
