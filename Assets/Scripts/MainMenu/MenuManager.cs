﻿using System;
using General;
using General.Localization;
using UnityEngine;
using UnityEngine.UI;

namespace MainMenu
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _infoButton;
        [SerializeField] private Button _exitButton;

        [SerializeField] private InfoWindow _infoWindow;
        [SerializeField] private PlayWindow _playWindow;

        private void Awake()
        {
            _playButton.onClick.AddListener(OnPlayClicked);
            _infoButton.onClick.AddListener(OnInfoClicked);
            _exitButton.onClick.AddListener(OnExitClicked);

            _infoWindow.WindowClosed += OnInfoClosed;
            _playWindow.WindowClosed += OnPlayWindowClosed;
            
            _playButton.Select();
        }

        private void Start()
        {
            FadeController.Instance.FadeOut();
        }

        private void OnExitClicked()
        {
            UiSoundsManager.Instance.PlayClickSound();
            Application.Quit();
        }

        private void OnInfoClicked()
        {
            UiSoundsManager.Instance.PlayClickSound();
            _infoWindow.Open();
        }
        
        private void OnInfoClosed()
        {
            _infoButton.Select();
        }

        private void OnPlayClicked()
        {
            UiSoundsManager.Instance.PlayClickSound();
            _playWindow.Open();
        }
        
        private void OnPlayWindowClosed()
        {
            _playButton.Select();
        }
    }
}