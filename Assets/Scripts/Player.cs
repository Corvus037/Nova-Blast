using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int LaneAtual = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoverEsquerda();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            MoverDireita();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Coin"))
        {
            
            GameManager.instancia.Pontos++;
            
            GameManager.instancia.Pontostxt.text = "Pontos: " + GameManager.instancia.Pontos;

            
            Destroy(other.gameObject);
        }
    }

    public void MoverEsquerda()
    {
        LaneAtual--;
        if (LaneAtual < 0) LaneAtual = 0;
        float x = GameManager.instancia.Lanes[LaneAtual];
        Vector3 posFinal = new Vector3(x, transform.position.y, transform.position.z);
        transform.position = posFinal;
    }

    public void MoverDireita()
    {
        LaneAtual++;
        if (LaneAtual > GameManager.instancia.Lanes.Length - 1) LaneAtual = GameManager.instancia.Lanes.Length - 1;
        float x = GameManager.instancia.Lanes[LaneAtual];
        Vector3 posFinal = new Vector3(x, transform.position.y, transform.position.z);
        transform.position = posFinal;
    }
}