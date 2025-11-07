using SubModule3;

namespace ModuleALibrary;

public interface IModuleAInterface
{
    string GetData();
}

public class ModuleAClass1: IModuleAInterface
{
    public string GetData()
    {
        var c = new Class3();
        return "Data from Module A Class 1" + Environment.NewLine + c.GetMessage();
    }

}