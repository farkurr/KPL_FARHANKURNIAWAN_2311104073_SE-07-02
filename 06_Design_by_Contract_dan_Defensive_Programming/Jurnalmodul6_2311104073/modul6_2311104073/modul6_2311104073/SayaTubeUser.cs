﻿using System;
using System.Collections.Generic;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username { get; private set; }

    public SayaTubeUser(string username)
    {
        if (username == null || username.Length > 100)
            throw new ArgumentException("Username tidak boleh null dan maksimal 100 karakter");

        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
    }

    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null)
            throw new ArgumentNullException("Video tidak boleh null");

        if (video.GetPlayCount() >= int.MaxValue)
            throw new ArgumentException("PlayCount video terlalu besar");

        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.GetPlayCount();
        }
        return total;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("======== VIDEO USER ========");
        Console.WriteLine($"User: {Username}");

        int maxPrint = Math.Min(8, uploadedVideos.Count); // POSTCONDITION
        for (int i = 0; i < maxPrint; i++)
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
        }

        Console.WriteLine();
    }
}
