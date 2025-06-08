using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    [SerializeField] private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        handleMovement();
        
        
    }
    private void handleMovement(){
        Vector3 moveInput = new Vector3(0f, 0f, 0f);
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();
        rb.linearVelocity = moveInput * moveSpeed;
        if (moveInput.sqrMagnitude > 0){
            animator.SetBool("isRunning", true);
        } else {
            animator.SetBool("isRunning", false);
        }
    }
}
