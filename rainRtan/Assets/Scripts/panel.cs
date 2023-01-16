using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void retry() 
    {
        GameManager.I.retry();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
