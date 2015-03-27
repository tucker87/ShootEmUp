﻿using UnityEngine;

namespace Assets.Scripts
{
    public class EnemySpawner : MonoBehaviour
    {
        public Transform Enemy;
        private float _timer;

        void Awake()
        {
            _timer = Time.time + 3;
        }

        void Start () 
        {

        }

        void Update () 
        {
            if (!(_timer < Time.time)) 
                return;

            Instantiate(Enemy, transform.position, transform.rotation); //This spawns the emeny
            _timer = Time.time + 3;
        }
    }
}