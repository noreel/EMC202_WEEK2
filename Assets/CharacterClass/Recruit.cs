using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recruit
{
    public float Stamina;

    public float Health;

    public float Mana;

    protected int _strength;

    protected int _agility;

    protected int _intelligence;

    protected int _attack;


    public virtual void Introduce()
    {

        Stamina = 50;
        Health = 50;
        Mana = 50;
    }

    public Recruit()
    {
        _strength = 0;
        _agility = 0;
        _intelligence = 0;
    }

    public virtual void RecruitInfo()
    {
        _strength = 0;
        _agility = 0;
        _intelligence = 0;
    }

    public virtual void ComputeAttack()
    {
        _attack = 2;
    }

}