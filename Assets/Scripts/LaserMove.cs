using UnityEngine;
using System.Collections;

public class LaserMove : MonoBehaviour 
{
	public float speed;

	void Start ()
	{
		GetComponent<Rigidbody>().velocity = -transform.right * speed;
	}
}