using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEntity
{
    public float Health { get;}
    public float MaxHealth { get;}
    public float PhysicalResistance { get;}
    public float MagicRestistance { get;}
    public float Speed { get; }
    public void Attack(GameObject AttackTarget, float damage);
    public float CalculateDamageReduction(bool isMagic, float magicResistance, bool isPhysical, float physicalResistance, float damage);
    public bool TakeDamage(bool isMagic, float magicResistance, bool isPhysical, float physicalResistance, float damage);


}
