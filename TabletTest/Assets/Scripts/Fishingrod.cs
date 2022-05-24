using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishingrod : MonoBehaviour
{
   public Transform fishingrod, pos2;
   public LineRenderer line;

   private void Update()
   {
      line.SetPosition(0, fishingrod.position);
      line.SetPosition(1, pos2.position);
   }
}
