using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public int onOff; //int för på och av knapp
    // Start is called before the first frame update
    void Start()
    {
        onOff = PlayerPrefs.GetInt("påAv"); //onOff är samma som int:en påAv
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("påAv", onOff); //sätter påAv till detsamma som onOff
    }
    public void On() //funktion för att ändra från av till på och tillbaka
    {
        if (onOff != 1) //om knappen inte är "på"
        onOff = 1; //sätter på knappen
        else if (onOff == 1) //om knappen är "på"
            onOff = 0; //stänger av knappen
    }
    
}
