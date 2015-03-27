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
            var movement = new Vector3();
            movement += Vector3.left * Speed * Time.deltaTime;
            transform.position += movement * Speed * Time.deltaTime;
        }    

        public void OnTriggerEnter(Collider col)
        {
            Debug.Log(name + " hit " + col.name);
            if (col.name == "PlayerBullet")
            {
                Destroy(col.gameObject);
                Destroy(gameObject);
            }

            if (col.name == "Player")
            {
                Destroy(col.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
