using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource OnTakeAudio;

    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController playerController = collision.GetComponent<PlayerController>();
        ++playerController.countCoins;
        OnTakeAudio.Play();
        Destroy(gameObject, OnTakeAudio.clip.length);
    }
}
