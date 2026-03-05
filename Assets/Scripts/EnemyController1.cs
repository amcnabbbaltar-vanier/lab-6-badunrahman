using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController1 : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator animator;
    private ParticleSystem hitParticles;
    private AudioSource audioSource;
    void Start()
    {
        animator = GetComponent<Animator>();
        hitParticles = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    public void GotHit()
    {
        animator.SetTrigger("GotHit");
        hitParticles.Play();
        audioSource.Play();

        if (GameManager.Instance != null)
        {
            GameManager.Instance.AddScore(1); // Add 1 point per hit
        }


    }

}
