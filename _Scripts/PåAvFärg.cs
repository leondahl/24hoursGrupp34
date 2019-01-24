using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PåAvFärg : MonoBehaviour
{
    public Image mat; //bilden

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("påAv") == 1) //om int:en är "på"
        {
            mat.color = Color.green; //blir grön
        }
        else
        {
            mat.color = Color.red; //blir röd
        }
    }
}
