using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] float speed = 1000f;
    [SerializeField] Rigidbody rb;
    [SerializeField] float maxSpeed = 20f;
    [SerializeField] float moveSpeed = 100f;

    void FixedUpdate()
    {
        rb.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Acceleration);
        rb.linearVelocity = Vector3.ClampMagnitude(rb.linearVelocity, maxSpeed);

        if(Input.GetKey("a")){
            rb.AddForce(Vector3.left * moveSpeed * Time.deltaTime , ForceMode.VelocityChange);
        }
        if(Input.GetKey("d")){
            rb.AddForce(Vector3.right * moveSpeed * Time.deltaTime , ForceMode.VelocityChange);
        }
    }

}