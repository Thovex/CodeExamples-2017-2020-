﻿using UnityEngine.EventSystems;

public class ExtendedStandaloneInputModule : StandaloneInputModule
{
    private static ExtendedStandaloneInputModule _instance;

    public static PointerEventData GetPointerEventData(int pointerId = -1)
    {
        PointerEventData eventData;
        _instance.GetPointerData(pointerId, out eventData, true);
        return eventData;
    }

    protected override void Awake()
    {
        base.Awake();
        _instance = this;
    }
}