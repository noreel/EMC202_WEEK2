using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assassin : Recruit
{
    protected int Strength => _strength + 2;
    protected int Agility => _agility + 5;
    protected int Intelligence => _intelligence + 3;

    public float AHealth => Health * Strength;
    public float AStamina => Stamina * Agility;
    public float AMana => Mana * Intelligence;

    public int AAttack => _attack * Agility;

    public override void Introduce()
    {
        base.Introduce();

        Health = AHealth;
        Stamina = AStamina;
        Mana = AMana;
        Debug.Log($"I am an Assassin, I have {Health} health, {Stamina} stamina and {Mana} mana");
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

        _attack = AAttack;
        Debug.Log($"Attack points: {_attack} Attack points = base attack * main attribute");
    }
}