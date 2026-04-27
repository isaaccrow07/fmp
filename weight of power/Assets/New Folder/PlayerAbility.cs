using UnityEngine;

public class PlayerAbility : MonoBehaviour
{
    public PlayerWeightSystem weightSystem;
    public float weightCost = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            UseAbility();
        }
    }

    void UseAbility()
    {
        // Add weight when ability is used
        weightSystem.AddWeight(weightCost);

        Debug.Log("Ability Used!");
    }
}
