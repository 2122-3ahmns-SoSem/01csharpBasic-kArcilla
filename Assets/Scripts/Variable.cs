using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Himmelsrichtungen
{
    Nord,
    Sued,
    West,
    Ost
}


public class Variable : MonoBehaviour

    colour farbe;
    int anztueren
    bool fahren;
    string name;
    int brot;
    int butter;
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Himmelsrichtungen.Nord + "" + Himmelsrichtungen.Sued + "" + Himmelsrichtungen.West + "" + Himmelsrichtungen.Ost);

        //Beispiel1
        name = "brot";
        Debug.Log("Hallo" + name);

        //Beispiel2
        anzTueren = 6;
        brot = 4;
        butter = 1;
        Debug.Log(anzTueren + brot + butter);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
