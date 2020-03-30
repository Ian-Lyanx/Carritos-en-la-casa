using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{

    [SerializeField] float health;
    double currentHealth;

    GameObject player;
    


    private void Awake()
    {
        currentHealth = health;
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (currentHealth < health && Time.time > 5 )
        {
            currentHealth += Time.deltaTime * (health * 0.1);
        }
    }

    public void PerderVida()
    {
         
    }
}
