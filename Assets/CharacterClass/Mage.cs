using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Recruit
{
    protected int Strength => _strength + 1;
    protected int Agility => _agility + 3;
    protected int Intelligence => _intelligence + 6;

    public float MHealth => Health * Strength;
    public float MStamina => Stamina * Agility;
    public float MMana => Mana * Intelligence;

    public int MAttack => _attack * Intelligence;

    public override void Introduce()
    {
        base.Introduce();

        Health = MHealth;
        Stamina = MStamina;
        Mana = MMana;
        Debug.Log($"I am a Mage, I have {Health} health, {Stamina} stamina and {Mana} mana");
    }


    public override void RecruitInfo()
    {
        base.RecruitInfo();
        _strength = Strength;
        _agility = Agility;
        _intelligence = Intelligence;
        Debug.Log(message: $"I also have {_strength} points on strength, {_agility} points on agility, and {_intelligence} points on intelligence");
    }

    public override void ComputeAttack()
    {
        base.ComputeAttack();

        _attack = MAttack;
        Debug.Log($"Attack points: {_attack} Attack points = base attack * main attribute");
    }
}
