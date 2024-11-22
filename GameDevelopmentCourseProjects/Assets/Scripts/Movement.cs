using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 4f;
    public float rotationSpeed = 80f;
    public Animator animator;

    void Update()
    {
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            moveDirection += Vector3.forward;
        if (Input.GetKey(KeyCode.S))
            moveDirection += Vector3.back;
        if (Input.GetKey(KeyCode.A))
            moveDirection += Vector3.left;
        if (Input.GetKey(KeyCode.D))
            moveDirection += Vector3.right;

        // Hareket varsa animasyonu başlat
        if (moveDirection != Vector3.zero)
        {
            // Hareket yönünde karakteri döndür
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Karakteri hareket ettir
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);

            animator.SetBool("isRun", true);
        }
        else
        {
            animator.SetBool("isRun", false);
        }
    }
}