﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKotak : MonoBehaviour
{
    public SpriteRenderer spriteRenderer { get; private set; }
    public Sprite[] states = new Sprite[0];
    public int health { get; private set; }
    public int points = 100;
    public bool unbreakable;

    private void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        ResetBrick();
    }

    public void ResetBrick()
    {
        this.gameObject.SetActive(true);

        if (!this.unbreakable)
        {
            this.health = this.states.Length;
            this.spriteRenderer.sprite = this.states[this.health - 1];
        }
    }
}
