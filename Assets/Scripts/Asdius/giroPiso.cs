using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class giroPiso : MonoBehaviour
{
    GameObject player;
    [SerializeField] Transform posL, posR, posReinicio;
    [SerializeField] GameObject txtGiro;          //cambiar por una lectura en el start
    GameObject gameManager;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController");
        player = GameObject.FindGameObjectWithTag("Player");
        //pendiente que se auto pongan aca los hijos posL posR PosRe
    }
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject== player)
        {
            txtGiro.SetActive(true);
           // print("detecto jugador");
            float moveHorizontal = Input.GetAxis("Horizontal");
            //print(moveHorizontal);
            if (moveHorizontal > 0) //si gira a la derecha...
            {
                if (posR != null)
                {
                    player.transform.position = posR.position;
                    player.transform.rotation = posR.rotation;
                    gameManager.GetComponent<detectorDireccion>().ChangeDirection(moveHorizontal);
                }
                


            }
            else if (moveHorizontal < 0)   //si gira a la izquierda
            {
                if (posL != null)
                {
                    player.transform.position = posL.position;
                    player.transform.rotation = posL.rotation;
                    gameManager.GetComponent<detectorDireccion>().ChangeDirection(moveHorizontal);
                }
                

            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        txtGiro.SetActive(false);
    }




}
