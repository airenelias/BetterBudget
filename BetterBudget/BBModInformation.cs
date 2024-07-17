using System;

using ICities;
using ColossalFramework.UI;
using UnityEngine;

namespace BetterBudget
{
    public class BBModInformation : IUserMod
    {
        public string Name
        { get { return "Better Budget (FIX)"; } }

        public string Description
        { get { return "Faster access to the budget service sliders"; } }
    }
}
