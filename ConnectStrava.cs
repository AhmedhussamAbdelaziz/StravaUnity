using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ConnectStrava : MonoBehaviour
{
     // Start is called before the first frame update
    void Start()
    {
        
    }
    public void onConnectClick(){
        Application.OpenURL("https://www.strava.com/oauth/authorize?client_id=38307&response_type=code&redirect_uri=http://box5137.temp.domains/~trajekta/test.html&approval_prompt=force&scope=read");

    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
