﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalControl : MonoBehaviour
{
    
    public new Rigidbody2D rigidbody { get; private set; }
    public float speed = 500f;
     private Text scoreText;

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ScoreScript.score = 0;
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        ResetBall();
    }

    public void ResetBall()
    {
        this.rigidbody.velocity = Vector2.zero;
        this.transform.position = Vector2.zero;

        Invoke(nameof(SetRandomTrajectory), 1f);
    }

    private void SetRandomTrajectory()
    {
        Vector2 force = new Vector2();
        force.x = Random.Range(-1f, 1f);
        force.y = -1f;

        this.rigidbody.AddForce(force.normalized * this.speed);
    }
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Kotak"))
        {
            ScoreScript.AddScore(1);
            scoreText.text = "Score : " + ScoreScript.score;
            Destroy(collision.gameObject);
        }
    }

 
}