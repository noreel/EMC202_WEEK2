using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassManager : MonoBehaviour
{

    private void Start()
    {
        var assassin = new Assassin();

        assassin.Introduce();
        assassin.RecruitInfo();
        assassin.ComputeAttack();

        var mage = new Mage();

        mage.Introduce();
        mage.RecruitInfo();
        mage.ComputeAttack();

        var warrior = new Warrior();

        warrior.Introduce();
        warrior.RecruitInfo();
        warrior.ComputeAttack();
    }

}

