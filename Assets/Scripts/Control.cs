using UnityEngine;

    public class Control : MonoBehaviour
    {

        public float Speed;
        public Transform Bullet;

        // Use this for initialization
        public void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Move();
            Shoot();
        }

        private void Move()
        {
            var movement = new Vector3();
            if (Input.GetKey(KeyCode.A))
                movement += Vector3.left*Speed*Time.deltaTime;

            if (Input.GetKey(KeyCode.D))
                movement += Vector3.right*Speed*Time.deltaTime;

            if (Input.GetKey(KeyCode.W))
                movement += Vector3.up*Speed*Time.deltaTime;

            if (Input.GetKey(KeyCode.S))
                movement += Vector3.down*Speed*Time.deltaTime;

            transform.position += movement*Speed*Time.deltaTime;
        }
		public GameObject shot;
		public Transform shotSpawn;
		public float fireRate;
		
		private float nextFire;
		
		void Shoot ()
		{
			if (Input.GetKey (KeyCode.Space) && Time.time > nextFire) {
				nextFire = Time.time + fireRate;
				Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
				GetComponent<AudioSource> ().Play ();
			}
		}
        //private void Shoot()
        //{

			//if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    var bullet = Instantiate(Bullet, transform.position, transform.rotation);
            //    bullet.name = "PlayerBullet";
            //}
                
        //}
   
}
