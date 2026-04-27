using StarterAssets;
using UnityEngine;

public class PlayerWeightSystem : MonoBehaviour
{
    public ThirdPersonController TPC;

    public float weight = 0f;
    public float maxWeight = 100f;

    // Movement stats
    public float baseSpeed = 10f;
    public float baseJumpForce = 10f;

    // Modified stats
    private float currentSpeed;
    private float currentJumpForce;

    // Shedding
    public float shedRate = 20f;
    private bool isShedding = false;

    void Update()
    {
        HandleShedding();
        UpdateStats();
    }

    // Call this when using an ability
    public void AddWeight(float amount)
    {
        weight += amount;
        weight = Mathf.Clamp(weight, 0, maxWeight);
    }

    void UpdateStats()
    {
        float weightPercent = weight / maxWeight;

        // Heavier = slower & lower jump
        currentSpeed = baseSpeed * (1 - weightPercent);
        currentJumpForce = baseJumpForce * (1 - weightPercent);

        TPC.MoveSpeed = currentSpeed;
        TPC.JumpHeight = currentJumpForce;
        TPC.SprintSpeed = currentSpeed + 3.35f;
    }

    void HandleShedding()
    {
        if (isShedding)
        {
            weight -= shedRate * Time.deltaTime;
            weight = Mathf.Clamp(weight, 0, maxWeight);
        }
    }

    public void StartShedding()
    {
        isShedding = true;
    }

    public void StopShedding()
    {
        isShedding = false;
    }
}