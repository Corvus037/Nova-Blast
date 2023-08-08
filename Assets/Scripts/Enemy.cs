using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour {

  
  public float speed = 1;

  
  public float startY = 5;

  
  void Awake() {
    transform.position = new Vector3(transform.position.x, startY, transform.position.z);
  }

  
  void Update() {
    transform.Translate(0, -speed * Time.deltaTime, 0);
  }

  
  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Player") {
      SceneManager.LoadScene("GameOver");
      Destroy(this.gameObject);
    }
  }
}