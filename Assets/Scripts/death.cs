using UnityEngine;

using UnityEngine.SceneManagement; // include so we can load new scenes

public class death : MonoBehaviour {
	void OnCollisionEnter2D (Collision2D other) {
		Debug.Log ("Player State reset.");
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
