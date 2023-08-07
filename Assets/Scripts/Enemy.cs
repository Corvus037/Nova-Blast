using UnityEngine;

public class Enemy : MonoBehaviour {

  
  [SerializeField] private float velocidade = -5;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * velocidade * Time.deltaTime);
    }}