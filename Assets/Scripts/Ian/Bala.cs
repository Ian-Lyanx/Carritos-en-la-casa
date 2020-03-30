using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    [SerializeField] float velocidad, tiempoDeVida;
    

    GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Start is called before the first frame update
    void OnEnable()
    {
        Invoke("Destruir", tiempoDeVida);
        transform.position = player.transform.position;
        transform.rotation = player.transform.rotation;
    }

    void Destruir()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * velocidad;
    }
}
