using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBase : MonoBehaviour, IEntity
{
    public float Health { get; protected set; }
    public float MaxHealth { get; protected set; }
    public float PhysicalResistance { get; protected set; }
    public float MagicRestistance { get; protected set; }
    public float Speed { get; protected set; }
    public float CalculateDamageReduction(bool isMagic, float magicResistance, bool isPhysical, float physicalResistance, float damage)
    {
        if (isMagic && !isPhysical)
        {
            return ((Mathf.Pow(damage, 2)) / (damage + magicResistance));
        }
        else if (!isMagic && isPhysical)
        {
            return ((Mathf.Pow(damage, 2)) / (damage + physicalResistance));
        }
        else if (isPhysical && isMagic)
        {
            return ((Mathf.Pow(damage, 2)) / (damage + ((magicResistance + physicalResistance) / 2)));
        }
        else
            return damage;
    }

    public void Attack(GameObject AttackTarget, float damage)
    {

    }
    public bool TakeDamage(bool isMagic, float magicResistance, bool isPhysical, float physicalResistance, float damage)
    {
        Health -= CalculateDamageReduction(isMagic, magicResistance, isPhysical, physicalResistance, damage);
        return CheckIfDead();
    }

    public bool CheckIfDead()
    {
        if (Health <= 0f) return true;
        else return false;
    }

}
