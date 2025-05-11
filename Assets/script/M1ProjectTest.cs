using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class M1ProjectTest : MonoBehaviour
{
    public Hero a, b;
    // Start is called before the first frame update
    void Start()
    {
        a.SetBaseStats(Stats.sum(a.GetBaseStats(), a.GetWeapon().GetBonusStats()));
        b.SetBaseStats(Stats.sum(b.GetBaseStats(), b.GetWeapon().GetBonusStats()));
    }

    // Update is called once per frame
    void Update()
    {
       
        if (a.GetHp() <=0 || b.GetHp() <= 0)
        {
            return;
        }
        if(a.GetBaseStats().Spd> b.GetBaseStats().Spd)
        { 
            Attacca(a,b);
           if (b.IsAlive())
            {
                Attacca(b,a);
            }
        }
        else
        {
            Attacca(b,a);
            if(a.IsAlive())
            {
                Attacca(a, b);
            }
        }
    }
    void Attacca(Hero attacker, Hero defender)
    {
        Debug.Log(attacker.GetName() + " sta attaccando");
        if (GameFormulas.HasHit(attacker.GetBaseStats(), defender.GetBaseStats()))
        {
            if (GameFormulas.HasElementAdvantage(attacker.GetWeapon().GetElement(), defender))
            {
                Debug.Log("WEAKNESS");
            }
            else if (GameFormulas.HasElementDisadvantage(attacker.GetWeapon().GetElement(), defender))
            {
                Debug.Log("RESIST");
            }
            int danno = GameFormulas.CalculateDamage(attacker, defender);
            Debug.Log("ha inflitto " + danno + " danni");
            defender.TakeDamage(danno);
            if (defender.IsAlive() == false)
            {
                Debug.Log(attacker.GetName() + " ha vinto");
            }
        }
        else
        {
            Debug.Log(attacker.GetName() + " non ha colpito");
        }
    }
}
