﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPickupable : IInteractable
{
  void PickUp();

  void OnThrow();
}
