using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GetLocationInfo : ReactionTrigger
{
  public UnityEvent<bool> UpdateInfo; 
  private LocationInfo locationInfo;
  
  public override void ReactionInvoke(Collider collider)
  {
    locationInfo = collider.GetComponent<LocationInfo>();
    
    if (locationInfo.EntityLost == true) 
    {
      UpdateInfo.Invoke(true);
      return;
    }
    
    UpdateInfo.Invoke(false);
    locationInfo.LostEntity += Check;
  }
  private void Check()
  {
    //Debug.Log("Check");
    UpdateInfo.Invoke(true);
    locationInfo.LostEntity -= Check;
  }
}
