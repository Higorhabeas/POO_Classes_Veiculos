namespace com.Higor.veiculos.entidades.veiculo;
class Veiculo
{
    private string placa;
    private string renavan;

    public void setPlaca(string _placa){
        this.placa = _placa;
    }

    public string getPlaca(){
        return this.placa;
    }

    public void setRenavan(string _renavan){
        this.renavan = _renavan;
    }

    public string getRenavan(){
        return this.renavan;
    }

    public Veiculo(string _placa, string _renavan){
        this.placa = _placa;
        this.renavan = _renavan;
    }

    public virtual void mostrar(){
        Console.WriteLine($"Placa: {placa}");
        Console.WriteLine($"Renavan: {renavan}");
    }
}