using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewCustomization
{
    public class Library
    {
        public String Name { get; set; }
        public String Value { get; set; }

        public ObservableCollection<Library> ChildLibraries = new ObservableCollection<Library>();

        public Library (String name, String value)
        {
            Name = name;
            Value = value;
        }

        public static void createLibraries(ref ObservableCollection<Library> libs)
        {
            libs.Add(new Library("Item1", "Val1"));
            libs.Add(new Library("Item2", "Val2"));

            var lib3 = new Library("Item3", "Val3");
            lib3.ChildLibraries.Add(new Library("Item3.1", "Val3.1"));
            libs.Add(lib3);

            libs.Add(new Library("Item4", "Val4"));


        }
    }
}
