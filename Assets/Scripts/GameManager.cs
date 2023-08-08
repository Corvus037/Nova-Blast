using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float[] Lanes = new float[3] { -5, 0f, 5f };
    public static GameManager instancia;
    public GameObject InimigoPrefab;
    public Text Pontostxt;
    public int Pontos = 0;
    public int Vidas = 3;

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

    
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
        }
        else if (collision.gameObject.tag == "Limit")
        {
            Pontos++;
            Pontostxt.text = "Pontos: " + Pontos; 
            Destroy(this.gameObject);
    
           
        }
    }

    
}
