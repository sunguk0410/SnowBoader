using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] private ParticleSystem dustEffect;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground") {
            dustEffect.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground") {
            dustEffect.Stop();
        }
    }
}
