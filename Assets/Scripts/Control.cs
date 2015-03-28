using System;
using UnityEngine;

namespace Assets.Scripts
{
    [Serializable]
    public class Boundary
    {
        public float XMin, XMax, YMin, YMax;
    }
    
    public class Control : MonoBehaviour
    {
        public Transform Projectile;
        public float Speed;
        public float Tilt;
        public Boundary Boundary;
        private Rigidbody _rigidbody;

        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(Projectile, _rigidbody.position, _rigidbody.rotation);
            }
        }

        void FixedUpdate()
        {
            var moveHorizontal = Input.GetAxis("Horizontal");
            var moveVertical = Input.GetAxis("Vertical");

            var movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
            _rigidbody.velocity = movement * Speed;

            _rigidbody.position = new Vector3
                (
                Mathf.Clamp(_rigidbody.position.x, Boundary.XMin, Boundary.XMax),
                Mathf.Clamp(_rigidbody.position.y, Boundary.YMin, Boundary.YMax),
                0.0f
                );

            _rigidbody.rotation = Quaternion.Euler(_rigidbody.velocity.y * -Tilt, 180.0f, 0.0f);
        }

        public void OnTriggerEnter(Collider col)
        {
            Debug.Log(col.name);
        }
    }
}