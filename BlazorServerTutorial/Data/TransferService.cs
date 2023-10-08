using System.Collections.ObjectModel;
namespace BlazorServerTutorial.Data;

public class TransferService
{
    private string _data = "TransferService";
    public string Data
    {
        get => _data;
        //set => _data = value;
        set 
        { 
            _data = value;
            DataChanged?.Invoke(this, value);
        }
    }
    public event EventHandler<string> DataChanged = (sender, value) => { };
    public ObservableCollection<ModelClass> Instances { get; set; } = new();
}

public class ModelClass
{
    public string Data { get; set; } = "";
}