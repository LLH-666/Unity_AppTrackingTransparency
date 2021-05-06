using System.Collections.Generic;
using UnityEngine;

namespace Balaso
{
    public class Settings : ScriptableObject
    {
        [Multiline(5)]
        public string PopupMessage;
        public List<string> SkAdNetworkIds;
    }
}
