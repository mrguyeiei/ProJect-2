using UnityEngine;

public class Loststar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //????????????????Player???
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        //??????????
        transform.Rotate(0, 1, 0);
    }
}
