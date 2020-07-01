using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TransferLevel1 : MonoBehaviour
{
   

    void Start()
    {
   
    }

    public void Click()
    {
       SceneManager.LoadScene(1 );
    }
}
