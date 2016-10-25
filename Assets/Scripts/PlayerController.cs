using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public Vector3 speed;
    Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            rb.velocity = new Vector3( speed.x ,rb.velocity.y, rb.velocity.z);
	}
}
