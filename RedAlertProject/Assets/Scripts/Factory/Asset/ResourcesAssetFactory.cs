using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class ResourcesAssetFactory:IAssetFactory
{
    public const string SoldierPath = "Characters/Soldier/";
    public const string EnemyPath = "Characters/Enemy/";
    public const string WeaponPath = "Weapons/";
    public const string EffectPath = "Effects/";
    public const string AudioPath = "Audios/";
    public const string SpritePath = "Sprites/";

    public GameObject LoadSoldier(string name)
    {
        return InstantiateGameObject(SoldierPath + name);
    }

    public GameObject LoadEnemy(string name)
    {
        return InstantiateGameObject(EnemyPath + name);
    }

    public GameObject LoadWeapon(string name)
    {
        return InstantiateGameObject(WeaponPath + name);
    }

    public GameObject LoadEffect(string name)
    {
        return InstantiateGameObject(EffectPath + name);
    }

    public AudioClip LoadAudioClip(string name)
    {
        return Resources.Load(SpritePath + name, typeof(AudioClip)) as AudioClip;
    }

    public Sprite LoadSprite(string name)
    {
        return Resources.Load(SpritePath + name, typeof(Sprite)) as Sprite;
    }

    private GameObject InstantiateGameObject(string path)
    {
        UnityEngine.Object o = Resources.Load(path);
        if (o == null)
        {
            Debug.LogError("无法加载资源，路径:" + path); return null;
        }
        return UnityEngine.GameObject.Instantiate(o) as GameObject;
    }
    public UnityEngine.Object LoadAsset(string path)
    {
        UnityEngine.Object o = Resources.Load(path);
        if (o == null) {  
            Debug.LogError("无法加载资源，路径:" + path); return null;
        }
        return o;
    }

}