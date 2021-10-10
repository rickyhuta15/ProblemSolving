using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Tombol untuk menggerakan ke atas
    public KeyCode leftButton = KeyCode.A;

    // Tombol untuk menggerakan ke bawah
    public KeyCode rightButton = KeyCode.D;

    // Kecepatan gerak
    public float speed = 10.0f;

    // Batas atas dan bawah game scene (Batas bawah menggunakan minus (-))
    public float xBoundary = 8.01f;

    // Rigidbody 2D raket ini
    public Rigidbody2D rigidBody2D;

    // Skor pemain
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Dapatkan kecepatan raket sekarang.
        Vector2 velocity = rigidBody2D.velocity;

        // Jika pemain menekan tombol ke atas, beri kecepatan positif ke komponen y (ke atas).
        if (Input.GetKey(leftButton))
        {
            velocity.x = -speed;
        }

        // Jika pemain menekan tombol ke bawah, beri kecepatan negatif ke komponen y (ke bawah).
        else if (Input.GetKey(rightButton))
        {
            velocity.x = speed;
        }

        // Jika pemain tidak menekan tombol apa-apa, kecepatannya nol.
        else
        {
            velocity.x = 0.0f;
        }

        // Masukkan kembali kecepatannya ke rigidBody2D.
        rigidBody2D.velocity = velocity;

        // Dapatkan posisi raket sekarang.
        Vector3 position = transform.position;

        // Jika posisi raket melewati batas atas (xBoundary), kembalikan ke batas atas tersebut.
        if (position.x > xBoundary)
        {
            position.x = xBoundary;
        }

        // Jika posisi raket melewati batas bawah (-yBoundary), kembalikan ke batas atas tersebut.
        else if (position.x < -xBoundary)
        {
            position.x = -xBoundary;
        }

        // Masukkan kembali posisinya ke transform.
        transform.position = position;
    }
    


}
