using System;
using System.Collections;
using System.Collections.Generic;
using Patterns;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : FlappyBirdsSingleton<GameManager>
{
    [Header("Game References")] public Player currentPlayer;
    public List<IResetGame> ResetGameObjects = new List<IResetGame>();

    public void Register(IResetGame registerer)
    {
        Debug.Log("I've got request to Register, His Name is " + registerer.gameObject.name );

        if(!ResetGameObjects.Contains(registerer))
            ResetGameObjects.Add(registerer);
        
        Debug.Log("I've Completed request to Register,, His Name is " + registerer.gameObject.name + " His Status is " + ResetGameObjects.Contains(registerer) );

    }
    
    public void DeRegister(IResetGame registerer)
    {
        if(ResetGameObjects.Contains(registerer))
            ResetGameObjects.Remove(registerer);    }
    
    public bool isGameEnded;

    public void ResetGame()
    {
        isGameEnded = false;
        for (int i = ResetGameObjects.Count - 1; i >= 0; i--)
        {
            ResetGameObjects[i].ResetGame();
        }
    }

}
