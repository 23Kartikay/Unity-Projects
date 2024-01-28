using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float finDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("You Win!!!");
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene",finDelay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}