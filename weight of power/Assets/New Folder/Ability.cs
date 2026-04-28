using UnityEngine;
public abstract class Ability : MonoBehaviour
{
    public string abilityName;
    public float cooldown = 1f;
    protected float lastUsedTime;
    public virtual bool CanUse()
    {
        return Time.time >= lastUsedTime + cooldown;
    }
    public virtual void Use(GameObject user)
    {
        if (!CanUse()) return;
        lastUsedTime = Time.time;
        Activate(user);
    }
    protected abstract void Activate(GameObject user);
}