using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Vector3 JumpSpeed;
	public Vector3 MoveSpeed;
	public float incMoveSpeed = 0.0001f;

	public Transform InputCamera;
	public Vector3 JumpLimit;

	private Rigidbody _rigidBody;
    private int _coins;

    private void Awake()
	{
		_rigidBody = this.GetComponent<Rigidbody>();
	}

	// Use this for initialization
	void Start () {
		transform.position += MoveSpeed * Time.deltaTime;
	   

	}

	// Update is called once per frame
	void Update () {
		MovePlayer();
		Debug.Log(InputCamera.rotation.eulerAngles);
		Debug.Log(360 + JumpLimit.x);
		if ( InputCamera.rotation.eulerAngles.x - 360 > JumpLimit.x && _rigidBody.velocity == Vector3.zero)
		{
			Jump();
		}
	}

	void MovePlayer()
	{
		MoveSpeed += MoveSpeed.normalized * incMoveSpeed;
		transform.position += MoveSpeed * Time.deltaTime ;
	}

	public void Jump()
	{
		_rigidBody.velocity += JumpSpeed;
	}

    public void TakeCoin(Coin coin)
    {
        _coins += coin.Value;
    }
}
