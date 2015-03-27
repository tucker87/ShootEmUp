using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class Despawner : MonoBehaviour 
    {
        public void OnTriggerEnter(Collider col)
        {
            Destroy(col.gameObject);
            Debug.Log(String.Format("Despawner destroyed {0}", col.name));
        }
    }
}
