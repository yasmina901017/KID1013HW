﻿using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace WineGiraffe
{
    /// <summary>
    /// 選單管理器
    /// </summary>

    public class MenuManager : MonoBehaviour
    {
        /// <summary>
        /// 開始遊戲
        /// </summary>
        private Button btnPlay;
        private void Awake()
        {
            btnPlay = GameObject.Find("開始遊戲").GetComponent<Button>();
            btnPlay.onClick.AddListener(StartGame);
        }
        private void StartGame()
        {
            SceneManager.LoadScene("遊戲場景");
        }
    }
}