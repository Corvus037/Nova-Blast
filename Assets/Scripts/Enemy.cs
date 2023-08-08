using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour {

  // The speed at which the enemy falls
  public float speed = 1;

  // The y-coordinate of the enemy's starting position
  public float startY = 5;

  // On awake, start the enemy falling
  void Awake() {
    transform.position = new Vector3(transform.position.x, startY, transform.position.z);
  }

  // On update, move the enemy down
  void Update() {
    transform.Translate(0, -speed * Time.deltaTime, 0);
  }

  // On collision, destroy the enemy
  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Player") {
      SceneManager.LoadScene("GameOver");
      Destroy(this.gameObject);
    }
  }
}