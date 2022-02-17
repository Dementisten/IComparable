using System;
class Fordon : IComparable {

    public Fordon(string tillverkare,string modell,int årsmodell) {
        Tillverkare=tillverkare;
        Modell=modell;
        Årsmodell=årsmodell;
    }
    public string Tillverkare{set; get;}

    public string Modell{set; get;}

    public int Årsmodell{set; get;}

    public int CompareTo(object obj)
    {
        Fordon fordonC = obj as Fordon;
        if(this.Tillverkare.CompareTo(fordonC.Tillverkare) < 0)
            return -1;
        else 
            return 1;
    }

    public override string ToString()
    {
        return (Tillverkare+" "+Modell+" "+Årsmodell);
    }
}