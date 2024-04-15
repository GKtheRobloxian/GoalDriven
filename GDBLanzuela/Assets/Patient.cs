using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : GAgent
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        SubGoal sl = new SubGoal("isWaiting", 1, true);
        goals.Add(sl, 3);
    }
}
