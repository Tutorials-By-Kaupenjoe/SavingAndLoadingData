using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsSaving : MonoBehaviour
{
    private PlayerData playerData;

    // Start is called before the first frame update
    void Start()
    {
        CreatePlayerData();
    }

    private void CreatePlayerData()
    {
        playerData = new PlayerData("Nico", 200f, 10f, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            SaveData();

        if (Input.GetKeyDown(KeyCode.L))
            LoadData();
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("Name", playerData.name);
        PlayerPrefs.SetFloat("Health", playerData.health);
        PlayerPrefs.SetFloat("Mana", playerData.mana);
        PlayerPrefs.SetInt("Level", playerData.level);
    }

    public void LoadData()
    {
        playerData = new PlayerData(PlayerPrefs.GetString("Name"), PlayerPrefs.GetFloat("Health"), 
            PlayerPrefs.GetFloat("Mana"), PlayerPrefs.GetInt("Level"));

        Debug.Log(playerData.ToString());
    }
}
