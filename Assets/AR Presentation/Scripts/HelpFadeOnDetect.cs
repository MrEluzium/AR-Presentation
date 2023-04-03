using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class HelpFadeOnDetect : MonoBehaviour
{
    [SerializeField]
    ARTrackedImageManager m_TrackedImageManager;

    [SerializeField]
    TMP_Text m_DebugTextMesh;

    [SerializeField]
    Animator m_HelpCanvasAnimator;

    void OnEnable() => m_TrackedImageManager.trackedImagesChanged += OnChanged;

    void OnDisable() => m_TrackedImageManager.trackedImagesChanged -= OnChanged;

    void Start()
    {
        m_DebugTextMesh.text = "Pending...";
    }

    void OnChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var newImage in eventArgs.added)
        {
            m_DebugTextMesh.text = "Event: added";
        }

        foreach (var updatedImage in eventArgs.updated)
        {
            
        }

        foreach (var removedImage in eventArgs.removed)
        {
            m_DebugTextMesh.text = "Event: removed";
        }
    }
}
