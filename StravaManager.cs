using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class StravaManager : MonoBehaviour
{
    [SerializeField] private string client_Id;
    [SerializeField] private string client_secret;
    [SerializeField] private string code;
    [SerializeField] private string grant_type;

    private void Start()
    {
        StartCoroutine(StravaRequest());
    }

    private IEnumerator StravaRequest()
    {
        var formData=new WWWForm();
        
        formData.AddField("client_id",client_Id);
        formData.AddField("client_secret",client_secret);
        formData.AddField("code",code);
        formData.AddField("grant_type", grant_type);
        var request = UnityWebRequest.Post("https://www.strava.com/oauth/token", formData);
        yield return request.SendWebRequest();

        if (request.isHttpError||request.isNetworkError)
        {
            Debug.Log("Error Network");
        }
        else
        {
            var strava = JsonUtility.FromJson<Strava>(request.downloadHandler.text);
            var athleteRequest = UnityWebRequest.Get("https://www.strava.com/api/v3/athlete");
            athleteRequest.SetRequestHeader("Authorization", "Bearer "+strava.AccessToken);

            yield return athleteRequest.SendWebRequest();

            if (athleteRequest.isHttpError || athleteRequest.isNetworkError)
            {
                Debug.Log("Error Network");
            }
            else
            {
                var athlete = JsonUtility.FromJson<Athlete>(athleteRequest.downloadHandler.text);
                Debug.Log(athlete.ToString());
            }
        }
    }
}
