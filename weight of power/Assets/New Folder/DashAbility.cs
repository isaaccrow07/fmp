using UnityEngine;
public class DashAbility : Ability
{
    public float dashForce = 10f;
    protected override void Activate(GameObject user)
    {
        Rigidbody rb = user.GetComponent<Rigidbody>();
        rb.AddForce(user.transform.forward * dashForce, ForceMode.VelocityChange);
    }
}
