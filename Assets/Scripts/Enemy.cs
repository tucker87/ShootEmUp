using UnityEngine;

namespace Assets.Scripts
{
    class Enemy : MonoBehaviour
    {
        public float Speed = 30;

        // Use this for initialization
        public void Start()
        {

        }

        // Update is called once per frame
        public void Update()
        {

        }    

        public void OnTriggerEnter(Collider col)
        {
            Debug.Log(name + " hit " + col.name);
            Destroy(gameObject);
        }
    }
}
