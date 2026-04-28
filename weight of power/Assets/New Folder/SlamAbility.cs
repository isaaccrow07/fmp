using UnityEngine;
public class SlamAbility : Ability
{
    public float force = 15f;
    public float radius = 5f;
    protected override void Activate(GameObject user)
    {
        Collider[] hits = Physics.OverlapSphere(user.transform.position, radius);
        foreach (Collider hit in hits)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, user.transform.position, radius);
            }
        }
    }
}
