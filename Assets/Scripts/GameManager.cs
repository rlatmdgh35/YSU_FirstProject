using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cover;
    public SpawnManager spawnManager;
    public ItemManager itemManager;

    void Start()
    {

    }

    public void OnClickStartButton()
    {
        cover.SetActive(false);

    }

}
