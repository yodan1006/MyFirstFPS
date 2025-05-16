using System;
using _.Features;
using UnityEngine;

public class Player : MonoBehaviour
{

    public UIManager uiManager;
    private void Awake()
    {
        _life.value = _playerData.m_maxLifes;
    }

    [ContextMenu("Test")]
    public void GetMaxLives()
    {
        Debug.Log("Max Lives :"+_playerData.m_maxLifes);
    }
    [ContextMenu("Test Weapon")]
    public void GetMaxAttack()
    {
        Debug.Log("Max attack :"+currentData.m_damage);
    }

    [ContextMenu("GameOver")]
    public void GameOver()
    {
        Debug.Log("Game Over");
        uiManager.ReactToPlayerDeath();
    }

    public int GetCurrentLivesPoint()
    {
        return _life.value;
    }

    [SerializeField] private WeaponItemData currentData;
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private IntValue _life;
}