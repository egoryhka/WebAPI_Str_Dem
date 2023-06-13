using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace DiplomsClassLibrary.Models
{
	public enum AcademicDegree
	{
		[Description("Бакалавр")] Bachelor,
		[Description("Магистр")] Magister,
		[Description("Аспирант")] Aspirant,
		[Description("Кандидат")] Candidat,
		[Description("Специалист")] Specialist,
		[Description("Доктор")] Doctor,
		//sadas
	}

	public interface IItem
	{
		int Id { get; set; }
	}

	public static class Extentions
	{
		public static string DescriptionAttr<T>(this T source)
		{
			FieldInfo fi = source.GetType().GetField(source.ToString());

			DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
				typeof(DescriptionAttribute), false);

			if (attributes != null && attributes.Length > 0) return attributes[0].Description;
			else return source.ToString();
		}

		public static T Copy<T>(this T o) where T : class, IItem
		{
			var json = JsonConvert.SerializeObject(o, new JsonSerializerSettings() { ContractResolver = ShouldSerializeContractResolver.Instance });
			var copy = Activator.CreateInstance<T>();
			JsonConvert.PopulateObject(json, copy);
			copy.Id = 0;
			return copy;
		}

		private class ShouldSerializeContractResolver : DefaultContractResolver
		{
			public static readonly ShouldSerializeContractResolver Instance = new ShouldSerializeContractResolver();
			private readonly Type[] excludedTypes = new[] {
				typeof(IItem),
			};

			protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
			{
				JsonProperty property = base.CreateProperty(member, memberSerialization);
				property.ShouldSerialize = i => !excludedTypes.Any(x=> x.IsAssignableFrom(property.PropertyType));
				return property;
			}
		}
	}

}