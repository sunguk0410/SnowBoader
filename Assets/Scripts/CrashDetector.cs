using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private ParticleSystem crashEffect;
    [SerializeField] private float loadDelay = 0.5f;
    [SerializeField] private AudioClip crashSPF;
    bool hasCrashed = false;
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Ground" && !hasCrashed) {
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSPF);
            Invoke("ReloadScene", loadDelay);
            hasCrashed = false;
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
