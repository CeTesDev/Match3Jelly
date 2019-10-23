using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class PlaysiveSDKUnity : MonoBehaviour {

    [DllImport("__Internal")]
    private static extern void gameLoadedLib();

    [DllImport("__Internal")]
    private static extern void gamePostScoreLib(int score);

    private static bool debugMode = true;
    private static bool loadedReported;

    public static PlaysiveSDKUnity instance;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }
        loadedReported = false;
        DontDestroyOnLoad(gameObject);
    }


    //////////////////////////////////////
    // Utils
    //////////////////////////////////////

    private void logger(string message)
    {
        if (debugMode && Application.isEditor)
        {
            Debug.Log(string.Format("PlaysiveSDK Debug - {0}", message));
        }
        
    }

    // 

    public void GameLoaded()
    {
        if (!loadedReported) {
            if (Application.platform == RuntimePlatform.WebGLPlayer) {
                gameLoadedLib();
            }
            loadedReported = true;
            logger("Action Event (Game Loaded)");
        }
    }

    public void PostScore(int score)
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            gamePostScoreLib(score);
        }
        logger(string.Format("Action Event (Post Score: {0})", score));
    }
}
