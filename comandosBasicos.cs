using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class comandosBasicos : MonoBehaviour
{

    public void carregaCena(string nomeCena)
    {

        SceneManager.LoadScene(nomeCena);


    }
}