using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomObjectEqualityComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MyObject> existingObjects = new List<MyObject>()
            {
                new MyObject()
                {
                    Value1 = 1,
                    Value2 = "Object 1",
                    Value3 = true
                },
                new MyObject()
                {
                    Value1 = 2,
                    Value2 = "Object 2",
                    Value3 = true
                },
                new MyObject()
                {
                    Value1 = 3,
                    Value2 = "Object 3",
                    Value3 = false
                },
                new MyObject()
                {
                    Value1 = 4,
                    Value2 = "Object 4",
                    Value3 = false
                },
                new MyObject()
                {
                    Value1 = 5,
                    Value2 = "Object 5",
                    Value3 = false
                },
            };

            List<MyObject> updatedObjects = new List<MyObject>()
            {
                new MyObject()
                {
                    Value1 = 1,
                    Value2 = "Object 1",
                    Value3 = true
                },
                new MyObject()
                {
                    Value1 = 2,
                    Value2 = "Object 2",
                    Value3 = true
                },
                new MyObject()
                {
                    Value1 = 3,
                    Value2 = "Object 3",
                    Value3 = true // changed
                },
                new MyObject()
                {
                    Value1 = 4,
                    Value2 = "Object 4",
                    Value3 = true // changed
                },
                new MyObject()
                {
                    Value1 = 5,
                    Value2 = "Object 5",
                    Value3 = true // changed
                },
            };

            // Unique Objects are updated objects that have difference from existing objects. It returns only changes.
            List<MyObject> uniqueObjects = updatedObjects.Except(existingObjects, new MyObjectEqualityComparer()).ToList();

            foreach (var unique in uniqueObjects)
            {
                Console.WriteLine($"Value1: {unique.Value1} | Value2: {unique.Value2} | Value3: {unique.Value3}");
            }

            // Output
            // Value1: 3 | Value2: Object 3 | Value3: True
            // Value1: 4 | Value2: Object 4 | Value3: True
            // Value1: 5 | Value2: Object 5 | Value3: True
            Console.ReadLine();
        }
    }
}
