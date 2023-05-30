using UnityEngine;

namespace IWD.FixtureChallenge.Serialization
{

    public abstract class BaseSerializer : ScriptableObject
    {
        public abstract string Serialize<T>(T serializable);
        public abstract T Deserialize<T>(string data);
    }

}