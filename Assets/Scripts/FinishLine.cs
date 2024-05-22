using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private ParticleSystem finalEffect;
    [SerializeField] private float loadDelay = 1f;
    void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player") {
            finalEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", loadDelay);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
