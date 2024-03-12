using com.Higor.veiculos.entidades.veiculo;
class  Sedan : Carro
{
    private double tamanhoTraseira;

    public void setTamanhoTraseira(double _tamanhoTraseira){
        
        this.tamanhoTraseira = _tamanhoTraseira;
    }

    public double getTamanhoTraseira(){
        
        return this.tamanhoTraseira;
    }

    public Sedan(string _placa, string _renavan, int _numPortas,string _cinto,double _tamanhoTraseira) : base (_placa,_renavan,_numPortas,_cinto){
        
        this.tamanhoTraseira = _tamanhoTraseira;
    }

    public override void mostrar()
    {
        base.mostrar();
        Console.WriteLine($"Comprimento da traseira: {tamanhoTraseira}");
    }
}