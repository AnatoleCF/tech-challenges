using IWD.FixtureChallenge.Fixture;
using NUnit.Framework;
using UnityEngine;

namespace IWD.FixtureChallenge.Serialization.Tests
{

	public class JsonSerializerTests
	{
		[Test]
		public void Serialize_ReturnsJsonString()
		{
			// Arrange
			var serializer = ScriptableObject.CreateInstance<JsonSerializer>();
			var obj = new CubicFixtureElement();

			// Act
			var result = serializer.Serialize(obj);

			// Assert
			Assert.IsNotNull(result);
			Assert.IsNotEmpty(result);
		}

		[Test]
		public void Deserialize_ReturnsDeserializedObject()
		{
			// Arrange
			var serializer = ScriptableObject.CreateInstance<JsonSerializer>();
			var jsonString = "{\r\n\t\"width\": 3000,\r\n\t\"height\": 400,\r\n\t\"depth\": 600}";
			var obj = new CubicFixtureElement();
			obj.width = 3000;
			obj.height = 400;
			obj.depth = 600;

			// Act
			var result = serializer.Deserialize<CubicFixtureElement>(jsonString); 

			// Assert
			Assert.IsNotNull(result);
			Assert.IsTrue(result.width == obj.width);
			Assert.IsTrue(result.height == obj.height);
			Assert.IsTrue(result.depth == obj.depth);
		}
	}

}