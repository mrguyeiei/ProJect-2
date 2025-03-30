using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;
        public float smoothSpeed = 5f;
        public Vector3 offset = new Vector3(0, 3, -5);

        void LateUpdate()
        {
            if (target == null) return;


            Vector3 desiredPosition = target.position + target.TransformDirection(offset);
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);


            Quaternion desiredRotation = Quaternion.LookRotation(target.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, smoothSpeed * Time.deltaTime);
        }
    }
}
