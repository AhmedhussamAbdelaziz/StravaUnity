using System;
using UnityEngine;

[Serializable]
public class Strava
{
    [SerializeField] private string token_type;
    [SerializeField] private string access_token;
    [SerializeField] private string refresh_token;
    [SerializeField] private string expires_in;
    [SerializeField] private Athlete athlete;


    public string TokenType => token_type;
    public string AccessToken => access_token;
    public string RefreshToken => refresh_token;
    public string ExpiresIn => expires_in;
    public Athlete Athlete => athlete;
}