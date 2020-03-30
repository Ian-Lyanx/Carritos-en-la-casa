using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{

    GameObject player = GameObject.FindGameObjectWithTag("Player");
    static Dictionary<int, Queue<GameObject>> pool = new Dictionary<int, Queue<GameObject>>();

    public static void PreInstancias(GameObject objetoAInstanciar, int cantidad)
    {
        pool.Add(objetoAInstanciar.GetInstanceID(), new Queue<GameObject>());

        for (int i = 0; i < cantidad; i++)
        {
            GameObject go = Instantiate(objetoAInstanciar) as GameObject;
            pool[objetoAInstanciar.GetInstanceID()].Enqueue(go);
            go.SetActive(false);
        }
    }

    public static void ReutilizarObjeto(GameObject objetoAInstanciar)
    {
        if (pool.ContainsKey(objetoAInstanciar.GetInstanceID()))
        {
            GameObject go = pool[objetoAInstanciar.GetInstanceID()].Dequeue();
            
            go.SetActive(true);
            pool[objetoAInstanciar.GetInstanceID()].Enqueue(go);
        }
    }

}
