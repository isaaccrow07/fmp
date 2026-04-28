using UnityEngine;
public class ProjectileAbility : Ability
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float speed = 20f;
    protected override void Activate(GameObject user)
    {
        GameObject proj = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = proj.GetComponent<Rigidbody>();
        rb.linearVelocity = firePoint.forward * speed;
    }
}