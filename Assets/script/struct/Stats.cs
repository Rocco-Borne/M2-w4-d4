using UnityEngine;
[System.Serializable]
public struct Stats
{
    public int Atk;
    public int Def;
    public int Res;
    public int Spd;
    public int Crt;
    public int Aim;
    public int Eva;
    public Stats(int atk, int def, int res, int spd, int crt, int aim, int eva)
    {
        this.Atk = Mathf.Abs(atk);
        this.Def = Mathf.Abs(def);
        this.Res = Mathf.Abs(res);
        this.Spd = Mathf.Abs(spd);
        this.Crt = Mathf.Abs(crt);
        this.Aim = Mathf.Abs(aim);
        this.Eva = Mathf.Abs(eva);
    }

    public static Stats sum(Stats a,Stats b)
    {
        return new Stats(a.Atk + b.Atk, a.Def + b.Def, a.Res + b.Res, a.Spd + b.Spd, a.Crt + b.Crt, a.Aim + b.Aim, a.Eva + b.Eva);
    }
}

