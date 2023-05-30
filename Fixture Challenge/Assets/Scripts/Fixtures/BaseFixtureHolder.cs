using IWD.FixtureChallenge.Generation;
using IWD.FixtureChallenge.Serialization;
using UnityEngine;

namespace IWD.FixtureChallenge.Fixture
{

    public class BaseFixtureHolder<T> : MonoBehaviour where T : BaseFixtureElement
    {
        [Header("References")]
        [SerializeField]
        private TextAsset _DataFile = default;

        [SerializeField]
        protected BaseSerializer _Serializer = default;

        [SerializeField]
        protected BaseElementGenerator<T> _Generator = default;



        [Header("\"Read Only\"")]
        [SerializeField]
        protected T element = default;

        protected virtual void Start()
        {
            Deserialize();
            Generate();
        }

        protected virtual void Deserialize()
        {
            element = _Serializer.Deserialize<T>(_DataFile.text);
        }

        protected virtual void Generate()
        {
            _Generator.Generate(element, transform);
        }

    }

}