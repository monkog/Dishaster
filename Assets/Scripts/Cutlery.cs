﻿using UnityEngine;

public class Cutlery : MonoBehaviour
{
	private const string FloorTag = "Floor";

	private const float Speed = 0.1f;

	private bool _canMove = true;

	public bool CanMove { get { return _canMove; } }

	// Use this for initialization
	void Start()
	{
		_canMove = true;
	}

	// Update is called once per frame
	void Update()
	{
		if (!_canMove) return;

		if (Input.GetKey(KeyCode.LeftArrow))
			transform.Translate(-Speed, 0, 0);
		if (Input.GetKey(KeyCode.RightArrow))
			transform.Translate(Speed, 0, 0);
		if (Input.GetKey(KeyCode.DownArrow))
			transform.Translate(0, -Speed, 0);
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == FloorTag)
			Destroy(gameObject);

		_canMove = false;
	}
}