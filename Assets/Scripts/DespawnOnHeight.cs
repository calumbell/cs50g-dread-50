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
        if (transform.position.y < despawnHeight) {
            Destroy(audioSource);
            SceneManager.LoadScene("GameOver");
        }
    }
}
