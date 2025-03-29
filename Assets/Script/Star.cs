using UnityEngine;

public class Star : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            TextShow.Score += 1;
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        transform.Rotate(0,1,0);
    }

}
