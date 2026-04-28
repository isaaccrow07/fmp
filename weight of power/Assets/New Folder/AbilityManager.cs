using UnityEditor.Playables;
using UnityEngine;
public class AbilityManager : MonoBehaviour
{
    public Ability traversal1;
    public Ability traversal2;
    public Ability attack1;
    public Ability attack2;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            traversal1?.Use(gameObject);
        if (Input.GetKeyDown(KeyCode.E))
            traversal2?.Use(gameObject);
        if (Input.GetMouseButtonDown(0))
            attack1?.Use(gameObject);
        if (Input.GetMouseButtonDown(1))
            attack2?.Use(gameObject);
    }
}