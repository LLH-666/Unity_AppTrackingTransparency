using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingManager : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(StartRun());
        
        Debug.Log("进入主场景");
    }

    private IEnumerator StartRun()
    {
#if UNITY_EDITOR

        yield return null;

#elif UNITY_IOS || UNITY_IPHONE
            bool waitForAppTracking = true;
            KRAppTrackingTransparency.Instance.RequestAuthorization((Balaso.AppTrackingTransparency.AuthorizationStatus status) =>
            {
                waitForAppTracking = false;
            });

            //wait for app tracking to be approved
            yield return new WaitUntil(() => waitForAppTracking == false);
#endif
    }
}
