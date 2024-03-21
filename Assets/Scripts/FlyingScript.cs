using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingScript : MonoBehaviour
{
    public GameManager gameManager;
    
    // Bat's Stats
    public float velocity = 1;
    private Rigidbody2D rb;
    public Animator animate;
    public float flappingLasting;

    // Bat's Sound effects
    public AudioSource flappingEffect;
    public AudioSource crashEffect;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        flappingLasting = Random.Range(1, 2);

    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocity * 2;
            flappingEffect.Play();
            animate.SetBool("clickOn", true);
            flappingLasting -= Time.deltaTime;
        }
        if (flappingLasting <= 0)
        {
            flappingLasting = Random.Range(1, 2);
            animate.SetBool("clickOn", false);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        gameManager.GameOver();
        crashEffect.Play();

        
    }

  

}
