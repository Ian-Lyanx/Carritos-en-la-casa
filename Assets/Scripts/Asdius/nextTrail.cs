using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextTrail : MonoBehaviour
{
    raceMision raceM;
    private void Start()
    {
        raceM = GetComponentInParent<raceMision>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            raceM.NextTrail();
        }
    }
}
