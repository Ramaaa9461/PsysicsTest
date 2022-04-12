using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPosition : MonoBehaviour
{
    List<GameObject> platforms = new List<GameObject>();
    void Awake()
    {
        platforms.AddRange(GameObject.FindGameObjectsWithTag("Plataform"));
    }
    private void Start()
    {
        for (int i = 0; i < platforms.Count - 1; i++)
        {
            GameObject aux;
            if (platforms[i].transform.position.y < platforms[i + 1].transform.position.y)
            {
                aux = platforms[i];
                platforms[i] = platforms[i + 1];
                platforms[i + 1] = platforms[i];
            }
        }
        for (int i = 0; i < platforms.Count; i++)
        {
            Debug.Log(platforms[i].transform.position.y);
        }
    }
    void Update()
    {
        
    }
}
