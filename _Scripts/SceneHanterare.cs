using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //måste ha access till scenemanagement

public class SceneHanterare : MonoBehaviour
{
    public void SceneChanger(string namn) //funktion för att ändra scene, med string för namnet på scenen
    {
        SceneManager.LoadScene(namn); //laddar scenen med namnet 
    }
    public void Exit() //funktion för att avsluta spelet
    {
        #if UNITY_EDITOR //om unityeditorn finns
            UnityEditor.EditorApplication.isPlaying = false; //sluta spela spelet från editorn
        #else
            Application.Quit(); 
        #endif
    }
}
