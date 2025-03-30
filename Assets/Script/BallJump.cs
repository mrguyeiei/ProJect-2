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
    public void SetAcc100()
    {
        acc = 200f;
        CalculateForce();  
    }
    public void SetAcc200()
    {
        acc = 300f;
        CalculateForce();
    }
    public void SetAcc300()
    {
        acc = 400f;
        CalculateForce();
    }
}
