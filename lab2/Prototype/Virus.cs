using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	internal class Virus: ICloneable
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public float Weight { get; set; }

		public string Type { get; set; }
		public List<Virus> Childs { get; set; }
		public Virus(string name, int age, float weight, string type) {
			Name = name;
			Age = age;
			Weight = weight;
			Type = type;
			Childs = [];
		}

		public void AddChild(Virus child)
		{
			Childs.Add(child);
		}
		public void DisplayInfo(int generation = 0)
		{
			string indent = new string(' ', generation * 2);
			Console.WriteLine($"{indent}*Покоління:{generation}* Вірус: {Name} (Тип: {Type}, Вага: {Weight}, Вік: {Age} днів)");
			foreach (var child in Childs)
			{
				child.DisplayInfo(generation + 1);
			}
		}
		public object Clone()
		{
			Virus clone = (Virus)this.MemberwiseClone();
			List<Virus> newChilds = new List<Virus>();
			foreach (Virus child in Childs)
			{
				var newChild = (Virus)child.Clone();
				newChilds.Add(newChild);
			}
			clone.Childs = newChilds;
			return clone;
		}
	}
}
