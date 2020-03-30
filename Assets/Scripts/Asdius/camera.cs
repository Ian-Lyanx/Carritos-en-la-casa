using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    private Vector3 offset;
    private float multiplicadorOffset, suavizado;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        multiplicadorOffset = 0.4f;
    }
    private void Start()
    {
        offset = transform.position - player.transform.position;
        suavizado = 3f;
    }

    void LateUpdate()
    {
        multiplicadorOffset = (player.GetComponent<movement>().Vel +0.4f) / player.GetComponent<movement>().MaxVel;
        //transform.position = player.transform.position + (offset)*multiplicadorOffset/2;

        Vector3 targetCamPos = player.transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, suavizado * Time.deltaTime);
    }
}
