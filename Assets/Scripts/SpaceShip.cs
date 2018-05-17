﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour {

	public float shipSpeed = 30;

	public GameObject theBullet;

	void FixedUpdate() {
		float horzMove = Input.GetAxisRaw("Horizontal");

		GetComponent<Rigidbody2D>().velocity = new Vector2 (horzMove, 0) * shipSpeed;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			Instantiate(theBullet, transform.position, Quaternion.identity);
		}
	}
}
