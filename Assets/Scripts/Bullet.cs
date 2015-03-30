using UnityEngine;

namespace Assets.Scripts
{
    class Bullet : MonoBehaviour
    {
        public int Team;

        public void OnTriggerEnter(Collider col)
        {
            Debug.Log(name + " hit " + col.name);
            Destroy(gameObject);
        }
    }
}
