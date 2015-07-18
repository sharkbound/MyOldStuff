using System;
using System.Collections.Generic;
using System.Text;
using Rocket.Unturned.Player;
using Rocket.Unturned;
using UnityEngine;
using Rocket.Unturned.Commands;
using Rocket.Core.Logging;
using Rocket.Unturned.Plugins;
using System.Threading.Tasks;
using System.Collections;

namespace learningToMakePlugins
{
   public class timertest : MonoBehaviour
    {
       public void start(float val)
        {
            StartCoroutine(timer(val));
        }
       public IEnumerator timer(float value)
        {
            yield return new WaitForSeconds(value);
        }

    }
}
