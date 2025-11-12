using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public float checkRate = 0.05f;
    private float lastCheckTime;
    public float maxCheckDistance;
    public LayerMask layerMask;

    public GameObject currentInteractObj;
    private IInteractable currentInteractable;

    public TextMeshProUGUI promptText;
    private Camera _camera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
