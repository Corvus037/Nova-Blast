using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private int pos;
    [SerializeField] private int tipo;
    [SerializeField] private float spawn = 3.0f;
    public List<GameObject> obj;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("RndPos", spawn);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void RndPos()
    {
        int rng = Random.Range(1, 11);
        int rnd = Random.Range(1, 4);
        pos = rnd;
        if (rng <= 8)
        {
            tipo = 1;
        }
        else
        {
            tipo = 0;
        }
        if (pos == 1)
        {
            Instantiate(obj[tipo], new Vector3(-0.53f, 5.13f, -0.26f), Quaternion.identity);
        }
        else if (pos == 2)
        {
            Instantiate(obj[tipo], new Vector3(-5.1f, 5.5f, -0.51f), Quaternion.identity);
        }
        else if (pos == 3)
        {
            Instantiate(obj[tipo], new Vector3(4.98f, 5.22f, 0f), Quaternion.identity);
        }
        Invoke("RndPos", spawn);
    }
}
