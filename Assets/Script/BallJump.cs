using UnityEngine;

public class BallJump : MonoBehaviour
{
    [SerializeField] float force;
    [SerializeField] float mass;
    [SerializeField] float acc;

    public void CalculateForce()
    {
        //??????????????????????????
        mass = GetComponent<Rigidbody>().mass;
        GetComponent<Rigidbody>().AddForce(force, force, 0);
        //????????????????? F=ma
        force = mass * acc;
        
    }
    public void Set200()
    {
        acc = 200f;
        CalculateForce();  
    }
    public void Set300()
    {
        acc = 300f;
        CalculateForce();
    }
    public void Set400()
    {
        acc = 400f;
        CalculateForce();
    }
}
