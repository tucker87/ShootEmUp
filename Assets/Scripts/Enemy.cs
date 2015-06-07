using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts
{
    public class Enemy : MonoBehaviour
    {
        public float Speed = 30;
        private float _spawnTime;
        public EnemyMovement EnemyMovement = EnemyMovement.Straight;

        void Start()
        {
            _spawnTime = Time.time;

            Debug.Log(EnemyMovement);
            switch (EnemyMovement)
            {
                case EnemyMovement.Straight:
                    Movement.MoveStraight(transform, MoveDirection.Left, Speed);
                    break;
                case EnemyMovement.Wave:
                    Movement.MoveStraight(transform, MoveDirection.Left, Speed/2);
                    var startingPosition = transform.position;
                    startingPosition.y -= Speed / 5;
                    transform.position = startingPosition;
                    break;
            }
        }

        void FixedUpdate()
        {
            if (EnemyMovement == EnemyMovement.Wave)
                Movement.MoveWave(transform, _spawnTime, Speed*0.5f);
        }

        public void OnTriggerEnter(Collider col)
        {
            Debug.Log(name + " hit " + col.name);
            Destroy(gameObject);
        }
    }

    public enum EnemyMovement
    {
        Straight,
        Wave
    }
}
