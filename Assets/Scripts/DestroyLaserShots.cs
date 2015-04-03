using UnityEngine;
using System.Collections;

public class DestroyLaserShots : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		Destroy(other.gameObject);
	}
}