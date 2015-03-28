using UnityEngine;

namespace Assets.Scripts
{
    class MoveForward : MonoBehaviour
    {
        public float Speed;

        void Start()
        {
            GetComponent<Rigidbody>().velocity = transform.forward * Speed;
        }
    }
}
