using UnityEngine;

namespace Assets
{
    class Enemy : MonoBehaviour
    {
        public void OnTriggerEnter(Collider col)
        {
            Debug.Log("Bullet Hit!");
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
