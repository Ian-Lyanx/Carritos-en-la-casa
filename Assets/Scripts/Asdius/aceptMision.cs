using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aceptMision : MonoBehaviour
{
    [SerializeField] GameObject misionObjetivos, spaceBarr;
    
    private void Start()
    {
        
        misionObjetivos.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" )
        {
            spaceBarr.SetActive(true);
            if (Input.GetAxis("Jump") != 0)
            {
                misionObjetivos.SetActive(true);
                gameObject.SetActive(false);


            }
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        spaceBarr.SetActive(false);
    }
}
