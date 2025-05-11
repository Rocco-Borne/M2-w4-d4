using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Hero 
{
    [SerializeField]
    string name;
    [SerializeField]
    int hp;
    [SerializeField]
    Stats BaseStats;
    [SerializeField]
    Element Resistance;
    [SerializeField]
    Element Weakness;
    [SerializeField]
    Weapon Weapon;
    
    public Hero (string name, int hp, Stats baseStats, Element resistance, Element weakness, Weapon weapon)
    {
        this.name = name;
        this.hp = hp;
        this.BaseStats = baseStats;
        this.Resistance = resistance;
        this.Weakness = weakness;
        this.Weapon = weapon;
    }

    void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return name;
    }
    void SetHp(int hp)
    {
        if (hp < 0) hp = 0;
        this.hp = hp;
    }
    public int GetHp()
    {
        return hp;
    }
    public void SetBaseStats(Stats baseStats)
    {
        this.BaseStats = baseStats;
    }
    public Stats GetBaseStats()
    {
        return BaseStats;
    }
    void SetResistance(Element resistance)
    {
        this.Resistance = resistance;
    }
    public Element GetResistance()
    {
        return Resistance;
    }
    void SetWeakness(Element weakness)
    {
        this.Weakness = weakness;
    }
    public Element GetWeakness()
    {
        return Weakness;
    }
    void SetWeapon(Weapon weapon)
    {
        this.Weapon = weapon;
    }
    public Weapon GetWeapon()
    {
        return Weapon;
    }
    
    public void AddHp(int ammount)
    {
        SetHp(hp += ammount);
    }
    public void TakeDamage(int damage)
    {
        AddHp(-damage);
    }
    public bool IsAlive()
    {
        if (hp > 0) {  return true; }
        return false;
    }
}
