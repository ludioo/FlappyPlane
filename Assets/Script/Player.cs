using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private AudioManager audioManager;
    public Vector2 jumpForce = new Vector2(0, 300);

    void Start()
    {
        Time.timeScale = 1;
        audioManager = FindObjectOfType<AudioManager>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
            audioManager.sfxJump.Play();
        }

        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }


    void Die()
    {
        audioManager.sfxDie.Play();
        FindObjectOfType<GameManager>().EndGame();
    }
}