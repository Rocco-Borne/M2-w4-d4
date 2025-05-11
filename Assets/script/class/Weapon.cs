using UnityEngine;
[System.Serializable]
public class Weapon 
{
    public enum DAMAGE_TYPE
    {
        PHISICAL,
        MAGICAL,
    }
    [SerializeField] string name;
    [SerializeField] DAMAGE_TYPE damage_type;
    [SerializeField] Element Element;
    [SerializeField] Stats BonusStats;
    public Weapon(string name, DAMAGE_TYPE damage_type, Element element, Stats bonusStats)
    {
        this.name = name;
        this.damage_type = damage_type;
        Element = element;
        BonusStats = bonusStats;
    }
    void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return name;
    }
    void SetDamageType(DAMAGE_TYPE damage_type) 
    {
        this.damage_type=damage_type;
    }
    public DAMAGE_TYPE GetDamageType()
    {
        return damage_type;

    }
    void SetElement(Element element)
    {
        this.Element = element;
    }
    public Element GetElement()
    {
        return Element;
    }
    void SetBonusStats(Stats bonusStats)
    {
        this.BonusStats = bonusStats;
    }
    public Stats GetBonusStats()
    {
        return BonusStats;
    }
}
