using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
enum DAMAGE_TYPE { };
//enum Element { };
public static class GameFormulas
{
    public static bool HasElementAdvantage(Element attackElement, Hero defender) 
    {
        if (attackElement==defender.GetWeakness()) return true;
        return false;
    }
    public static bool HasElementDisadvantage(Element attackElement, Hero defender) 
    {
        if (attackElement ==defender.GetResistance()) return true;
        return false;
    }
    static float EvaluateElementalModifier(Element attackElement, Hero defender)
    {
        if (HasElementAdvantage(attackElement, defender) == true)
        {
            return 1.5f;
        }
        else if (HasElementDisadvantage(attackElement,defender) == true)
        {
            return 0.5f;
        }
        return 1f;
    }
    public static bool HasHit(Stats attacker, Stats defender)
    {
        int hitChance = attacker.Aim - defender.Eva;
        if (hitChance < UnityEngine.Random.Range(0,100))
        {
            Debug.Log("MISS");
            return false;
        }
        return true;
    }
    static bool IsCrit(int critValue)
    {
        if (critValue <= UnityEngine.Random.Range(0, 100))
        {
            return true;
        }
        return false;

    }
    public static int CalculateDamage(Hero attacker, Hero defender)
    {
        float danno;

        float difesa;
        if (attacker.GetWeapon().GetDamageType()== Weapon.DAMAGE_TYPE.PHISICAL)
        {
            difesa= defender.GetBaseStats().Def;
        }
        else
        {
            difesa = defender.GetBaseStats().Res;
        }
        danno = attacker.GetBaseStats().Atk - difesa;
        danno *= EvaluateElementalModifier(attacker.GetWeapon().GetElement(), defender);
        if (IsCrit(attacker.GetBaseStats().Crt))
        {
            danno = danno * 2;
        }
        if(danno > 0)
        {
            return (int) danno;
        }
        else
        {
            danno = 0;
            return (int)danno;
        }
    }
}
