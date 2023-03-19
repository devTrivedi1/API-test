using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClassLibrary1;
public class GameTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        API myAPI = new API();
        int s = myAPI.AddNumbers(2, 3);
        Debug.Log(myAPI.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
