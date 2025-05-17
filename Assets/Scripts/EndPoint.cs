using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{
    [SerializeField] ParticleSystem endPointEffect;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            endPointEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ResetLevel", 3f);
        }
    }

    void ResetLevel()
    {
        SceneManager.LoadScene(0);
    }

}
