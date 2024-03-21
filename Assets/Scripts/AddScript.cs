using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
      
        GameManager.Instance.score += 1;
        GameManager.Instance.scoreText.text = " " + Mathf.Round(GameManager.Instance.score);
    }


}
