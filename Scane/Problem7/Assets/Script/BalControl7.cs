using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalControl7 : MonoBehaviour
{
     // Tombol untuk menggerakan ke atas
    public KeyCode upButton = KeyCode.W;

    // Tombol untuk menggerakan ke bawah
    public KeyCode downButton = KeyCode.S;

    // Tombol untuk menggerakan ke kanan
    public KeyCode rightButton = KeyCode.D;
    // Tombol Untuk menggerakan ke kiri
    public KeyCode leftButton = KeyCode.A;

    // Kecepatan gerak
    public float speed = 10.0f;

    // Batas atas dan bawah game scene (Batas bawah menggunakan minus (-))
    public float yBoundary = 9.0f;

    // Rigidbody 2D ball ini
    public Rigidbody2D rigidBody2D;

    private Text scoreText;
    
    void Start()
    {
        ScoreScript.score = 0;
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
         rigidBody2D = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        // Dapatkan kecepatan bola sekarang.
        Vector2 velocity = rigidBody2D.velocity;

        // Jika pemain menekan tombol W Bola Akan ke atas (y+)
        if (Input.GetKey(upButton))
        {
            velocity.y = speed;
        }

        // Jika pemain menekan tombol S Bola Akan Kebawah(y-)
        else if (Input.GetKey(downButton))
        {
            velocity.y = -speed;
        }

        // jika pemain menekan tombol D bola akan ke kanan(x)
        else if (Input.GetKey(rightButton))
        {
            velocity.x = speed;
        }

        // Jika pemain menekan tombol ke bawah, beri kecepatan negatif ke komponen y (ke bawah).
        else if (Input.GetKey(leftButton))
        {
            velocity.x = -speed;
        }

        // Jika pemain tidak menekan tombol apa-apa, kecepatannya nol.
        else
        {
            velocity.y = 0.0f;
            velocity.x =0.0f;
        }

        // Masukkan kembali kecepatannya ke rigidBody2D.
        rigidBody2D.velocity = velocity;

        // Dapatkan posisi bola sekarang.
        Vector3 position = transform.position;
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
