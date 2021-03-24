using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsBarManager : MonoBehaviour
{
    [SerializeField] private GameObject gameView;
    [SerializeField] private GameObject windowView;
    [SerializeField] private GameObject messengerView;
    [SerializeField] private GameObject folderView;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GameBarButton()
    {
        if(gameView.activeInHierarchy)
        {
            windowView.SetActive(true);
            gameView.SetActive(false);
        }
        else
        {
            windowView.SetActive(false);
            gameView.SetActive(true);
        }
        
    }

    public void DesktopButton()
    {
        windowView.SetActive(true);
        gameView.SetActive(false);
    }

    public void FolderBarButton()
    {
        windowView.SetActive(true);
        gameView.SetActive(false);

        if (folderView.activeInHierarchy)
        {
            folderView.SetActive(false);
        }
        else
        {
            folderView.SetActive(true);
        }
    }

    public void ChatBarButton()
    {
        windowView.SetActive(true);
        gameView.SetActive(false);

        if (messengerView.activeInHierarchy)
        {
            messengerView.SetActive(false);
        }
        else
        {
            messengerView.SetActive(true);
        }

    }

    public void CloseChat()
    {
        messengerView.SetActive(false);
    }

    public void CloseFolder()
    {
        folderView.SetActive(false);
    }
}
