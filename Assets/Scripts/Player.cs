using System;
using UnityEngine;

namespace Assets.Scripts
{
    [Serializable]
    public class Boundary
    {
        public float XMin, XMax, YMin, YMax;
    }
    
    public class Player : MonoBehaviour
    {
        public Transform Projectile;
        public float Speed;
        public float Tilt;
        public Boundary Boundary;
        public Transform ShotLocation;
        private Rigidbody Rigidbody { get { return GetComponent<Rigidbody>(); } }


        public float FireRate = 0.2f;
        private float _nextShot;
        private bool CanShoot { get { return _nextShot < Time.time; } }
        
        void Update()
        {
            if (Input.GetButton("Fire1") && CanShoot)
            {
                Instantiate(Projectile, ShotLocation.position, ShotLocation.rotation);
                _nextShot = Time.time + FireRate;
            }
        }

        void FixedUpdate()
        {
            var moveHorizontal = Input.GetAxis("Horizontal");
            var moveVertical = Input.GetAxis("Vertical");

            var movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
            Rigidbody.velocity = movement * Speed;

            Rigidbody.position = new Vector3
                (
                Mathf.Clamp(Rigidbody.position.x, Boundary.XMin, Boundary.XMax),
                Mathf.Clamp(Rigidbody.position.y, Boundary.YMin, Boundary.YMax),
                0.0f
                );

            Rigidbody.rotation = Quaternion.Euler(Rigidbody.velocity.y * Tilt, Rigidbody.rotation.y, Rigidbody.rotation.z);
        }

        public void OnTriggerEnter(Collider col)
        {
            Debug.Log(name + " hit " + col.name);
            Destroy(gameObject);
        }
    }
}