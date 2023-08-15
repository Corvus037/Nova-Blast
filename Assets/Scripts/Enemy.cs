using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Enemy : MonoBehaviour {

  
  public float speed = 1;
    public Text Pontostxt;
    public int Pontos = 0;


    public float startY = 5;

  
  void Awake() {
    transform.position = new Vector3(transform.position.x, startY, transform.position.z);
  }

  
  void Update() {
    transform.Translate(0, -speed * Time.deltaTime, 0);
  }


    


}