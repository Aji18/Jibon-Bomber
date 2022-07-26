using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private const float speed = 5f;
	private Vector2 direction = Vector2.down;

	private new Rigidbody2D rigidbody { get; private set; }
	// Start is called before the first frame update
	private void Awake()
	{
		rigidbody = GetComponent<Rigidbody2D>();
	}

	void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
		MovePlayer();
    }

	private void MovePlayer()
	{
		if(Input.GetKey(KeyCode.W))
		{
			//new Vector2(0, 1 * speed * Time.fixedDeltaTime);
			SetDirection(Vector2.up);
		}
		else if (Input.GetKey(KeyCode.S))
		{
			//new Vector2(0, -1 * speed * Time.fixedDeltaTime);
			SetDirection(Vector2.down);
		}
		else if (Input.GetKey(KeyCode.D))
		{
			//new Vector2(1 * speed * Time.fixedDeltaTime, 0);
			SetDirection(Vector2.right);
		}
		else if (Input.GetKey(KeyCode.A))
		{
			//new Vector2(-1 * speed * Time.fixedDeltaTime, 0);
			SetDirection(Vector2.left);
		}
	}

	private void FixedUpdate()
	{
		Vector2 position = rigidbody.position;
		Vector2 translation = direction * speed * Time.fixedDeltaTime;

		rigidbody.MovePosition(position + translation);
	}

	private void SetDirection(Vector2 newDirection)
	{
		direction = newDirection;
	}
}
