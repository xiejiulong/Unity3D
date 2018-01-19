using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class AchievementMemento
{
    public int enemyKilledCount { get; set; }
    public int soldieryKilledCount { get; set; }
    public int maxStageLv { get; set; }


    public void SaveData()
    {
        PlayerPrefs.SetInt("EnemyKilledCount", enemyKilledCount);
        PlayerPrefs.SetInt("SoldierKilledCount", soldieryKilledCount);
        PlayerPrefs.SetInt("MaxStageLv", maxStageLv);
    }
    public void LoadData()
    {
        enemyKilledCount=PlayerPrefs.GetInt("EnemyKilledCount" );
        soldieryKilledCount=PlayerPrefs.GetInt("SoldierKilledCount" );
        maxStageLv=PlayerPrefs.GetInt("MaxStageLv" );
    }
}
