using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace RestGuide
{
	public class RestaurantRepository
	{

		public static List<Restaurant> GetAll(string source)
		{
			using (TextReader reader = new StreamReader(source))
			{
				XmlSerializer serializer = new XmlSerializer(typeof(List<Restaurant>));
				return (List<Restaurant>)serializer.Deserialize(reader);
			}
		}

		public static List<Restaurant> GetAll(Stream stream)
		{
			using (TextReader reader = new StreamReader(stream))
			{
				XmlSerializer serializer = new XmlSerializer(typeof(List<Restaurant>));
				return (List<Restaurant>)serializer.Deserialize(reader);
			}
		}

	}
}
