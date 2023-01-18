using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelectedVisual : MonoBehaviour
{
  [SerializeField] private Unit unit;
  private MeshRenderer meshRenderer;

  private void Awake()
  {
    meshRenderer = GetComponent<MeshRenderer>();
    UnitActionSystem.Instance.OnSelectedUnitChanged += UnitActionSystem_OnSelectedunitChanged;
  }

  private void UnitActionSystem_OnSelectedunitChanged(object sender, EventArgs e)
  {
    UpdateVisual();
  }

  private void UpdateVisual()
  {
    if (UnitActionSystem.Instance.GetSelectedUnit() == unit)
    {
      meshRenderer.enabled = true;
    }
    else
    {
      meshRenderer.enabled = false;
    }
  }
}
