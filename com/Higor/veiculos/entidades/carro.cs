using com.Higor.veiculos.entidades.veiculo;

class Carro : Veiculo
{
    private int numPortas;
    private string cinto;

    public void setNumPortas(int _numPortas){
        this.numPortas = _numPortas;
    }

    public int getNumPortas(){
        return this.numPortas;
    }

    public void setCinto(string _cinto){
        this.cinto = _cinto;
    }

    public string getCinto(){
        return this.cinto;
    }

    public Carro(string _placa, string _renavan, int _numPortas,string _cinto) : base(_placa, _renavan)
    {
        this.numPortas = _numPortas;
        this.cinto = _cinto;
    }

    public override void mostrar()
    {
        base.mostrar();
        Console.WriteLine($"Número de portas: {numPortas}");
    }
}
