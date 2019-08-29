using System;
using UnityEngine;

[Serializable]
public class Athlete
{
    [SerializeField] private string id;
    [SerializeField] private string username;
    [SerializeField] private string resource_state;
    [SerializeField] private string firstname;
    [SerializeField] private string lastname;
    [SerializeField] private string city;
    [SerializeField] private string state;
    [SerializeField] private string country;
    [SerializeField] private string sex;
    [SerializeField] private string profile;
    [SerializeField] private int follower_count;
    [SerializeField] private int friend_count;
    [SerializeField] private string athlete_type;
    [SerializeField] private float weight;
    [SerializeField] private string[] clubs;
    [SerializeField] private string[] bikes;
    [SerializeField] private string[] shoes;

    public string Id => id;
    public string Username => username;
    public string Firstname => firstname;
    public string Lastname => lastname;
    public string Name => firstname + " " + lastname;
    public string City => city;
    public string State => state;
    public string Country => country;
    public string Sex => sex == "M" ? "Male" : "Female";
    public string Profile => profile;
    public int FollowerCount => follower_count;
    public int FriendCount => friend_count;
    public string AthleteType => athlete_type;
    public float Weight => weight;
    public string[] Clubs => clubs;
    public string[] Bikes => bikes;
    public string[] Shoes => shoes;
        
    public override string ToString()
    {
        return "Id: " + Id + ", " +
               "FirstName: " + Firstname + ", " +
               "LastName: " + Lastname + ", " +
               "Name: " + Name + ", " +
               "City: " + City + ", " +
               "State: " + State + ", " +
               "Country: " + Country + ", " +
               "Sex: " + Sex + "\n" +
               "Profile: " + Profile + ", " +
               "FollowerCount: " + FollowerCount + ", " +
               "FriendCount: " + FriendCount + ", " +
               "AthleteType: " + AthleteType + ", " +
               "Weight: " + Weight;
    }
}
