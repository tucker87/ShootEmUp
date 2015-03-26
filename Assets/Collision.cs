using UnityEngine;

namespace Assets
{
    public class Collision : MonoBehaviour 
    {
        public void OnTriggerEnter(Collider col)
        {
            Debug.Log(col.name);
        }
    }
}