using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts
{
    class Movement : MonoBehaviour
    {
        public MoveDirection Direction;
        public float Speed;

        void Start()
        {
            MoveStraight(transform, Direction, Speed);
        }

        public static void MoveStraight(Transform element, MoveDirection direction, float speed)
        {
            switch (direction)
            {
                case MoveDirection.Left:
                    element.GetComponent<Rigidbody>().velocity = element.right * -speed;
                    break;
                case MoveDirection.Right:
                    element.GetComponent<Rigidbody>().velocity = element.right * speed;
                    break;
                case MoveDirection.Up:
                    element.GetComponent<Rigidbody>().velocity = element.up * speed;
                    break;
                case MoveDirection.Down:
                    element.GetComponent<Rigidbody>().velocity = element.up * -speed;
                    break;
            }
        }

        public static void MoveWave(Transform element, MoveDirection direction, float speed)
        {
            float delta = 1f;

            Vector3 v = element.position;
            v.y += delta * Mathf.Sin(Time.time * speed / 2);
            Debug.DrawLine(element.position, v);
            element.position = v;
            

            //element.GetComponent<Rigidbody>().velocity =
            //    element.GetComponent<Rigidbody>().velocity + element.up * Mathf.Sin(element.position.x / 10);
            
            //switch (direction)
            //{
            //    case MoveDirection.Left:
            //        var newVelocity = element.GetComponent<Rigidbody>().velocity;

            //        if (element.position.y > waveBound || element.position.y == 0.0f)
            //            element.GetComponent<Rigidbody>().velocity += element.up * (-speed * 0.5f);
            //        if (element.position.y < waveBound*-1)
            //            element.GetComponent<Rigidbody>().velocity += element.up * (speed * 0.5f);
            //        break;
            //    case MoveDirection.Right:
            //        break;
            //    case MoveDirection.Up:
            //        break;
            //    case MoveDirection.Down:
            //        break;
            //}
        }
    }
}
