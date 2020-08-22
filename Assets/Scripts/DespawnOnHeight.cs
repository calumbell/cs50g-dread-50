using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour {
    public float despawnHeight;
    private GameObject audioSource;

    // Start is called before the first frame update
    void Start() {
        audioSource = GameObject.FindGameObjectWithTag("Audio");
    }

    // Update is called once per frame
    void Update() {

        // Check if player has fallen out of level

        if (transform.position.y < despawnHeight) {
            // stop the audio
            Destroy(audioSource);
            // reset level counter
            LevelUI.reset();
            // load next scene
            SceneManager.LoadScene("GameOver");
        }
    }
}
