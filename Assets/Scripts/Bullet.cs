﻿using UnityEngine;

namespace Assets.Scripts
{
    class Bullet : MonoBehaviour
    {
        public float Speed;

        // Use this for initialization
        public void Start()
        {

        }

        // Update is called once per frame
        public void Update()
        {
            var movement = new Vector3();
            movement += Vector3.right*Speed*Time.deltaTime;
            transform.position += movement*Speed*Time.deltaTime;
        }        
    }
}
