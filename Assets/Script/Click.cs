using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Click : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static int score = 10;
    public TextMeshProUGUI scoreText;
    public AudioSource clickSound;
    public GameObject win;

    private void Start()
    {
        score = 10;
    }
    void OnMouseDown()
    {
        score--;

        scoreText.text = "Object Left: " + score;

        if (clickSound != null)
        {
            clickSound.Play();
        }
        if (score == 0)
        {
            win.SetActive(true);
        }

        gameObject.SetActive(false);

    }

}
