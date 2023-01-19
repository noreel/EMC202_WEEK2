using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Recruit
{

    protected int Strength => _strength + 5;
    protected int Agility => _agility + 3;
    protected int Intelligence => _intelligence + 2;

    public float WHealth => Health * Strength;
    public float WStamina => Stamina * Agility;
    public float WMana => Mana * Intelligence;

    public int WAttack => _attack * Strength;

    public override void Introduce()
    {
        base.Introduce();

        Health = WHealth;
        Stamina = WStamina;
        Mana = WMana;
        Debug.Log($"I am an Warrior, I have {Health} health, {Stamina} stamina and {Mana} mana");
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

        _attack = WAttack;
        Debug.Log($"Attack points: {_attack} Attack points = base attack * main attribute");
    }
}
