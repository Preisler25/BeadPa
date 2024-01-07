using System;
namespace BeadPa
{
	public class Obj
	{
		public string Name { get; set; }

        public Obj(string name) => Name = name;

		public void Self() => Util.Print($"{Name}");
    }
}

