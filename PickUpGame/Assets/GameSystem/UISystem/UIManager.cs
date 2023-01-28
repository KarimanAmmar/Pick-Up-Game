﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameSystem
{
    namespace UISystem
    {
        public class UIManager : MonoBehaviour
        {
            // Start is called before the first frame update
            void Start()
            {

            }

            // Update is called once per frame
            void Update()
            {

            }
            public void StartGame()
            {
                SceneManager.LoadScene("Game");
            }
            public void Exit()
            {
                Application.Quit();
            }
            public void stop()
            {
                SceneManager.LoadScene("UI");
            }
        }
    }
}
