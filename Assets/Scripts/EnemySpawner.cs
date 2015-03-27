using UnityEngine;

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

            Debug.Log("Spawning Enemy");
            var enemy = Instantiate(Enemy, transform.position, transform.rotation);
            _timer = Time.time + 3;
            Debug.Log(_timer);
        }
    }
}