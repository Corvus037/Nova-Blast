using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float[] Lanes = new float[3] { -5.0f, 0f, 5.0f };
    public static GameManager instancia;
    public GameObject InimigoPrefab;
    public void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //public static
      //  {

        //}
}
