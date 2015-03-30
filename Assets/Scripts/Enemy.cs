using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts
{
    public class Enemy : MonoBehaviour
    {
        public float Speed = 30;
        public EnemyMovement EnemyMovement = EnemyMovement.Straight;

        void Start()
        {
            Debug.Log(EnemyMovement);
            switch (EnemyMovement)
            {
                case EnemyMovement.Straight:
                    Movement.MoveStraight(transform, MoveDirection.Left, Speed);
                    break;
                case EnemyMovement.Wave:
                    Movement.MoveStraight(transform, MoveDirection.Left, Speed);
                    //transform.GetComponent<Rigidbody>().velocity += transform.up * (Speed * 0.5f);
                    break;
            }
        }

        void FixedUpdate()
        {
            if (EnemyMovement == EnemyMovement.Wave)
                Movement.MoveWave(transform, MoveDirection.Left, Speed*0.5f);
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
