using UnityEngine;

namespace Assets.Scripts
{
    public class EnemySpawner : MonoBehaviour
    {
        public Enemy Enemy;
        public EnemyMovement EnemyMovement;

        private float _timer;

        void Awake()
        {
            _timer = Time.time + 3;
        }

        void Update () 
        {
            if (_timer > Time.time) 
                return;

            Enemy.EnemyMovement = EnemyMovement;
            Instantiate(Enemy, transform.position, transform.rotation);
            _timer = Time.time + 3;
        }
    }
}