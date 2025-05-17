using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollision : MonoBehaviour
{
    [SerializeField] ParticleSystem bottomParticle;
    [SerializeField] ParticleSystem topParticle;
    [SerializeField] AudioClip crashSound;
    
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            bottomParticle.Play();
        }
        if (collision.gameObject.tag == "Obstacle")
        {
            topParticle.Play();
            bottomParticle.Stop();
            GetComponent<AudioSource>().PlayOneShot(crashSound);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            bottomParticle.Stop();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Obstacle")
        {
            topParticle.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSound);
        }
    }

}
