namespace ModuleALibrary;

public interface IModuleAInterface
{
    string GetData();
}

public class ModuleAClass1: IModuleAInterface
{
    public string GetData()
    {
        return "Data from Module A Class 1";
    }

}