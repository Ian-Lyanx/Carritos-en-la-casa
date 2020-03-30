using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    [SerializeField] float cadencia;
    [SerializeField] GameObject prefab,disparoFx;
    [SerializeField] float cD = 0;
    [SerializeField] int cantidad;

    GameObject spawn, spawn2;


    void Awake()
    {
        spawn = GameObject.FindGameObjectWithTag("Spawn");
        spawn2 = GameObject.FindGameObjectWithTag("Spawn2");
    }

    void Start()
    {
        Pool.PreInstancias(prefab, cantidad);
        
    }

    void Update()
    {
        

        if (Input.GetMouseButton(0) && Time.time > cD)
        {
            cD = Time.time + cadencia;
            InstanciarAdelante();
            
        }
        else if (Input.GetMouseButton(1) && Time.time > cD)
        {
            cD = Time.time + cadencia;
            InstanciarAtras();

        }
    }

    void InstanciarAdelante()
    {
        Pool.ReutilizarObjeto(prefab);
        disparoFx.SetActive(true);
    }

    void InstanciarAtras()
    {
        Pool.ReutilizarObjeto(prefab);
    }



}
