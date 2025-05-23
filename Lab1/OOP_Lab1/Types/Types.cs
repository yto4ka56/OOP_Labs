using System.Reflection;

namespace OOP_Lab1.Types;

public class Types
{
    public static System.Type[] GetTypes()
    {
        Assembly[] allAssemblies = AppDomain.CurrentDomain.GetAssemblies();
        System.Type[] allTypes = allAssemblies
            .SelectMany(assembly =>
            {
                try
                {
                    return assembly.GetTypes();
                }
                catch (ReflectionTypeLoadException ex)
                {
                    return ex.Types.Where(t => t != null);
                }
            })
            .ToArray()!;
        return allTypes;
    }    
}