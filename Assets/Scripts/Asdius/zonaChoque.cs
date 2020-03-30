using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zonaChoque : MonoBehaviour
{
    [SerializeField] GameObject posReinicio,Fx;

    private void Start()
    {
        Fx.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = posReinicio.transform.position;
            other.GetComponent<movement>().zeroVel();
            Fx.SetActive(true);
            //zona choque sonido hace falta
            Invoke("Ocultar", 2f);
        }
    }
    void Ocultar()
    {
        Fx.SetActive(false);
    }
}
