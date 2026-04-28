using UnityEngine;
public class AbilityManager : MonoBehaviour
{
    public Ability traversal1;
    public Ability traversal2;
    public Ability attack1;
    public Ability attack2;
    void Update()
    {
        // Traversal
        if (Input.GetKeyDown(KeyCode.Q))
            traversal1?.Use(gameObject);
        if (Input.GetKeyDown(KeyCode.E))
            traversal2?.Use(gameObject);
        // Attacks
        if (Input.GetMouseButtonDown(0))
            attack1?.Use(gameObject); // Left click
        if (Input.GetMouseButtonDown(1))
            attack2?.Use(gameObject); // Right click
    }

}