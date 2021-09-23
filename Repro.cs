using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Repro
    {
        public static void RunController(DynamicContainer container)
        {
            container.Dynamic.Test = "Key";
        }

        public static void RunView(DynamicContainer container)
        {
            Console.WriteLine(container.Dynamic.Test);
        }
    }

    class DynamicContainer
    {
        public dynamic Dynamic { get; } = new DynamicDictionary();
    }

    class DynamicDictionary : DynamicObject
    {
        private readonly Dictionary<string, object?> _dictionary = new();

        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            result = _dictionary[binder.Name];
            return true;
        }

        public override bool TrySetMember(SetMemberBinder binder, object? value)
        {
            _dictionary[binder.Name] = value;
            return true;
        }

    }
}
