using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransferLevel3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Click()
    {
        SceneManager.LoadScene(5);
    }
}
