using UnityEngine;

namespace Assets.Scripts
{
    public class Collision : MonoBehaviour 
    {
        public void OnTriggerEnter(Collider col)
        {
            Debug.Log(col.name);
        }
    }
}