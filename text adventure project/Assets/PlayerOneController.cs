using UnityEngine;
using System.Collections;

public class PlayerOneController : MonoBehaviour {
    Vector3 velocity;
    public float walkSpeed;
    public float verticalSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        velocity = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x -= walkSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x += walkSpeed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity.y += verticalSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            velocity.y -= verticalSpeed;
        }

        transform.position += velocity;
    }
}
