using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raceMision : MonoBehaviour
{
   [SerializeField] GameObject[] Objetivos;
    [SerializeField] GameObject win;
    int objetivoActual;
    
    private void Start()
    {
        
        for (int i = 1; i >= Objetivos.Length; i++)
        {
            Objetivos[i].SetActive(false);
        }
        Objetivos[0].SetActive(true);
        objetivoActual = 1;
    }
    private void OnEnable()
    {
        for (int i = 1; i < Objetivos.Length; i++)
        {
            Objetivos[i].SetActive(false);
        }
        Objetivos[0].SetActive(true);
        objetivoActual = 1;
    }

    public void NextTrail()
    {
        if(objetivoActual<Objetivos.Length)
        
        {
            Objetivos[objetivoActual].SetActive(true);
            Objetivos[objetivoActual - 1].SetActive(false);
            objetivoActual++;
        }
        else  //si es nulo es porque llego a la meta
        {
            Objetivos[objetivoActual - 1].SetActive(false);
            win.SetActive(true);
        }
        
    }
}
