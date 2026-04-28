using UnityEngine;
public class DoubleJumpAbility : Ability
{
    public float jumpForce = 7f;
    private int jumpsRemaining = 1;
    protected override void Activate(GameObject user)
    {
        Rigidbody rb = user.GetComponent<Rigidbody>();
        if (jumpsRemaining > 0)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpsRemaining--;
        }
    }
    public void ResetJumps()
    {
        jumpsRemaining = 1;
    }
}