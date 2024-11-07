using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 4f;
    public float rotationSpeed = 80f;
    public Animator animator;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
            animator.SetBool("isRun", true);
        }
        else
        {
            animator.SetBool("isRun", false);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        
    }
}
