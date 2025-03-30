using System.Collections;
using System.Xml.Serialization;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5.0f;
    public float jump = 5.0f;
    public bool isOnGround = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //?????????????Player
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVetical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVetical);
        rb.AddForce(movement * speed);

    }

    private void Update()
    {
        //???????????????????????????????? ???????????????????
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //????????
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

    }
}
