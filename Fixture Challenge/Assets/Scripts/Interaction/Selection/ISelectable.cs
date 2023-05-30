using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IWD.FixtureChallenge.Interaction
{

    public interface ISelectable 
    {
        bool IsSelected { get; }
        void Select();
        void Deselect();
    }

}