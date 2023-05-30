using UnityEngine;

namespace IWD.FixtureChallenge.Serialization
{
	[CreateAssetMenu(menuName = "IWD/Serializers/Json")]
	public class JsonSerializer : BaseSerializer
	{
		public override string Serialize<T>(T serializable)
		{
			return JsonUtility.ToJson(serializable);
		}

		public override T Deserialize<T>(string data)
		{
			return JsonUtility.FromJson<T>(data);
		}

	}

}